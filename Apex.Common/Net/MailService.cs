using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace Apex.Common.Net
{
    public class MailService : IMailService
    {
        private readonly MailServiceConfiguration _configuration;
        private SmtpClient _mailClient;

        public MailService(MailServiceConfiguration configuration)
        {
            if(configuration == null)
                throw new ArgumentNullException("configuration");
            _configuration = configuration;
            InitialiseComponents();
        }

        private void InitialiseComponents()
        {
            _mailClient = new SmtpClient
                              {
                                  Host = _configuration.SmtpHost,
                                  Port = _configuration.Port,
                                  EnableSsl = true,
                                  DeliveryMethod = SmtpDeliveryMethod.Network,
                                  UseDefaultCredentials = false,
                                  Credentials = new NetworkCredential(_configuration.Sender.Address,_configuration.Password)
                              };
        }

        public void Send(Mail mail, EmailAccount recipient)
        {
            if(mail == null)
                throw new ArgumentNullException("mail");
            if(recipient == null)
                throw new ArgumentNullException("recipient");
            var mailMessage = new MailMessage(_configuration.Sender.Address, recipient.Address)
                                  {Subject = mail.Subject, Body = mail.Body};
            mailMessage.Bcc.Add(new MailAddress(_configuration.Sender.Address));
            foreach (var attachment in mail.Attachments)
            {
                mailMessage.Attachments.Add(attachment);
            }
            _mailClient.Send(mailMessage);
        }

        public void Send(Mail mail, List<EmailAccount> recipients)
        {
            throw new NotImplementedException();
        }
    }
}
