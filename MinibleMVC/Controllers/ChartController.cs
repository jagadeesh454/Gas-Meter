using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2;
using Syncfusion.EJ2.CircularGauge;

namespace Hydroid5.Controllers
{
    public class ChartController : Controller
    {
        //
        // GET: /Chart/
        [ActionName("apex")]
        public ActionResult apex()
        {
            return View();
        }

        [ActionName("chartjs")]
        public ActionResult chartjs()
        {
            return View();
        }

        [ActionName("flot")]
        public ActionResult flot()
        {
            return View();
        }

        [ActionName("knob")]
        public ActionResult knob()
        {
            return View();
        }

        [ActionName("sparkline")]
        public ActionResult sparkline()
        {
            return View();
        }
	}
}