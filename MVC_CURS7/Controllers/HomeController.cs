using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CURS7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("about")]
        public ActionResult SomeMethodName()
        {

            return View();

        }
        [NonAction]
        public int Calc()
        {


            return 20;
        }

        public int DisplayCalc()
        {
            return Calc();
        }


        public ActionResult VerbsTest()
        {
            return Content("Hello");
        }

        public ActionResult Verbs()
        {
            return Content("Hello");
        }
    }
}