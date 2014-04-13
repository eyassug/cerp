using CERP.Modules.HumanResources.Domain;
using CERP.Modules.HumanResources.EmailConsole.Models;

namespace CERP.Modules.HumanResources.EmailConsole
{
    public class PaySlipInformation
    {
        public Employee Employee { get; set; }
        public int WagePaymentID { get; set; }
        public string PaySlipPeriod { get; set; }
        public PaySlipModel Slip { get; set; }

    }
}
