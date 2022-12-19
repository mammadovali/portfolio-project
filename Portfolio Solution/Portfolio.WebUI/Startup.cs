using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.AppCode.Services;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Linq;
using MediatR;
using Portfolio.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication;
using Portfolio.WebUI.Models.AppCode.Providers;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Portfolio.WebUI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(
                cfg =>
                {

                    var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                    cfg.Filters.Add(new AuthorizeFilter(policy));
                });


            services.AddDbContext<PortfolioDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("cString"));
            }).AddIdentity<PortfolioUser, PortfolioRole>()
              .AddEntityFrameworkStores<PortfolioDbContext>()
              .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(cfg =>
            {
                cfg.User.RequireUniqueEmail = true; //herkesin bir emaili olsun
                cfg.Password.RequireDigit = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredUniqueChars = 1; //123
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 1, 0);
                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Password.RequiredLength = 3;

            });

            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/notfound.html";

                cfg.Cookie.Name = "portfolio";
                cfg.Cookie.HttpOnly = true;
                cfg.ExpireTimeSpan = new TimeSpan(0, 15, 0);
            });

            services.AddAuthentication();
            services.AddAuthorization();

            services.AddScoped<UserManager<PortfolioUser>>();
            services.AddScoped<SignInManager<PortfolioUser>>();



            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });


            services.Configure<EmailServiceOptions>(cfg =>
            {
                configuration.GetSection("emailAccount").Bind(cfg);
            });
            services.AddSingleton<EmailService>();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddScoped<IClaimsTransformation, AppClaimProvider>();


            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("Portfolio."));

            services.AddMediatR(assemblies.ToArray());
        }



        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<PortfolioRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.SeedMembership();
            PortfolioDbSeed.SeedUserRole(roleManager);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(cfg =>
            {
                cfg.MapAreaControllerRoute("defaultAdmin", "admin", "admin/{controller=dashboard}/{action=index}/{id?}");


                cfg.MapControllerRoute(
                name: "default-accessdenied",
                pattern: "accessdenied.html",
                defaults: new
                {
                    area = "",
                    controller = "account",
                    action = "accessdenied"
                });


                cfg.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

        }
    }
}
