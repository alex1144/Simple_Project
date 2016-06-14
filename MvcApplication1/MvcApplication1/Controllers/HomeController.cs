using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Modificacion del branch de mantenimientos";

            return View();
        }

        public ActionResult Contact() 
        {
            ViewData["Message"] = "Nueva modificacion";

            return View();
        }
    }
}
