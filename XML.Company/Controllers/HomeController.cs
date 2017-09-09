using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XML.Company.ConnectedServices.BankServiceReference;

namespace XML.Company.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBankService _bankService;

        public HomeController(IBankService bankService)
        {
            _bankService = bankService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var response = _bankService.PaymentActionAsync(new PaymentActionRequest1()).Result;
            var response2 = _bankService.GetAccountStatementAsync(new GetAccountStatementRequest()).Result;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
