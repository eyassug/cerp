using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("Location", Schema = "Inventory")]
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Name { get; set; }
        public int LocationNode { get; set; }
    }
}
