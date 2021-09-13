
using System.Collections.Generic;

namespace AirportManager.Models
{
    public class Profile
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public ICollection<Airport> Airports { get; set; }
    }
}
