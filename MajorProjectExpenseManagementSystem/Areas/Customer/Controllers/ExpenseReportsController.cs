using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MajorProjectExpenseManagementSystem.Data;
using MajorProjectExpenseManagementSystem.Models;

namespace MajorProjectExpenseManagementSystem.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ExpenseReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/ExpenseReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExpenseReports.ToListAsync());
        }

        // GET: Customer/ExpenseReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseReport = await _context.ExpenseReports
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (expenseReport == null)
            {
                return NotFound();
            }

            return View(expenseReport);
        }

        // GET: Customer/ExpenseReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/ExpenseReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,ItemName,Amount,ExpenseDate,Category")] ExpenseReport expenseReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expenseReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expenseReport);
        }

        // GET: Customer/ExpenseReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseReport = await _context.ExpenseReports.FindAsync(id);
            if (expenseReport == null)
            {
                return NotFound();
            }
            return View(expenseReport);
        }

        // POST: Customer/ExpenseReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,ItemName,Amount,ExpenseDate,Category")] ExpenseReport expenseReport)
        {
            if (id != expenseReport.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expenseReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseReportExists(expenseReport.ItemId))
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
            return View(expenseReport);
        }

        // GET: Customer/ExpenseReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expenseReport = await _context.ExpenseReports
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (expenseReport == null)
            {
                return NotFound();
            }

            return View(expenseReport);
        }

        // POST: Customer/ExpenseReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expenseReport = await _context.ExpenseReports.FindAsync(id);
            _context.ExpenseReports.Remove(expenseReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpenseReportExists(int id)
        {
            return _context.ExpenseReports.Any(e => e.ItemId == id);
        }
    }
}
