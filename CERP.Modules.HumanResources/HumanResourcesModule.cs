using System;

namespace CERP.Modules.HumanResources
{
    public class HumanResourcesModule : Ninject.Modules.NinjectModule
    {
        private readonly HumanResourcesModuleConfiguration _configuration;

        public HumanResourcesModule(HumanResourcesModuleConfiguration configuration)
        {
            if(configuration == null)
                throw new ArgumentNullException("configuration");
            _configuration = configuration;
        }

        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
}
