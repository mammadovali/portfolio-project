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
     public class AcademicBackgroundCreateCommand : IRequest<AcademicBackground> 
    {
        public string Duration { get; set; }

        public string Qualification { get; set; }

        public string Degree { get; set; }

        public string InstituteOrUniversityName { get; set; }

        public string Details { get; set; }


        public class AcademicBackgroundCreateCommandHandler : IRequestHandler<AcademicBackgroundCreateCommand, AcademicBackground>
        {
            private readonly PortfolioDbContext db;

            public AcademicBackgroundCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<AcademicBackground> Handle(AcademicBackgroundCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new AcademicBackground();

                model.Duration = request.Duration;

                model.Qualification = request.Qualification;

                model.Degree = request.Degree;

                model.InstituteOrUniversityName = request.InstituteOrUniversityName;

                model.Details = request.Details;

                await db.AcademicBackgrounds.AddAsync(model, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);

                return model;
            }


        }
    }
}
