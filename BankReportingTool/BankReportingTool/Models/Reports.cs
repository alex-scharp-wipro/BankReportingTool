using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankReportingTool.Models
{
    /// <summary>
    /// Enumerates all reports
    /// </summary>
   
    public class ReportsList
    {
        public enum Reports
        {
            [Display(Name = "Consumer Spending")]
            ConsumerSpending = 1
        };
        public Reports Report { get; set; }
    }
}