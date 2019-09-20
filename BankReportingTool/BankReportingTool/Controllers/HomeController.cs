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
        /// GET /Home/GetFilters/reportId
        /// After the user selects a report, the page should request here.
        /// This method returns a partial view containing search filters 
        /// specific to the requested report.
        /// If no match, return HTTP 404 message.
        /// </summary>
        /// <param name="reportId">Report's enum value as int</param>
        /// <returns></returns>
        public ActionResult GetFilters(int reportId)
        {
            string viewName;
            object viewModel;

            // Assign viewName and viewModel based on reportId
            switch(reportId)
            {
                // Consumer Spending Report
                case (int)Reports.ConsumerSpending:
                    viewName = "ConsumerSpendingFilters";
                    // TODO rename model to ConsumerSpendingFiltersModel
                    viewModel = new Models.ConsumerSpending.ConsumerSpendingFilterModel();
                    break;

                // Uh oh! Id does not match a known report.
                default:
                    string message = "Oops! We couldn't find that report.";
                    return new HttpNotFoundResult(message);
            }

            // Store reportId in ViewBag.
            ViewBag.SelectedReport = reportId;

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