using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Portfolio.Domain.Models.Entities;
using Portfolio.Domain.Models.DataContext;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostCommentRemoveCommand : IRequest<BlogPostComment>
    {
        public int Id { get; set; }

        public class BlogPostCommentRemoveCommandHandler : IRequestHandler<BlogPostCommentRemoveCommand, BlogPostComment>
        {
            private readonly PortfolioDbContext db;

            public BlogPostCommentRemoveCommandHandler(PortfolioDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPostComment> Handle(BlogPostCommentRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPostComments.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

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

