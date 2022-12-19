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
    public class ResumeBioGetSingleQuery : IRequest<ResumeBio>
    {
        public int Id { get; set; }
        public class ResumeBioSingleQueryHandler : IRequestHandler<ResumeBioGetSingleQuery, ResumeBio>
        {
            private readonly PortfolioDbContext db;

            public ResumeBioSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeBio> Handle(ResumeBioGetSingleQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeBios.FirstOrDefaultAsync(p=>p.Id == request.Id && p.DeletedDate == null);
                    
                return data;
            }
        }

    }
}
