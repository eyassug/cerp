using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace Apex.Common.Net
{
    public class Mail
    {
        private IList<Attachment> _attachments;
        /// <summary>
        /// Constructs a new Mail object
        /// </summary>
        /// <param name="subject">Subject of the email</param>
        /// <param name="body">Body of the message</param>
        /// <param name="attachments">Optional file locations</param>
        public Mail(string subject,string body, params string[] attachments)
        {
            Subject = subject;
            Body = body;
            foreach (var attachment in attachments.Where(File.Exists))
            {
                Attachments.Add(new Attachment(attachment));
            }
        }
        /// <summary>
        /// Subject of the mail
        /// </summary>
        public string Subject { get; private set; }
        /// <summary>
        /// Body of the mail
        /// </summary>
        public string Body { get; private set; }

        /// <summary>
        /// Attachments
        /// </summary>
        public IList<Attachment> Attachments
        {
            get
            {
                return _attachments ?? (_attachments = new List<Attachment>());
            }
        }
    }
}