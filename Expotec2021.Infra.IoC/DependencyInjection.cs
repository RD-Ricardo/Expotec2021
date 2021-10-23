using System;
using Expotec2021.Application.Interfaces;
using Expotec2021.Application.Mappings;
using Expotec2021.Application.Services;
using Expotec2021.Domain.Auth;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Infra.Data.context;
using Expotec2021.Infra.Data.Repositories;
using Expotec2021.Infra.Data.Services;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Expotec2021.Infra.IoC
{
    public static class DependencyInjection
    {
       public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectioMysql = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Context>(options => 
            options.UseMySql(connectioMysql, ServerVersion.AutoDetect(connectioMysql), 
            b => b.MigrationsAssembly(typeof(Context).Assembly.FullName)));
        
            services.AddIdentity<ApplicationUser,IdentityRole>(option => 
            {
                option.Password.RequiredLength = 5;
                option.Password.RequireLowercase = false;
                option.Password.RequireUppercase = false;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireDigit = false;
            })
            .AddEntityFrameworkStores<Context>()
            .AddDefaultTokenProviders();



            services.AddScoped<IGetUserAuthenticate,GetUserAutheticate>();
            services.AddScoped<IAuthenticate,AuthenticateService>();
            services.AddScoped<ISeedUserInitial, SeedUserInitial>();  

            //Repository
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IJobsRepository, JobsRepository>();
            services.AddScoped<ILaunchsRepository, LaunchsRepository>();
            services.AddScoped<IPostsRepository, PostsRepository>();
            services.AddScoped<IListTaskRepository, ListTaskRepository>(); 

            // //Mediator
            // var myHandles = AppDomain.CurrentDomain.Load("Expotec2021.Application");
            // services.AddMediatR(myHandles);

            //AutoMapper
            services.AddAutoMapper(typeof(DomainForMappingProfile));


            services.AddScoped<IBlogServices, BlogServices>();
            services.AddScoped<ICategoriesServices, CategoriesServices>();
            services.AddScoped<IJobsServices, JobsServices>();
            services.AddScoped<ITarefasServices, TarefasServices>();
            services.AddScoped<ILaunchsServices, LaunchsServices>();


            // services.ConfigureApplicationCookie(option => option.AccessDeniedPath ="/Conta/Login").AddHttpContextAccessor();
            return services;

            //0800 940 5776
        }
    }
}