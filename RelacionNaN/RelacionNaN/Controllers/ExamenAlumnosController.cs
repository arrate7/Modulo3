using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RelacionNaN.Models;

namespace RelacionNaN.Controllers
{
    public class ExamenAlumnosController : Controller
    {
        private readonly RelacionNaNContext _context;

        public ExamenAlumnosController(RelacionNaNContext context)
        {
            _context = context;
        }

        // GET: ExamenAlumnos
        public async Task<IActionResult> Index()
        {

            return View(await _context.ExamenAlumno.Include(x=>x.Examen).Include(x=>x.Alumno).ToListAsync());
        }

        // GET: ExamenAlumnos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examenAlumno = await _context.ExamenAlumno
                .Include(e => e.Alumno)
                .Include(e => e.Examen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examenAlumno == null)
            {
                return NotFound();
            }

            return View(examenAlumno);
        }

        // GET: ExamenAlumnos/Create
        public IActionResult Create()
        {
            ViewData["AlumnoId"] = new SelectList(_context.Set<Alumno>(), "Id", "Id");
            ViewData["ExamenId"] = new SelectList(_context.Set<Examen>(), "Id", "Id");
            return View();
        }

        // POST: ExamenAlumnos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nota,AlumnoId,ExamenId")] ExamenAlumno examenAlumno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examenAlumno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Set<Alumno>(), "Id", "Id", examenAlumno.AlumnoId);
            ViewData["ExamenId"] = new SelectList(_context.Set<Examen>(), "Id", "Id", examenAlumno.ExamenId);
            return View(examenAlumno);
        }

        // GET: ExamenAlumnos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examenAlumno = await _context.ExamenAlumno.FindAsync(id);
            if (examenAlumno == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(_context.Set<Alumno>(), "Id", "Id", examenAlumno.AlumnoId);
            ViewData["ExamenId"] = new SelectList(_context.Set<Examen>(), "Id", "Id", examenAlumno.ExamenId);
            return View(examenAlumno);
        }

        // POST: ExamenAlumnos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nota,AlumnoId,ExamenId")] ExamenAlumno examenAlumno)
        {
            if (id != examenAlumno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examenAlumno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamenAlumnoExists(examenAlumno.Id))
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
            ViewData["AlumnoId"] = new SelectList(_context.Set<Alumno>(), "Id", "Id", examenAlumno.AlumnoId);
            ViewData["ExamenId"] = new SelectList(_context.Set<Examen>(), "Id", "Id", examenAlumno.ExamenId);
            return View(examenAlumno);
        }

        // GET: ExamenAlumnos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examenAlumno = await _context.ExamenAlumno
                .Include(e => e.Alumno)
                .Include(e => e.Examen)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examenAlumno == null)
            {
                return NotFound();
            }

            return View(examenAlumno);
        }

        // POST: ExamenAlumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var examenAlumno = await _context.ExamenAlumno.FindAsync(id);
            _context.ExamenAlumno.Remove(examenAlumno);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamenAlumnoExists(int id)
        {
            return _context.ExamenAlumno.Any(e => e.Id == id);
        }
    }
}
