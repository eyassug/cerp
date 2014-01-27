using System.Security.Principal;

namespace CERP.Core.Security.Principal
{
    public interface IUserIdentity : IIdentity
    {
        string Username { get; set; }
    }
}
