Namespace WebViewer_DefaultParameterValues
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim card1 As New DevExpress.DashboardCommon.Card()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As New DevExpress.DataAccess.Sql.Table()
            Dim column2 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column6 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardParameter1 As New DevExpress.DashboardCommon.DashboardParameter()
            Dim dynamicListLookUpSettings1 As New DevExpress.DashboardCommon.DynamicListLookUpSettings()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' cardDashboardItem1
            ' 
            measure1.DataMember = "ExtendedPrice"
            card1.AddDataItem("ActualValue", measure1)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension1.DataMember = "Customers.CompanyName"
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.cardDashboardItem1.DataMember = "Invoices"
            Me.cardDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.cardDashboardItem1.ShowCaption = False
            ' 
            ' dashboardSqlDataSource1
            ' 
            Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
            Me.dashboardSqlDataSource1.ConnectionName = "nwindConnection"
            Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
            columnExpression1.ColumnName = "CustomerID"
            table1.MetaSerializable = "30|30|200|550"
            table1.Name = "Invoices"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "Customers.CompanyName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "OrderDate"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "ProductName"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "ExtendedPrice"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.FilterString = "[Invoices.CustomerID] In (?customerIdParameter)"
            selectQuery1.GroupFilterString = ""
            selectQuery1.MetaSerializable = "20|20|100|103"
            selectQuery1.Name = "Invoices"
            queryParameter1.Name = "customerIdParameter"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.customerIdParameter]", GetType(String))
            selectQuery1.Parameters.Add(queryParameter1)
            selectQuery1.Tables.Add(table1)
            columnExpression6.ColumnName = "CustomerID"
            table2.MetaSerializable = "30|30|125|550"
            table2.Name = "Invoices"
            columnExpression6.Table = table2
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Customers.CompanyName"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            selectQuery2.Columns.Add(column6)
            selectQuery2.Columns.Add(column7)
            selectQuery2.Name = "Invoices_DashboardParameterSource"
            selectQuery2.Tables.Add(table2)
            Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
            ' 
            ' chartDashboardItem1
            ' 
            dimension2.DataMember = "OrderDate"
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure2.DataMember = "ExtendedPrice"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.chartDashboardItem1.DataMember = "Invoices"
            Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Chart 1"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.SplineArea
            simpleSeries1.AddDataItem("Value", measure2)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.ShowCaption = False
            ' 
            ' pivotDashboardItem1
            ' 
            dimension3.DataMember = "OrderDate"
            Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            measure3.DataMember = "ExtendedPrice"
            dimension4.DataMember = "ProductName"
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem1")
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.pivotDashboardItem1.DataMember = "Invoices"
            Me.pivotDashboardItem1.DataSource = Me.dashboardSqlDataSource1
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4})
            Me.pivotDashboardItem1.ShowCaption = False
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3})
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.cardDashboardItem1, Me.chartDashboardItem1, Me.pivotDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem1.Weight = 24.041811846689896R
            dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem2.Weight = 75.9581881533101R
            dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup2.DashboardItem = Nothing
            dashboardLayoutGroup2.Weight = 56.71641791044776R
            dashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem3.Weight = 43.28358208955224R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            dashboardParameter1.AllowMultiselect = True
            dashboardParameter1.Description = "Select companies:"
            dynamicListLookUpSettings1.DataMember = "Invoices_DashboardParameterSource"
            dynamicListLookUpSettings1.DataSourceName = "dashboardSqlDataSource1"
            dynamicListLookUpSettings1.DisplayMember = "Customers.CompanyName"
            dynamicListLookUpSettings1.ValueMember = "CustomerID"
            dashboardParameter1.LookUpSettings = dynamicListLookUpSettings1
            dashboardParameter1.Name = "customerIdParameter"
            dashboardParameter1.Type = GetType(String)
            dashboardParameter1.Value = (DirectCast(resources.GetObject("dashboardParameter1.Value"), Object))
            Me.Parameters.AddRange(New DevExpress.DashboardCommon.DashboardParameter() { dashboardParameter1})
            Me.Title.Text = "Dashboard"
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
    End Class
End Namespace
