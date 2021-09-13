using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zarządzanie_Lotniskiem.Models
{
    public class Passenger
    {
        public int ID { get; set; }

        [Display(Name = "Pasażer")]
        public string Name { get; set; }

        public virtual ICollection<Luggage> Luggage { get; set; }
    }
}
