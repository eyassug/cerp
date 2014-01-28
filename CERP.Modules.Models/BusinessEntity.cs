using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("BusinessEntity", Schema = "Business")]
    public abstract class BusinessEntity
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public string Name { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
