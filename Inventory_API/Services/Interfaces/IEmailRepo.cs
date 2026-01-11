namespace Inventory_API.Services.Interfaces
{
    public interface IEmailRepo
    {
        Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true);
    }
}
