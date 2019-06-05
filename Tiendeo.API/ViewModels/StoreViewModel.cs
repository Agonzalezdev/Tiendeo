
namespace Tiendeo.API.ViewModels
{
    public class StoreViewModel
    {
        public long Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public long CityId { get; set; }
        public string EnterpriseMarkerUrl { get; set; }
        public int Top { get; set; }
    }
}
