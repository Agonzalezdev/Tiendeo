using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Tiendeo.BLL.Services;
using Tiendeo.DAL.Repositories;

namespace Tiendeo.API.Config
{
    public static class DIConfig
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IStoreService, StoreService>();
            
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();

            services.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            }).CreateMapper());
        }
    }
}
