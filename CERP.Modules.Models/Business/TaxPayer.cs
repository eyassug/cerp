using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Business
{
    [Table("TaxPayer", Schema = "Business")]
    public class TaxPayer : Partner
    {
        public string LicenseNumber { get; set; }
        public string TIN { get; set; }
        public string VATNumber { get; set; }
    }
}
