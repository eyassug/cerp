using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("Individual", Schema = "Sales")]
    public class Individual
    {
        [Key]
        public int CustomerID { get; set; }
        public string Demographics { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
