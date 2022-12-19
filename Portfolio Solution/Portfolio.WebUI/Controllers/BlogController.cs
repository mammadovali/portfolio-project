using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using Portfolio.WebUI.ViewModels.BlogPostSingleViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMediator mediator;
        private readonly PortfolioDbContext db;

        public BlogController(IMediator mediator, PortfolioDbContext db)
        {
            this.mediator = mediator;
            this.db = db;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Body", response);
            }

            if (response == null)
            {
                return NotFound();
            }
            return View(response);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {

            var blogPost = await mediator.Send(query);

            if (blogPost == null)
            {
                return NotFound();
            }


            return View(blogPost);
        }

        [HttpPost]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand command)
        {

            try
            {

                var response = await mediator.Send(command);
                return PartialView("_Comment", response);
            }
            catch (System.Exception ex)
            {
                return Json(new
                {
                    error = true,
                    message = ex.Message
                });
            }

            //return Json(response);

        }
    }
}
