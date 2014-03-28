namespace CERP.Modules.DataManagement.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
