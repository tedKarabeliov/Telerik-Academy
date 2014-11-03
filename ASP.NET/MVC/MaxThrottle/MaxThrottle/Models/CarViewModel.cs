using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxThrottle.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string CarModel { get; set; }

        public string Engine { get; set; }

        public int YearOfProduction { get; set; }

        public decimal Price { get; set; }

        public int KilometersRan { get; set; }

        public string ImageUrl { get; set; }

        public bool LeatherInterior { get; set; }

        public bool AirConditioner { get; set; }
    }
}
