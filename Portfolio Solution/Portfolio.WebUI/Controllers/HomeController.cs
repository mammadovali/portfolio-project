using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.Models.DataContext;
using Portfolio.WebUI.ViewModels.ContactPostViewModel;
using Portfolio.WebUI.ViewModels.PortfolioVIewModel;
using Portfolio.WebUI.ViewModels.ResumeViewModel;
using System.IO;
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

        public IActionResult Resume()
        {
            return View();
        }

        public async Task<IActionResult> Portfolio(PortfolioViewModel model)
        {
            var projectCategories = await db.ProjectCategories.Where(pc => pc.DeletedDate == null).ToListAsync();

            var projects = await db.Projects.Where(c => c.DeletedDate == null).ToListAsync();

            return View(new PortfolioViewModel
            {
                ProjectCategories = projectCategories,
                Projects = projects
            });
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

        public IActionResult Pdf()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Export(string GridHtml)
        {

            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 100f, 0f);

                PdfWriter writer = PdfWriter.GetInstance(pdfDocument, stream);

                pdfDocument.Open();

                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDocument, sr);

                pdfDocument.Close();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }
    }
}
