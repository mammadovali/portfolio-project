using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ResumeCategoriesController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IMediator mediator;

        public ResumeCategoriesController(PortfolioDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ResumeCategories
        public async Task<IActionResult> Index()
        {
            return View(await db.ResumeCategories.ToListAsync());
        }

        // GET: Admin/ResumeCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeCategory = await db.ResumeCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeCategory == null)
            {
                return NotFound();
            }

            return View(resumeCategory);
        }

        // GET: Admin/ResumeCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ResumeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id,CreatedDate,DeletedDate")] ResumeCategory resumeCategory)
        {
            if (ModelState.IsValid)
            {
                db.Add(resumeCategory);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resumeCategory);
        }

        // GET: Admin/ResumeCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeCategory = await db.ResumeCategories.FindAsync(id);
            if (resumeCategory == null)
            {
                return NotFound();
            }
            return View(resumeCategory);
        }

        // POST: Admin/ResumeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id,CreatedDate,DeletedDate")] ResumeCategory resumeCategory)
        {
            if (id != resumeCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(resumeCategory);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeCategoryExists(resumeCategory.Id))
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
            return View(resumeCategory);
        }

        // GET: Admin/ResumeCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeCategory = await db.ResumeCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeCategory == null)
            {
                return NotFound();
            }

            return View(resumeCategory);
        }

        // POST: Admin/ResumeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumeCategory = await db.ResumeCategories.FindAsync(id);
            db.ResumeCategories.Remove(resumeCategory);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeCategoryExists(int id)
        {
            return db.ResumeCategories.Any(e => e.Id == id);
        }
    }
}
