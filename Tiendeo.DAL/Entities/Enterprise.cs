using System.ComponentModel.DataAnnotations;

namespace Tiendeo.DAL.Entities
{
    public class Enterprise
    {
        public long Id { get; set; }
        [Required]
        public int Top { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MarkerUrl { get; set; }
    }
}
