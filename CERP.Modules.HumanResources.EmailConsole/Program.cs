using CERP.Modules.HumanResources.Controls.Payroll.Reports;
using CERP.Modules.HumanResources.Controls.Payroll.ViewModels;

namespace CERP.Modules.HumanResources.EmailConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var slip = new PaySlip
                           {
                               PaySlipInformation = new EmployeePayrollViewModel()
                                                        {
                                                            Name = "Eyassu",
                                                            GrossSalary = 10,
                                                            IncomeTax = 100
                                                        }
                           };
            slip.ExportToPdf(@"E:\abc.pdf");
        }
    }
}
