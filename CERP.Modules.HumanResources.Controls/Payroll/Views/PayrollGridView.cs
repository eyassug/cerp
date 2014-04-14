using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERP.Modules.HumanResources.Controls.Payroll.ViewModels;

namespace CERP.Modules.HumanResources.Controls.Payroll.Views
{
    public partial class PayrollGridView : UserControl
    {
        private IPayrollService _payrollService;

        public PayrollGridView()
        {
            InitializeComponent();
            PayrollDetails = new List<EmployeePayrollViewModel>();
        }

        private void BtnConfirmClick(object sender, EventArgs e)
        {
            OnPayrollConfirmed();
        }

        private void OnPayrollConfirmed()
        {
            var handler = PayrollConfirmed;
            if (handler != null)
                handler(PayrollDetails, null);
        }

        public List<EmployeePayrollViewModel> PayrollDetails
        {
            get { return employeeListBindingSource.DataSource as List<EmployeePayrollViewModel>; }
            set { employeeListBindingSource.DataSource = value; }
        }

        public event EventHandler PayrollConfirmed;
    }
}
