using Common;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace Services.Emails.MailKits
{
    public class MailKitEmailSender : IEmailSender
    {
        private readonly EmailSetting _emailSetting;
        private readonly ILogger<MailKitEmailSender> logger;

        public MailKitEmailSender(IOptionsSnapshot<SiteSettings> settings, ILogger<MailKitEmailSender> logger)
        {
            _emailSetting = settings.Value.EmailSetting;
            this.logger = logger;
        }
        public async Task SendEmail(EmailMessage message)
        {
            var emailMessage = CreateEmailMessage(message);

            await Send(emailMessage);
        }
        private MimeMessage CreateEmailMessage(EmailMessage message)
        {
            var emailMessage = new MimeMessage();
            
            emailMessage.From.Add(MailboxAddress.Parse(_emailSetting.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Content };

            return emailMessage;
        }

        private async Task Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_emailSetting.SmtpServer, _emailSetting.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(_emailSetting.UserName, _emailSetting.Password);

                    await client.SendAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    //log an error message or throw an exception or both.
                    logger.LogError(ex, "خطا در ارسال ایمیل");
                    throw new Exception("خطا در ارسال ایمیل", ex);
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
