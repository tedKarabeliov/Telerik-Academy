using MaxThrottle.Data;
using MaxThrottle.Model;
using MaxThrottle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Controllers
{
    public class CarsController : Controller
    {
        public ActionResult Index(string manufacturer, string carModel, string engine)
        {
            var db = new MaxThrottleData();

            var cars = db.Cars.All();
            if (!String.IsNullOrEmpty(manufacturer))
            {
                var manufacturerId = int.Parse(manufacturer);
                cars = cars.Where(c => c.ManufacturerId == manufacturerId);

                if (!String.IsNullOrEmpty(carModel))
                {
                    var carModelId = int.Parse(carModel);
                    cars = cars.Where(c => c.CarModelId == carModelId);

                    if (!String.IsNullOrEmpty(engine))
                    {
                        var engineId = int.Parse(engine);
                        cars = cars.Where(c => c.EngineId == engineId);
                    }
                }
            }

            var carsToReturn = cars.Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Manufacturer = c.Manufacturer.Name,
                    CarModel = c.CarModel.Name,
                    Engine = c.Engine.Name,
                    YearOfProduction = c.YearOfProduction,
                    Price = c.Price
                }).ToList();

            return View(carsToReturn);
        }

        public ActionResult Details(int id)
        {
            var db = new MaxThrottleData();
            var car = db.Cars.All().FirstOrDefault(c => c.Id == id);

            var viewCar = new CarViewModel
            {
                Id = car.Id,
                Manufacturer = car.Manufacturer.Name,
                CarModel = car.CarModel.Name,
                Engine = car.Engine.Name,
                YearOfProduction = car.YearOfProduction,
                KilometersRan = car.KilometersRan,
                Price = car.Price,
                LeatherInterior = car.LeatherInterior,
                AirConditioner = car.AirConditioner
            };

            return View(viewCar);
        }

        public JsonResult GetModels(int manufacturerId)
        {
            var db = new MaxThrottleData();
            var carModels = db.CarModels.All()
                .Where(cm => cm.ManufacturerId == manufacturerId)
                .Select(cm => new CarModelViewModel
                {
                    Id = cm.Id,
                    Name = cm.Name
                }).ToList();

            return Json(carModels, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEngines(int carModelId)
        {
            var db = new MaxThrottleData();

            var engines = db.Engines.All()
                .Where(e => e.CarModels.FirstOrDefault(cm => cm.Id == carModelId) != null)
                .Select(e => new EngineViewModel
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList();

            return Json(engines, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            var db = new MaxThrottleData();
            var manufacturers = db.Manufacturers.All().OrderBy(m => m.Name)
                .Select(m => new ManufacturerViewModel
                {
                    Id = m.Id,
                    Name = m.Name
                }).ToList();

            ViewBag.Years = this.PopulateYears();

            return View(manufacturers);
        }

        [HttpPost]
        public ActionResult Create(CarViewModel inputCar, HttpPostedFileBase carPicture)
        {
            var db = new MaxThrottleData();

            var manufacturerId = int.Parse(inputCar.Manufacturer);
            var carModelId = int.Parse(inputCar.CarModel);
            var engineId = int.Parse(inputCar.Engine);

            var manufacturer = db.Manufacturers.All().FirstOrDefault(m => m.Id == manufacturerId);
            if (manufacturer == null)
            {
                throw new ArgumentException("Invalid manufacturer");
            }

            var carModel = db.CarModels.All().FirstOrDefault(cm => cm.Id == carModelId);
            if (carModel == null)
            {
                throw new ArgumentException("Invalid car model");
            }

            var engine = db.Engines.All().FirstOrDefault(e => e.Id == engineId);
            if (engine == null)
            {
                throw new ArgumentException("Invalid engine");
            }

            var yearOfProduction = inputCar.YearOfProduction;
            var kilometersRan = inputCar.KilometersRan;
            var price = inputCar.Price;

            var leatherInterior = inputCar.LeatherInterior;
            var airConditioner = inputCar.AirConditioner;

            var imageUrl = inputCar.ImageUrl;

            var car = new Car
            {
                ManufacturerId = manufacturerId,
                CarModelId = carModelId,
                EngineId = engineId,
                YearOfProduction = yearOfProduction,
                KilometersRan = kilometersRan,
                Price = price,
                LeatherInterior = leatherInterior,
                AirConditioner = airConditioner,
            };

            db.Cars.Add(car);
            db.SaveChanges();

            if (carPicture != null)
            {
                car.ImageUrl = "~/Content/CarImages/" + car.Id + ".jpg";
                carPicture.SaveAs(Server.MapPath(car.ImageUrl));
                db.SaveChanges();
            }
            
            return Redirect("~/Cars/Details?id=" + car.Id);
        }

        private SelectList PopulateYears()
        {
            return new SelectList(new List<int>
            {
                1990,
                1991,
                1992,
                1993,
                1994,
                1995,
                1996,
                1997,
                1998,
                1999,
                2000,
                2001,
                2002,
                2003,
                2004,
                2005,
                2006,
                2007,
                2008,
                2009,
                2010,
                2011,
                2012,
                2013,
                2014
            });
        }
    }
}