using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class Luggage
    {
        public int ID { get; set; }

        [Required]
        public int Weight { get; set; }
    }
}
