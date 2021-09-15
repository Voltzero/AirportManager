using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirportManager.Models
{
    public class Country
    {
        public int ID { get; set; }

        [Display(Name = "Nazwa Państwa")]
        [Required]
        public string Name { get; set; }

        public IEnumerable<int> CitiesID { get; set; }

        [Display(Name = "Miasta")]
        public virtual ICollection<City> Cities { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
