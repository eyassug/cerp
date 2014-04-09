using CERP.Modules.HumanResources.Controls.Payroll.ViewModels;

namespace CERP.Modules.HumanResources.Controls.Payroll.Reports
{
    public partial class PaySlip : DevExpress.XtraReports.UI.XtraReport
    {
        public PaySlip()
        {
            InitializeComponent();
        }

        public EmployeePayrollViewModel PaySlipInformation
        {
            get { return paySlipBindingSource.DataSource as EmployeePayrollViewModel; }
            set { paySlipBindingSource.DataSource = value; }
        }

    }
}
