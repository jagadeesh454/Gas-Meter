using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/
        [ActionName("login")]
        public ActionResult login()
        {
            return View();
        }

        [ActionName("register")]
        public ActionResult register()
        {
            return View();
        }

        [ActionName("recoverpassword")]
        public ActionResult recoverpassword()
        {
            return View();
        }

        [ActionName("lockscreen")]
        public ActionResult lockscreen()
        {
            return View();
        }
	}
}