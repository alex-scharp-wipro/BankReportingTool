using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankReportingTool.Models.ConsumerSpending
{
    public class ConsumerSpendingFiltersModel
    {
        // TODO Implement class to accept filter values
        [Display(Name = "Age Min")]
        public int? AgeMin { get; set; }

        [Display(Name = "Age Max")]
        public int? AgeMax { get; set; }

        [Display(Name = "Is Male")]
        public bool? IsMale { get; set; }

        [Display(Name = "Is Female")]
        public bool? IsFemale { get; set; }

        [Display(Name = "Payment Type")]
        public bool? PaymentType { get; set; }

        [Display(Name = "Date Start")]
        public string DateStart { get; set; }

        [Display(Name = "Date End")]
        public string DateEnd { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Goods")]
        public string Goods { get; set;}

        [Display(Name = "Amount")]
        public int? Amount { get; set; }
    }
}