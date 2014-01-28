using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CERP.Models
{
    [Table("CurrencyRate", Schema = "Sales")]
    public class CurrencyRate
    {
        [Key]
        public int CurrencyRateID { get; set; }
        public DateTime CurrencyRateDate { get; set; }
        public decimal AverageRate { get; set; }
        public decimal EndOfDayRate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
