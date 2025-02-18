using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace IdentityDemo.Services
{
    public class EmailSender: IEmailSender
    {
        public string SendGridKey { get; set; }
        public EmailSender(IConfiguration _config)
        {
            SendGridKey = _config.GetValue<string>("SendGrid:ApiKey");
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SendGridClient(SendGridKey);
            var from = new EmailAddress("", "Identity Demo");
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, message, message);
            return client.SendEmailAsync(msg);
        }

    }
}
