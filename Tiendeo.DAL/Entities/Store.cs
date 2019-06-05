using System.ComponentModel.DataAnnotations;

namespace Tiendeo.DAL.Entities
{
    public class Store : Establishment
    {
        [Required]
        public string Name { get; set; }

        public int Top { get; set; }

        [Required]
        public virtual Enterprise Enterprise { get; set; }
    }
}
