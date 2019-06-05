using Tiendeo.Shared;

namespace Tiendeo.BLL.DTO
{
    public class CityDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }
    }
}
