using MaxThrottle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaxThrottle.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
            : this(new MaxThrottleData())
        {
        }

        public BaseController(IMaxThrottleData data)
        {
            this.Data = data;
        }

        public IMaxThrottleData Data  { get; private set; }
    }
}