namespace Inventory_API.Services.Interfaces
{
    public interface ICommonRepo
    {
        Task<string> SaveImageAsync(IFormFile file,string folderName,CancellationToken cancellationToken = default);

        Task<bool> DeleteImageAsync(string relativePath);
        Task SendEmailAsync(string toEmail,string subject,string body,bool isHtml = true);
    }
}
