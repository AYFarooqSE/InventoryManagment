using Inventory_API.Models;

namespace Inventory_API.Services.Interfaces
{
    public interface IProductRepo
    {
        Task<int> CreateNewProduct(Products model);
        Task<int> UpdateProduct(int ProductID,Products model);
        Task<int> DeleteProduct(int ProductID);
        Task<IEnumerable<Products>> GetProducts();
        Task<Products> GetProductByProductID(int ProductID);
    }
}
