using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("ShipMethod", Schema = "Sales")]
    public class ShipMethod
    {
        [Key]
        public int ShipMethodID { get; set; }
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
