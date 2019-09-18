using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankReportingTool.Models;

namespace BankReportingTool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET /Home/Report/reportName
        /// After the user selects a report, the page should redirect here.
        /// This method returns a partial view containing search filters 
        /// specific to the requested report.
        /// </summary>
        /// <param name="reportId">ID of the report</param>
        /// <returns></returns>
        public ActionResult Report(int reportId)
        {
            string viewName;
            object viewModel;

            // Assign viewName and viewModel based on reportId
            switch(reportId)
            {
                // Consumer Spending Report
                case 0:
                    viewName = "ConsumerSpendingForm";
                    viewModel = new Models.ConsumerSpending.ConsumerSpendingViewModel();
                    break;

                // Uh oh! Id does not match a known report.
                default:
                    string message = "Oops! We couldn't find that report.";
                    return new HttpNotFoundResult(message);
            }

            // Return the appropriate partial view
            return PartialView(viewName, viewModel);
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