using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models
{
    [Table("SalesPersonQuotaHistory", Schema = "Sales")]
    public class SalesPersonQuotaHistory
    {
        [Key]
        public int SalesPersonID { get; set; }
        public DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public Guid? Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
