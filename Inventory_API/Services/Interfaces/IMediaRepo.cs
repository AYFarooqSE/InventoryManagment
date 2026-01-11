namespace Inventory_API.Services.Interfaces
{
    public interface IMediaRepo
    {
        Task<string> SaveImageAsync(IFormFile file, string folderName, CancellationToken cancellationToken = default);

        Task<bool> DeleteImageAsync(string relativePath);
    }
}
