using System.Security.Principal;

namespace CERP.Core.Security.Principal
{
    public interface IUserPrincipal : IPrincipal
    {
        bool IsInRole(Roles role);
    }
}
