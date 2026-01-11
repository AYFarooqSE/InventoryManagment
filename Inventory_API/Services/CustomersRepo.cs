using Inventory_API.Data;
using Inventory_API.Models;
using Inventory_API.Services.Interfaces;
using System;

namespace Inventory_API.Services 
{
    public class CustomersRepo : ICustomersRepo
    {
        private readonly ApplicationDbContext _context;

        public CustomersRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }
    }
}
