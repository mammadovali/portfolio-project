using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostGetDeletedSingleQuery : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public class BlogPostGetSingleQueryHandler : IRequestHandler<BlogPostGetDeletedSingleQuery, BlogPost>
        {
            private readonly PortfolioDbContext db;

            public BlogPostGetSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostGetDeletedSingleQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                    .Include(bp => bp.Comments)
                    .AsQueryable();
                if (string.IsNullOrWhiteSpace(request.Slug))
                {
                    return await query.FirstOrDefaultAsync(bp => bp.Id == request.Id && bp.DeletedDate != null, cancellationToken);

                }
                return await query.FirstOrDefaultAsync(bp => bp.Slug.Equals(request.Slug), cancellationToken);
            }
        }
    }
}
