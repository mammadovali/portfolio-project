using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entities;
using Portfolio.Domain.Models.Entities.Membership;

namespace Portfolio.Domain.Models.DataContext
{
    public class PortfolioDbContext : IdentityDbContext<PortfolioUser,
        PortfolioRole,
        int,
        PortfolioUserClaim,
        PortfolioUserRole,
        PortfolioUserLogin,
        PortfolioRoleClaim,
        PortfolioUserToken>
    {
        public PortfolioDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PortfolioUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });

            builder.Entity<PortfolioRole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });

            builder.Entity<PortfolioUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");
            });

            builder.Entity<PortfolioUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });

            builder.Entity<PortfolioRoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");
            });

            builder.Entity<PortfolioUserLogin>(e =>
            {
                e.ToTable("UserLogin", "Membership");
            });

            builder.Entity<PortfolioUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });

        }

        public DbSet<ContactPost> ContactPosts { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<BlogPostComment> BlogPostComments { get; set; }

        public DbSet<ContactDetail> ContactDetails { get; set; }

        public DbSet<ResumeBio> ResumeBios { get; set; }

        public DbSet<HardSkillCategory> HardSkillCategories { get; set; }

        public DbSet<HardSkill> HardSkills { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<SoftSkill> SoftSkills { get; set; }

        public DbSet<AcademicBackground> AcademicBackgrounds { get; set; }


    }
}
