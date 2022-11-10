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

namespace Portfolio.Domain.Business.ExperienceModule
{

    public class ExperienceGetAllQuery : IRequest<List<Experience>>
    {
        public class ExperienceGetAllQueryHandler : IRequestHandler<ExperienceGetAllQuery, List<Experience>>
        {
            private readonly PortfolioDbContext db;

            public ExperienceGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Experience>> Handle(ExperienceGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Experiences
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
