using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Apex.Common.Data;
using CERP.Core.Security;
using CERP.Modules.Security.DataAccess;
using CERP.Modules.Security.Repository;

namespace CERP.Modules.Security.Services
{
    /// <summary>
    /// Authenticates the supplied credentials against a database
    /// </summary>
    class DatabaseAuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserRepository _userRepository;

        public DatabaseAuthenticationService()
            : this(new SecurityDataContext())
        {
        }

        private DatabaseAuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = new UserRepository(_unitOfWork);
            
        }
        /// <summary>
        /// Creates a session and sets it to Thread.Current principal. Throws InvalidCredentialsException upon error
        /// </summary>
        /// <param name="username">Unique identifier of the user account</param>
        /// <param name="password">Password</param>
        public void Authenticate(string username, string password)
        {
            // TODO: Sanitise parameters
            // TODO: Encrypt password
            var user = _userRepository.FindSingle(m => m.Username == username);
            if(user == null)
                throw new InvalidCredentialException("The supplied username is incorrect.");
            if(user.Password != password)
                throw new InvalidCredentialException("The supplied password is incorrect.");
        }
    }
}
