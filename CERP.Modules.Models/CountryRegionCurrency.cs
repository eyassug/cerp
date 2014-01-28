using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("CountryRegionCurrency", Schema = "Sales")]
    public class CountryRegionCurrency
    {
        [Key]
        public string CountryRegionCode { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
