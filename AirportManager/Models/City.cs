using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class City
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Miasta")]
        [Required]
        public string Name { get; set; }

    }
}
