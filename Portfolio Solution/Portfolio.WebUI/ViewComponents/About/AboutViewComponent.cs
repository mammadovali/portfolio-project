using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents.About
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly PortfolioDbContext db;

        public AboutViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.Abouts.ToListAsync();

            if (data == null)
            {
                return null;
            }
            return View(await Task.FromResult(data));
        }
    }
}
