using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Models.Entities.Membership
{
    public class PortfolioUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
    }
}
