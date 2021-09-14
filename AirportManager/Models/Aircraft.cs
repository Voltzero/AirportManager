using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class Aircraft
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Samolotu")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Ilość Miejsc")]
        [Required]
        public int Seats { get; set; }

        [Display(Name = "Pojemnośc (kg)")]
        public int? LuggageSpace { get; set; }

        [Display(Name = "Typ samolotu")]
        [Required]
        public AircraftType Type { get; set; }
    }

    public enum AircraftType
    {
        [Display(Name = "Samolot Pasażerski")]
        Airliner,

        [Display(Name = "Samolot Wojskowy")]
        MilitaryPlane,

        [Display(Name = "Helikopter")]
        Helicopter,

        [Display(Name = "Samolot podmiejski")]
        CommuterAircraft,
    }
}
