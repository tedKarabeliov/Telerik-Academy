using MaxThrottle.Areas.Administration.Models;
using MaxThrottle.Constants;
using MaxThrottle.Controllers;
using MaxThrottle.Model;
using MaxThrottle.Models;
using MaxThrottle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Areas.Administration.Controllers
{
    [Authorize(Roles="admin")]
    public class CarsController : BaseController
    {
        public ActionResult Edit(int id)
        {
            var car = this.Data.Cars.All()
                .FirstOrDefault(c => c.Id == id);

            var carViewModel = new EditCarViewModel
            {
                ManufacturerId = car.ManufacturerId,
                CarModelId = car.CarModel.Id,
                EngineId = car.Engine.Id,
                YearOfProduction = car.YearOfProduction,
                KilometersRan = car.KilometersRan,
                Price = car.Price,
                TimesVisited = car.TimesVisited,
                ImageUrl = car.ImageUrl != null ? car.ImageUrl : Globals.NoImageFoundPath,
                LeatherInterior = car.LeatherInterior,
                AirConditioner = car.AirConditioner,
            };

            var manufacturers = this.Data.Manufacturers.All().OrderBy(m => m.Name).ToList();
            var carModels = this.Data.CarModels.All().Where(cm => cm.ManufacturerId == carViewModel.ManufacturerId).ToList();
            var engines = this.Data.Engines.All().Where(e => e.CarModels.FirstOrDefault(cm => cm.Id == carViewModel.CarModelId) != null).ToList();

            ViewBag.ManufacturerId = new SelectList(manufacturers, "Id", "Name", carViewModel.ManufacturerId);
            ViewBag.CarModelId = new SelectList(carModels, "Id", "Name", carViewModel.CarModelId);
            ViewBag.EngineId = new SelectList(engines, "Id", "Name", carViewModel.EngineId);
            ViewBag.YearOfProduction = SelectListDataGenerator.PopulateYears(carViewModel.YearOfProduction);

            return View(carViewModel);
        }

        [HttpPost]
        public ActionResult Edit(EditCarViewModel car, HttpPostedFileBase carPicture)
        {
            if (ModelState.IsValid)
            {
                var carId = int.Parse((string)this.RouteData.Values["id"]);
                var carToUpdate = this.Data.Cars.All().FirstOrDefault(c => c.Id == carId);

                if (carToUpdate.ManufacturerId != car.ManufacturerId)
                {
                    carToUpdate.ManufacturerId = car.ManufacturerId;
                }

                if (carToUpdate.CarModelId != car.CarModelId)
                {
                    carToUpdate.CarModelId = car.CarModelId;
                }

                if (carToUpdate.EngineId != car.EngineId)
                {
                    carToUpdate.EngineId = car.EngineId;
                }

                if (carToUpdate.YearOfProduction != car.YearOfProduction)
                {
                    carToUpdate.YearOfProduction = car.YearOfProduction;
                }

                if (carToUpdate.KilometersRan != car.KilometersRan)
                {
                    carToUpdate.KilometersRan = car.KilometersRan;
                }

                if (carToUpdate.Price != car.Price)
                {
                    carToUpdate.Price = car.Price;
                }

                if (carToUpdate.LeatherInterior != car.LeatherInterior)
                {
                    carToUpdate.LeatherInterior = car.LeatherInterior;
                }

                if (carToUpdate.AirConditioner != car.AirConditioner)
                {
                    carToUpdate.AirConditioner = car.AirConditioner;
                }

                if (carToUpdate.ImageUrl != car.ImageUrl)
                {
                    carToUpdate.ImageUrl = car.ImageUrl;
                }

                if (carPicture != null)
                {
                    if (carToUpdate.ImageUrl != null)
                    {
                        carToUpdate.ImageUrl = "~/Content/CarImages/" + carToUpdate.Id + ".jpg";
                    }

                    var path = Server.MapPath(carToUpdate.ImageUrl);
                    carPicture.SaveAs(Server.MapPath(carToUpdate.ImageUrl));
                }

                this.Data.SaveChanges();

                return Redirect(Url.Content("~/Cars/Details/" + carId));
            }

            var manufacturers = this.Data.Manufacturers.All().OrderBy(m => m.Name).ToList();
            var carModels = this.Data.CarModels.All().Where(cm => cm.ManufacturerId == car.ManufacturerId).ToList();
            var engines = this.Data.Engines.All().Where(e => e.CarModels.FirstOrDefault(cm => cm.Id == car.CarModelId) != null).ToList();

            ViewBag.ManufacturerId = new SelectList(manufacturers, "Id", "Name");
            ViewBag.CarModelId = new SelectList(carModels, "Id", "Name", car.CarModelId);
            ViewBag.EngineId = new SelectList(engines, "Id", "Name", car.EngineId);
            ViewBag.YearOfProduction = SelectListDataGenerator.PopulateYears();

            if (car.ImageUrl == null)
            {
                car.ImageUrl = Globals.NoImageFoundPath;
            }

            return View(car);
        }

        public ActionResult Delete(int id)
        {
            var carToDelete = this.Data.Cars.All().FirstOrDefault(c => c.Id == id);

            if (carToDelete == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            this.Data.Cars.Delete(carToDelete);
            this.Data.SaveChanges();

            return Redirect(Url.Content("~/Cars"));
        }
    }
}
