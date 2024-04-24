using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RaulCruz_PruebaProgreso1.Models;

namespace RaulCruz_PruebaProgreso1.Controllers
{
    public class RC_Tabla1Controller : Controller
    {
        private readonly RaulCruz_DBContext _context;

        public RC_Tabla1Controller(RaulCruz_DBContext context)
        {
            _context = context;
        }

        // GET: RC_Tabla1
        public async Task<IActionResult> Index()
        {
            return View(await _context.RC_Tabla1.ToListAsync());
        }

        // GET: RC_Tabla1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rC_Tabla1 = await _context.RC_Tabla1
                .FirstOrDefaultAsync(m => m.RCId == id);
            if (rC_Tabla1 == null)
            {
                return NotFound();
            }

            return View(rC_Tabla1);
        }

        // GET: RC_Tabla1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RC_Tabla1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RCId,RCNombre,RCValor,RCFechaInicio,RCBoleano")] RC_Tabla1 rC_Tabla1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rC_Tabla1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rC_Tabla1);
        }

        // GET: RC_Tabla1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rC_Tabla1 = await _context.RC_Tabla1.FindAsync(id);
            if (rC_Tabla1 == null)
            {
                return NotFound();
            }
            return View(rC_Tabla1);
        }

        // POST: RC_Tabla1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RCId,RCNombre,RCValor,RCFechaInicio,RCBoleano")] RC_Tabla1 rC_Tabla1)
        {
            if (id != rC_Tabla1.RCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rC_Tabla1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RC_Tabla1Exists(rC_Tabla1.RCId))
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
            return View(rC_Tabla1);
        }

        // GET: RC_Tabla1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rC_Tabla1 = await _context.RC_Tabla1
                .FirstOrDefaultAsync(m => m.RCId == id);
            if (rC_Tabla1 == null)
            {
                return NotFound();
            }

            return View(rC_Tabla1);
        }

        // POST: RC_Tabla1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rC_Tabla1 = await _context.RC_Tabla1.FindAsync(id);
            if (rC_Tabla1 != null)
            {
                _context.RC_Tabla1.Remove(rC_Tabla1);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RC_Tabla1Exists(int id)
        {
            return _context.RC_Tabla1.Any(e => e.RCId == id);
        }
    }
}
