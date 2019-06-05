using Tiendeo.Shared;

namespace Tiendeo.BLL.DTO
{
    public class ServiceViewModel
    {
        public long Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
