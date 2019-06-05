using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tiendeo.API.ViewModels;
using Tiendeo.BLL.DTO;
using Tiendeo.BLL.Services;
using Tiendeo.Shared.Classes;

namespace Tiendeo.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class CityController : ControllerBase
    {

        private ICityService _cityService;
        private readonly IMapper _Mapper;

        public CityController(
            ICityService cityService,
            IMapper mapper
            )
        {
            _cityService = cityService;
            _Mapper = mapper;
        }


        [HttpGet("cities")]
        public ActionResult<List<CityViewModel>> Get()
        {
            try
            {
               List<CityDTO> cities = _cityService.GetAll();
                List<CityViewModel> mappedCities = _Mapper.Map<List<CityViewModel>>(cities);
                return Ok(mappedCities);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }
    }
}