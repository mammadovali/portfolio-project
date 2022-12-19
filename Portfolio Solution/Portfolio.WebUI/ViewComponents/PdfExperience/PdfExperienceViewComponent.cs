using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.ResumeExperience
{
    public class PdfExperienceViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public PdfExperienceViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.Experiences.Where(e => e.DeletedDate == null).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
