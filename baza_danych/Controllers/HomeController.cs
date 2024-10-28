using baza_danych.Models;
using baza_danych.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace baza_danych.Controllers
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
//tworzenie formularza do dodania danych kontaktowych
            KontaktyContext db = new KontaktyContext();
            var kontakty = db.Kontakty;
            return View(kontakty);
        }
        [HttpPost]
        public ActionResult Index(Kontakt kontakt)
        {
            if (ModelState.IsValid) { return View("Index", kontakt); }
            else
            {
                //Dodanie do bazy danych
                KontaktyContext db = new KontaktyContext();
                db.Kontakty.Add(kontakt);
                db.SaveChanges();
            }

            return View("Index");
        }
            public IActionResult Privacy()
        {
            //wyœwietlanie danych na stronie privacy
            KontaktyContext db = new KontaktyContext();
            var kontakty = db.Kontakty;
            return View(kontakty);
        }

        public IActionResult UsunSamochody()
        {

            KontaktyContext db = new KontaktyContext();
            var samochody = db.Samochody;
            return View(samochody);
        }

        [HttpPost]
        public async Task<IActionResult> UsunSamochody(Samochody samochody1)
        {
            try
            {
                KontaktyContext db = new KontaktyContext();
                var samochody0 = from marka in db.Samochody select marka;


                var samochody3 = await samochody0.FirstOrDefaultAsync(s => s.Marka == samochody1.Marka);


                db.Remove(samochody3);
                db.SaveChanges();

                return View(await samochody0.ToListAsync());
            }
            catch (Exception ex) { return View(); }

        }
        public IActionResult DodajSamochody()
        {

            KontaktyContext db = new KontaktyContext();
            var samochody = db.Samochody;
            return View(samochody);
        }

        [HttpPost] //Ta metoda polega na pobraniu informacji z formularza i dodaniu ich do bazy danych
        public ActionResult DodajSamochody(Samochody samochody)
        {
            if (ModelState.IsValid) { return View("Index", samochody); }
            else
            {
                //Dodanie do bazy danych
                KontaktyContext db = new KontaktyContext();
                db.Samochody.Add(samochody);
                db.SaveChanges();
            }

            return View("DodajSamochody");
        }

        public IActionResult WyswietlSamochody()
        {
            //wyœwietlanie danych na stronie privacy
            KontaktyContext db = new KontaktyContext(); ;
            var samochody = db.Samochody;
            return View(samochody);
            //------------ Samochody ---------

            //-------------
        }
            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //próba ³apania b³êdu przez asp.net
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
