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
    public class CityService : ICityService
    {
        private Context _context;
        private readonly IMapper _Mapper;
        private readonly ICityRepository _cityRepository;

        public CityService(
            Context context,
            ICityRepository cityRepository,
            IMapper mapper
        )
        {           
            _context = context;
            _cityRepository = cityRepository;
            _Mapper = mapper;
        }

        public List<CityDTO> GetAll()
        {
            try
            {
                List<City> cities = _cityRepository.Get(_context).ToList();
                return _Mapper.Map<List<CityDTO>>(cities);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
