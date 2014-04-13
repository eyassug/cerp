using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Apex.Common.Net;
using CERP.Modules.HumanResources.Domain;
using CERP.Modules.HumanResources.EmailConsole.DataAccess;
using CERP.Modules.HumanResources.EmailConsole.Models;

namespace CERP.Modules.HumanResources.EmailConsole.Services
{
    public class PaySlipMailService : IPaySlipMailService
    {
        private readonly IMailService _mailService;
        

        public PaySlipMailService()
        {
            _mailService = new MailService(new MailServiceConfiguration("cerpnotifications+ICS@gmail.com","smtp.gmail.com",587,"pass@cerp"));
        }
        
        public void SendPaySlip(PaySlipInformation paySlip)
        {
            var fileName = string.Format("{0}.pdf", Guid.NewGuid());
            var mail = Compose(paySlip,fileName);
            var recipient = new EmailAccount(paySlip.Employee.EmailAddress);
            
            _mailService.Send(mail, recipient);

            // Remove queue from database
            using (var context = new CERPContext())
            {
                var queue =
                    context.PaySlipQueue.Single(
                        q => q.EmployeeID == paySlip.Employee.EmployeeID && q.WagePaymentID == paySlip.WagePaymentID);
                queue.SentFlag = true;
                context.SaveChanges();
            }
        }

        public Queue<PaySlipInformation> GetQueuedPaySlips()
        {
            using (var context = new CERPContext())
            {
                var slipQueue = new Queue<PaySlipInformation>();
                var queuedSlips = (from q in context.PaySlipQueue
                                  where !q.SentFlag
                                  select q).OrderBy(q => q.QueuedDate).ToList();
                var wagePayments = queuedSlips.Select(q => q.WagePayment).Distinct().ToList();
                var employees = queuedSlips.Select(q => q.Employee).Distinct().ToList();
                var paymentDetails =
                    context.WagePaymentDetails.Where(
                        p => wagePayments.Select(w => w.WagePaymentID).Contains(p.WagePaymentID));

                foreach (var paySlipQueue in queuedSlips)
                {
                    var slipInformation = new PaySlipInformation();
                    var employee = employees.Single(e => e.EmployeeID == paySlipQueue.EmployeeID);
                    slipInformation.Employee = new Employee
                                                   {
                                                       EmployeeID = employee.EmployeeID,
                                                       FirstName = employee.FirstName,
                                                       LastName = employee.LastName,
                                                       EmailAddress = employee.EmailAddress
                                                   };
                    var wagePayment = wagePayments.Single(w => w.WagePaymentID == paySlipQueue.WagePaymentID);
                    slipInformation.PaySlipPeriod = wagePayment.PeriodName;
                    slipInformation.WagePaymentID = wagePayment.WagePaymentID;
                    var paymentDetail = wagePayment.WagePaymentDetails.Single(
                            p =>
                            p.WagePaymentID == slipInformation.WagePaymentID &&
                            p.EmployeeID == slipInformation.Employee.EmployeeID);
                    slipInformation.Slip = new PaySlipModel
                                               {
                                                   EmployeeName = slipInformation.Employee.FirstName + slipInformation.Employee.LastName,
                                                   CompanyName = "International Community School",
                                                   GrossIncome = paymentDetail.GrossSalary,
                                                   IncomeTax = paymentDetail.IncomeTax,
                                                   Pension = paymentDetail.PensionContribution,
                                                   Other = paymentDetail.OtherDeduction,
                                                   NetPay = paymentDetail.NetPay,
                                                   PaySclipDate = DateTime.Today
                                               };
                    slipQueue.Enqueue(slipInformation);
                }

                return slipQueue;
            }
        }

        #region Helper Methods
        static Mail Compose(PaySlipInformation paySlip,string fileName)
        {
            var subject = string.Format("Payslip for {0}",paySlip.PaySlipPeriod);
            var body = string.Format("Dear {0}, \nPlease find attached a payslip for the period {1}.\nRegards,\nFinance Department",
                                     paySlip.Employee.FirstName, paySlip.PaySlipPeriod);
            var attachment = CreateSlipFile(paySlip.Slip,fileName);
            return new Mail(subject,body,attachment);
        }

        static string CreateSlipFile(PaySlipModel paySlipModel,string fileName)
        {
            var filePath = Path.Combine(Program.TemporaryFileDirectory, fileName);
            var slip = new PaySlip
                           {
                               PaySlipInformation = paySlipModel
                           };
            slip.ExportToPdf(filePath);
            return filePath;
        }
        #endregion
    }
}
