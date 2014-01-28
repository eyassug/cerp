using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("VendorAddress", Schema = "Purchasing")]
    public class VendorAddress
    {
        [Key]
        public int VendorID { get; set; }
        public int AddressID { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
