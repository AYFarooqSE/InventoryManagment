namespace Inventory_API.Services.Interfaces
{
    public interface IUnitOfWorkRepo : IDisposable
    {
        ICommonRepo CommonRepo { get; }

        Task<int> SaveChangesAsync();
    }
}
