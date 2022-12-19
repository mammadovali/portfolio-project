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

namespace Portfolio.Domain.Business.ResumeCategoryModule
{
    public class ResumeCategoryEditCommand : IRequest<ResumeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public class ResumeCategoryEditCommandHandler : IRequestHandler<ResumeCategoryEditCommand, ResumeCategory>
        {
            private readonly PortfolioDbContext db;

            public ResumeCategoryEditCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeCategory> Handle(ResumeCategoryEditCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeCategories
                    .FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null, cancellationToken);

                if (data == null)
                {
                    return null;
                }

                data.Name = request.Name;
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }


        }
    }
}
