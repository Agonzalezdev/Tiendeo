using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Tiendeo.Shared;

namespace Tiendeo.DAL.Entities
{
    public class Service : Establishment
    {
        [Required]
        public ServiceType ServiceType { get; set; }
    }
}
