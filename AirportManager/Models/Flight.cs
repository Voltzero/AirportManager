using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirportManager.Models
{
    public class Flight
    {
        public int ID { get; set; }

        [Display(Name = "Lotnisko startowe")]
        [Required]
        public virtual Airport Start { get; set; }

        [Display(Name = "Lotnisko docelowe")]
        [Required]
        public virtual Airport Destination { get; set; }

        public virtual ICollection<Passenger> Passengers { get; set; }

        [Display(Name = "Data odlotu")]
        [Required]
        public DateTime StartTime { get; set; }

        [Display(Name = "Data przylotu")]
        public DateTime FinishTime { get; set; }
    }
}