Public Class ReviewApplicationForm
    Private DB As New DBAccess
    Dim Status As String
    Public SelectedApplication As Integer
    Private Sub ProcessApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text)
    End Sub
    Private Sub SearchApplications(ApplicationId As String, LastName As String, CustomerId As String, Optional ByVal Status As String = "pending")
        DB.AddParam("@application_id", ApplicationId & "%")
        DB.AddParam("@last_name", LastName & "%")
        DB.AddParam("@customer_id", CustomerId & "%")
        DB.AddParam("@status", Status & "%")

        DB.ExecuteQuery("SELECT
                        application_id,
                        first_name,
                        last_name,
                        customer.customer_id
                        FROM application
                        JOIN customer
                        ON application.customer_id = customer.customer_id
                        JOIN property
                        ON application.property_id = property.property_id
                        WHERE application.application_id LIKE ? AND customer.last_name LIKE ? AND application.customer_id LIKE ? AND application_status Like ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        DBDataGridView.ReadOnly = True
    End Sub

    Private Sub SearchTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SearchApplicationIdTextBox.KeyUp, SearchLastNameTextBox.KeyUp, SerachCustomerIdTextBox.KeyUp
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text, Status)
    End Sub

    'Radio Buttons Search
    Private Sub PendingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PendingRadioButton.CheckedChanged
        If PendingRadioButton.Checked Then
            Status = "pending"
        End If
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text, Status)
    End Sub

    Private Sub ProcessingRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ProcessingRadioButton.CheckedChanged
        If ProcessingRadioButton.Checked Then
            Status = "processing"
        End If
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text, Status)
    End Sub

    Private Sub ApprovedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ApprovedRadioButton.CheckedChanged
        If ApprovedRadioButton.Checked Then
            Status = "approved"
        End If
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text, Status)
    End Sub

    Private Sub RejectedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RejectedRadioButton.CheckedChanged
        If RejectedRadioButton.Checked Then
            Status = "rejected"
        End If
        SearchApplications(SearchApplicationIdTextBox.Text, SearchLastNameTextBox.Text, SerachCustomerIdTextBox.Text, Status)
    End Sub

    ' Fill Text Boxes

    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count Or IsDBNull(DBDataGridView.Rows(e.RowIndex).Cells(0).Value) Then
            ClearTextBoxes()
        Else
            SelectedApplication = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            FillTextBoxes(SelectedApplication)
        End If
    End Sub

    Private Sub FillTextBoxes(SelectedApplication As Integer)
        DB.AddParam("@application_id", SelectedApplication)
        DB.ExecuteQuery("SELECT * 
                        FROM application
                        JOIN customer
                        ON application.customer_id = customer.customer_id
                        JOIN property
                        ON application.property_id = property.property_id
                        LEFT JOIN lease
                        ON property.property_id = lease.property_id
                        WHERE application.application_id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        'Customer information
        NameTextBox.Text = DB.DBDataTable(0)!first_name + " " + DB.DBDataTable(0)!last_name
        EmailTextBox.Text = DB.DBDataTable(0)!email
        PhoneTextBox.Text = DB.DBDataTable(0)!phone_number
        UserAddressTextBox.Text = DB.DBDataTable(0)!street_1 + ", " + DB.DBDataTable(0)!city + ", " + DB.DBDataTable(0)!state + ", " + Str(DB.DBDataTable(0)!zip_code)
        CustomerIdTextBox.Text = DB.DBDataTable(0)!customer_id
        UserNameTextBox.Text = DB.DBDataTable(0)!username
        DOBTextBox.Text = DB.DBDataTable(0)!DOB

        'Property information
        PropertyIdTextBox.Text = DB.DBDataTable(0)!property_id
        PropertyAddressTextBox.Text = DB.DBDataTable(0)!street_11 + ", " + DB.DBDataTable(0)!city1 + ", " + DB.DBDataTable(0)!state1 + ", " + Str(DB.DBDataTable(0)!zip_code1)
        If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then
            LeaseEndDateTimePicker.Visible = False
            PropertyAvailableLabel.Text = "Available Property"
        Else
            LeaseEndDateTimePicker.Visible = True
            LeaseEndDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date
            PropertyAvailableLabel.Text = "Lease End Date"
        End If
        'Lease information
        ApplicationIdTextBox.Text = DB.DBDataTable(0)!application_id
        CreateDateTimePicker.Value = DB.DBDataTable(0)!create_date
        PreferredStartDateTimePicker.Value = DB.DBDataTable(0)!preferred_start_date
        LeaseDurationTextBox.Text = Str(DB.DBDataTable(0)!lease_duration)

        If IsDBNull(DB.DBDataTable(0)!process_by) Then
            ProcessedByTextBox.Text = ""
        Else
            ProcessedByTextBox.Text = DB.DBDataTable(0)!process_by
        End If

        If IsDBNull(DB.DBDataTable(0)!process_date) Then
            ProcessDateTimePicker.Visible = False
        Else
            ProcessDateTimePicker.Visible = True
            ProcessDateTimePicker.Value = DB.DBDataTable(0)!process_date
        End If

        If IsDBNull(DB.DBDataTable(0)!decision_by) Then
            DecisionByTextBox.Text = ""
        Else
            DecisionByTextBox.Text = DB.DBDataTable(0)!decision_by
        End If

        If IsDBNull(DB.DBDataTable(0)!decision_date) Then
            DecisionDateTimePicker.Visible = False
        Else
            DecisionDateTimePicker.Visible = True
            DecisionDateTimePicker.Value = DB.DBDataTable(0)!decision_date
        End If

        ApplicationStatusLabel.Text = DB.DBDataTable(0)!application_status

    End Sub
    Private Sub ClearTextBoxes()
        NameTextBox.Clear()
        EmailTextBox.Clear()
        CustomerIdTextBox.Clear()
        UserNameTextBox.Clear()
        PhoneTextBox.Clear()
        UserAddressTextBox.Clear()
        DOBTextBox.Clear()

        PropertyIdTextBox.Clear()
        PropertyAddressTextBox.Clear()
        ApplicationIdTextBox.Clear()

        ApplicationIdTextBox.Clear()
        LeaseDurationTextBox.Clear()
        ProcessedByTextBox.Clear()
        DecisionByTextBox.Clear()
    End Sub

    Private Sub ProcessApplicationButton_Click(sender As Object, e As EventArgs) Handles ProcessApplicationButton.Click
        If SelectedApplication <= 0 Then
            MessageBox.Show("Please select an applicatoin")
        Else
            ProcessApplicationForm.ShowDialog()
        End If
    End Sub
End Class
