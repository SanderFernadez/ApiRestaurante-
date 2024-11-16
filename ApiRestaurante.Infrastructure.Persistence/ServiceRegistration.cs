

using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Infrastructure.Persistence.Repositories;
using ApiRestaurante.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestauranteApi.Infrastructure.Persistence.Contexts;


namespace ApiRestaurante.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {


        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contexts
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<PersistenceContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<PersistenceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(PersistenceContext).Assembly.FullName)));
            }
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IIngredientpository, IngredientRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderPlateRepository, OrderPlateRepository>();
            services.AddTransient<IPlateIngredientRepository, PlateIngredientRepository>();
            services.AddTransient<IPlateRepository, PlateRepository>();
            services.AddTransient<ITableRepository, TableRepository>();
            #endregion
        }




    }
}
