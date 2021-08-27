<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580386/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T475791)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/WebViewer_DefaultParameterValues/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/WebViewer_DefaultParameterValues/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/WebViewer_DefaultParameterValues/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/WebViewer_DefaultParameterValues/WebForm1.aspx.vb))
<!-- default file list end -->
# How to specify default parameter values in the Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t475791/)**
<!-- run online end -->


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx"><strong>ASPxDashboard</strong> control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.<br>To specify initial <strong>ASPxDashboard</strong> parameter values, use the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboard_SetInitialDashboardStatetopic">ASPxDashboard.SetInitialDashboardState</a> event as shown in the <a href="https://www.devexpress.com/Support/Center/p/T513681">ASPxDashboard - How to specify a default dashboard state in code</a> example.</em><br><br><em>Below is the original description related to the ASPxDashboardViewer component.</em><br><br>The following example shows how to specify default parameter values on dashboard loading. To do this, handle the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_DashboardLoadedtopic">ASPxDashboardViewer.DashboardLoaded</a> event, get access to the dashboard object using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebDashboardLoadedWebEventArgs_Dashboardtopic">DashboardLoadedWebEventArgs.Dashboard</a> event parameter and specify the default value(s) using the <strong>Dashboard</strong>.<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_Parameterstopic">Parameters</a>["parameterName"].<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDataAccessParameter_Valuetopic">Value</a> property.<br><br><strong>See also:</strong> <a href="https://www.devexpress.com/Support/Center/p/T338480">How to pass a hidden dashboard parameter to a custom SQL query in the Web Viewer</a>

<br/>


