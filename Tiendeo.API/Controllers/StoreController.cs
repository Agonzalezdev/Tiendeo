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
    public class StoreController : ControllerBase
    {

        private IStoreService _storeService;
        private readonly IMapper _Mapper;

        public StoreController(
            IStoreService storeService,
            IMapper mapper
            )
        {
            _storeService = storeService;
            _Mapper = mapper;
        }


        [HttpGet("stores")]
        public ActionResult<List<StoreViewModel>> Search([FromQuery]LocationWrapper locationWrapper, long maxResults)
        {
            try
            {
               List<StoreDTO> stores = _storeService.SearchStores(locationWrapper, maxResults);
                List<StoreViewModel> mappedStores = _Mapper.Map<List<StoreViewModel>>(stores);
                return Ok(mappedStores);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }
    }
}