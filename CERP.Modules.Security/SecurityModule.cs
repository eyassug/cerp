using System;
using Ninject.Modules;

namespace CERP.Modules.Security
{
    class SecurityModule : NinjectModule
    {
        private readonly SecurityModuleSettings _settings;

        public SecurityModule(SecurityModuleSettings settings)
        {
            if(settings == null)
                throw new ArgumentNullException("settings");
            _settings = settings;
        }

        public override void Load()
        {
            throw new System.NotImplementedException();
        }
    }
}
