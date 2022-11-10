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
    public class ExperienceEditCommand : IRequest<Experience>
    {
        public int Id { get; set; }
        public string Duration { get; set; }

        public string JobTitle { get; set; }

        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string Details { get; set; }

        public class ExperienceEditCommandHandler : IRequestHandler<ExperienceEditCommand, Experience>
        {
            private readonly PortfolioDbContext db;

            public ExperienceEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<Experience> Handle(ExperienceEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.Experiences
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Duration = request.Duration;

                data.JobTitle = request.JobTitle;

                data.CompanyName = request.CompanyName;

                data.Location = request.Location;

                data.Details = request.Details;

                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }

}
