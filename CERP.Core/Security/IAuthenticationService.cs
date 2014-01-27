namespace CERP.Core.Security
{
    /// <summary>
    /// Authenticates given credentials against a list of users
    /// </summary>
    public interface IAuthenticationService
    {
        void Authenticate(string username, string password);
    }
}
