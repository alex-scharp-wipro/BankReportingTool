using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankReportingTool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET /Home/Results
        public ActionResult Results()
        {
            ViewBag.Message = "Results Query";

            return View();
        }
        // Grab chart to render in partial view
        public ActionResult DrawChart()
        {
            return View("_Chart");
        }
    }
}