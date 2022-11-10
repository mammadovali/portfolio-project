using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMediator mediator;

        public BlogController(IMediator mediator)
        {
            this.mediator = mediator;
        }
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
    }
}
