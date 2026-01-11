using Inventory_API.Data;
using Inventory_API.Models;
using Inventory_API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

namespace Inventory_API.Services
{
    public class CommonRepo  : ICommonRepo
    {
        private readonly ApplicationDbContext _context;
        public CommonRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }
    }
}