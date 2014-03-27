using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("ProductCategory", Schema = "Inventory")]
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
