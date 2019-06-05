using AutoMapper;
using Tiendeo.API.ViewModels;
using Tiendeo.BLL.DTO;

namespace Tiendeo.API.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<StoreDTO, StoreViewModel>();
            CreateMap<CityDTO, CityViewModel>();
            CreateMap<ServiceDTO, ServiceViewModel>();
            
        }
    }
}
