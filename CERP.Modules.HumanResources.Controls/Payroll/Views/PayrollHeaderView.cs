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
        }

        private void BtnCreateClick(object sender, EventArgs e)
        {
            OnCreatePayroll();
        }

        private void OnCreatePayroll()
        {
            var handler = CreatePayrollClick;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public event EventHandler CreatePayrollClick;

        public DateTime? StartDate
        {
            get { return dtpStartDate.EditValue as DateTime?; }
            set { dtpStartDate.EditValue = value; }
        }

        public DateTime? EndDate
        {
            get { return dtpEndDate.EditValue as DateTime?; }
            set { dtpEndDate.EditValue = value; }
        }

        public string PeriodName
        {
            get { return txtPeriodName.Text; }
            set { txtPeriodName.Text = value; }
        }

    }
}
