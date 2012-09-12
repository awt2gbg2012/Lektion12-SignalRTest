using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id = "default")
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View((object)id);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
