namespace Apex.Common.Net
{
    public class MailServiceConfiguration
    {
        private readonly EmailAccount _sender;
        private readonly string _smtpHost;
        private readonly int _port;
        private readonly string _password;

        public MailServiceConfiguration(string senderName, string senderAddress, string smtpHost, int port, string password)
        {
            _sender = new EmailAccount(senderName,senderAddress);
            _smtpHost = smtpHost;
            _port = port;
            _password = password;
        }

        public MailServiceConfiguration(string senderAddress, string smtpHost, int port, string password)
            : this(string.Empty,senderAddress,smtpHost,port,password)
        {
            
        }

        public EmailAccount Sender
        {
            get { return _sender; }
        }

        public string SmtpHost
        {
            get { return _smtpHost; }
        }

        public int Port
        {
            get { return _port; }
        }

        // TODO: Encrypt
        public string Password
        {
            get { return _password; }
        }
    }
}