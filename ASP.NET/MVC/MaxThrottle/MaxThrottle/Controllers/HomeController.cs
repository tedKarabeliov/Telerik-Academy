using MaxThrottle.Data;
using MaxThrottle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new MaxThrottleData();
            var manufacturers = db.Manufacturers.All().OrderBy(m => m.Name)
                .Select(m => new ManufacturerViewModel
                {
                    Id = m.Id,
                    Name = m.Name
                }).ToList();

            return View(manufacturers);
        }
    }
}