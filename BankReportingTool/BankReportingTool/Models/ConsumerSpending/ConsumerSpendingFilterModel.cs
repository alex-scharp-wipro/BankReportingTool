using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankReportingTool.Models.ConsumerSpending
{
    public class ConsumerSpendingFilterModel
    {
        // TODO Implement class to accept filter values
        [HiddenInput(DisplayValue = false)]
        public int AccountId { get; set; }

        [Display(Name = "Age Min")]
        public int? AgeMin { get; set; }

        [Display(Name = "Age Max")]
        public int? AgeMax { get; set; }

        [Display(Name = "Is Online")]
        public bool? IsOnline { get; set; }

        [Display(Name = "Not Online")]
        public bool? NotOnline { get; set; }

        [Display(Name = "Cash Payment")]
        public bool? CashPayment{ get; set; }

        [Display(Name = "Online Payment")]
        public bool? OnlinePayment { get; set; }

        [Display(Name = "Date Start")]
        public string DateStart { get; set; }

        [Display(Name = "Date End")]
        public string DateEnd { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }
    }
}