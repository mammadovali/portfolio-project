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

namespace BigOn.Domain.Business.ResumeBioModule
{ 
    public class ResumeBioRemoveCommand : IRequest<ResumeBio>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class ResumeBioRemoveCommandHandler : IRequestHandler<ResumeBioRemoveCommand, ResumeBio>
        {
            private readonly PortfolioDbContext db;

            public ResumeBioRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeBio> Handle(ResumeBioRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeBios
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }
    
}
