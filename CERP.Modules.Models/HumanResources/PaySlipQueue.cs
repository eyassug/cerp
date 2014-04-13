using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("PaySlipQueue",Schema = "HumanResources")]
    public class PaySlipQueue
    {
        [Key]
        public int PaySlipQueueID { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [ForeignKey("WagePayment")]
        public int WagePaymentID { get; set; }
        public bool SentFlag { get; set; }
        public DateTime QueuedDate { get; set; }

        public virtual WagePayment WagePayment { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
