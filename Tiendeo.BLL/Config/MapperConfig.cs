using AutoMapper;
using Tiendeo.BLL.DTO;
using Tiendeo.DAL.Entities;

namespace Tiendeo.BLL.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Establishment, EstablishmentDTO>();
            CreateMap<Service, ServiceDTO>();
            CreateMap<Store, StoreDTO>();
            CreateMap<City, CityDTO>();
        }
    }
}
