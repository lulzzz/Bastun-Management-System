using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using BMS.Services.Contracts;
using BMS.Services;
using BMS.Services.Utility.UtilityContracts;
using BMS.Services.Utility;
using BMS.Services.ParserUtility.UtilityContracts;
using BMS.Services.ParserUtility;
using BMS.Services.ParserUtility.ParserMovementUtility;
using Microsoft.AspNetCore.Http;
using Wkhtmltopdf.NetCore;

namespace WebApplication1
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
            services.AddTransient<IFlightService, FlightsService>();
            services.AddTransient<IAircraftService, AircraftService>();
            services.AddTransient<IMovementService, MovementsService>();
            services.AddTransient<IPAXService, PAXService>();
            services.AddTransient<ILoadControlService, LoadControlService>();
            services.AddTransient<ILoadsheetService, LoadsheetService>();
            services.AddTransient<IMessageParser, MessageParser>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IFlightDataValidation, FlightDataValidation>();
            services.AddTransient<IAircraftCabinService, AircraftCabinService>();
            services.AddTransient<IAircraftBaggageHoldService, AircraftBaggageHoldService>();
            services.AddTransient<IContainerService, ContainerService>();
            services.AddTransient<IParserMovementUtility, ParserArrMVTUtility>();
            services.AddTransient<IParserMovementUtility, ParserDepMVTUtility>();
            services.AddTransient<IParserCPMUtility, ParserCPMUtility>();
            services.AddTransient<IFuelAndWeightService, FuelAndWeightService>();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies());
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 10;
            });
            services.AddAuthentication()
                .AddCookie(options =>
                {
                    options.LoginPath = "/Identity/Account/Login";
                    options.LogoutPath = "/Identity/Account/Logout";
                });
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddRazorPages();
            services.AddAutoMapper(typeof(Startup));
            services.AddWkhtmltopdf(@"C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\wkhtmltopdf\");
       }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
              
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                   
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");    
            });
        }
    }
}
