using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Tiendeo.BLL.DTO;
using Tiendeo.DAL;
using Tiendeo.DAL.Entities;
using Tiendeo.DAL.Repositories;
using Tiendeo.Shared.Classes;

namespace Tiendeo.BLL.Services
{
    public class StoreService : IStoreService
    {
        private Context _context;
        private readonly IMapper _Mapper;
        private readonly IStoreRepository _storeRepository;

        public StoreService(
            Context context,
            IStoreRepository storeRepository,
            IMapper mapper
        )
        {
            _context = context;
            _storeRepository = storeRepository;
            _Mapper = mapper;
        }

        public List<StoreDTO> SearchStores(int? maxResults = null, LocationWrapper locationWrapper = null)
        {
            try
            {
                List<Store> stores = null;
                
                if(locationWrapper != null)
                    stores  = _storeRepository.Get(_context,
                                e =>
                                    e.Latitude < locationWrapper.FromLatitude &&
                                    e.Latitude > locationWrapper.ToLatitude &&
                                    e.Longitude < locationWrapper.FromLongitude &&
                                    e.Longitude > locationWrapper.ToLongitude
                            ).OrderBy(e => e.Top).ToList();
                else
                    stores = _storeRepository.Get(_context).OrderBy(e => e.Top).ToList();

                if (maxResults != null)
                    stores = stores.Take(maxResults.Value).ToList();

                return _Mapper.Map<List<StoreDTO>>(stores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<StoreDTO> GetNearestStores(double latitude, double longitude, int maxResults = 1)
        {
            try
            {
                List<Store> store = _storeRepository.Get(_context).OrderBy(
                    x => (latitude - x.Latitude) * (latitude - x.Latitude) + (longitude - x.Longitude) * (longitude - x.Longitude)
                ).Take(maxResults).ToList();

                return _Mapper.Map< List<StoreDTO>>(store);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
