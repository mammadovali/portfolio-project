﻿using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.AppCode.Extensions;
using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.BlogPostModule
{
    public class BlogPostCommentCommand : IRequest<BlogPostComment>
    {
        public int? CommentId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Post Id uygun deyil")]
        public int PostId { get; set; }

        [Required]
        public string Comment { get; set; }

        public class BlogPostCommentCommandHandler : IRequestHandler<BlogPostCommentCommand, BlogPostComment>
        {

            private readonly PortfolioDbContext db;
            private readonly IActionContextAccessor ctx;

            public BlogPostCommentCommandHandler(PortfolioDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }

            public async Task<BlogPostComment> Handle(BlogPostCommentCommand request, CancellationToken cancellationToken)
            {
                if (!ctx.ActionContext.ModelState.IsValid)
                {

                    throw new Exception(ctx.ActionContext.ModelState.GetError().FirstOrDefault().Message);
                }

                var post = await db.BlogPosts.FirstOrDefaultAsync(bp => bp.Id == request.PostId);

                if (post == null)
                {
                    throw new Exception("Post mövcud deyil");
                }

                var commentModel = new BlogPostComment
                {
                    BlogPostId = request.PostId,
                    Text = request.Comment,
                    CreatedByUserId = ctx.GetCurrentUserId()
                };

               

                if (request.CommentId.HasValue && await db.BlogPostComments.AnyAsync(c => c.Id == request.CommentId))
                {
                    commentModel.ParentId = request.CommentId;
                }

                db.BlogPostComments.Add(commentModel);
                await db.SaveChangesAsync();

                commentModel = await db.BlogPostComments
                    .Include(c=>c.CreatedByUser)
                    .Include(c=>c.Parent)
                    .FirstOrDefaultAsync(c => c.Id == commentModel.Id);

                return commentModel;
            }
        }
    }
}
