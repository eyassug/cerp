namespace CERP.Modules.Procurement.Domain
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int PurchaseOrderID { get; set; }
        public Product Product { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
