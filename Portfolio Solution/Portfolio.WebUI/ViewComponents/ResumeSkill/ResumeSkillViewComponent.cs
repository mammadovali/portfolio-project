using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.ResumeSkill
{
    public class ResumeSkillViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public ResumeSkillViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var data = await db.ResumeSkills.Where(re => re.DeletedDate == null && re.SelectedDate != null).Include(re => re.ResumeCategory).ToListAsync();
            var data = await db.ResumeCategories.Include(cr => cr.HardSkills.Where(rs => rs.DeletedDate == null && rs.SelectedDate != null)).ToListAsync();
            if (data == null)
            {
                return null;
            }

            return View(data);
        }
    }
}
