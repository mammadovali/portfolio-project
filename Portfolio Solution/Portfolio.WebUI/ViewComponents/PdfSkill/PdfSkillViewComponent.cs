using Portfolio.Domain.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.ResumeSkill
{
    public class PdfSkillViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public PdfSkillViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeSkills.Where(re=>re.DeletedDate==null && re.SelectedDate !=null).Include(re=>re.ResumeCategory).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
