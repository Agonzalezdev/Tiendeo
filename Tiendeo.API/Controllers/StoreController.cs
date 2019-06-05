using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult<List<StoreViewModel>> Search([FromQuery]LocationWrapper locationWrapper, int? maxResults)
        {
            try
            {
               List<StoreDTO> stores = _storeService.SearchStores(maxResults, locationWrapper);
                List<StoreViewModel> mappedStores = _Mapper.Map<List<StoreViewModel>>(stores);
                return Ok(mappedStores);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }

        [HttpGet("stores/top")]
        public ActionResult<List<StoreViewModel>> GetAllStoresByTop()
        {
            try
            {
                List<StoreDTO> stores = _storeService.SearchStores();
                List<StoreViewModel> mappedStores = _Mapper.Map<List<StoreViewModel>>(stores);
                return Ok(mappedStores);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }

        [HttpGet("stores/near/top")]
        public ActionResult<List<StoreViewModel>> GetNearestStore(double? latitude, double? longitude)
        {
            try
            {

                if (latitude == null || longitude == null)
                    return BadRequest(new { message = "Both latitude and longitude arguments must be specified" });

                StoreDTO store = _storeService.GetNearestStores(latitude.Value, longitude.Value).FirstOrDefault();
                StoreViewModel mappedStore = _Mapper.Map<StoreViewModel>(store);
                return Ok(mappedStore);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Unexpected error" });
            }
        }

        [HttpGet("stores/near")]
        public ActionResult<List<StoreViewModel>> GetNearestStores(double? latitude, double? longitude, int? maxResults)
        {
            try
            {
                if (maxResults == null)
                    return BadRequest(new { message = "MaxResults, Latitude and Longitude arguments must be specified" });

                List<StoreDTO> stores = _storeService.GetNearestStores(latitude.Value, longitude.Value, maxResults.Value);
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