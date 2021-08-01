Public Class CustomerApplicationStatus
    Private DB As New DBAccess
    Private Sub CustomerApplicationStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(ActiveUser.User_id) Then
            Me.Close()
        Else
            DB.AddParam("@user_id", ActiveUser.User_id)
            DB.ExecuteQuery("SELECT a.application_id, a.customer_id, a.application_status, a.preferred_start_date, a.lease_duration, c.first_name, c.last_name, p.property_id, p.property_type, p.street_1, p.street_2 FROM application AS a JOIN customer as c ON a.application_id = c.customer_id JOIN property as p on p.property_id = a.application_id WHERE c.customer_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            UserIdTextBox.Text = DB.DBDataTable(0)("customer_id")
            ApplicationIdTextBox.Text = DB.DBDataTable(0)!application_id
            FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
            LastNameTextBox.Text = DB.DBDataTable(0)!last_name
            StatusTextBox.Text = DB.DBDataTable(0)!application_status
            PropertyInfoTextBox.Text = DB.DBDataTable(0)!property_type
            PropertyIdTextBox.Text = DB.DBDataTable(0)!property_id
            PropertyAddressTextBox.Text = DB.DBDataTable(0)!street_1 & " " & DB.DBDataTable(0)!street_2
            PreferredDateTextBox.Text = DB.DBDataTable(0)!preferred_start_date
            LeaseDurationTextBox.Text = DB.DBDataTable(0)!lease_duration

        End If
        WindowState = FormWindowState.Maximized

    End Sub


End Class