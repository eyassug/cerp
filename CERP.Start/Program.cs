using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERP.Modules.HumanResources;
using Ninject;

namespace CERP.Start
{
    static class Program
    {
        public static IKernel Kernel;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadModules();
            Application.Run(new Shell());
        }

        static void LoadModules()
        {
            Kernel = new StandardKernel(new HumanResourcesModule(new HumanResourcesModuleConfiguration()
                                                                     {
                                                                         ConnectionString = @"Data Source=.;Initial Catalog=CERP;Integrated Security=True;"
                                                                     }));
        }
    }
}
