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

namespace Portfolio.Domain.Business.AcademicBackgroundModule
{

    public class AcademicBackgroundGetAllQuery : IRequest<List<AcademicBackground>>
    {
        public class AcademicBackgroundGetAllQueryHandler : IRequestHandler<AcademicBackgroundGetAllQuery, List<AcademicBackground>>
        {
            private readonly PortfolioDbContext db;

            public AcademicBackgroundGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<AcademicBackground>> Handle(AcademicBackgroundGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.AcademicBackgrounds
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
