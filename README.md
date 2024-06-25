<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/380194211/23.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1009554)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# BI Dashboard for ASP.NET Core - How to use separate server-side settings for different views

This example illustrates how to use separate [DashboardConfigurator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator) instances within an [ASP.NET Core Dashboard](https://docs.devexpress.com/Dashboard/115163/web-dashboard/aspnet-core-dashboard-control) application to provide different server-side settings. In this example, the _Sales_ and _Marketing_ views use different dashboard storages.

Dashboard controllers are defined in the [DashboardControllers.cs](./CS/Controllers/DashboardControllers.cs) file.

The dependency injection technique is used to register [Dashboard Configurators](./CS/DashboardConfigurators.cs) in the [Startup.cs](./CS/Startup.cs) file.

Note that the Web Dashboard control uses a single cache. The use of separate **DashboardConfigurator** instances does not create separated caches. To specify a different cache for different controllers/configurators, you need to create a [custom parameter](https://docs.devexpress.com/Dashboard/118651/web-dashboard/general-information/security-considerations#cache-security).

## Files to Review:

* [Startup.cs](./CS/Startup.cs)
* [DashboardConfigurators.cs](./CS/DashboardConfigurators.cs)
* [DashboardControllers.cs](./CS/Controllers/DashboardControllers.cs)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [MarketingView.cshtml](./CS/Views/Home/MarketingView.cshtml)
* [SalesView.cshtml](./CS/Views/Home/SalesView.cshtml)

## Documentation

- [Manage Multi-Tenancy](https://docs.devexpress.com/Dashboard/402924/web-dashboard/dashboard-backend/manage-multi-tenancy)

## More Examples

- [Dashboard for MVC - How to use separate server-side settings for different views](https://github.com/DevExpress-Examples/aspnet-mvc-dashboard-how-to-use-separate-server-side-settings-for-different-views-t464543)
- [Dashboard for MVC - How to implement multi-tenant Dashboard architecture](https://github.com/DevExpress-Examples/DashboardUserBasedMVC)
- [Dashboard for MVC - How to load different data based on the current user](https://github.com/DevExpress-Examples/DashboardDifferentUserDataMVC)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-separate-server-settings-for-different-views&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-core-dashboard-separate-server-settings-for-different-views&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
