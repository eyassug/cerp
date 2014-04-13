using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("EmployeePayHistory", Schema = "HumanResources")]
    public class EmployeePayHistory
    {
        [Key,Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key,Column(Order = 2)]
        public DateTime RateChangedDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
    }
}
