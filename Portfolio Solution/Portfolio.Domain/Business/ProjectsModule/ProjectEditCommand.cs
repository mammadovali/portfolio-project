using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ProjectsModule
{
    public class ProjectEditCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string Link { get; set; }

        public int ProjectCategoryId { get; set; }

        public IFormFile Image { get; set; }


        public class ProjectEditCommandHandler : IRequestHandler<ProjectEditCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public ProjectEditCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<JsonResponse> Handle(ProjectEditCommand request, CancellationToken cancellationToken)
            {
                var entity = await db.Projects
                       .FirstOrDefaultAsync(p => p.Id == request.Id && p.DeletedDate == null)
                      ;
                if (entity == null)
                {
                    return null;
                }

                entity.Name = request.Name;
                entity.Link = request.Link;
                entity.ProjectCategoryId = request.ProjectCategoryId;

                if (request.Image == null)
                    goto end;

                string extexsion = Path.GetExtension(request.Image.FileName); //.jpg, png 

                request.ImagePath = $"JsonResponse-{Guid.NewGuid().ToString().ToLower()}{extexsion}";

                string fullPath = env.GetImagePhysicalPath(request.ImagePath);


                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }

                string oldPath = env.GetImagePhysicalPath(entity.ImagePath);


                System.IO.File.Move(oldPath, env.GetImagePhysicalPath($"archive{DateTime.Now:yyyyMMdd}-{entity.ImagePath}"));

                entity.ImagePath = request.ImagePath;

            end:

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
