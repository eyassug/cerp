using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERP.Modules.HumanResources.Controls.Payroll.ViewModels;
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
            var payrollInfo = payrollHeaderView.PayrollInformation;
            if (payrollInfo == null)
                XtraMessageBox.Show("Invalid Payroll Header");
            LoadGrid(payrollInfo);
        }

        private void LoadGrid(PayrollInformationViewModel payrollInfo)
        {
            var payroll = _payrollService.CreateNew(payrollInfo.Period, payrollInfo.StartDate, payrollInfo.EndDate);
            var gridDetails = from p in payroll.PayrollDetails
                              select new EmployeePayrollViewModel
                                         {
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
    }
}
