using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jw537414_MIS_plswrk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Jenna";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Jenna's Contact Information";

            return View();
        }
    }
}