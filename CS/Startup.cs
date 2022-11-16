using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AspNetCoreDashboard {
    public class Startup {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            Configuration = configuration;
            FileProvider = hostingEnvironment.ContentRootFileProvider;
        }

        public IConfiguration Configuration { get; }
        public IFileProvider FileProvider { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            // Configures services to use the Web Dashboard Control.
            services
                .AddDevExpressControls()
                .AddControllersWithViews()
                .ConfigureApplicationPartManager((manager) => {
                    var dashboardApplicationParts = manager.ApplicationParts.Where(part =>
                        part is AssemblyPart && ((AssemblyPart)part).Assembly == typeof(DashboardController).Assembly).ToList();
                    foreach (var partToRemove in dashboardApplicationParts) {
                        manager.ApplicationParts.Remove(partToRemove);
                    }
                });

            services.AddSingleton<SalesDashboardConfigurator>();
            services.AddSingleton<MarketingDashboardConfigurator>();

            DevExpress.DashboardCommon.DashboardOlapDataSource.OlapDataProvider = DevExpress.DashboardCommon.OlapDataProviderType.Xmla;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            // Registers the DevExpress middleware.
            app.UseDevExpressControls();
            app.UseRouting();

            app.UseEndpoints(endpoints => {
                // Maps the dashboard route.
                endpoints.MapDashboardRoute("api/dashboards_sales", "SalesDashboard");
                endpoints.MapDashboardRoute("api/dashboards_marketing", "MarketingDashboard");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}