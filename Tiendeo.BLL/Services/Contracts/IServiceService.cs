using System;
using System.Collections.Generic;
using System.Text;
using Tiendeo.BLL.DTO;
using Tiendeo.Shared.Classes;

namespace Tiendeo.BLL.Services
{
    public interface IServiceService
    {
        List<ServiceDTO> SearchServices(long cityId);
    }
}
