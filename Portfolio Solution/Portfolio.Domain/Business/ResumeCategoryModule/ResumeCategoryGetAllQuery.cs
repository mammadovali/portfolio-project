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

namespace Portfolio.Domain.Business.ResumeCategoryModule
{
    public class ResumeCategoryGetAllQuery : IRequest<List<ResumeCategory>>
    {
        public class ResumeCategoryGetAllQueryHandler : IRequestHandler<ResumeCategoryGetAllQuery, List<ResumeCategory>>
        {
            private readonly PortfolioDbContext db;

            public ResumeCategoryGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeCategory>> Handle(ResumeCategoryGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeCategories
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
