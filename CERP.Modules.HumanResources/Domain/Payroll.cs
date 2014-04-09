using System;
using System.Collections.Generic;

namespace CERP.Modules.HumanResources.Domain
{
    public class Payroll
    {
        public int PayrollID { get; set; }
        public string Period { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Models.HumanResources.PaymentFrequency PaymentFrequency { get; set; }

        public ICollection<PayrollDetail> PayrollDetails { get; set; }
    }
}
