using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tiendeo.BLL.DTO;
using Tiendeo.BLL.Exceptions;
using Tiendeo.DAL;
using Tiendeo.DAL.Entities;
using Tiendeo.DAL.Repositories;
using Tiendeo.Shared.Classes;

namespace Tiendeo.BLL.Services
{
    public class ServiceService : IServiceService
    {
        private Context _context;
        private readonly IMapper _Mapper;
        private readonly IServiceRepository _serviceRepository;
        private readonly ICityRepository _cityRepository;

        public ServiceService(
            Context context,
            IServiceRepository serviceRepository,
            ICityRepository cityRepository,
            IMapper mapper
        )
        {           
            _context = context;
            _serviceRepository = serviceRepository;
            _cityRepository = cityRepository;
            _Mapper = mapper;
        }

        public List<ServiceDTO> SearchServices(long cityId)
        {
            try
            {
                if (_cityRepository.GetByID(_context, cityId) == null)
                    throw new CityDoesNotExistException("The specified city does not exist");

                List<Service> services = _serviceRepository.Get(_context, e => e.City.Id == cityId).ToList();
                return _Mapper.Map<List<ServiceDTO>>(services);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
