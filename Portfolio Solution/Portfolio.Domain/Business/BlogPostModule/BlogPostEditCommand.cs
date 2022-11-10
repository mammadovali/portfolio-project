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

    public class BlogPostEditCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }

        public class BlogPostEditCommandHandler : IRequestHandler<BlogPostEditCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public BlogPostEditCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(BlogPostEditCommand request, CancellationToken cancellationToken)
            {
                var entity = db.BlogPosts
                     .FirstOrDefault(bg => bg.Id == request.Id && bg.DeletedDate == null);

                if (entity == null)
                {
                    return null;
                }

                entity.Title = request.Title;
                entity.Body = request.Body;
                if (request.Image == null)
                    goto end;

                string extension = Path.GetExtension(request.Image.FileName); //.jpg-ni goturur
                request.ImagePath = $"JsonResponse-{Guid.NewGuid().ToString().ToLower()}{extension}";

                string fullPath = env.GetImagePhysicalPath(request.ImagePath);

                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                string oldPath = env.GetImagePhysicalPath(entity.ImagePath);

               
                System.IO.File.Move(oldPath, env.GetImagePhysicalPath($"archive{DateTime.Now:yyyyMMdd}-{entity.ImagePath}"));

                entity.ImagePath = request.ImagePath;

            end:
                if (string.IsNullOrWhiteSpace(entity.Slug))
                {
                    entity.Slug = request.Title.ToSlug();
                }



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
