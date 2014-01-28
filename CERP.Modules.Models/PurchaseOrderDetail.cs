using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("PurchaseOrderDetail", Schema = "Purchasing")]
    public class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderDetailID { get; set; }
        public int PurchaseOrderID { get; set; }
        public DateTime DueDate { get; set; }
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal RejectedQty { get; set; }
        public decimal StockedQty { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
