using System;
using CERP.Core.Security;
using CERP.Modules.Security.Services;
using Ninject.Modules;

namespace CERP.Modules.Security
{
    public class SecurityModule : NinjectModule
    {
        internal static SecurityModuleSettings Settings;

        public SecurityModule(SecurityModuleSettings settings)
        {
            if(settings == null)
                throw new ArgumentNullException("settings");
            Settings = settings;
        }

        public override void Load()
        {
            Bind<IAuthenticationService>().To<DatabaseAuthenticationService>();
        }
    }
}
