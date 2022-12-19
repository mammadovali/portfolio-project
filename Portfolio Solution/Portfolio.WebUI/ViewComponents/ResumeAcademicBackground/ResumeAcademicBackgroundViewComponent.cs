using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Domain.Models.DataContext;

namespace Portfolio.WebUI.ViewComponents.ResumeAcademicBackground
{
    public class ResumeAcademicBackgroundViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public ResumeAcademicBackgroundViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.AcademicBackgrounds.Where(rd => rd.DeletedDate == null).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
