using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERP.Modules.HumanResources.EmailConsole.Models
{
   public class PaySlipModel
    {
       public string CompanyName { get; set; }
       public string EmployeeName { get; set; }
       public DateTime PaySclipDate { get; set; }
       public decimal GrossIncome { get; set; }
       public decimal IncomeTax { get; set; }
       public decimal Pension { get; set; }
       public decimal Other { get; set; }
       public decimal NetPay { get; set; }
    }
}
