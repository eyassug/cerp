using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("AddressType", Schema = "Person")]
    public class AddressType
    {
        [Key]
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
    }
}
