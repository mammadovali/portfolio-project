using MediatR;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ResumeModel
{
    public class ResumeCategoryCreateCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }

        public class ResumeCategoryPostCommandHandler : IRequestHandler<ResumeCategoryCreateCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;

            public ResumeCategoryPostCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<JsonResponse> Handle(ResumeCategoryCreateCommand request, CancellationToken cancellationToken)
            {
                var data = new ResumeCategory();

                data.Name = request.Name;

                await db.ResumeCategories.AddAsync(data, cancellationToken);

                await db.SaveChangesAsync(cancellationToken);
                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                }; ;
            }
        }
    }
}
