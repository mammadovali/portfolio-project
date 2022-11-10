using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Business.AboutModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutsController : Controller
    {
        private readonly PortfolioDbContext _context;
        private readonly IMediator mediator;

        public AboutsController(PortfolioDbContext context, IMediator mediator)
        {
            _context = context;
            this.mediator = mediator;
        }

        // GET: Admin/Abouts
        public async Task<IActionResult> Index([FromRoute] ContactDetailGetAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.Abouts.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AboutEditCommand command)
        {

            if (id != command.Id)
            {
                return NotFound();
            }

            var response = await mediator.Send(command);

            if (response.Error == false)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(command);


        }

        private bool AboutExists(int id)
        {
            return _context.Abouts.Any(e => e.Id == id);
        }
    }
}
