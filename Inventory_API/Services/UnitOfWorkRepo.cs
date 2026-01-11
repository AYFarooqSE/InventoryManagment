using Inventory_API.Data;
using Inventory_API.Services.Interfaces;
using System;

namespace Inventory_API.Services
{
    public class UnitOfWorkRepo : IUnitOfWorkRepo
    {
        private readonly ApplicationDbContext _context;

        public ICommonRepo CommonRepo { get; }
        public ICustomersRepo CustomersRepo { get; }

        public UnitOfWorkRepo(ApplicationDbContext context)
        {
            _context = context;
            CommonRepo = new CommonRepo(_context);
            CustomersRepo = new CustomersRepo(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
