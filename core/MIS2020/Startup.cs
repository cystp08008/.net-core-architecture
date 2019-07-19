using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBClassLibrary.Models;
using DBClassLibrary.Models.Interface;
using DBClassLibrary.Models.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MIS2020.Services.PasswordEncrypt;

namespace MIS2020
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromHours(5);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton <IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });

            var connection = @"Data Source=test2012;Initial Catalog=Bom2013;Integrated Security=True;";


            //含複雜型態Repository
            services.AddTransient<IEngRepository, EngRepository>();
            services.AddTransient<IRightRepository, RightRepository>();
            services.AddTransient<IFavoriteFormRepository, FavoriteFormRepository>();

            //ControllerDI
            services.AddTransient<IPasswordEncrypt, PasswordEncrypt>();

            //Repository
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //DbContext
            services.AddDbContext<Bom2013Context>(options => options.UseSqlServer(connection));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<Bom2013Context>(options =>options.UseSqlServer(Configuration.GetConnectionString("Database")));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
