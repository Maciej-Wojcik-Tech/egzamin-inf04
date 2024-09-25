using kalkulator_aspnetcoremvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kalkulator_aspnetcoremvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // ------------- Kalkulator rat -------------------------
        public IActionResult Kalkulator()
        {
            return View();
        }

		[HttpPost]
		public IActionResult kalkulator(string amount, string interestRate, double numberOfYears)
		{
			float intRate = float.Parse(interestRate);
			double amountOfMoney = double.Parse(amount);
			double interestRates = double.Parse(interestRate);
			double interest = (amountOfMoney * interestRates * numberOfYears) / 100;
			ViewBag.Result = $"Twoje raty ?{amountOfMoney} ze stop¹ procentow¹ wynosz¹c¹ {intRate}% w {numberOfYears} roku jest ?{interest}";
			return View();
		}

		// ------------------  koniec kalkulatora ------------------

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
