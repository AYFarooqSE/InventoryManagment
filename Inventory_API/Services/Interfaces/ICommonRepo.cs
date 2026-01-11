namespace Inventory_API.Services.Interfaces
{
    public interface ICommonRepo
    {
        Task AddAsync<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
    }
}
