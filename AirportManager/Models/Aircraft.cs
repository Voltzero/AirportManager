using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zarządzanie_Lotniskiem.Models
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

        public int? LuggageSpace { get; set; }

        [Required]
        public ICollection<AircraftType> Types { get; set; }
    }

    public enum AircraftType
    {
        Airliner, MilitaryPlane, Helicopter, CommuterAircraft
    }
}
