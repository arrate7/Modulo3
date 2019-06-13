using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Relacion1a1.Models;

namespace Relacion1a1.Controllers
{
    public class BiografiasController : Controller
    {
        private readonly Relacion1a1Context _context;

        public BiografiasController(Relacion1a1Context context)
        {
            _context = context;
        }

        // GET: Biografias
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Biografia.Include(x => x.Autor).ToListAsync());
        }

        // GET: Biografias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia
                .Include(b => b.Autor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografia == null)
            {
                return NotFound();
            }

            return View(biografia);
        }

        // GET: Biografias/Create
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id");
            return View();
        }

        // POST: Biografias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,FechaEdicion,AutorId")] Biografia biografia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biografia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", biografia.AutorId);
            return View(biografia);
        }

        // GET: Biografias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia.FindAsync(id);
            if (biografia == null)
            {
                return NotFound();
            }
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", biografia.AutorId);
            return View(biografia);
        }

        // POST: Biografias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,FechaEdicion,AutorId")] Biografia biografia)
        {
            if (id != biografia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biografia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiografiaExists(biografia.Id))
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
            ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", biografia.AutorId);
            return View(biografia);
        }

        // GET: Biografias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia
                .Include(b => b.Autor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografia == null)
            {
                return NotFound();
            }

            return View(biografia);
        }

        // POST: Biografias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var biografia = await _context.Biografia.FindAsync(id);
            _context.Biografia.Remove(biografia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BiografiaExists(int id)
        {
            return _context.Biografia.Any(e => e.Id == id);
        }
    }
}
