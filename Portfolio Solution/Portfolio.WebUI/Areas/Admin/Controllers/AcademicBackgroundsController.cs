using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigOn.Domain.Business.AcademicBackgroundModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Business.AcademicBackgroundModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AcademicBackgroundsController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IMediator mediator;

        public AcademicBackgroundsController(PortfolioDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/AcademicBackgrounds
        public async Task<IActionResult> Index(AcademicBackgroundGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (response==null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/AcademicBackgrounds/Details/5
        public async Task<IActionResult> Details(AcademicBackgroundSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/AcademicBackgrounds/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AcademicBackgroundCreateCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/AcademicBackgrounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicBackground = await db.AcademicBackgrounds.FindAsync(id);
            if (academicBackground == null)
            {
                return NotFound();
            }
            return View(academicBackground);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AcademicBackgroundEditCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/AcademicBackgrounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academicBackground = await db.AcademicBackgrounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (academicBackground == null)
            {
                return NotFound();
            }

            return View(academicBackground);
        }


        // POST: Admin/AcademicBackgrounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(AcademicBackgroundRemoveCommand command)
        {

            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool AcademicBackgroundExists(int id)
        {
            return db.AcademicBackgrounds.Any(e => e.Id == id);
        }
    }
}
