Imports ClosedXML.Excel
Public Class Reports
    Private DB As New DBAccess

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPropertiesInfoChart()
        LoadCustomerInfoChart()
        LoadLeaseInfoChart()
        LoadEmployeeInfoChart()



    End Sub

    Private Sub LoadCustomerInfoChart()
        DB.ExecuteQuery("SELECT year(create_date) AS Year, count(*) as 'Customer Count' FROM sp2021bis698fc1g2.customer GROUP BY year(create_date);")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        CustomerChart.DataSource = DB.DBDataTable

        CustomerChart.Series("Customers").XValueMember = "Year"
        CustomerChart.Series("Customers").YValueMembers = "Customer Count"
        CustomerChart.Series("Customers").ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub

    Private Sub LoadEmployeeInfoChart()
        DB.ExecuteQuery("SELECT year(start_date) AS Year, count(*) as 'Employee Count' FROM sp2021bis698fc1g2.employee GROUP BY year(start_date);")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        ActiveEmployees.DataSource = DB.DBDataTable

        ActiveEmployees.Series("Employees").XValueMember = "Year"
        ActiveEmployees.Series("Employees").YValueMembers = "Employee Count"
        ActiveEmployees.Series("Employees").ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub
    Private Sub LoadLeaseInfoChart()
        DB.ExecuteQuery("SELECT year(lease_start_date) AS Year, customer_id AS Count FROM lease WHERE is_active = 1")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        LeaseInfoChart.DataSource = DB.DBDataTable

        LeaseInfoChart.Series("Current Lease").XValueMember = "Year"
        LeaseInfoChart.Series("Current Lease").YValueMembers = "Count"
        LeaseInfoChart.Series("Current Lease").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        LeaseInfoChart.Legends.Clear()
    End Sub


    Private Sub LoadPropertiesInfoChart()
        DB.ExecuteQuery("SELECT DISTINCT property_type AS Property_Type, monthly_rate AS Rate FROM property WHERE is_active = 1")
        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        PropertiesInfoChart.DataSource = DB.DBDataTable

        PropertiesInfoChart.Series("Active Properties").XValueMember = "Property_Type"
        PropertiesInfoChart.Series("Active Properties").YValueMembers = "Rate"
        PropertiesInfoChart.Series("Active Properties").ChartType = DataVisualization.Charting.SeriesChartType.Bar
        PropertiesInfoChart.Legends.Clear()
    End Sub

    Public Sub ExportGridDataToExcel(ByVal DataGridViewRef As DataGridView, WorkSheetName As String)
        Dim SaveFileDialogRef As New SaveFileDialog

        SaveFileDialogRef.Filter = "XLSX Files (*.xlsx*)|*.xlsx"
        If SaveFileDialogRef.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Creating DataTable
            Dim DataTableRef As New DataTable()

            'Adding the Columns
            For Each column As DataGridViewColumn In DataGridViewRef.Columns
                DataTableRef.Columns.Add(column.HeaderText, column.ValueType)
            Next

            'Adding the Rows
            For Each row As DataGridViewRow In DataGridViewRef.Rows
                DataTableRef.Rows.Add()
                For Each cell As DataGridViewCell In row.Cells
                    If Not IsDBNull(cell.Value) Then
                        DataTableRef.Rows(DataTableRef.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
                    End If
                Next
            Next

            ' Using workbook ref to  create a new workbook and add the datasource
            Using wb As New XLWorkbook()
                wb.Worksheets.Add(DataTableRef, WorkSheetName)
                wb.SaveAs(SaveFileDialogRef.FileName)
                MessageBox.Show(WorkSheetName & " has been exported to excel successfully.")
            End Using

        End If
    End Sub

    Public Sub ExportDataTableToExcel(DataTableRef As DataTable, WorkSheetName As String)
        Dim FileDlg As New SaveFileDialog
        FileDlg.Filter = "XLSX Files (*.xlsx*)|*.xlsx"
        If FileDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using wb As New XLWorkbook()
                wb.Worksheets.Add(DataTableRef, WorkSheetName)
                wb.SaveAs(FileDlg.FileName)
                MessageBox.Show(WorkSheetName & " has been exported to excel successfully.")
            End Using
        End If
    End Sub
    Private Sub ExcelButton1_Click(sender As Object, e As EventArgs)
        ExportDataTableToExcel(PropertiesInfoChart.DataSource, "Number of available properties")
    End Sub
    Private Sub ExcelButton2_Click(sender As Object, e As EventArgs)
        ExportDataTableToExcel(CustomerChart.DataSource, "Number of customers")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ExportDataTableToExcel(LeaseInfoChart.DataSource, "Number of active leases")
    End Sub
    Private Sub ExcelButton4_Click(sender As Object, e As EventArgs)
        ExportDataTableToExcel(ActiveEmployees.DataSource, "Number of active employees")
    End Sub
End Class
