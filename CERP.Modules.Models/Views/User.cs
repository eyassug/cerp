using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Views
{
    [Table("vUser", Schema = "Security")]
    public class User
    {
        [Key]
        public int UserAccountID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public Guid? RowGuid { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
