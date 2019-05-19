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
    public class CommitteeController : Controller
    {
        private readonly WoSContext _context;

        public CommitteeController(WoSContext context)
        {
            _context = context;
        }

        // GET: Committee
        public async Task<IActionResult> Index()
        {
            var woSContext = _context.Committees.Include(c => c.Chairperson).Include(c => c.MemberOne).Include(c => c.MemberThree).Include(c => c.MemberTwo).Include(c => c.Seb).Include(c => c.Secretary);
            return View(await woSContext.ToListAsync());
        }

        // GET: Committee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var committee = await _context.Committees
                .Include(c => c.Chairperson)
                .Include(c => c.MemberOne)
                .Include(c => c.MemberThree)
                .Include(c => c.MemberTwo)
                .Include(c => c.Seb)
                .Include(c => c.Secretary)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (committee == null)
            {
                return NotFound();
            }

            return View(committee);
        }

        // GET: Committee/Create
        public IActionResult Create()
        {
            ViewData["ChairpersonID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberOneID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberThreeID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberTwoID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["SebID"] = new SelectList(_context.SEBs, "ID", "NameOfSEB");
            ViewData["SecretaryID"] = new SelectList(_context.Employees, "ID", "LastName");
            return View();
        }

        // POST: Committee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Committee committee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(committee);
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
            ViewData["ChairpersonID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberOneID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberThreeID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberTwoID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["SebID"] = new SelectList(_context.SEBs, "ID", "NameOfSEB");
            ViewData["SecretaryID"] = new SelectList(_context.Employees, "ID", "LastName");
            return View(committee);
        }

        // GET: Committee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var committee = await _context.Committees.FindAsync(id);
            if (committee == null)
            {
                return NotFound();
            }
            ViewData["ChairpersonID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberOneID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberThreeID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberTwoID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["SebID"] = new SelectList(_context.SEBs, "ID", "NameOfSEB");
            ViewData["SecretaryID"] = new SelectList(_context.Employees, "ID", "LastName");
            return View(committee);
        }

        // POST: Committee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SebID,ChairpersonID,SecretaryID,MemberOneID,MemberTwoID,MemberThreeID")] Committee committee)
        {
            if (id != committee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(committee);
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
            ViewData["ChairpersonID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberOneID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberThreeID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MemberTwoID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["SebID"] = new SelectList(_context.SEBs, "ID", "NameOfSEB");
            ViewData["SecretaryID"] = new SelectList(_context.Employees, "ID", "LastName");
            return View(committee);
        }

        // GET: Committee/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var committee = await _context.Committees
                .Include(c => c.Chairperson)
                .Include(c => c.MemberOne)
                .Include(c => c.MemberThree)
                .Include(c => c.MemberTwo)
                .Include(c => c.Seb)
                .Include(c => c.Secretary)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (committee == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(committee);
        }

        // POST: Committee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var committee = await _context.Committees.FindAsync(id);
            if(committee == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                _context.Committees.Remove(committee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool CommitteeExists(int id)
        {
            return _context.Committees.Any(e => e.ID == id);
        }
    }
}
