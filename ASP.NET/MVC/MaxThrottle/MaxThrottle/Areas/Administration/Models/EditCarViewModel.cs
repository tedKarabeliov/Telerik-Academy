using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaxThrottle.Areas.Administration.Models
{
    public class EditCarViewModel
    {
        [Required(ErrorMessage = "Please select an year of production")]
        public int YearOfProduction { get; set; }

        [Required(ErrorMessage = "Please specify kilometers ran")]
        public int KilometersRan { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        public decimal Price { get; set; }

        [Required]
        public bool LeatherInterior { get; set; }

        [Required]
        public bool AirConditioner { get; set; }

        public string ImageUrl { get; set; }

        public int TimesVisited { get; set; }

        [Required(ErrorMessage = "Please select a manufacturer")]
        public int ManufacturerId { get; set; }

        [Required(ErrorMessage = "Please select a model")]
        public int CarModelId { get; set; }

        [Required(ErrorMessage = "Please select an engine")]
        public int EngineId { get; set; }
    }
}