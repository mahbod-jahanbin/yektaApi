using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using yektaApi.Models;

namespace yektaApi.Controllers
{
    public class ProCategoriesController : Controller
    {
        private readonly ApiContext _context;

        public ProCategoriesController(ApiContext context)
        {
            _context = context;
        }

        // GET: ProCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProCategory.ToListAsync());
        }

        // GET: ProCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proCategory = await _context.ProCategory
                .FirstOrDefaultAsync(m => m.CPId == id);
            if (proCategory == null)
            {
                return NotFound();
            }

            return View(proCategory);
        }

        // GET: ProCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CPId,CPName,CPInfo")] ProCategory proCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proCategory);
        }

        // GET: ProCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proCategory = await _context.ProCategory.FindAsync(id);
            if (proCategory == null)
            {
                return NotFound();
            }
            return View(proCategory);
        }

        // POST: ProCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CPId,CPName,CPInfo")] ProCategory proCategory)
        {
            if (id != proCategory.CPId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProCategoryExists(proCategory.CPId))
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
            return View(proCategory);
        }

        // GET: ProCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proCategory = await _context.ProCategory
                .FirstOrDefaultAsync(m => m.CPId == id);
            if (proCategory == null)
            {
                return NotFound();
            }

            return View(proCategory);
        }

        // POST: ProCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proCategory = await _context.ProCategory.FindAsync(id);
            _context.ProCategory.Remove(proCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProCategoryExists(int id)
        {
            return _context.ProCategory.Any(e => e.CPId == id);
        }
    }
}
