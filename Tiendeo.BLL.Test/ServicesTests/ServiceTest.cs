using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tiendeo.BLL.DTO;
using Tiendeo.BLL.Exceptions;
using Tiendeo.BLL.Services;
using Xunit;

namespace Tiendeo.BLL.Test.ServicesTests
{
    public class ServiceTest : IClassFixture<TestConfig>
    {
        private IStoreService _storeService;
        private ICityService _cityService;
        private IServiceService _serviceService;

        public ServiceTest(
            TestConfig testConfig
        )
        {
            testConfig.InitTransaction();
            _storeService = testConfig.ServiceProvider.GetRequiredService<IStoreService>();
            _cityService = testConfig.ServiceProvider.GetRequiredService<ICityService>();
            _serviceService = testConfig.ServiceProvider.GetRequiredService<IServiceService>();
        }

        [Fact]
        public void SearchStores() => Assert.IsType<List<StoreDTO>>(_storeService.SearchStores());

        [Fact]
        public void GetNearestStores() => Assert.IsType<List<StoreDTO>>(_storeService.GetNearestStores(12.3, 14.2, 1));

        [Fact]
        public void GetNearestStoresCountOk() => Assert.Single(_storeService.GetNearestStores(12.3, 14.2, 1));

        [Fact]
        public void GetAllCity() => Assert.IsType<List<CityDTO>>(_cityService.GetAll());

        [Fact]
        public void GetServices() => Assert.IsType<List<ServiceDTO>>(_serviceService.SearchServices(1));        

        [Fact]
        public void GetServicesFail() => Assert.Throws<CityDoesNotExistException>((Action)(() => _serviceService.SearchServices(9999)));

    }
}
