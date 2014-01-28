using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("ContactType",Schema = "Person")]
    public partial class ContactType
    {
        [Key]
        public int ContactTypeID { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
