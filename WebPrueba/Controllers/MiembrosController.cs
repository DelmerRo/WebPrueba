using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPrueba.Data;
using WebPrueba.Models;

namespace WebPrueba.Controllers
{
    public class MiembrosController : Controller
    {
        private readonly ForoContext _BdMiembros;

        public MiembrosController(ForoContext context)
        {
            _BdMiembros = context;
        }

        // GET: Miembros
        public async Task<IActionResult> Index()
        {
            if (!_BdMiembros.Miembros.Any())
            {
                _BdMiembros.Miembros.AddRange(MiembrosFalsoRepo.GetMiembros());
                _BdMiembros.SaveChanges();
            }
            var listaDeMiembros = _BdMiembros.Miembros.ToList();
            return View(listaDeMiembros);
        }

        // GET: Miembros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miembro = await _BdMiembros.Miembros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (miembro == null)
            {
                return NotFound();
            }

            return View(miembro);
        }

        // GET: Miembros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Miembros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Telefono,Id,UserName,Nombre,Apellido,Email,FechaAlta,Passsword")] Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                _BdMiembros.Add(miembro);
                await _BdMiembros.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(miembro);
        }

        // GET: Miembros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miembro = await _BdMiembros.Miembros.FindAsync(id);
            if (miembro == null)
            {
                return NotFound();
            }
            return View(miembro);
        }

        // POST: Miembros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Telefono,Id,UserName,Nombre,Apellido,Email,FechaAlta,Passsword")] Miembro miembro)
        {
            if (id != miembro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _BdMiembros.Update(miembro);
                    await _BdMiembros.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MiembroExists(miembro.Id))
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
            return View(miembro);
        }

        // GET: Miembros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var miembro = await _BdMiembros.Miembros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (miembro == null)
            {
                return NotFound();
            }

            return View(miembro);
        }

        // POST: Miembros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var miembro = await _BdMiembros.Miembros.FindAsync(id);
            _BdMiembros.Miembros.Remove(miembro);
            await _BdMiembros.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MiembroExists(int id)
        {
            return _BdMiembros.Miembros.Any(e => e.Id == id);
        }
    }
}
