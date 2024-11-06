using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZBazamiDanychProjekt.Models;

namespace ZBazamiDanychProjekt.Controllers
{
    public class ZadaniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZadaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Zadanies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zadania.ToListAsync());
        }

        // GET: Zadanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zadanie = await _context.Zadania
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zadanie == null)
            {
                return NotFound();
            }

            return View(zadanie);
        }

        // GET: Zadanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zadanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Waznosc,Grupa,DataWykonania,DataPrzypomnienia,DataZakonczenia,Tresc")] Zadanie zadanie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zadanie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zadanie);
        }

        // GET: Zadanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zadanie = await _context.Zadania.FindAsync(id);
            if (zadanie == null)
            {
                return NotFound();
            }
            return View(zadanie);
        }

        // POST: Zadanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Waznosc,Grupa,DataWykonania,DataPrzypomnienia,DataZakonczenia,Tresc")] Zadanie zadanie)
        {
            if (id != zadanie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zadanie);
                    await _context.SaveChangesAsync();
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

        // GET: Zadanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zadanie = await _context.Zadania
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zadanie == null)
            {
                return NotFound();
            }

            return View(zadanie);
        }

        // POST: Zadanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zadanie = await _context.Zadania.FindAsync(id);
            if (zadanie != null)
            {
                _context.Zadania.Remove(zadanie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZadanieExists(int id)
        {
            return _context.Zadania.Any(e => e.Id == id);
        }
    }
}
