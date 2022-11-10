using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostGetAllDeletedQuery : IRequest<List<BlogPost>>
    {
        public class BlogPostGetAllDeletedHandler : IRequestHandler<BlogPostGetAllDeletedQuery, List<BlogPost>>
        {
            private readonly PortfolioDbContext db;

            public BlogPostGetAllDeletedHandler(PortfolioDbContext db)
            {
                this.db = db;
            }


            public async Task<List<BlogPost>> Handle(BlogPostGetAllDeletedQuery request, CancellationToken cancellationToken)
            {
                var deletedPosts = await db.BlogPosts
                    .Where(bp => bp.DeletedDate != null)
                    .ToListAsync(cancellationToken);


                return deletedPosts;
            }
        }
    }
}
