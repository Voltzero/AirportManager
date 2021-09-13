using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zarządzanie_Lotniskiem.Models
{
    public class Airport
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Lotniska")]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Display(Name = "Lokalizacja")]
        [Required]
        public string Location
        {
            get
            {
                return $"{City}, {Country}";
            }
        }

        [Required]
        public AirportType Type { get; set; }

        public ICollection<Aircraft> Aircrafts { get; set; }
    }

    public enum AirportType
    {
        Airport, LandingStrip, Heliport, MilitaryAirport, CityAirport
    }
}
