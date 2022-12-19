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

namespace Portfolio.Domain.Business.ResumeModel
{
    
    public class ResumeSkillRemoveCommand : IRequest<ResumeSkill>
    {
        public int Id { get; set; }

        public class ResumeSkillRemoveCommandHandler : IRequestHandler<ResumeSkillRemoveCommand, ResumeSkill>
        {
            private readonly PortfolioDbContext db;

            public ResumeSkillRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<ResumeSkill> Handle(ResumeSkillRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeSkills.FirstOrDefaultAsync(re => re.Id == request.Id && re.DeletedDate == null);

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
