using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Transactions;
using Tiendeo.BLL.Config;
using Tiendeo.BLL.Services;
using Tiendeo.DAL;
using Tiendeo.DAL.Repositories;

namespace Tiendeo.BLL.Test
{
    public class TestConfig : IDisposable
    {
        protected TransactionScope Transaction;
        public ServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; }

        public TestConfig()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddDbContext<Context>(
                    options => options.UseSqlServer("Server=ALEX-PC\\SQLEXPRESS;Database=TiendeoDemo;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=True;TrustServerCertificate=True"),
                        ServiceLifetime.Transient
                );
            

            serviceCollection.AddScoped<IServiceService, ServiceService>();
            serviceCollection.AddScoped<IStoreService, StoreService>();
            serviceCollection.AddScoped<ICityService, CityService>();

            serviceCollection.AddScoped<IServiceRepository, ServiceRepository>();
            serviceCollection.AddScoped<ICityRepository, CityRepository>();
            serviceCollection.AddScoped<IProvinceRepository, ProvinceRepository>();
            serviceCollection.AddScoped<IStoreRepository, StoreRepository>();
            serviceCollection.AddScoped<IEnterpriseRepository, EnterpriseRepository>();

            serviceCollection.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperConfig());
            }).CreateMapper());

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public void InitTransaction()
        {
            if (Transaction != null)
                Transaction?.Dispose();

            Transaction = new TransactionScope(TransactionScopeOption.RequiresNew);
        }

        public void Dispose()
        {
            Transaction?.Dispose();
        }

    }
}
