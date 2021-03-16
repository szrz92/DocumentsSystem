using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentManagement.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DocumentManagement
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
            {
                o.LoginPath = new PathString("/Account/Login");
                o.AccessDeniedPath = new PathString("/Account/AccessDenied");
                o.LogoutPath = new PathString("/Account/Logout");
                o.ExpireTimeSpan = TimeSpan.FromSeconds(1200);
                o.SlidingExpiration = true;
                o.Cookie.Name = "DMSCookie";
            });
            services.AddDbContext<DocumentManagementContext>
                (options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DmsCs"));
                });
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            //using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetRequiredService<DocumentManagementContext>();
            //    context.Database.EnsureDeleted();
            //    context.Database.Migrate();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
