
using System.Collections.Generic;
using Tiendeo.BLL.DTO;
using Tiendeo.Shared.Classes;

namespace Tiendeo.BLL.Services
{
    public interface ICityService
    {
        List<CityDTO> GetAll();
    }
}
