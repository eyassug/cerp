using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("UserAccount", Schema = "Security")]
    public class UserAccount : BusinessEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
    }
}
