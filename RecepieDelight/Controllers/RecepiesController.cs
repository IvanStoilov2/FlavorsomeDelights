﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecepieDelight.Data;
using RecepieDelight.Models;

namespace RecepieDelight.Controllers
{
    public class RecepiesController : Controller
    {
        private readonly RecepieDelightContext _context;

        public RecepiesController(RecepieDelightContext context)
        {
            _context = context;
        }

        // GET: Recepies
        public async Task<IActionResult> Index()
        {
              return _context.Recepie != null ? 
                          View(await _context.Recepie.ToListAsync()) :
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
            return View();
        }

        // POST: Recepies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] Recepie recepie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recepie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recepie);
        }

        // GET: Recepies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recepie == null)
            {
                return NotFound();
            }

            var recepie = await _context.Recepie.FindAsync(id);
            if (recepie == null)
            {
                return NotFound();
            }
            return View(recepie);
        }

        // POST: Recepies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] Recepie recepie)
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