using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Business
{
    [Table("PartnerType", Schema = "Business")]
    public class PartnerType
    {
        [Key, Column(Order = 0)]
        public int PartnerID { get; set; }
        [Key, Column(Order = 1)]
        public string PartnerTypeCode { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
