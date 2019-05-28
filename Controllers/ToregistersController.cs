using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Original.Models;

namespace Original.Controllers
{
    public class ToregistersController : Controller
    {
        private readonly OriginalContext _context;

        public ToregistersController(OriginalContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Toregister.ToListAsync());
        }

        // GET: Toregisters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toregister = await _context.Toregister
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toregister == null)
            {
                return NotFound();
            }

            return View(toregister);
        }

        public IActionResult Create()
        {
            return View();
        }

      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Idade,CPF,Peso,Altura,Telefone,Nascimento,Sexo")] Toregister toregister)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toregister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toregister);
        }

        // GET: Toregisters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toregister = await _context.Toregister.FindAsync(id);
            if (toregister == null)
            {
                return NotFound();
            }
            return View(toregister);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Idade,CPF,Peso,Altura,Telefone,Nascimento,Sexo")] Toregister toregister)
        {
            if (id != toregister.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toregister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToregisterExists(toregister.Id))
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
            return View(toregister);
        }

        // GET: Toregisters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toregister = await _context.Toregister
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toregister == null)
            {
                return NotFound();
            }

            return View(toregister);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toregister = await _context.Toregister.FindAsync(id);
            _context.Toregister.Remove(toregister);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToregisterExists(int id)
        {
            return _context.Toregister.Any(e => e.Id == id);
        }
    }
}
