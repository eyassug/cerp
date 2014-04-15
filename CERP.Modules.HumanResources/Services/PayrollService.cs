using System;
using System.Collections.Generic;
using System.Linq;
using CERP.Models.HumanResources;
using CERP.Modules.HumanResources.DataAccess;
using CERP.Modules.HumanResources.Domain;

namespace CERP.Modules.HumanResources.Services
{
    public class PayrollService : IPayrollService
    {
        private readonly IEmployeeService _employeeService = new EmployeeService();
        public Payroll CreateNew(string periodName, DateTime startDate, DateTime endDate, Models.HumanResources.PaymentFrequency paymentFrequency)
        {
            using (var context = new CERPContext())
            {
                var payFrequency = (byte) paymentFrequency;
                var payment = context.WagePayments.ToList().Any(m => (m.StartDate.Date == startDate.Date && m.EndDate.Date == endDate.Date) || (m.StartDate.Date == startDate.Date && m.PayFrequency == payFrequency) || (m.EndDate.Date == endDate.Date && m.PayFrequency == payFrequency));
                if(payment)
                    throw new ArgumentException("A payment with the supplied parameters already exists");
                var payroll = new Payroll
                                  {
                                      Period = periodName,
                                      StartDate = startDate.Date,
                                      EndDate = endDate.Date,
                                      PaymentFrequency = paymentFrequency
                                  };
                var employees = context.ExtendedEmployees.Where(e => e.PayFrequency == payFrequency && e.IsCurrent).ToList();
                payroll.PayrollDetails = employees.Select(e => new PayrollDetail
                                                                   {
                                                                       Employee = _employeeService.GetEmployee(e.EmployeeID),
                                                                       GrossSalary = e.Rate,
                                                                       IncomeTax = CalculateIncomeTax(e.Rate),
                                                                       Pension = CalculatePension(e.Rate)
                                                                   }).ToList();
                return payroll;
            }
        }

        public Payroll CreateNew(string periodName, DateTime startDate, DateTime endDate)
        {
            return CreateNew(periodName, startDate, endDate, PaymentFrequency.Monthly);
        }

        public void AddDraft(Payroll payroll)
        {
            using(var context = new CERPContext())
            {
                var newWagePayment = new WagePayment
                                      {
                                          PeriodName = payroll.Period,
                                          StartDate = payroll.StartDate.Date,
                                          EndDate = payroll.EndDate.Date,
                                          PaymentFrequency = payroll.PaymentFrequency,
                                          WagePaymentDetails = (from detail in payroll.PayrollDetails
                                                                select new WagePaymentDetail
                                                                {
                                                                    EmployeeID = detail.Employee.EmployeeID,
                                                                    GrossSalary = detail.GrossSalary,
                                                                    IncomeTax = detail.IncomeTax,
                                                                    OtherDeduction = detail.OtherDeductions,
                                                                    PensionContribution = detail.Pension
                                                                }).ToList()
                                      };
                var wagePaymentStatus = new WagePaymentStatusHistory
                                            {
                                                WagePayment = newWagePayment,
                                                WagePaymentStatusCode = "DRFT",
                                                StatusChangedDate = DateTime.Now
                                            };
                context.WagePayments.Add(newWagePayment);
                context.WagePaymentStatusHistory.Add(wagePaymentStatus);
                context.SaveChanges();
                payroll.PayrollID = newWagePayment.WagePaymentID;
            }
        }

        public void Cancel(Payroll payroll)
        {
            using(var context = new CERPContext())
            {
                var wagePayment = context.WagePayments.SingleOrDefault(w => w.WagePaymentID == payroll.PayrollID);
                if(wagePayment == null)
                    throw new Exception("Payroll not found");

                // TODO: Check the Payroll has not already been confirmed
                var wagePaymentStatus = new WagePaymentStatusHistory
                {
                    WagePayment = wagePayment,
                    WagePaymentStatusCode = "CNCL",
                    StatusChangedDate = DateTime.Now
                };
                context.WagePaymentStatusHistory.Add(wagePaymentStatus);
                context.SaveChanges();
            }
        }

        public void ConfirmPayment(Payroll payroll)
        {
            AddDraft(payroll);
            using (var context = new CERPContext())
            {
                var wagePayment = context.WagePayments.SingleOrDefault(w => w.WagePaymentID == payroll.PayrollID);
                if (wagePayment == null)
                    throw new Exception("Payroll not found");

                // TODO: Check the Payroll has not already been confirmed
                var wagePaymentStatus = new WagePaymentStatusHistory
                {
                    WagePayment = wagePayment,
                    WagePaymentStatusCode = "CNFRM",
                    StatusChangedDate = DateTime.Now
                };
                context.WagePaymentStatusHistory.Add(wagePaymentStatus);

                // Queue Payslip
                foreach (var wagePaymentDetail in wagePayment.WagePaymentDetails)
                {
                    var payslipQueue = new PaySlipQueue
                                           {
                                               EmployeeID = wagePaymentDetail.EmployeeID,
                                               WagePaymentID = wagePaymentDetail.WagePaymentID,
                                               SentFlag = false,
                                               QueuedDate = DateTime.Now
                                           };
                    context.PaySlipQueues.Add(payslipQueue);
                }
                context.SaveChanges();
            }
        }

        static decimal CalculateIncomeTax(decimal grossSalary)
        {
            if (grossSalary <= 150)
                return 0;
            if (grossSalary > 150 && grossSalary <= 1200)
                return (grossSalary - 150)/10;
            if(grossSalary > 1200 && grossSalary <=2400)
                return (grossSalary - 215) * 15 / 100;
            if (grossSalary > 2400 && grossSalary <= 3500)
                return (grossSalary - 215) * 25 / 100;
            if (grossSalary > 3500 && grossSalary <= 5000)
                return (grossSalary - 380) * 30 / 100;
            return (grossSalary*35/100) - 662;
        }

        static decimal CalculatePension(decimal grossSalary)
        {
            return grossSalary * 7 / 100 ;
        }

        
    }
}
