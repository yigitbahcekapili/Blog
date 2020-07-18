using AutoMapper;
using Blog.Infrastructure.Data;
using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement;
using Blog.Module.ArticleManagement.AutoMapper;
using FluentValidation.AspNetCore;
using FluentValidation.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddFluentValidation(opt => opt.ValidatorFactoryType = typeof(AttributedValidatorFactory))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            #region Database Connection

            services.AddDbContext<BlogDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("BlogDbConnectionString"));
                });

            #endregion

            #region IoC Install

            services.InstallDataIoC();
            services.InstallArticleManagementIoC();

            #endregion

            #region Auto Mapper

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ArticleManagementMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);

            #endregion
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowCredentials()
                      .AllowAnyHeader();
            });

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "api/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
