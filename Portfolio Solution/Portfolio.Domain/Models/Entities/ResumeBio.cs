using Portfolio.Domain.AppCode.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Models.Entities
{
    public class ResumeBio : BaseEntity
    {
        [Required]
        public string Text { get; set; }
    }
}
