using System.ComponentModel.DataAnnotations;

namespace Tiendeo.DAL.Entities
{
    public abstract class Establishment
    {
        public long Id { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public virtual City City { get; set; }
    }
}
