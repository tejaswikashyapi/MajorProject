using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseManagementSystem.Data;
using ExpenseManagementSystem.Models;

namespace ExpenseManagementSystem.Areas.ExpenseMgmt.Controllers
{
    [Area("ExpenseMgmt")]
    public class PayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PayersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExpenseMgmt/Payers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Payer.Include(p => p.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ExpenseMgmt/Payers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payer = await _context.Payer
                .Include(p => p.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payer == null)
            {
                return NotFound();
            }

            return View(payer);
        }

        // GET: ExpenseMgmt/Payers/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: ExpenseMgmt/Payers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PayerName")] Payer payer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", payer.Id);
            return View(payer);
        }

        // GET: ExpenseMgmt/Payers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payer = await _context.Payer.FindAsync(id);
            if (payer == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", payer.Id);
            return View(payer);
        }

        // POST: ExpenseMgmt/Payers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,PayerName")] Payer payer)
        {
            if (id != payer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PayerExists(payer.Id))
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
            ViewData["Id"] = new SelectList(_context.Users, "Id", "Id", payer.Id);
            return View(payer);
        }

        // GET: ExpenseMgmt/Payers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payer = await _context.Payer
                .Include(p => p.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payer == null)
            {
                return NotFound();
            }

            return View(payer);
        }

        // POST: ExpenseMgmt/Payers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var payer = await _context.Payer.FindAsync(id);
            _context.Payer.Remove(payer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PayerExists(int? id)
        {
            return _context.Payer.Any(e => e.Id == id);
        }
    }
}
