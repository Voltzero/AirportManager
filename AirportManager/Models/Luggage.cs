using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zarządzanie_Lotniskiem.Models
{
    public class Luggage
    {
        public int ID { get; set; }

        [Required]
        public int Weight { get; set; }
    }
}
