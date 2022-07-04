using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework;

namespace Teleperformance.Final.Project.Persistance
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ShoppingListDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("ShopingListConnectionString")));


            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IShopListRepository, EfShopListRepository>();


            return services;
        }


    }
}
