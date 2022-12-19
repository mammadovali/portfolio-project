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
    public class ResumeCategoryGetSingleQuery : IRequest<ResumeCategory>
    {
        public int Id { get; set; }

        public class ResumeCategorySingleQueryHandler : IRequestHandler<ResumeCategoryGetSingleQuery, ResumeCategory>
        {
            private readonly PortfolioDbContext db;

            public ResumeCategorySingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeCategory> Handle(ResumeCategoryGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeCategories.FirstOrDefaultAsync(p => p.Id == request.Id);

                return data;
            }
        }

    }
}
