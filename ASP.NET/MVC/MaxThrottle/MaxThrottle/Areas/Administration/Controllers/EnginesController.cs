using MaxThrottle.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Areas.Administration.Controllers
{
    [Authorize(Roles = "admin")]
    public class EnginesController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}