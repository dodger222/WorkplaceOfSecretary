using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WorkplaceOfSecretary.Data;
using WorkplaceOfSecretary.Models;

namespace WorkplaceOfSecretary.Controllers
{
    public class SEBController : Controller
    {
        private readonly WoSContext _context;

        public SEBController(WoSContext context)
        {
            _context = context;
        }

        // GET: SEB
        public async Task<IActionResult> Index()
        {
            return View(await _context.SEBs.ToListAsync());
        }

        // GET: SEB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sEB = await _context.SEBs
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sEB == null)
            {
                return NotFound();
            }

            return View(sEB);
        }

        // GET: SEB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SEB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SEB sEB)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(sEB);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(sEB);
        }

        // GET: SEB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sEB = await _context.SEBs.FindAsync(id);
            if (sEB == null)
            {
                return NotFound();
            }
            return View(sEB);
        }

        // POST: SEB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,NameOfSEB")] SEB sEB)
        {
            if (id != sEB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sEB);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(sEB);
        }

        // GET: SEB/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sEB = await _context.SEBs
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sEB == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(sEB);
        }

        // POST: SEB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sEB = await _context.SEBs.FindAsync(id);
            if (sEB == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                _context.SEBs.Remove(sEB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool SEBExists(int id)
        {
            return _context.SEBs.Any(e => e.ID == id);
        }
    }
}
