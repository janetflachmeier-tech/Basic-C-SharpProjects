using Microsoft.AspNetCore.Mvc;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers;

public class InsureeController : Controller
{
    private readonly InsuranceContext _context;

    public InsureeController(InsuranceContext context)
    {
        _context = context;
    }

    // GET: Insuree/Index
    public IActionResult Index()
    {
        return View();
    }

    // POST: Insuree/Index
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(Insuree insuree)
    {
        if (ModelState.IsValid)
        {
            // Calculate the quote
            insuree.Quote = CalculateQuote(insuree);

            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ThankYou), new { id = insuree.Id });
        }
        return View(insuree);
    }

    // GET: Insuree/ThankYou
    public async Task<IActionResult> ThankYou(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: Insuree/Admin
    public async Task<IActionResult> Admin()
    {
        var insurees = _context.Insurees.ToList();
        return View(insurees);
    }

    // GET: Insuree/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: Insuree/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: Insuree/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Insuree insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            // Recalculate the quote
            insuree.Quote = CalculateQuote(insuree);

            _context.Update(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Admin));
        }
        return View(insuree);
    }

    // GET: Insuree/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: Insuree/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree != null)
        {
            _context.Insurees.Remove(insuree);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Admin));
    }

    private decimal CalculateQuote(Insuree insuree)
    {
        // Start with base monthly rate
        decimal quote = 50m;

        // Calculate age
        var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

        // Age-based pricing
        if (age <= 18)
        {
            quote += 100m;
        }
        else if (age >= 19 && age <= 25)
        {
            quote += 50m;
        }
        else if (age >= 26)
        {
            quote += 25m;
        }

        // Car year pricing
        if (insuree.CarYear < 2000)
        {
            quote += 25m;
        }
        else if (insuree.CarYear > 2015)
        {
            quote += 25m;
        }

        // Car make/model pricing
        if (insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
        {
            quote += 25m;
            if (insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;
            }
        }

        // Speeding tickets
        quote += insuree.SpeedingTickets * 10m;

        // DUI
        if (insuree.DUI)
        {
            quote *= 1.25m; // 25% increase
        }

        // Full coverage
        if (insuree.CoverageType)
        {
            quote *= 1.5m; // 50% increase
        }

        return quote;
    }
}
