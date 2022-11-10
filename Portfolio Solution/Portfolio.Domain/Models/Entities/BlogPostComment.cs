using Portfolio.Domain.AppCode.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Models.Entities
{
    public class BlogPostComment : BaseEntity
    {

        [Required]
        public string Text { get; set; }

        public int BlogPostId { get; set; }

        public int? ParentId { get; set; } 

        public virtual BlogPost BlogPost { get; set; }

        public virtual BlogPostComment Parent { get; set; }

        public virtual ICollection<BlogPostComment> Children { get; set; }
    }
}