Imports System
Imports System.Collections.Generic
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace WebViewer_DefaultParameterValues
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_DashboardLoaded(ByVal sender As Object, _
                                                           ByVal e As DashboardLoadedWebEventArgs)
            ' Specifies default parameter values.
            e.Dashboard.Parameters("customerIdParameter").Value = New List(Of String)() From {"ALFKI", "AROUT", "BONAP"}
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                                                   ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" Then
                e.ConnectionParameters = New Access97ConnectionParameters(Server.MapPath("App_Data/nwind.mdb"), "", "")
            End If
        End Sub
    End Class
End Namespace