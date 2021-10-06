using Microsoft.Extensions.DependencyInjection;
using WebApiClass.Data.Implementations;
using WebApiClass.Data.Interfaces;
using WebApiClass.Model.Entities;
using WebApiClass.Service.Implementations;
using WebApiClass.Service.Interfaces;

namespace WebApiClass.Api.Extensions
{
    public static class MidderWareExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitofWork, UnitofWork<WebApiContext>>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IServiceFactory, ServiceFactory>();

            return services;
        }
    }
}
