using System;
using Apex.Common.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CERP.Modules.DataManagement.Tests
{
    [TestClass]
    public class MailServiceTest
    {
        private const string File1 = @"E:\payslip.txt";
        private const string File2 = @"E:\payslip2.txt";
        private readonly EmailAccount _recipient = new EmailAccount("eyassug@gmail.com");

        #region Constructor
        private readonly MailServiceConfiguration _configuration;

        public MailServiceTest()
        {

            _configuration = new MailServiceConfiguration("someone@example.com","smtp.gmail.com",587,"passw0rd");
        }

        #endregion

        [TestMethod]
        public void MailWithoutAttachmentTest()
        {
            IMailService mailService = new MailService(_configuration);
            var mail = new Mail("Payslip for March 2014", "Please find attached your payslip for the month March 2014");
            mailService.Send(mail,_recipient);
        }

        [TestMethod]
        public void MailWithAttachmentTest()
        {
            IMailService mailService = new MailService(_configuration);
            var mailWithAttachment = new Mail("Payslip for March 2014", "Please find attached your payslip for the month March 2014",File1,File2);
            mailService.Send(mailWithAttachment,_recipient);
        }
    
    }
}
