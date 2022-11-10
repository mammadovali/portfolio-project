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

namespace BigOn.Domain.Business.AcademicBackgroundModule
{ 
    public class AcademicBackgroundRemoveCommand : IRequest<AcademicBackground>
    {
        public int Id { get; set; }

        public class AcademicBackgroundRemoveCommandHandler : IRequestHandler<AcademicBackgroundRemoveCommand, AcademicBackground>
        {
            private readonly PortfolioDbContext db;

            public AcademicBackgroundRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<AcademicBackground> Handle(AcademicBackgroundRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.AcademicBackgrounds
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
