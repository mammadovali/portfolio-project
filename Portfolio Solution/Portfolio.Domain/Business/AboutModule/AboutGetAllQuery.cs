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

namespace Portfolio.Domain.Business.AboutModule
{

    public class ContactDetailGetAllQuery : IRequest<List<About>>
    {
        public class AboutGetAllQueryHandler : IRequestHandler<ContactDetailGetAllQuery, List<About>>
        {
            private readonly PortfolioDbContext db;

            public AboutGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<List<About>> Handle(ContactDetailGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Abouts
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
