using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace Services.Emails.MailKits
{
    public class EmailMessage
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public EmailMessage(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(x => MailboxAddress.Parse(x)));
            Subject = subject;
            Content = content;
        }

        public EmailMessage(string to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            var address = new List<string>() { to };
            To.AddRange(address.Select(x => MailboxAddress.Parse(x)));
            Subject = subject;
            Content = content;
        }
    }
}
