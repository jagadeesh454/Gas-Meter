using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class TableController : Controller
    {
        //
        // GET: /Table/
        [ActionName("basic")]
        public ActionResult basic()
        {
            return View();
        }

        [ActionName("datatable")]
        public ActionResult datatable()
        {
            return View();
        }

        [ActionName("responsive")]
        public ActionResult responsive()
        {
            return View();
        }

        [ActionName("editable")]
        public ActionResult editable()
        {
            return View();
        }
	}
}