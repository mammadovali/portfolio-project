using MediatR;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ResumeModel
{
    public class ResumeSkillCreateCommand : IRequest<JsonResponse>
    {
        public string Name { get; set; }

        public int Level { get; set; }

        public int ResumeCategoryId { get; set; }

        public string Description { get; set; }
        

        public class ResumeSkillCreateCommandHandler : IRequestHandler<ResumeSkillCreateCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public ResumeSkillCreateCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ResumeSkillCreateCommand request, CancellationToken cancellationToken)
            {
                var entity = new ResumeSkill();

                entity.Name = request.Name;
                entity.ResumeCategoryId = request.ResumeCategoryId;
                entity.Level = request.Level;
                entity.Description = request.Description;

                await db.AddAsync(entity, cancellationToken);
                await db.SaveChangesAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Success"
                };
            }
        }
    }
}
