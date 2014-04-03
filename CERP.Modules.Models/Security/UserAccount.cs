using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Security
{
    [Table("UserAccount", Schema = "Security")]
    public class UserAccount 
    {   [Key]
        public int UserAccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
    }
}
