using Inventory_API.Models;

namespace Inventory_API.Services.Interfaces
{
    public interface ICustomersRepo
    {
        Task<Customer> GetByIdAsync(int id);
        Task AddCustomerAsync(Customer customer);
    }
}
