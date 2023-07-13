using DevExpress.DashboardAspNetCore;

namespace AspNetCoreDashboard {
    public class SalesDashboardController : DashboardController {
        public SalesDashboardController(SalesDashboardConfigurator configrurator) : base(configrurator) {

        }
    }

    public class MarketingDashboardController : DashboardController {
        public MarketingDashboardController(MarketingDashboardConfigurator configrurator) : base(configrurator) {

        }
    }
}
