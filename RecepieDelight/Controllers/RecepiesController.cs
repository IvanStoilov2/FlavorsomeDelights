using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using RecepieDelight.Data;
using RecepieDelight.Models;

namespace RecepieDelight.Controllers
{
    public class RecepiesController : Controller
    {
        private readonly RecepieDelightContext _context;

        public async Task<Recepie> GetDailyRecepieFromRandomCategory()
        {
            var random = new Random();

            // Get all categories
            var categories = await _context.Category.ToListAsync();

            if (!categories.Any())
            {
                return null;
            }

            // Choose a random category
            var randomCategory = categories[random.Next(categories.Count)];

            // Get all recepies from the chosen category
            var recepiesFromCategory = await _context.Recepie.Where(r => r.CategoryId == randomCategory.Id).ToListAsync();

            if (!recepiesFromCategory.Any())
            {
                return null;
            }

            // Choose a random recepie from the category
            var randomRecepie = recepiesFromCategory[random.Next(recepiesFromCategory.Count)];

            return randomRecepie;
        }

        public async Task<IActionResult> RecepieOfTheDay()
        {
            var recepie = await GetDailyRecepieFromRandomCategory();
            if (recepie == null)
            {
                // Handle the case when there is no recepie
                return View("NoRecepie"); // Change to an appropriate view
            }
            return View(recepie); // Change to an appropriate view
        }




        public RecepiesController(RecepieDelightContext context)
        {
            _context = context;
        }

        // GET: Recepies
        public async Task<IActionResult> Index(int? categoryId)
        {
            if (_context.Recepie == null)
            {
                return Problem("Entity set 'RecepieDelightContext.Recepie'  is null.");
            }

            if (categoryId.HasValue)
            {
                var recepies = _context.Recepie.Where(r => r.CategoryId == categoryId).Include(r => r.Category).ToList();

                if (recepies.Count == 0)
                {
                    return Problem("No Data.");
                }

                ViewData["Title"] = recepies.First().Category.Name;

                return View(recepies);
            }
            else
            {
                ViewData["Title"] = "All Recepies";

                return View(await _context.Recepie.Include(r => r.Category).ToListAsync());
            }
        }


        // GET: Recepies/Details/5
        public async Task<IActionResult> GetByTitle(string titleFilter)
        {
            return _context.Recepie.Where(x => x.Title.Contains(titleFilter)) != null ?
                          View("Index", await _context.Recepie.Where(x => x.Title.Contains(titleFilter)).ToListAsync()) :
                          Problem("Entity set 'RecepieDelightContext.Recepie'  is null.");
        }

        // GET: Recepies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Recepie == null)
            {
                return NotFound();
            }

            var recepie = await _context.Recepie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recepie == null)
            {
                return NotFound();
            }

            return View(recepie);
        }

        // GET: Recepies/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = _context.Category.ToList();
            return View();
        }

        // POST: Recepies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Recepie recepie)
        {
            _context.Add(recepie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ViewData["Categories"] = _context.Category.ToList();
            return View(recepie);
        }

        // GET: Recepies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recepie == null)
            {
                return NotFound();
            }

            ViewData["Categories"] = _context.Category.ToList();

            var recepie = await _context.Recepie.FindAsync(id);
            if (recepie == null)
            {
                return NotFound();
            }
            //recepie.Ingredients = new List<Ingredient>();

            return View(recepie);
        }

        // POST: Recepies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Recepie recepie)
        {
            if (id != recepie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(recepie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecepieExists(recepie.Id))
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
            return View(recepie);
        }

        // GET: Recepies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Recepie == null)
            {
                return NotFound();
            }

            var recepie = await _context.Recepie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recepie == null)
            {
                return NotFound();
            }

            return View(recepie);
        }

        // POST: Recepies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Recepie == null)
            {
                return Problem("Entity set 'RecepieDelightContext.Recepie'  is null.");
            }
            var recepie = await _context.Recepie.FindAsync(id);
            if (recepie != null)
            {
                _context.Recepie.Remove(recepie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecepieExists(int id)
        {
            return (_context.Recepie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
