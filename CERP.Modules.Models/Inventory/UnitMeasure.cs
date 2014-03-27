using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("UnitMeasure", Schema = "Inventory")]
    public class UnitMeasure
    {
        [Key]
        public string UnitMeasureCode { get; set; }
        public string Name { get; set; }
    }
}
