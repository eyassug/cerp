using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("EmployeePayHistory", Schema = "HumanResources")]
    public class EmployeeDepartmentHistory
    {
        [Key,Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key, Column(Order = 1)]
        public int DepartmentID { get; set; }
        [Key, Column(Order = 1)]
        public int ShiftID { get; set; }
        [Key, Column(Order = 1)]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
