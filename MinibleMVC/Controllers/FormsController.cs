using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class FormsController : Controller
    {
        //
        // GET: /Forms/
        [ActionName("elements")]
        public ActionResult elements()
        {
            return View();
        }

        [ActionName("validation")]
        public ActionResult validation()
        {
            return View();
        }

        [ActionName("advanced")]
        public ActionResult advanced()
        {
            return View();
        }

        [ActionName("editors")]
        public ActionResult editors()
        {
            return View();
        }

        [ActionName("uploads")]
        public ActionResult uploads()
        {
            return View();
        }

        [ActionName("xeditable")]
        public ActionResult xeditable()
        {
            return View();
        }

        [ActionName("repeater")]
        public ActionResult repeater()
        {
            return View();
        }

        [ActionName("wizard")]
        public ActionResult wizard()
        {
            return View();
        }

        [ActionName("mask")]
        public ActionResult mask()
        {
            return View();
        }
	}
}