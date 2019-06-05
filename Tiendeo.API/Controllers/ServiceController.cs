using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Tiendeo.API.ViewModels;
using Tiendeo.BLL.DTO;
using Tiendeo.BLL.Exceptions;
using Tiendeo.BLL.Services;
using Tiendeo.Shared.Classes;

namespace Tiendeo.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private IServiceService _serviceService;
        private readonly IMapper _Mapper;

        public ServiceController(
            IServiceService serviceService,
            IMapper mapper
            )
        {
            _serviceService = serviceService;
            _Mapper = mapper;
        }


        [HttpGet("services-by-city/{cityId}")]
        public ActionResult<List<ServiceViewModel>> GetByCity(long? cityId)
        {
            try
            {
                if(cityId == null)
                    return BadRequest(new { message = "City id must be specified" });

                List<ServiceDTO> stores = _serviceService.SearchServices(cityId.Value);
                List<ServiceViewModel> mappedStores = _Mapper.Map<List<ServiceViewModel>>(stores);
                return Ok(mappedStores);
            }
            catch(CityDoesNotExistException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }        
    }
}