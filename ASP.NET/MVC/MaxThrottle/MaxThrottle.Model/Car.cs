using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Model
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public int YearOfProduction { get; set; }

        [Required]
        public int KilometersRan { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool LeatherInterior { get; set; }

        [Required]
        public bool AirConditioner { get; set; }

        [Required]
        public DateTime DateOfCreation { get; set; }

        [Required]
        public int TimesVisited { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public int CarModelId { get; set; }

        public virtual CarModel CarModel { get; set; }

        [Required]
        public int EngineId { get; set; }

        public virtual Engine Engine { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
