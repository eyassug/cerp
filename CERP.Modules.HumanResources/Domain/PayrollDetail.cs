namespace CERP.Modules.HumanResources.Domain
{
    public class PayrollDetail
    {
        public Employee Employee { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal Pension { get; set; }
        public decimal OtherDeductions { get; set; }
    }
}
