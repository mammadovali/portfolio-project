using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HardSkillCategoriesController : Controller
    {
        private readonly PortfolioDbContext _context;

        public HardSkillCategoriesController(PortfolioDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HardSkillCategories
        public async Task<IActionResult> Index()
        {
            var data = await _context.HardSkillCategories
                .Include(hs => hs.HardSkills)
                .ToListAsync();

            return View(data);
        }

        // GET: Admin/HardSkillCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardSkillCategory = await _context.HardSkillCategories
                .Include(hs => hs.HardSkills)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hardSkillCategory == null)
            {
                return NotFound();
            }

            return View(hardSkillCategory);
        }

        // GET: Admin/HardSkillCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HardSkillCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedDate,DeletedDate")] HardSkillCategory hardSkillCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hardSkillCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hardSkillCategory);
        }

        // GET: Admin/HardSkillCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardSkillCategory = await _context.HardSkillCategories.FindAsync(id);
            if (hardSkillCategory == null)
            {
                return NotFound();
            }
            return View(hardSkillCategory);
        }

        // POST: Admin/HardSkillCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedDate,DeletedDate")] HardSkillCategory hardSkillCategory)
        {
            if (id != hardSkillCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hardSkillCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HardSkillCategoryExists(hardSkillCategory.Id))
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
            return View(hardSkillCategory);
        }

        // GET: Admin/HardSkillCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hardSkillCategory = await _context.HardSkillCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hardSkillCategory == null)
            {
                return NotFound();
            }

            return View(hardSkillCategory);
        }

        // POST: Admin/HardSkillCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hardSkillCategory = await _context.HardSkillCategories.FindAsync(id);
            _context.HardSkillCategories.Remove(hardSkillCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HardSkillCategoryExists(int id)
        {
            return _context.HardSkillCategories.Any(e => e.Id == id);
        }
    }
}
