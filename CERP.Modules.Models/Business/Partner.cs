using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Business
{
    [Table("Partner", Schema = "Business")]
    public class Partner
    {
        [Key]
        public int PartnerID { get; set; }
        public string Name { get; set; }
    }
}
