using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ninject;

namespace CERP.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static IKernel Kernel { get; private set; }

        public App()
        {
            LoadModules();
        }

        

        #region Load Modules
        private void LoadModules()
        {
            // Load Security Module
            //Kernel = new StandardKernel(new SecurityModule())
        }

        #endregion
    }
}
