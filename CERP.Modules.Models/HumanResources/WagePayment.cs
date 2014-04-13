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
        [Key]
        public int WagePaymentID { get; set; }
        [Column("Period")]
        public string PeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Column("PayeePayFrequency")]
        public byte PayFrequency { get; set; }

        [NotMapped]
        public PaymentFrequency PaymentFrequency
        {
            get { return (PaymentFrequency)PayFrequency; }
            set { PayFrequency = (byte)value; }
        }

        public virtual ICollection<WagePaymentDetail> WagePaymentDetails { get; set; }
    }
}
