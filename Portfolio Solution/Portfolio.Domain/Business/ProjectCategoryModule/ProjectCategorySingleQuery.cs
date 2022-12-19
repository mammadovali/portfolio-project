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
    public class ProjectCategoryGetSingleQuery : IRequest<ProjectCategory>
    {
        public int Id { get; set; }
        public class ProjectCategorySingleQueryHandler : IRequestHandler<ProjectCategoryGetSingleQuery, ProjectCategory>
        {
            private readonly PortfolioDbContext db;

            public ProjectCategorySingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ProjectCategory> Handle(ProjectCategoryGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories.FirstOrDefaultAsync(p=>p.Id == request.Id);
                    
                return data;
            }
        }

    }
}
