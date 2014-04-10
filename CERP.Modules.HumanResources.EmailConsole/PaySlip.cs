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
            : this(new PaySlipModel())
        {
            
        }

        public PaySlip(PaySlipModel paySlipModel)
        {
            InitializeComponent();
            PaySlipInformation = paySlipModel;
        }

        public PaySlipModel PaySlipInformation
        {
            get { return bindingSource.DataSource as PaySlipModel; }
            set { bindingSource.DataSource = value; }
        }
    }
}
