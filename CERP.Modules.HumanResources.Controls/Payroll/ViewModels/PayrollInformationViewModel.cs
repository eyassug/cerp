using System;

namespace CERP.Modules.HumanResources.Controls.Payroll.ViewModels
{
    public class PayrollInformationViewModel
    {
        readonly string[] _monthNames = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public string Period
        {
            get { return string.Format("{0} - {1}", _monthNames[StartDate.Month - 1], StartDate.Year); }
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public PayrollStatus? PayrollStatus { get; set; }
        public string PayrollStatusDescription
        {
            get { return PayrollStatus.ToString(); }
        }

    }

    public enum PayrollStatus
    {
        Draft,
        InProcess,
        PaymentConfirmed
    }
}
