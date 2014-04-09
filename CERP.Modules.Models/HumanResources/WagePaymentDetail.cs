using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CERP.Models.HumanResources
{
    [Table("WagePaymentDetail", Schema = "HumanResources")]
    public class WagePaymentDetail
    {
        [Key]
        public int WagePaymentDetailID { get; set; }
        public int WagePaymentID { get; set; }
        public int EmployeeID { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal PensionContribution { get; set; }
        public decimal OtherDeduction { get; set; }

        [NotMapped]
        public decimal NetPay
        {
            get { return GrossSalary - (IncomeTax + PensionContribution + OtherDeduction); }
        }
    }
}
