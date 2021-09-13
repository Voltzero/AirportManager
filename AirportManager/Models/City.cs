using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zarządzanie_Lotniskiem.Models
{
    public class City
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Miasta")]
        [Required]
        public string Name { get; set; }

    }
}
