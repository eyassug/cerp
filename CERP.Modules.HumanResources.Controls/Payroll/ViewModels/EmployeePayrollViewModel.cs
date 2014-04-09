using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERP.Modules.HumanResources.Controls.Payroll.ViewModels
{
    public class EmployeePayrollViewModel
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal ProvidentFund { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal PensionDeduction { get; set; }
        public decimal LoadDeduction { get; set; }
    }
}
