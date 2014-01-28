using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("Vendor", Schema = "Purchasing")]
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public byte CreditRating { get; set; }
        public bool PreferredVendorStatus { get; set; }
        public bool ActiveFlag { get; set; }
        public string PurchasingWebServiceURL { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
