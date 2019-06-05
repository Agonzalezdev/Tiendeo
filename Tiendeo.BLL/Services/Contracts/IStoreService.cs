
using System.Collections.Generic;
using Tiendeo.BLL.DTO;
using Tiendeo.Shared.Classes;

namespace Tiendeo.BLL.Services
{
    public interface IStoreService
    {
        /// <summary>
        /// Search stores and returns a list
        /// </summary>
        /// <param name="maxResults">Number of max results</param>
        /// <param name="locationWrapper">Object that cointains location info</param>
        /// <returns>List of StoreDTO</returns>
        List<StoreDTO> SearchStores(int? maxResults = null, LocationWrapper locationWrapper = null);

        /// <summary>
        /// Get the store nearest to the coordinates
        /// </summary>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <returns></returns>
        List<StoreDTO> GetNearestStores(double latitude, double longitude, int maxResults = 1);
    }
}
