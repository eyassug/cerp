using System;
using CERP.Modules.HumanResources.Services;

namespace CERP.Modules.HumanResources
{
    public class HumanResourcesModule : Ninject.Modules.NinjectModule
    {
        private static HumanResourcesModuleConfiguration _configuration;

        internal static string ConnectionString
        {
            get { return _configuration.ConnectionString; }
        }

        public HumanResourcesModule(HumanResourcesModuleConfiguration configuration)
        {
            if(configuration == null)
                throw new ArgumentNullException("configuration");
            _configuration = configuration;
        }

        public override void Load()
        {
            Bind<IEmployeeService>().To<EmployeeService>();
            Bind<IDepartmentService>().To<DepartmentService>();
            Bind<IPayrollService>().To<PayrollService>();
        }
    }
}
