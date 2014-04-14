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
    public partial class PayrollHeaderView : UserControl
    {
        public PayrollHeaderView()
        {
            InitializeComponent();
            PayrollInformation = new PayrollInformationViewModel
                                     {
                                         StartDate = DateTime.Today,
                                         EndDate = DateTime.Today
                                     };
        }

        private void BtnCreateClick(object sender, EventArgs e)
        {
            OnCreatePayroll();
        }

        private void OnCreatePayroll()
        {
            var handler = CreatePayrollClick;
            if (handler != null)
                handler(PayrollInformation, null);
        }

        public event EventHandler CreatePayrollClick;

        public PayrollInformationViewModel PayrollInformation
        {
            get { return payrollHeaderBindingSource.DataSource as PayrollInformationViewModel; }
            set { payrollHeaderBindingSource.DataSource = value; }
            
        }
    }
}
