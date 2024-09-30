using AplikacjaInternetowa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AplikacjaInternetowa.Controllers
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
        public IActionResult Informations()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Kalkulator()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kalkulator(double l1, double l2, string operation)
        {
            double equals = 0;
            switch (operation)
            {

                case "+":
                    {
                        equals = l1 + l2;
                        break;
                    }
                case "-":
                    {
                        equals = l1 - l2;
                        break;
                    }
                case "*":
                    {
                        equals = l1 * l2;
                        break;
                    }
                case "/":
                    {
                        equals = l1 / l2;
                        
                        break;

                    }
             }
            ViewBag.Result = equals;
            return View();
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*
 
 [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
 
 */