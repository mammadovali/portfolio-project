using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ProjectCategoryModule
{
     public class ProjectCategoryCreateCommand : IRequest<ProjectCategory> 
    {
        public string Name { get; set; }
        public class ProjectCategoryCreateCommandHandler : IRequestHandler<ProjectCategoryCreateCommand, ProjectCategory>
        {
            private readonly PortfolioDbContext db;

            public ProjectCategoryCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new ProjectCategory();

                model.Name = request.Name;

                await db.ProjectCategories.AddAsync(model, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);

                return model;
            }


        }
    }
}
