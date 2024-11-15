using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ApiRestaurante.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //#region Services
            //services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<ICategoryService, CategoryService>();
            //services.AddTransient<IUserService, UserService>();
            //#endregion
        }
    }
}















