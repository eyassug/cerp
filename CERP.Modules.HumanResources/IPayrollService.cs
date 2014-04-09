using System;
using CERP.Modules.HumanResources.Domain;

namespace CERP.Modules.HumanResources
{
    public interface IPayrollService
    {
        Payroll CreateNew(string periodName, DateTime startDate, DateTime endDate,Models.HumanResources.PaymentFrequency paymentFrequency);

        Payroll CreateNew(string periodName, DateTime startDate, DateTime endDate);

        void AddDraft(Payroll payroll);

        void Cancel(Payroll payroll);

        void ConfirmPayment(Payroll payroll);
    }
}
