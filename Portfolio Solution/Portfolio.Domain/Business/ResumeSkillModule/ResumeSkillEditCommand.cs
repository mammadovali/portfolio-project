using MediatR;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ResumeModel
{
    public class ResumeSkillEditCommand : IRequest<JsonResponse>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public int ResumeCategoryId { get; set; }

        public string Description { get; set; }

        public class ResumeSkillEditCommandHandler : IRequestHandler<ResumeSkillEditCommand, JsonResponse>
        {
            private readonly PortfolioDbContext db;
            private readonly IHostEnvironment env;

            public ResumeSkillEditCommandHandler(PortfolioDbContext db, IHostEnvironment env)
            {
                this.db = db;
                this.env = env;
            }
            public async Task<JsonResponse> Handle(ResumeSkillEditCommand request, CancellationToken cancellationToken)
            {
                var entity = db.ResumeSkills.FirstOrDefault(bg => bg.Id == request.Id && bg.DeletedDate == null);


                if (entity == null)
                {
                    return null;
                }


                entity.Name = request.Name;
                entity.ResumeCategoryId = request.ResumeCategoryId;
                entity.Level = request.Level;
                entity.Description = request.Description;

                
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
