using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class Passenger
    {
        public int ID { get; set; }

        [Display(Name = "Pasażer")]
        public string Name { get; set; }

        public virtual ICollection<Luggage> Luggage { get; set; }
    }
}
