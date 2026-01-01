using Inventory_API.Data;
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

    }
}
