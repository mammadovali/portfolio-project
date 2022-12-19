using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Portfolio.Domain.Models.DataContext;

namespace Portfolio.WebUI.ViewComponents.PdfBio
{
    public class PdfBioViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public PdfBioViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeBios.FirstOrDefaultAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
