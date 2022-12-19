using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ResumeModel
{
    public class ResumeSkillGetAllQuery : IRequest<List<ResumeSkill>>
    {
        public class ResumeSkillGetAllQueryHandler : IRequestHandler<ResumeSkillGetAllQuery, List<ResumeSkill>>
        {
            private readonly PortfolioDbContext db;

            public ResumeSkillGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ResumeSkill>> Handle(ResumeSkillGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ResumeSkills.Where(re => re.DeletedDate == null).Include(re=>re.ResumeCategory).ToListAsync(cancellationToken);
                return data;
            }
        }
    }
}
