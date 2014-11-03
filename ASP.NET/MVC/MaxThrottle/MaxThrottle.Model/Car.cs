using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxThrottle.Model
{
    public class Car
    {
        public int Id { get; set; }

        public int YearOfProduction { get; set; }

        public int KilometersRan { get; set; }

        public decimal Price { get; set; }

        public bool LeatherInterior { get; set; }

        public bool AirConditioner { get; set; }

        public string ImageUrl { get; set; }

        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public int CarModelId { get; set; }

        public virtual CarModel CarModel { get; set; }

        public int EngineId { get; set; }

        public virtual Engine Engine { get; set; }
    }
}
