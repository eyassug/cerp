using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERP.Models.HumanResources;
using CERP.Modules.HumanResources.Controls.Payroll.ViewModels;
using CERP.Modules.HumanResources.Domain;
using CERP.Modules.HumanResources.Services;
using DevExpress.XtraEditors;

namespace CERP.Modules.HumanResources.Controls.Payroll
{
    public partial class NewPayrollShell : Form
    {
        private IPayrollService _payrollService;
        public NewPayrollShell()
        {
            InitializeComponent();
            _payrollService = new PayrollService();
        }

        private void PayrollHeaderViewCreatePayrollClick(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var payroll = _payrollService.CreateNew(payrollHeaderView.PeriodName, payrollHeaderView.StartDate.GetValueOrDefault(), payrollHeaderView.EndDate.GetValueOrDefault());
            var gridDetails = from p in payroll.PayrollDetails
                              select new EmployeePayrollViewModel
                                         {
                                             EmployeeID = p.Employee.EmployeeID,
                                             Name = string.Format("{0} {1}", p.Employee.FirstName, p.Employee.LastName),
                                             Department = p.Employee.Department.Name,
                                             GrossSalary = p.GrossSalary,
                                             IncomeTax = p.IncomeTax,
                                             PensionDeduction = p.Pension,
                                             LoanDeduction = p.OtherDeductions,
                                             ProvidentFund = 0
                                         };
            payrollGridView.PayrollDetails = gridDetails.ToList();
        }

        private void PayrollGridViewLoad(object sender, EventArgs e)
        {
            
        }

        private void PayrollConfirmed(object sender, EventArgs e)
        {
            var payroll = new Domain.Payroll
            {
                StartDate = payrollHeaderView.StartDate.GetValueOrDefault(),
                EndDate = payrollHeaderView.EndDate.GetValueOrDefault(),
                Period = payrollHeaderView.PeriodName,
                PaymentFrequency = PaymentFrequency.Monthly,
                PayrollDetails = (from p in payrollGridView.PayrollDetails
                                  select new Domain.PayrollDetail
                                  {
                                      Employee =
                                          new Domain.Employee { EmployeeID = p.EmployeeID },
                                      GrossSalary = p.GrossSalary,
                                      IncomeTax = p.IncomeTax,
                                      Pension = p.PensionDeduction,
                                      OtherDeductions = p.LoanDeduction
                                  }).ToList()
            };
            _payrollService.ConfirmPayment(payroll);
        }
    }
}
