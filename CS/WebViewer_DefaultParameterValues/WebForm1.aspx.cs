using System;
using System.Collections.Generic;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

namespace WebViewer_DefaultParameterValues {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_DashboardLoaded(object sender, DashboardLoadedWebEventArgs e) {
            // Specifies default parameter values.
            e.Dashboard.Parameters["customerIdParameter"].Value = new List<string>() { "ALFKI", "AROUT", "BONAP" };
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1")
                e.ConnectionParameters = new Access97ConnectionParameters(Server.MapPath("App_Data/nwind.mdb"), "", "");
        }
    }
}