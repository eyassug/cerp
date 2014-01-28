using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("Store", Schema = "Sales")]
    public class Store
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Demographics { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
