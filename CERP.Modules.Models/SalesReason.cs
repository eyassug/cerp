using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("SalesReason", Schema = "Sales")]
    public class SalesReason
    {
        [Key]
        public int SalesReasonID { get; set; }
        public string Name { get; set; }
        public string ReasonType { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
