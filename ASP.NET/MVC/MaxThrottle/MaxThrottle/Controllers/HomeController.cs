using MaxThrottle.Data;
using MaxThrottle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var manufacturers = this.Data.Manufacturers.All().OrderBy(m => m.Name).ToList();
            ViewBag.ManufacturerId = new SelectList(manufacturers, "Id", "Name");

            ViewBag.LatestCars = this.Data.Cars.All()
                .OrderByDescending(c => c.DateOfCreation)
                .Take(5)
                .Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Manufacturer = c.Manufacturer.Name,
                    CarModel = c.CarModel.Name,
                    YearOfProduction = c.YearOfProduction,
                    KilometersRan = c.KilometersRan,
                    Price = c.Price,
                    ImageUrl = c.ImageUrl
                })
                .ToList();

            ViewBag.MostVisitedCars = this.Data.Cars.All()
                .GroupBy(c => c.CarModel)
                .Select(c => new CarViewModel
                {
                    Manufacturer = c.Key.Manufacturer.Name,
                    CarModel = c.Key.Name,
                    TimesVisited = c.Sum(car => car.TimesVisited)
                })
                .OrderByDescending(c => c.TimesVisited)
                .Take(3)
                .ToList();

            return View();
        }
    }
}