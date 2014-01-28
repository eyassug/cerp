using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("VendorContact", Schema = "Purchasing")]
    public class VendorContact
    {
        public int VendorID { get; set; }
        public int ContactID { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
