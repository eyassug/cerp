namespace CERP.Modules.HumanResources.Controls.Payroll.ViewModels
{
    public class EmployeePayrollViewModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal ProvidentFund { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal PensionDeduction { get; set; }
        public decimal LoanDeduction { get; set; }
    }
}
