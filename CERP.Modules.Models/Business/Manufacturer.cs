using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Business
{
    [Table("Manufacturer", Schema = "Inventory")]
    public class Manufacturer
    {
        [Key]
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
    }
}
