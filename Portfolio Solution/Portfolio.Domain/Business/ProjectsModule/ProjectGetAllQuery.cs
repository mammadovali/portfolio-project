using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ProjectsModule
{
    public class ProjectGetAllQuery : IRequest<List<Project>>
    {
        public int ProjectCategoryId { get; set; }

        public class ProjectGetAllQueryHandler : IRequestHandler<ProjectGetAllQuery, List<Project>>
        {
            private readonly PortfolioDbContext db;

            public ProjectGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Project>> Handle(ProjectGetAllQuery request, CancellationToken cancellationToken)
            {
                
                var data = await db.Projects
                .Include(p => p.ProjectCategory)
                .Where(p => p.DeletedDate == null)
                .OrderByDescending(p=>p.ProjectCategory)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
