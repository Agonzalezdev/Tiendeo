using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tiendeo.BLL.DTO;
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

        public ServiceService(
            Context context,
            IServiceRepository serviceRepository,
            IMapper mapper
        )
        {           
            _context = context;
            _serviceRepository = serviceRepository;
            _Mapper = mapper;
        }

        public List<ServiceDTO> SearchServices(long cityId)
        {
            try
            {
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
