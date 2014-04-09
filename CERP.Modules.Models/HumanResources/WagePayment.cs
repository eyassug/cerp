using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace CERP.Models.HumanResources
{
    [Table("WagePayment", Schema = "HumanResources")]
    public class WagePayment
    {
        private byte _payFrequency;

        [Key]
        public int WagePaymentID { get; set; }
        public string PeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte PayFrequency
        {
            get { return _payFrequency; }
            set
            {
                if(value != 1 || value != 2)
                    throw new ArgumentOutOfRangeException("PayFrequency");
                _payFrequency = value;
            }
        }

        [NotMapped]
        public PaymentFrequency PaymentFrequency
        {
            get { return (PaymentFrequency)PayFrequency; }
            set { PayFrequency = (byte)value; }
        }

        public virtual ICollection<WagePaymentDetail> WagePaymentDetails { get; set; }
    }
}
