using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("WagePaymentStatusHistory", Schema = "HumanResources")]
    public class WagePaymentStatusHistory
    {
        [Key]
        public int WagePaymentStatusHistoryID { get; set; }
        [ForeignKey("WagePayment")]
        public int WagePaymentID { get; set; }
        public string WagePaymentStatusCode { get; set; }
        public DateTime? StatusChangedDate { get; set; }

        public virtual WagePayment WagePayment { get; set; }
        
    }
}
