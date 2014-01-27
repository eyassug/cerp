using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CERP.Core.Security;

namespace CERP.Modules.Security.Services
{
    /// <summary>
    /// Authenticates the supplied credentials against a database
    /// </summary>
    class DatabaseAuthenticationService : IAuthenticationService
    {
        /// <summary>
        /// Creates a session and sets it to Thread.Current principal. Throws InvalidCredentialsException upon error
        /// </summary>
        /// <param name="username">Unique identifier of the user account</param>
        /// <param name="password">Password</param>
        public void Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
