using MediatR;
using Portfolio.Domain.Models.Entities;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ResumeModel
{
    public class ResumeSkillViewCommand : IRequest<ResumeSkill>
    {
        public int Id { get; set; }

        public class ResumeSkillViewCommandHandler : IRequestHandler<ResumeSkillViewCommand, ResumeSkill>
        {
            private readonly PortfolioDbContext db;

            public ResumeSkillViewCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<ResumeSkill> Handle(ResumeSkillViewCommand request, CancellationToken cancellationToken)
            {
                string tag = "tag";

                var data = db.ResumeSkills.FirstOrDefault(m => m.Id == request.Id);

                if (data == null)
                {
                    return null;
                }
                if (data.View != null)
                {
                    data.View = null;
                }
                else if (data.View == null)
                {
                    data.View = tag;
                }
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
