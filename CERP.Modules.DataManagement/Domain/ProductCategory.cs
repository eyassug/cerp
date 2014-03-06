namespace CERP.Modules.DataManagement.Domain
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public ProductCategory ParentProductCategory { get; set; }
    }
}
