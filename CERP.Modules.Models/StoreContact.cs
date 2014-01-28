using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("StoreContact", Schema = "Sales")]
    public class StoreContact
    {
        [Key]
        public int CustomerID { get; set; }
        [Key]
        public int ContactID { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
