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

namespace Portfolio.Domain.Business.ResumeBioModule
{

    public class ResumeBioGetAllQuery : IRequest<List<ResumeBio>>
    {
        public class ResumeBioGetAllQueryHandler : IRequestHandler<ResumeBioGetAllQuery, List<ResumeBio>>
        {
            private readonly PortfolioDbContext db;

            public ResumeBioGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeBio>> Handle(ResumeBioGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeBios
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
