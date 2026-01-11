using Inventory_API.Models;
using Inventory_API.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace Inventory_API.Services
{
    public class EmailRepo : IEmailRepo
    {
        private readonly EmailSettings _emailSettings;
        public EmailRepo()
        {
            _emailSettings = new EmailSettings();
        }
        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true)
        {
            var message = new MailMessage
            {
                From = new MailAddress(
                    _emailSettings.SenderEmail,
                    _emailSettings.SenderName),
                Subject = subject,
                Body = body,
                IsBodyHtml = isHtml
            };

            message.To.Add(toEmail);

            using var smtp = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.Port)
            {
                Credentials = new NetworkCredential(
                    _emailSettings.Username,
                    _emailSettings.Password),
                EnableSsl = true
            };

            await smtp.SendMailAsync(message);
        }
    }
}
