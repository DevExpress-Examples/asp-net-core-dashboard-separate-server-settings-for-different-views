using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreDashboard {
    public class SalesDashboardConfigurator : DashboardConfigurator {
        public SalesDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Sales").PhysicalPath));
            DataSourceCacheKeyCreated += SalesDashboardConfigurator_DataSourceCacheKeyCreated;
        }

        private void SalesDashboardConfigurator_DataSourceCacheKeyCreated(object sender, DataSourceCacheKeyCreatedEventArgs e) {
            e.Key.CustomData.Add("ViewId" , "Sales");
        }
    }

    public class MarketingDashboardConfigurator : DashboardConfigurator {
        public MarketingDashboardConfigurator(IConfiguration configuration, IWebHostEnvironment hostingEnvironment) {
            SetConnectionStringsProvider(new DashboardConnectionStringsProvider(configuration));
            SetDashboardStorage(new DashboardFileStorage(hostingEnvironment.ContentRootFileProvider.GetFileInfo("App_Data/Marketing").PhysicalPath));
            DataSourceCacheKeyCreated += MarketingDashboardConfigurator_DataSourceCacheKeyCreated;
        }

        private void MarketingDashboardConfigurator_DataSourceCacheKeyCreated(object sender, DataSourceCacheKeyCreatedEventArgs e) {
            e.Key.CustomData.Add("ViewId" , "Marketing");
        }
    }
}
