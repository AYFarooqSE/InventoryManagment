using Inventory_API.Models;
using Inventory_API.Services.Interfaces;

namespace Inventory_API.Services
{
    public class ProductsRepo : IProductRepo
    {
        public Task<int> CreateNewProduct(Products model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteProduct(int ProductID)
        {
            throw new NotImplementedException();
        }

        public Task<Products> GetProductByProductID(int ProductID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Products>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateProduct(int ProductID, Products model)
        {
            throw new NotImplementedException();
        }
    }
}
