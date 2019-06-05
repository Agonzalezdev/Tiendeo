using System.ComponentModel.DataAnnotations;

namespace Tiendeo.DAL.Entities
{
    public class City
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        public virtual Province Province { get; set; }
    }
}
