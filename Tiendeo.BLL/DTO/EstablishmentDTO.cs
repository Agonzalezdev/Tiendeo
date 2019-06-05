using Tiendeo.Shared;

namespace Tiendeo.BLL.DTO
{
    public abstract class EstablishmentDTO
    {
        public long Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
    }
}
