using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigOn.Domain.Business.ResumeBioModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Business.ResumeBioModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ResumeBiosController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IMediator mediator;

        public ResumeBiosController(PortfolioDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ResumeBios
        public async Task<IActionResult> Index(ResumeBioGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/ResumeBios/Details/5
        public async Task<IActionResult> Details(ResumeBioSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/ResumeBios/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResumeBioCreateCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/ResumeBios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeBio = await db.ResumeBios.FindAsync(id);
            if (resumeBio == null)
            {
                return NotFound();
            }
            return View(resumeBio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ResumeBioEditCommand command)
        {

            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/ResumeBios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeBio = await db.ResumeBios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeBio == null)
            {
                return NotFound();
            }

            return View(resumeBio);
        }

        // POST: Admin/ResumeBios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(ResumeBioRemoveCommand command)
        {
            //var resumeBio = await db.ResumeBios.FindAsync(id);
            //db.ResumeBios.Remove(resumeBio);
            //await db.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));


            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ResumeBioExists(int id)
        {
            return db.ResumeBios.Any(e => e.Id == id);
        }
    }
}
