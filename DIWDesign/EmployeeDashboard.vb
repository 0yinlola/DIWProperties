Public Class EmployeeDashboard
    Private DB As New DBAccess
    Private Sub EmployeePanel_Paint(sender As Object, e As PaintEventArgs) Handles EmployeePanel.Paint
        RetrieveCustomers()
        RetrieveEmployees()
        RetrieveCustomerBill()
        RetrieveBill()
    End Sub
    Private Sub RetrieveCustomers()
        DB.ExecuteQuery("SELECT * FROM customer")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        CustomersDataGridView.DataSource = DB.DBDataTable

        CustomersDataGridView.ReadOnly = True
        CustomersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub ClearCustomer()
        CustomerIDTextBox.Clear()
        CustomerFirstNameTextBox.Clear()
        CustomerLastNameTextBox.Clear()
        CustomerActiveCheckBox.Checked = False
        CustomerEmailTextBox.Clear()
        CustomerCreateDateTimePicker.Value = Today.Date
        CustomerLastUpdateDateTimePicker.Value = Today.Date
    End Sub
    Private Sub SearchCustomer(FirstName As String, LastName As String)
        DB.AddParam("@firstname", FirstName & "%")
        DB.AddParam("@lastname", LastName & "%")

        DB.ExecuteQuery("SELECT * FROM customer WHERE first_name LIKE ? AND last_name LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        CustomersDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub CustomerNamesTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp, LastNameTextBox.KeyUp
        SearchCustomer(FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub
    Private Sub CustomersDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = CustomersDataGridView.Rows.Count - 1 Then
            ClearCustomer()
            Exit Sub
        Else
            CustomerIDTextBox.Text = CustomersDataGridView.Rows(e.RowIndex).Cells(0).Value
            CustomerFirstNameTextBox.Text = CustomersDataGridView.Rows(e.RowIndex).Cells(3).Value
            CustomerLastNameTextBox.Text = CustomersDataGridView.Rows(e.RowIndex).Cells(4).Value
            CustomerEmailTextBox.Text = CustomersDataGridView.Rows(e.RowIndex).Cells(6).Value
            CustomerActiveCheckBox.Checked = CustomersDataGridView.Rows(e.RowIndex).Cells(27).Value
            CustomerCreateDateTimePicker.Value = CustomersDataGridView.Rows(e.RowIndex).Cells(28).Value
            CustomerLastUpdateDateTimePicker.Value = CustomersDataGridView.Rows(e.RowIndex).Cells(29).Value
        End If
    End Sub
    Private Sub CustomerNewButton_Click(sender As Object, e As EventArgs) Handles CustomerNewButton.Click
        ApplicationForm.ShowDialog()
    End Sub
    Private Sub RetrieveEmployees()
        DB.ExecuteQuery("SELECT * FROM employee")

        If DB.Exception <> String.Empty Then
            MsgBox(DB.Exception)
            Exit Sub
        End If

        EmployeeDataGridView.DataSource = DB.DBDataTable

        EmployeeDataGridView.ReadOnly = True
        EmployeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub ClearEmployee()
        EmployeeIDTextBox.Clear()
        EmployeeFNTextBox.Clear()
        EmployeeLNTextBox.Clear()
        EmployeeActiveCheckBox.Checked = False
        EmployeeEmailTextBox.Clear()
        ECreateDateTimePicker.Value = Today.Date
        ELastUpdateDateTimePicker.Value = Today.Date
    End Sub
    Private Sub SearchEmployee(FirstName As String, LastName As String)
        DB.AddParam("@firstname", FirstName & "%")
        DB.AddParam("@lastname", LastName & "%")

        DB.ExecuteQuery("SELECT * FROM employee WHERE first_name LIKE ? AND last_name LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        EmployeeDataGridView.DataSource = DB.DBDataTable
    End Sub
    Private Sub EmployeeDashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SystemDateToolStripStatusLabel.Text = Today.Date.ToLongDateString

        LoadPropertiesInfoChart()
        LoadCustomerInfoChart()
        LoadLeaseInfoChart()
        'LoadFilmCategorySalesInfoChart()
    End Sub
    Private Sub LoadCustomerInfoChart()
        DB.ExecuteQuery("SELECT year(create_date) AS Year, count(*) as 'Customer Count' FROM sp2021bis698fc1g2.customer GROUP BY year(create_date);")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        CustomerInfoChart.DataSource = DB.DBDataTable

        CustomerInfoChart.Series("Customers").XValueMember = "Year"
        CustomerInfoChart.Series("Customers").YValueMembers = "Customer Count"
        CustomerInfoChart.Series("Customers").ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub
    Private Sub LoadLeaseInfoChart()
        DB.ExecuteQuery("SELECT year(lease_end_date) AS End_Year, year(lease_start_date) AS Start_Year FROM lease")

        If DB.Exception <> String.Empty Then
            Exit Sub
        End If


        LeaseInfoChart.DataSource = DB.DBDataTable

        LeaseInfoChart.Series("Current Lease").XValueMember = "End_Year"
        LeaseInfoChart.Series("Current Lease").YValueMembers = "Start_Year"
        LeaseInfoChart.Series("Current Lease").ChartType = DataVisualization.Charting.SeriesChartType.Bar
    End Sub
    Private Sub LoadPropertiesInfoChart()
        DB.ExecuteQuery("SELECT p.property_type AS Property_Type, l.is_active AS Available_Properties FROM property as p JOIN lease as l on p.property_id = l.lease_id")
        If DB.Exception <> String.Empty Then
            Exit Sub
        End If

        PropertiesChart.DataSource = DB.DBDataTable

        PropertiesChart.Series("Active Properties").XValueMember = "Property_Type"
        PropertiesChart.Series("Active Properties").YValueMembers = "Available_Properties"
        PropertiesChart.Series("Active Properties").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        PropertiesChart.Legends.Clear()
    End Sub

    Private Sub EmployeeNamesTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles EmployeeFNTextBox.KeyUp, EmployeeLNTextBox.KeyUp
        SearchEmployee(EmployeeFNTextBox.Text, EmployeeLNTextBox.Text)
    End Sub
    Private Sub EmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = EmployeeDataGridView.Rows.Count - 1 Then
            ClearCustomer()
            Exit Sub
        Else
            EmployeeIDTextBox.Text = EmployeeDataGridView.Rows(e.RowIndex).Cells(0).Value
            EmployeeFNTextBox.Text = EmployeeDataGridView.Rows(e.RowIndex).Cells(3).Value
            EmployeeLNTextBox.Text = EmployeeDataGridView.Rows(e.RowIndex).Cells(4).Value
            EmployeeEmailTextBox.Text = EmployeeDataGridView.Rows(e.RowIndex).Cells(6).Value
            EmployeeActiveCheckBox.Checked = EmployeeDataGridView.Rows(e.RowIndex).Cells(20).Value
            ECreateDateTimePicker.Value = EmployeeDataGridView.Rows(e.RowIndex).Cells(21).Value
            ELastUpdateDateTimePicker.Value = EmployeeDataGridView.Rows(e.RowIndex).Cells(22).Value
        End If
    End Sub

    Private Sub NewEmployeeButton_Click(sender As Object, e As EventArgs) Handles NewEmployeeButton.Click
        NewEmployeeForm.ShowDialog()
    End Sub
    Private Sub ReadDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchCustomerBill(FirstNameTextBox.Text, LastNameTextBox.Text)
        'SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
    End Sub

    'Customer DGV Search parameters
    Public Sub SearchCustomerBill(FirstName As String, LastName As String)
        DB.AddParam("@first_name", FirstName & "%")
        DB.AddParam("@last_name", LastName & "%")
        DB.ExecuteQuery("SELECT * FROM customer WHERE first_name LIKE ? AND last_name LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridViewCustomer.DataSource = DB.DBDataTable
    End Sub

    Private Sub RetrieveCustomerBill()
        DB.ExecuteQuery("SELECT
                        customer.customer_id,
                        customer.first_name,
                        customer.last_name,
                        lease.lease_id,
                        lease.property_id,
                        lease.lease_rate,
                        lease.lease_start_date,
                        lease.lease_end_date,
                        customer.phone_number,
                        customer.email
                        FROM customer
                        JOIN lease
                        ON customer.customer_id = lease.customer_id
                        WHERE first_name LIKE ? AND 
                        last_name LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridViewCustomer.DataSource = DB.DBDataTable
        DBDataGridViewCustomer.ReadOnly = True
    End Sub

    'Bill DGV Search parameters
    Public Sub SearchBills(BillId As String, LeaseId As String)
        DB.AddParam("@bill_id", BillId & "%")
        DB.AddParam("@lease_id", LeaseId & "%")
        DB.ExecuteQuery("SELECT * FROM bill WHERE bill_id LIKE ? AND lease_id LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        DBDataGridViewBill.DataSource = DB.DBDataTable
    End Sub
    Private Sub RetrieveBill()
        DB.ExecuteQuery("SELECT
                        bill.bill_id AS 'Bill No.',
                        lease.lease_id,
                        bill.description,
                        bill.amount AS 'Amount',
                        SUM(payment.amount) AS 'Paid',
                        bill.amount - SUM(payment.amount) AS 'Remaining',
                        bill.due_date,
                        bill.create_date,
                        bill.last_update
                        FROM bill
                        LEFT JOIN payment
                        ON payment.bill_id = bill.bill_id
                        JOIN lease
                        ON lease.lease_id = bill.lease_id
                        JOIN customer
                        ON customer.customer_id = lease.customer_id
                        WHERE bill.bill_id LIKE ? AND lease.lease_id LIKE ?
                        GROUP BY bill.bill_id
                        ORDER BY create_date DESC")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridViewBill.DataSource = DB.DBDataTable
        DBDataGridViewBill.ReadOnly = True
    End Sub

    ' Customer DGV search values
    Private Sub SearchCustomerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp, LastNameTextBox.KeyUp
        SearchCustomer(FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub

    ' Bill DGV search values
    Private Sub SearchBillTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles BillIdTextBox.KeyUp, LeaseIdTextBox.KeyUp
        SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
    End Sub

    'New Bill Form
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewBillForm.ShowDialog()
    End Sub

    'New Payment
    Private Sub NewPaymentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewPaymentToolStripMenuItem1.Click
        NewPaymentForm.ShowDialog()
    End Sub

    'Edit Bill Form
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ExistingBillForm.ShowDialog()
    End Sub

    'Delete Bill
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim aDialogResult As DialogResult

        aDialogResult = MessageBox.Show("Do you really want to delete payment #" & SelectedBillTextBox.Text & "'s record",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then
            Exit Sub
        Else
            DB.AddParam("@bill_id", SelectedBillTextBox.Text)
            DB.ExecuteQuery("UPDATE bill SET is_active = False WHERE bill_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("The bill  #" & SelectedBillTextBox.Text & "'s record has been deleted successfully.")

            SelectedBillTextBox.Clear()

            'refresh DataGridView
            SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
        End If

    End Sub

    'Customer DGV Selected value
    Private Sub DBDataGridViewCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridViewCustomer.CellClick

        If e.RowIndex < 0 Or e.RowIndex = DBDataGridViewCustomer.Rows.Count Then
            SelectedCustomerTextBox.Clear()
            SelectedBillTextBox.Clear()
        Else
            SelectedCustomerTextBox.Text = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(0).Value
            PaymentForm.SelectedCustomer = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(3).Value
            'Clear bill text box after search customer
            SelectedBillTextBox.Clear()
            PaymentForm.SelectedBill = Integer.TryParse(PaymentForm.SelectedBill, PaymentForm.SelectedBill)
            SearchBills(BillIdTextBox.Text, DBDataGridViewCustomer.Rows(e.RowIndex).Cells(3).Value)
        End If
    End Sub

    'Bill DGV Selected value
    Private Sub DBDataGridViewBill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridViewBill.CellClick

        If e.RowIndex < 0 Or e.RowIndex = DBDataGridViewBill.Rows.Count Then
            SelectedBillTextBox.Clear()
        Else
            SelectedBillTextBox.Text = DBDataGridViewBill.Rows(e.RowIndex).Cells(0).Value
            PaymentForm.SelectedBill = SelectedBillTextBox.Text
        End If
    End Sub

    Private Sub BillIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SelectedBillTextBox.TextChanged
        If String.IsNullOrWhiteSpace(SelectedBillTextBox.Text) Then
            DeleteToolStripMenuItem.Enabled = False
            EditToolStripMenuItem.Enabled = False
        Else
            DeleteToolStripMenuItem.Enabled = True
            EditToolStripMenuItem.Enabled = True
        End If
    End Sub


End Class