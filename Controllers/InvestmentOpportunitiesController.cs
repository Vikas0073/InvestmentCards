using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nextinvesting.Data;
using nextinvesting.Models;

namespace nextinvesting.Controllers
{
    public class InvestmentOpportunitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvestmentOpportunitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InvestmentOpportunities
        public async Task<IActionResult> Index()
        {
              return View(await _context.InvestmentOpportunities.ToListAsync());
        }

        // GET: InvestmentOpportunities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InvestmentOpportunities == null)
            {
                return NotFound();
            }

            var investmentOpportunities = await _context.InvestmentOpportunities
                .FirstOrDefaultAsync(m => m.id == id);
            if (investmentOpportunities == null)
            {
                return NotFound();
            }

            return View(investmentOpportunities);
        }

        // GET: InvestmentOpportunities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InvestmentOpportunities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,InvestmentName,InvestmentAmount,Description")] InvestmentOpportunities investmentOpportunities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(investmentOpportunities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(investmentOpportunities);
        }

        // GET: InvestmentOpportunities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InvestmentOpportunities == null)
            {
                return NotFound();
            }

            var investmentOpportunities = await _context.InvestmentOpportunities.FindAsync(id);
            if (investmentOpportunities == null)
            {
                return NotFound();
            }
            return View(investmentOpportunities);
        }

        // POST: InvestmentOpportunities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,InvestmentName,InvestmentAmount,Description")] InvestmentOpportunities investmentOpportunities)
        {
            if (id != investmentOpportunities.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(investmentOpportunities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestmentOpportunitiesExists(investmentOpportunities.id))
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
            return View(investmentOpportunities);
        }

        // GET: InvestmentOpportunities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InvestmentOpportunities == null)
            {
                return NotFound();
            }

            var investmentOpportunities = await _context.InvestmentOpportunities
                .FirstOrDefaultAsync(m => m.id == id);
            if (investmentOpportunities == null)
            {
                return NotFound();
            }

            return View(investmentOpportunities);
        }

        // POST: InvestmentOpportunities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InvestmentOpportunities == null)
            {
                return Problem("Entity set 'ApplicationDbContext.InvestmentOpportunities'  is null.");
            }
            var investmentOpportunities = await _context.InvestmentOpportunities.FindAsync(id);
            if (investmentOpportunities != null)
            {
                _context.InvestmentOpportunities.Remove(investmentOpportunities);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestmentOpportunitiesExists(int id)
        {
          return _context.InvestmentOpportunities.Any(e => e.id == id);
        }
    }
}
