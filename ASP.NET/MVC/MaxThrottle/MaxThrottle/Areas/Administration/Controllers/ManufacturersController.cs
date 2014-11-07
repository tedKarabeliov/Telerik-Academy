using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MaxThrottle.Data;
using MaxThrottle.Model;
using MaxThrottle.Controllers;

namespace MaxThrottle.Areas.Administration.Controllers
{
    [Authorize(Roles = "admin")]
    public class ManufacturersController : BaseController
    {
        private const int PageSize = 10;
        // GET: Administration/Manufacturers
        public ActionResult Index()
        {
            int page = 0;
            int.TryParse((string)RouteData.Values["page"], out page);

            var manufacturers = this.Data.Manufacturers.All()
                .OrderBy(m => m.Name).Skip(page * PageSize).Take(PageSize).ToList();

            ViewBag.ManufacturersCount = this.Data.Manufacturers.All().Count();

            return View(manufacturers);
        }

        // GET: Administration/Manufacturers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var manufacturer = this.Data.Manufacturers.All().FirstOrDefault(m => m.Id == id);

            if (manufacturer == null)
            {
                return HttpNotFound();
            }

            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Manufacturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                this.Data.Manufacturers.Add(manufacturer);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var manufacturer = this.Data.Manufacturers.All().FirstOrDefault(m => m.Id == id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }

            return View(manufacturer);
        }

        // POST: Administration/Manufacturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                this.Data.Manufacturers.Update(manufacturer);
                this.Data.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturer);
        }

        // GET: Administration/Manufacturers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturer manufacturer = this.Data.Manufacturers.All().FirstOrDefault(m => m.Id == id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }

            return View(manufacturer);
        }

        // POST: Administration/Manufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var manufacturer = this.Data.Manufacturers.All().FirstOrDefault(m => m.Id == id);
            this.Data.Manufacturers.Delete(manufacturer);
            this.Data.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
