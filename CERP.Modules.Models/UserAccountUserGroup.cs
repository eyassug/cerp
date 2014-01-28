using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("UserAccountUserGroup", Schema = "Security")]
    public class UserAccountUserGroup
    {
        [Key]
        public int UserAccountID { get; set; }
        public byte UserGroupID { get; set; }
    }
}
