using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class Airport
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Lotniska")]
        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryID { get; set; }

        [Required]
        public int CityID { get; set; }

        public virtual Country Country { get; set; }

        public virtual City City { get; set; }

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

        public virtual ICollection<Aircraft> Aircrafts { get; set; }
    }

    public enum AirportType
    {
        Airport, LandingStrip, Heliport, MilitaryAirport, CityAirport
    }
}
