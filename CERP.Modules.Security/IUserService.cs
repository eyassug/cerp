using System.Collections.Generic;
using CERP.Modules.Security.Domain;

//using CERP.Modules.Security.Domain;

namespace CERP.Modules.Security
{
    public interface IUserService
    {
        /// <summary>
        /// Adds a new User to the database
        /// </summary>
        /// <param name="user">User entity to be added</param>
        void AddNewUser(UserAccount user);

        /// <summary>
        /// Changes Account Password
        /// </summary>
        /// <param name="user">User entity to change password </param>
        /// <param name="oldPassword">Old Password to be checked</param>
        /// <param name="newPassword">New Password to replace the old one</param>
        void ChangePassword(UserAccount user, string oldPassword, string newPassword);
        /// <summary>
        /// Reset user Password to generated Values.
        /// </summary>
        /// <param name="user">User entity to be Password reset</param>
        void ResetPassword(UserAccount user);
        /// <summary>
        /// Disable selected Active User
        /// </summary>
        /// <param name="user">User entity to be Disabled</param>
        void DisableUser(UserAccount user);
        /// <summary>
        /// Enable selected Inactive User
        /// </summary>
        /// <param name="user">User entity to be Activated</param>
        void EnableUser(UserAccount user);
    }
}
