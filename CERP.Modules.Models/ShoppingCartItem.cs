using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("ShoppingCartItem", Schema = "Sales")]
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
