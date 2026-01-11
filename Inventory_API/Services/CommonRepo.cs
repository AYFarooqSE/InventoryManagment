using Inventory_API.Models;
using Inventory_API.Services.Interfaces;
using System.Net;
using System.Net.Mail;

namespace Inventory_API.Services
{
    public class CommonRepo : ICommonRepo
    {
        private readonly IWebHostEnvironment _env;
        private readonly EmailSettings _emailSettings;
        public CommonRepo(IWebHostEnvironment env)
        {
            _env = env;
            _emailSettings = new EmailSettings();
        }
        public Task<bool> DeleteImageAsync(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
                return Task.FromResult(false);

            var fullPath = Path.Combine(_env.WebRootPath, relativePath);

            if (!File.Exists(fullPath))
                return Task.FromResult(false);

            File.Delete(fullPath);
            return Task.FromResult(true);
        }

        public async Task<string> SaveImageAsync(IFormFile file, string folderName, CancellationToken cancellationToken = default)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("Invalid image file");

            var uploadsFolder = Path.Combine(_env.WebRootPath, folderName);

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var fileExtension = Path.GetExtension(file.FileName);
            var fileName = $"{Guid.NewGuid()}{fileExtension}";
            var filePath = Path.Combine(uploadsFolder, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream, cancellationToken);

            return Path.Combine(folderName, fileName).Replace("\\", "/");
        }

        public async Task SendEmailAsync(string toEmail,string subject,string body,bool isHtml = true)
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