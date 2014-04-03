using Microsoft.VisualStudio.TestTools.UnitTesting;
using CERP.Modules.Security.Domain;
using CERP.Modules.Security;
using CERP.Modules.Security.Services;

namespace CERP.Modules.Security.Tests
{
    [TestClass]
    public class UserServiceTest
    {
        readonly IUserService _userService = new UserService();
        const string OldPassword = "XXX";
        const string NewPassword = "sammy";
       

        [TestMethod]
        public void AddNewUser_ShouldPass()
        {
            var u = new UserAccount
                            {
                                FirstName = "Samuel",
                                LastName = "Habtewold",
                                Username = "Yesammy",
                                Password = "XXX"
                            };
            _userService.AddNewUser(u);
        }
        [TestMethod]
        public void ChangePWD_ShouldPass()
        {
            var u = new UserAccount
                        {
                            FirstName = "Samuel",
                            LastName = "Habtewold",
                            Username = "Yesammy",
                            Password = "XXX"
                        };
            
                        _userService.ChangePassword(u,OldPassword,NewPassword);
        }

        [TestMethod]
        public void DisableUserTest_shouldPass()
        {
            var u = new UserAccount { UserAccountID = 1 };
            _userService.DisableUser(u);
            
        }

        [TestMethod]
        public void EnableUserTestShouldPass()
        {
            var u = new UserAccount { UserAccountID = 1 };
            _userService.EnableUser(u);

        }

    }
}



