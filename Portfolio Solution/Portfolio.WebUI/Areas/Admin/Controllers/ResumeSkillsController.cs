using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Business.ResumeModel;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "sa")]
    public class ResumeSkillsController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IMediator mediator;

        public ResumeSkillsController(PortfolioDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        // GET: Admin/ResumeSkills
        public async Task<IActionResult> Index(ResumeSkillGetAllQuery query)
        {
            var response = await mediator.Send(query);

            return View(response);
        }

        // GET: Admin/ResumeSkills/Details/5
        public async Task<IActionResult> Details(int? id, ResumeSkillGetSingleQuery query)
        {
            if (id != query.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(query);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // GET: Admin/ResumeSkills/Create
        public IActionResult Create()
        {
            ViewData["ResumeCategoryId"] = new SelectList(db.ResumeCategories, "Id", "Name");

            ViewBag.Name = new SelectList(db.ResumeSkills.Where(vb => vb.DeletedDate == null).ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ResumeSkillCreateCommand command)
        {
            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);
                if (response.Error == false)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["ResumeCategoryId"] = new SelectList(db.ResumeCategories, "Id", "Name", command.ResumeCategoryId);
            return View(command);
        }

        // GET: Admin/ResumeSkills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeSkill = await db.ResumeSkills.FindAsync(id);
            if (resumeSkill == null)
            {
                return NotFound();
            }
            var command = new ResumeSkillEditCommand();

            command.Id = resumeSkill.Id;
            command.Name = resumeSkill.Name;
            command.Level = resumeSkill.Level;
            command.Description = resumeSkill.Description;
            command.ResumeCategoryId = resumeSkill.ResumeCategoryId;

            ViewData["ResumeCategoryId"] = new SelectList(db.ResumeCategories, "Id", "Name", command.ResumeCategoryId);
            return View(resumeSkill);
        }

        // POST: Admin/ResumeSkills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ResumeSkillEditCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);

            if (response != null)
            {
                return RedirectToAction(nameof(Index));
            }

            ViewData["ResumeCategoryId"] = new SelectList(db.ResumeCategories, "Id", "Name", command.ResumeCategoryId);
            return View(command);
        }


        // POST: Admin/ResumeSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, ResumeSkillRemoveCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(ResumeCategoryCreateCommand command)
        {

            var response = await mediator.Send(command);

            if (response.Error == false)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(command);
        }

        [HttpPost, ActionName("Selected")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SelectedConfirmed(int id, ResumeSkillSelectedDateCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("ViewSkill")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ViewConfirmed(int id, ResumeSkillViewCommand command)
        {
            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeSkillExists(int id)
        {
            return db.ResumeSkills.Any(e => e.Id == id);
        }
    }
}
