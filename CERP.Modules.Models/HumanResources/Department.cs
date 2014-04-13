using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("Department", Schema = "HumanResources")]
    public class Department
    {
        [Key]
        public Int16 DepartmentID { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
    }
}
