using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace page1.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; }
        [Required]
        [BindProperty]

        public string Loan_Amount { get; set; }
        [Required]
        [BindProperty]
        public string Interest { get; set; }
        [Required]
        [BindProperty]
        public string Duration { get; set; }


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "";
        }


        /*
        public void OnPost()
        {
            double.TryParse(Loan_Amount, out double principal);
            double.TryParse(Interest, out double rate);
            double.TryParse(Duration, out double years);
        }

            double monthly = MoratageCalcHelper.ComputeMonthlyPayment(principal, years, rate);
            System.Console.WriteLine(Message);
            Message = $"For a loan of ${principal},for a duration of {years} years and a interest rate of {rate}% the monthly loan payment is {monthly:$0.00}";

        }*/
    }
}
