using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.Inventory
{
    [Table("Batch", Schema = "Inventory")]
    public class Batch
    {
        public Batch()
        {
            BatchIdentifier = Guid.NewGuid();
        }

        [Key]
        public Guid BatchIdentifier { get; set; }
        public string SerialNumber { get; set; }
    }
}
