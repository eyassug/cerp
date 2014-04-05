using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Common.Net
{
    public interface IMailService
    {
        void Send(Mail mail, EmailAccount recipient);
        void Send(Mail mail, List<EmailAccount> recipients);
    }
}
