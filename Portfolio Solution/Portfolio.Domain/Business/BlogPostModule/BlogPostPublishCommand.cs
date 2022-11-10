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
    public class BlogPostPublishCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public class BlogPostPublishCommandHandler : IRequestHandler<BlogPostPublishCommand, BlogPost>
        {
            private readonly PortfolioDbContext db;

            public BlogPostPublishCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostPublishCommand request, CancellationToken cancellationToken)
            {
                var data = await db.BlogPosts.FirstOrDefaultAsync(bp => bp.Id == request.Id && bp.PublishedDate == null);

                if (data == null)
                {
                    return null;
                }

                data.PublishedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);

                return data;
            }
        }

    }
}
