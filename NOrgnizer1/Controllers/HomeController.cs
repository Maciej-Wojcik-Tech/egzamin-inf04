using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NOrgnizer1.Models;
using NOrgnizer1.Models.Data;
using System.Diagnostics;

namespace NOrgnizer1.Controllers
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

            ApplicationDbContext db = new ApplicationDbContext();
            var zadania = db.Zadania;
            return View(zadania);
           
        }
        //----------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Zadanie zadanie)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (ModelState.IsValid)
            {
                db.Add(zadanie);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zadanie);
        }


        //------ Delete kasowanie--------
        public async Task<IActionResult> Delete(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (id == null) return NotFound();

            var zadanie = await db.Zadania
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zadanie == null) return NotFound();

            return View(zadanie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var zadanie = await db.Zadania.FindAsync(id);
            db.Zadania.Remove(zadanie);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //---- edycja ----------
        // GET: Zadanie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (id == null)
            {
                return NotFound();
            }

            var zadanie = await db.Zadania.FindAsync(id);
            if (zadanie == null)
            {
                return NotFound();
            }
            return View(zadanie);
        }

        // POST: Zadanie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Zadanie zadanie)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            if (id != zadanie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(zadanie);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZadanieExists(zadanie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(zadanie);
        }

        private bool ZadanieExists(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return db.Zadania.Any(e => e.Id == id);
        }
        //--------------------

            // Wyœwietlanie zadañ z filtrami
            public async Task<IActionResult> Filtr(int? grupa, int? waznosc, DateTime? dataWykonania)
            {
            ApplicationDbContext db = new ApplicationDbContext();
            // Zaczynamy od bazy danych
            var zadaniaQuery = db.Zadania.AsQueryable();

                // Filtracja po grupie
                if (grupa.HasValue)
                {
                    zadaniaQuery = zadaniaQuery.Where(z => z.Grupa == grupa.Value);
                }

                // Filtracja po wa¿noœci
                if (waznosc.HasValue)
                {
                    zadaniaQuery = zadaniaQuery.Where(z => z.Waznosc == waznosc.Value);
                }

                // Filtracja po dacie wykonania
                if (dataWykonania.HasValue)
                {
                    zadaniaQuery = zadaniaQuery.Where(z => z.DataWykonania == dataWykonania.Value);
                }

                // Pobranie wyników z bazy danych
                var zadania = await zadaniaQuery.ToListAsync();

                return View(zadania);
            }
        


        //--------- koniec filtr --------
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
