using Inventory_API.Data;
using Inventory_API.Services;
using Inventory_API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventory_API.Middlewares
{
    public static class DependenciesMiddleware
    {
        public static IServiceCollection AddConnectionStrin(this IServiceCollection _Service,IConfiguration _config)
        {
            var ConnectionStr = _config.GetConnectionString("ConnectionStr");
            _Service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionStr));

            return _Service;
        }

        public static IServiceCollection RegisterDIClasses(this IServiceCollection _Services)
        {
            _Services.AddScoped<IProductRepo, ProductsRepo>();
            _Services.AddScoped<ICustomersRepo, CustomersRepo>();
            _Services.AddScoped<IUnitOfWorkRepo, UnitOfWorkRepo>();
            return _Services;
        }

    }
}
