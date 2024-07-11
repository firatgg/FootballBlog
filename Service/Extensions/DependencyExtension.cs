using DataAccess.Contexts;
using DataAccess.Identity;
using DataAccess.Repositories;
using DataAccess.UnitOfWorks;
using Entity.Repositories;
using Entity.Services;
using Entity.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Service.Mapping;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Extensions
{
    public static class DependencyExtension
    {
        public static void AddExtension(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
                    opt =>
                    {
                        opt.Password.RequireNonAlphanumeric = false;
                        opt.Password.RequiredLength = 3;
                        opt.Password.RequireLowercase = false;
                        opt.Password.RequireUppercase = false;
                        opt.Password.RequireDigit = false;

                        opt.User.RequireUniqueEmail = true;
                        opt.Lockout.MaxFailedAccessAttempts = 3; //default=5
                        opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); //default=5
                    }
                
                ).AddEntityFrameworkStores<FootballBlogDbContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Account/Login");
                opt.LogoutPath = new PathString("/Account/Logout");
                //opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                opt.SlidingExpiration = true; //10 dk. dolmadan kullanıcı yeniden login olursa süre baştan başlar.

                opt.Cookie = new CookieBuilder()
                {
                    Name = "Identity.App.Cookie",
                    HttpOnly = true
                };
            }
            );
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped(typeof(IAccountService), typeof(AccountService));

            services.AddAutoMapper(typeof(MappingProfile));


        }
    }
}
