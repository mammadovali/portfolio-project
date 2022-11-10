using MediatR;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Infrastructure;
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
    public class BlogPostGetAllQuery : PaginateModel, IRequest<PagedViewModel<BlogPost>>
    {

        public class BlogPostGetAllQueryHandler : IRequestHandler<BlogPostGetAllQuery, PagedViewModel<BlogPost>>
        {
            private readonly PortfolioDbContext db;

            public BlogPostGetAllQueryHandler(PortfolioDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPostGetAllQuery request, CancellationToken cancellationToken)
            {
                //var posts = await db.BlogPosts
                //.Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                //.ToListAsync(cancellationToken);

                int skipSize = (request.PageIndex - 1) * request.PageSize;

                var query = db.BlogPosts
                .Where(bp => bp.DeletedDate == null && bp.PublishedDate != null)
                .OrderByDescending(bp => bp.PublishedDate)
                .AsQueryable();

                var pagedModel = new PagedViewModel<BlogPost>(query, request);

                return pagedModel;
            }
        }
    }
}
