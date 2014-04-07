using System;
using System.Linq;
using Apex.Common.Data;
using CERP.Modules.Security.DataAccess;
using CERP.Modules.Security.Domain;
using CERP.Modules.Security.Repository;


namespace CERP.Modules.Security.Services
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly SecurityDataContext _context;
        private readonly UserRepository _userRepository;
        #endregion

        #region Constructors
        public UserService()
            : this(new SecurityDataContext())
        {
        }

        public UserService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            _context = unitOfWork as SecurityDataContext;
            _userRepository = new UserRepository(_context);
        }

        #endregion

        #region IUserService Implementation
        public void AddNewUser(UserAccount user)
        {
            // Validation
            if (user.FirstName.Trim() == string.Empty || user.LastName.Trim() == string.Empty || user.Username.Trim() == string.Empty || user.Password.Trim() == string.Empty)
            {
                throw new Exception("Can't add User!!!");
            }
            var newUser = new Models.Security.UserAccount
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                IsActive = true

            };
            _userRepository.Add(newUser);
            _context.CommitChanges();
        }
        #endregion


        public void ChangePassword(UserAccount user, string oldPassword, string newPassword)
        {
            var u = _context.Users.SingleOrDefault(x => x.UserAccountID == user.UserAccountID);
            if (u == null)
                throw new Exception("User doesn't exist.");
            var p = _context.Users.SingleOrDefault(x => x.Password == oldPassword);
            if(p == null)
                throw new Exception("Old Password and the supplied Password are not the same.");
            u.Password = newPassword;
            _context.CommitChanges();
        }

        public void ResetPassword(UserAccount user)
        {
            var u = _context.Users.SingleOrDefault(x => x.UserAccountID == user.UserAccountID);
            if (u == null)
                throw new Exception("User doesn't exist.");
           //generate new pssword
           // u.Password = generateNewPassword;
            _context.CommitChanges();
        }

        public void DisableUser(UserAccount user)
        {
            var u = _context.Users.SingleOrDefault(m => m.UserAccountID == user.UserAccountID);
            if (u == null)
                throw new Exception("user not found!!!");
            u.IsActive = false;
            _context.CommitChanges();
        }

        public void EnableUser(UserAccount user)
        {
            var u = _context.Users.SingleOrDefault(m => m.UserAccountID == user.UserAccountID);
            if (u == null)
                throw new Exception("user not found!!!");
            u.IsActive = true;
            _context.CommitChanges();
        }
    }
}
