using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.Bio
{
    public class ResumeBioViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public ResumeBioViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeBios.Where(rb=>rb.DeletedDate == null).FirstOrDefaultAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
