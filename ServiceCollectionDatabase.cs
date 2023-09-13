using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.CompilerServices;
using WebApplication1.Database;
using WebApplication1.Database.Context;
using WebApplication1.Database.Entities;
using WebApplication1.Database.Repositories;

namespace WebApplication1
{
    public static class ServiceCollectionDatabase
    {
        public static void AddInfrastructureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>
                (options => options.UseNpgsql(configuration.GetConnectionString("DBconnection")), ServiceLifetime.Scoped);
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Event>, EventRepository>();
        }
    }
}
