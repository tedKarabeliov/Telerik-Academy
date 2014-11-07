using MaxThrottle.Data;
using MaxThrottle.Model;
using MaxThrottle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MaxThrottle.Controllers
{
    public class CarsController : BaseController
    {
        public ActionResult Index(string manId, string modelId, string engId)
        {
            var cars = this.Data.Cars.All();
            if (!String.IsNullOrEmpty(manId))
            {
                var manufacturerId = int.Parse(manId);
                cars = cars.Where(c => c.ManufacturerId == manufacturerId);

                if (!String.IsNullOrEmpty(modelId))
                {
                    var carModelId = int.Parse(modelId);
                    cars = cars.Where(c => c.CarModelId == carModelId);

                    if (!String.IsNullOrEmpty(engId))
                    {
                        var engineId = int.Parse(engId);
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

        [HttpPost]
        public ActionResult Index(CarSearchViewModel carSearch)
        {
            var manufacturerIdInput = carSearch.ManufacturerId;
            var carModelIdInput = carSearch.CarModelId;
            var engineIdInput = carSearch.EngineId;

            return RedirectToAction("Index", new { manId = manufacturerIdInput, modelId = carModelIdInput, engineId = engineIdInput });
        }

        public ActionResult Details(int id)
        {
            var car = this.Data.Cars.All().FirstOrDefault(c => c.Id == id);
            car.TimesVisited++;
            this.Data.SaveChanges();

            var viewCar = new CarViewModel
            {
                Id = car.Id,
                Manufacturer = car.Manufacturer.Name,
                CarModel = car.CarModel.Name,
                Engine = car.Engine.Name,
                YearOfProduction = car.YearOfProduction,
                KilometersRan = car.KilometersRan,
                Price = car.Price,
                TimesVisited = car.TimesVisited,
                LeatherInterior = car.LeatherInterior,
                AirConditioner = car.AirConditioner
            };

            return View(viewCar);
        }

        public JsonResult GetModels(int manufacturerId)
        {
            var carModels = this.Data.CarModels.All()
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
            var engines = this.Data.Engines.All()
                .Where(e => e.CarModels.FirstOrDefault(cm => cm.Id == carModelId) != null)
                .Select(e => new EngineViewModel
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList();

            return Json(engines, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public ActionResult Create()
        {
            var manufacturers = this.Data.Manufacturers.All().OrderBy(m => m.Name).ToList();
            ViewBag.ManufacturerId = new SelectList(manufacturers, "Id", "Name");
            ViewBag.CarModelId = new SelectList(new List<CarModel>(), "Id", "Name");
            ViewBag.EngineId = new SelectList(new List<Engine>(), "Id", "Name");
            ViewBag.YearOfProduction = this.PopulateYears();
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreateCarViewModel carViewModel, HttpPostedFileBase carPicture)
        {
            if (ModelState.IsValid)
            {
                var car = new Car
                {
                    ManufacturerId = carViewModel.ManufacturerId,
                    CarModelId = carViewModel.CarModelId,
                    EngineId = carViewModel.EngineId,
                    YearOfProduction = carViewModel.YearOfProduction,
                    KilometersRan = carViewModel.KilometersRan,
                    Price = carViewModel.Price,
                    LeatherInterior = carViewModel.LeatherInterior,
                    AirConditioner = carViewModel.AirConditioner,
                    DateOfCreation = DateTime.Now,
                    UserId = this.Data.Users.All().FirstOrDefault(u => u.UserName == User.Identity.Name).Id
                };

                this.Data.Cars.Add(car);
                this.Data.SaveChanges();

                if (carPicture != null)
                {
                    car.ImageUrl = "~/Content/CarImages/" + car.Id + ".jpg";
                    carPicture.SaveAs(Server.MapPath(car.ImageUrl));
                }

                this.Data.SaveChanges();

                return Redirect("~/Cars/" + car.Id);
            }

            var manufacturers = this.Data.Manufacturers.All().OrderBy(m => m.Name).ToList();
            ViewBag.ManufacturerId = new SelectList(manufacturers, "Id", "Name", carViewModel.ManufacturerId);
            ViewBag.CarModelId = new SelectList(new List<CarModel>(), "Id", "Name");
            ViewBag.EngineId = new SelectList(new List<Engine>(), "Id", "Name");
            ViewBag.YearOfProduction = this.PopulateYears();

            return View(carViewModel);
        }

        private SelectList PopulateYears()
        {
            const int YearInterval = 40;

            var years = new List<int>();

            var currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= currentYear - YearInterval; i--)
            {
                years.Add(i);
            }

            return new SelectList(years);
        }
    }
}