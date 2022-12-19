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

namespace Portfolio.Domain.Business.ProjectsModule
{

    public class ProjectsCreateCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }
        public string Link { get; set; }

        public int ProjectCategoryId { get; set; }

        public IFormFile Image { get; set; }

        public class ProjectsCreateCommandHandler : IRequestHandler<ProjectsCreateCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public ProjectsCreateCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }

            public async Task<JsonResponse> Handle(ProjectsCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new Project();

                entity.Name = request.Name;
                entity.ProjectCategoryId = request.ProjectCategoryId;
                entity.Link = request.Link;

                if (request.Image == null)
                    goto end;

                string extexsion = Path.GetExtension(request.Image.FileName); //.jpg, png 

                request.ImagePath = $"project-{Guid.NewGuid().ToString().ToLower()}{extexsion}";

                string fullPath = env.GetImagePhysicalPath(request.ImagePath);


                using (var fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    request.Image.CopyTo(fs);
                }


                entity.ImagePath = request.ImagePath;

            end:

                await db.Projects.AddAsync(entity, cancellationToken);
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
