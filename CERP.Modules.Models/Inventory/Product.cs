using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("Product", Schema = "Inventory")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int ProductCategoryID { get; set; }
        public int ManufacturerID { get; set; }
        public string UnitMeasureCode { get; set; }
        public bool IsActive { get; set; }
    }
}
