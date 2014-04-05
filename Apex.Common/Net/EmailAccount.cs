using System.Net.Mail;

namespace Apex.Common.Net
{
    public class EmailAccount
    {
        private readonly string _name;
        private readonly MailAddress _address;

        
        public EmailAccount(string address)
            : this(string.Empty,address)
        {
            
        }

        public EmailAccount(string name, string address)
        {
            _name = name;
            _address = new MailAddress(address);
        }

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address.Address; }
        }
    }
}