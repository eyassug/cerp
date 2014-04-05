using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace Apex.Common.Net
{
    public class Mail
    {
        private IList<Attachment> _attachments;

        public Mail(string subject,string body, params string[] attachments)
        {
            Subject = subject;
            Body = body;
            foreach (var attachment in attachments.Where(File.Exists))
            {
                Attachments.Add(new Attachment(attachment));
            }
        }
        
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public IList<Attachment> Attachments
        {
            get
            {
                return _attachments ?? (_attachments = new List<Attachment>());
            }
        }
    }
}