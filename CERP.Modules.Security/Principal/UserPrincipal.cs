using System;
using System.Collections.Generic;
using System.Linq;
using CERP.Core.Security;
using CERP.Core.Security.Principal;

namespace CERP.Modules.Security.Principal
{
    public sealed class UserPrincipal : IUserPrincipal
    {
        private readonly ICollection<Roles> _roles;
        private readonly IUserIdentity _identity;

        internal UserPrincipal(IUserIdentity identity, ICollection<Roles> roles)
        {
            if(identity == null)
                throw new ArgumentNullException("identity");
            if(roles == null)
                throw new ArgumentNullException("roles");
            _identity = identity;
            _roles = roles;
        }

        public bool IsInRole(Roles role)
        {
            return _roles.Contains(role);
        }

        public System.Security.Principal.IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            return _roles.Any(r => r.ToString() == role);
        }
    }
}
