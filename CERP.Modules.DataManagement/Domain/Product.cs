namespace CERP.Modules.DataManagement.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
