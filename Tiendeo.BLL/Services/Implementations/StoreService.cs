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

        public List<StoreDTO> SearchStores(LocationWrapper locationWrapper, long? maxResults)
        {
            try
            {
                List<Store> stores = _storeRepository.Get(_context,
                    e => 
                        e.Latitude < locationWrapper.FromLatitude &&
                        e.Latitude > locationWrapper.ToLatitude &&
                        e.Longitude < locationWrapper.FromLongitude &&
                        e.Longitude > locationWrapper.ToLongitude 
                    ).OrderBy(e => e.Top).ToList();

                if (maxResults != null)
                    stores = stores.Take((int)maxResults).ToList();

                return _Mapper.Map<List<StoreDTO>>(stores);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
