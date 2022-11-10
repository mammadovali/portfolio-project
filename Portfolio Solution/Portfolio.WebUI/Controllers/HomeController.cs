using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Business.ExperienceModule;
using Portfolio.Domain.Business.ResumeBioModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using Portfolio.WebUI.ViewModels.ContactPostViewModel;
using Portfolio.WebUI.ViewModels.ResumeViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly PortfolioDbContext db;
        private readonly IMediator mediator;

        public HomeController(PortfolioDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var response = await db.Abouts.ToListAsync();

            return View(response);
        }

        public async Task<IActionResult> Resume()
        {
            var resumeBio = await db.ResumeBios.FirstOrDefaultAsync(rb => rb.DeletedDate == null);
            var experiences = await db.Experiences.Where(e => e.DeletedDate == null).ToListAsync();
            var academicBackgrounds = await db.AcademicBackgrounds.Where(ab => ab.DeletedDate == null).ToListAsync();

            
            return View(new ResumeViewModel
            {
                ResumeBio = resumeBio,
                Experiences = experiences,
                AcademicBackgrounds = academicBackgrounds
            });
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contact()
        {

            var contactDetail = db.ContactDetails.FirstOrDefault();

            return View(new ContactPostContactDetailViewModel
            {
                ContactDetails = contactDetail
            });
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactPostContactDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(model.ContactPosts);

                await db.SaveChangesAsync();
                var response = new
                {
                    error = false,
                    message = "Müraciətiniz qeydə alındı, tezliklə geri dönüş edəcəyik"
                };

                return Json(response);
            }

            var responseError = new
            {
                error = true,
                message = "Melumatlar uygun deyil, zehmet olmasa yeniden yoxlayin",
                state = ModelState.GetError()
            };
            return Json(responseError);


        }
    }
}
