using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using TasteRestaurant.Utility;
using System;

namespace TasteRestaurant
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));


            //SetUp Identity and Identity roles
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            //OAuth Authentication for FaceBook  01.Go to https://developers.facebook.com ,  02.Create an app,  03.SetUp credential 
            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                //We setup the AppId and App Secret
                facebookOptions.AppId = "1859920520772872";
                facebookOptions.AppSecret = "5bf5cdc148d68127a6ae178bcfd4870b";
            });


            //OAuth Google Authentication, 01.Go to https://console.developers.google.com ,  02.Create an app,  03.Enable google + API service
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                //With google we have ClientID and ClientSecret
                googleOptions.ClientId = "164244893980-bpq20parqdcaau72q3areuvoditgiqh4.apps.googleusercontent.com";
                googleOptions.ClientSecret = "SddQIWU_Ca5BKWIdvdKCdXyr";
            });
            

            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddRazorPagesOptions(options => {

                    //Authorize folders and pages here
                    options.Conventions.AuthorizeFolder("/Account/Manage");
                    options.Conventions.AuthorizePage("/Account/Logout");
                });

            //Policy for admin users to access pages
            services.AddAuthorization(options =>
            {
                options.AddPolicy(SD.Admin, policy => policy.RequireRole(SD.Admin));
            });


            //Sessions
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }


            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-SA");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-SA");
            
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();  //Sessions
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
