using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("UserGroup", Schema = "Security")]
    public class UserGroup
    {
        [Key]
        public byte UserGroupID { get; set; }
        public string Name { get; set; }
        public string UserGroupCode { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
