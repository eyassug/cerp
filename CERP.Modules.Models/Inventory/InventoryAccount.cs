using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("InventoryAccount", Schema = "Inventory")]
    public class InventoryAccount
    {
        [Key]
        public int InventoryAccountID { get; set; }
        public string Name { get; set; }
        public string InventoryAccountCode { get; set; }
    }
}
