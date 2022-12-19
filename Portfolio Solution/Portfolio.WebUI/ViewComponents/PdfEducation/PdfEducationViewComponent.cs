using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.PdfEducation
{
    public class PdfEducationViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public PdfEducationViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.AcademicBackgrounds.Where(rd=>rd.DeletedDate==null).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
