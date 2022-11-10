using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostCreateCommand : IRequest<JsonResponse>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class BlogPostCreateCommandHandler : IRequestHandler<BlogPostCreateCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostCreateCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(BlogPostCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new BlogPost();

                entity.Title = request.Title;
                entity.Body = request.Body;
                entity.Slug = entity.Title.ToSlug();

                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName);

                request.ImagePath = $"blogpost-{Guid.NewGuid().ToString().ToLower()}{extension}";


                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                entity.ImagePath = request.ImagePath;

            end:
                await db.BlogPosts.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };


            }
        }
    }
}
