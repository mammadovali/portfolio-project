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
    public class AcademicBackgroundEditCommand : IRequest<AcademicBackground>
    {
        public int Id { get; set; }
        public string Duration { get; set; }

        public string Qualification { get; set; }

        public string Degree { get; set; }

        public string InstituteOrUniversityName { get; set; }

        public string Details { get; set; }

        public class AcademicBackgroundEditCommandHandler : IRequestHandler<AcademicBackgroundEditCommand, AcademicBackground>
        {
            private readonly PortfolioDbContext db;

            public AcademicBackgroundEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<AcademicBackground> Handle(AcademicBackgroundEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.AcademicBackgrounds
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Duration = request.Duration;

                data.Qualification = request.Qualification;

                data.Degree = request.Degree;

                data.InstituteOrUniversityName = request.InstituteOrUniversityName;

                data.Details = request.Details;

                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }

}
