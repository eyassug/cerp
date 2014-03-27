using System.Collections.Generic;
using System.Linq;

namespace CERP.Modules.Procurement.Domain
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public decimal SubTotal
        {
            get { return OrderDetails.Sum(m => m.Quantity * m.UnitPrice); }
        }
    }
}
