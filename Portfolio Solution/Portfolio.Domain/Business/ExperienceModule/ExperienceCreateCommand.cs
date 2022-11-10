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
     public class ExperienceCreateCommand : IRequest<Experience> 
    {
        public string Duration { get; set; }

        public string JobTitle { get; set; }

        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }


        public class ExperienceCreateCommandHandler : IRequestHandler<ExperienceCreateCommand, Experience>
        {
            private readonly PortfolioDbContext db;

            public ExperienceCreateCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceCreateCommand request, CancellationToken cancellationToken)
            {
                var model = new Experience();

                model.Duration = request.Duration;

                model.JobTitle = request.JobTitle;

                model.CompanyName = request.CompanyName;

                model.Location = request.Location;

                model.Details = request.Details;

                await db.Experiences.AddAsync(model, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);

                return model;
            }


        }
    }
}
