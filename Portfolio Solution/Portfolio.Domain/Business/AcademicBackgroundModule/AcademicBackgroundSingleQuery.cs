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
    public class AcademicBackgroundSingleQuery : IRequest<AcademicBackground>
    {
        public int Id { get; set; }
        public class AcademicBackgroundSingleQueryHandler : IRequestHandler<AcademicBackgroundSingleQuery, AcademicBackground>
        {
            private readonly PortfolioDbContext db;

            public AcademicBackgroundSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<AcademicBackground> Handle(AcademicBackgroundSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.AcademicBackgrounds.FirstOrDefaultAsync(p=>p.Id == request.Id);
                    
                return data;
            }
        }

    }
}
