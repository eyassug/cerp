using System;
using System.Text;
using System.Collections.Generic;
using CERP.Core.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace CERP.Modules.Security.Tests
{
    /// <summary>
    /// Summary description for DatabaseAuthenticationServiceTest
    /// </summary>
    [TestClass]
    public class DatabaseAuthenticationServiceTest
    {
        private const string ConnectionString = @"Data Source=.\SQLSERVER;Integrated Security=True;Initial Catalog=CERP;";
        private readonly IKernel _kernel;
        private IAuthenticationService _authenticationService;
        public DatabaseAuthenticationServiceTest()
        {
            _kernel = new StandardKernel(new SecurityModule(new SecurityModuleSettings{ConnectionString = ConnectionString}));
            _authenticationService = _kernel.Get<IAuthenticationService>();
        }

        #region TestContext
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #endregion

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void AuthenticateMethodTest()
        {
            
            var username = "admin";
            var password = "admin";
            _authenticationService.Authenticate(username,password);
        }
    }
}
