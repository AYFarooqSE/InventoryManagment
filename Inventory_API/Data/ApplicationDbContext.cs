using Inventory_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
