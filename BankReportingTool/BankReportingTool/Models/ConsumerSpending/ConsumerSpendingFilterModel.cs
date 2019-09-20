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

        [Display(Name = "Age")]
        public int? Age { get; set; }

        [Display(Name = "Is Online")]
        public bool? IsOnline { get; set; }

        [Display(Name = "Payment Type")]
        public int? PaymentType { get; set; }

        [Display(Name = "Date")]
        public string Date { get; set; }

        [Display(Name = "Store")]
        public string Store { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Goods")]
        public string Goods { get; set; }

        [Display(Name = "Amount")]
        public string Amount { get; set; }
    }
}