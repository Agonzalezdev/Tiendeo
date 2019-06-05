using System.ComponentModel.DataAnnotations;

namespace Tiendeo.DAL.Entities
{
    public class Province
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
