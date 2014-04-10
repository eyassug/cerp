using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using CERP.Modules.HumanResources.EmailConsole.Models;
using DevExpress.XtraReports.UI;

namespace CERP.Modules.HumanResources.EmailConsole
{
    public partial class PaySlip : DevExpress.XtraReports.UI.XtraReport
    {
        public PaySlip()
        {
            InitializeComponent();
            LoadReport();
        }
        public void LoadReport ()
        {
            var model = new PaySlipModel();
            model.CompanyName = "AA";
            model.EmployeeName = "Eyassu";
            model.GrossIncome = 15000;
            model.IncomeTax = 2000;
            model.NetPay = 10000;
            bindingSource.DataSource = model;
        }
    }
}
