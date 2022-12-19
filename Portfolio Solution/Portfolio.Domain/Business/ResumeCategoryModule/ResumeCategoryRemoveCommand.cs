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
    public class ResumeCategoryRemoveCommand : IRequest<ResumeCategory>
    {
        public int Id { get; set; }

        public class ResumeCategoryRemoveCommandHandler : IRequestHandler<ResumeCategoryRemoveCommand, ResumeCategory>
        {
            private readonly PortfolioDbContext db;

            public ResumeCategoryRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeCategory> Handle(ResumeCategoryRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeCategories
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
