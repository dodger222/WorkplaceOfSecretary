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
    public class ProtocolController : Controller
    {
        private readonly WoSContext _context;

        public ProtocolController(WoSContext context)
        {
            _context = context;
        }

        // GET: Protocol
        public async Task<IActionResult> Index()
        {
            var woSContext = _context.Protocols.Include(p => p.Leader).Include(p => p.Meeting).Include(p => p.Student);
            return View(await woSContext.ToListAsync());
        }

        // GET: Protocol/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols
                .Include(p => p.Leader)
                .Include(p => p.Meeting)
                .Include(p => p.Student)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (protocol == null)
            {
                return NotFound();
            }

            return View(protocol);
        }

        // GET: Protocol/Create
        public IActionResult Create()
        {
            ViewData["LeaderID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "LastName");
            return View();
        }

        // POST: Protocol/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Protocol protocol)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(protocol);
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
            ViewData["LeaderID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "LastName");
            return View(protocol);
        }

        // GET: Protocol/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols.FindAsync(id);
            if (protocol == null)
            {
                return NotFound();
            }
            ViewData["LeaderID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "LastName");
            return View(protocol);
        }

        // POST: Protocol/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,LastNameInDative,LastNameInGenitive,FirstNameInGenitive,PatronymicInGenitive,LeaderID,Theme,Consultants,MeetingID")] Protocol protocol)
        {
            if (id != protocol.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(protocol);
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
            ViewData["LeaderID"] = new SelectList(_context.Employees, "ID", "LastName");
            ViewData["MeetingID"] = new SelectList(_context.Meetings, "ID", "ID");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "LastName");
            return View(protocol);
        }

        // GET: Protocol/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protocol = await _context.Protocols
                .Include(p => p.Leader)
                .Include(p => p.Meeting)
                .Include(p => p.Student)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (protocol == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(protocol);
        }

        // POST: Protocol/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var protocol = await _context.Protocols.FindAsync(id);
            if (protocol == null)
            {
                return RedirectToAction(nameof(Index));
            }
            try
            {
                _context.Protocols.Remove(protocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool ProtocolExists(int id)
        {
            return _context.Protocols.Any(e => e.ID == id);
        }
    }
}
