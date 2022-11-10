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

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostSingleQuery : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public class BlogPostSingleQueryHandler : IRequestHandler<BlogPostSingleQuery, BlogPost>
        {
            private readonly PortfolioDbContext db;

            public BlogPostSingleQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostSingleQuery request, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts
                     .Include(bp => bp.Comments)
                     .AsQueryable();

                if (string.IsNullOrWhiteSpace(request.Slug))
                {
                    return await query.FirstOrDefaultAsync(m => m.Id == request.Id && m.DeletedDate == null);
                }

                return await query.FirstOrDefaultAsync(m => m.Slug.Equals(request.Slug) && m.DeletedDate == null);
            }
        }

    }
}
