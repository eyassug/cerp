using System.Collections.Generic;

namespace CERP.Modules.HumanResources.EmailConsole
{
    public interface IPaySlipMailService
    {
        Queue<PaySlipInformation> GetQueuedPaySlips();
        void SendPaySlip(PaySlipInformation paySlip);
    }
}
