using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Areas.Administration.Controllers
{
    [Authorize(Roles="admin")]
    public class AdministrationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}