using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankReportingTool.Models;
using BankReportingTool.Models.ConsumerSpending;

namespace BankReportingTool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET /Home/GetFilters/{reportId}
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
                    viewName = "~/Views/Filters/_ConsumerSpendingFiltersView.cshtml";
                    viewModel = new ConsumerSpendingFiltersModel()
                    {
                        AgeMax = null,
                        AgeMin = null,
                        IsMale = null,
                        IsFemale = null,
                        PaymentType = null,
                        DateStart = null,
                        DateEnd = null,
                        State = null,
                        Goods = null,
                        Amount = null
                    };
                    break;

                // Uh oh! Id does not match a known report.
                default:
                    string message = "Oops! We couldn't find that report.";
                    return new HttpNotFoundResult(message);
            }

            // Store reportId in ViewBag.
            ViewBag.SelectedReport = reportId;

            // Return correct filters partial view
            return PartialView(viewName, viewModel);
        }

        // POST /Home/Submit
        [HttpPost]
        public ActionResult Submit(object filtersModel)
        {
            // TODO: Type check model, and verify it matches selected report.
            // TODO: Also check model and data validity.

            // TODO: Construct submit model from filters model and data.
            object submitModel = null;

            // TODO: Send submit model to service/API to process report.

            // TODO: Send report results to Results action.
            object resultsModel = null;

            return View("Results", resultsModel);
        }

        // GET /Home/Results
        // TODO: Delete this action once Submit is finished. Results page should only be accessible from Submit action.
        public ActionResult Results(object resultsModel)
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