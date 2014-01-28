using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("StateProvince")]
    public class StateProvince
    {
        [Key]
        public int StateProvinceID { get; set; }
        public string StateProvinceCode { get; set; }
        public bool IsOnlyStateProvinceFlag { get; set; }
        public string Name { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
