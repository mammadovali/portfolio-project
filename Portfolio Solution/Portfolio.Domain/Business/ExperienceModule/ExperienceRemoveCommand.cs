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

namespace BigOn.Domain.Business.ExperienceModule
{ 
    public class ExperienceRemoveCommand : IRequest<Experience>
    {
        public int Id { get; set; }

        public class ExperienceRemoveCommandHandler : IRequestHandler<ExperienceRemoveCommand, Experience>
        {
            private readonly PortfolioDbContext db;

            public ExperienceRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Experiences
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
