using System.Threading.Tasks;

namespace Services.Emails.MailKits
{
    public interface IEmailSender
    {
        Task SendEmail(EmailMessage message);
    }
}
