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

    public class ProjectCategoryGetAllQuery : IRequest<List<ProjectCategory>>
    {
        public class ProjectCategoryGetAllQueryHandler : IRequestHandler<ProjectCategoryGetAllQuery, List<ProjectCategory>>
        {
            private readonly PortfolioDbContext db;

            public ProjectCategoryGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ProjectCategory>> Handle(ProjectCategoryGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
