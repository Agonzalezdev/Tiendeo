using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiendeo.DAL.Repositories;

namespace Tiendeo.API.Config
{
    public static class DIConfig
    {
        public static void Setup(IServiceCollection services)
        {
            //SERV
            //services.AddScoped<IUserService, UserService>();

            
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IProvinceRepository, ProvinceRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();

            services.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            }).CreateMapper());
        }
    }
}
