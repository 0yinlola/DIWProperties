
Imports System.Text.RegularExpressions
Public Class ExistingLeaseForm

    Private DB As New DBAccess

    Private Sub ExistingLeaseForm_Load(Sender As Object, e As EventArgs) Handles Me.Load
        If String.IsNullOrWhiteSpace(LeaseForm.LeaseIDTextbox.Text) Then
            MessageBox.Show("No Lease is selected. Try Again.")
            Me.Close()
        Else
            DB.AddParam("@leaseID", LeaseForm.LeaseIDTextbox.Text)
            DB.ExecuteQuery("SELECT 
                            L.lease_id, 
                            P.property_id,
                            C.username AS 'Username', 
                            L.lease_rate, 
                            L.lease_start_date, 
                            L.lease_end_date,
                            L.is_active
                            FROM 
                            lease AS L 
                            JOIN property AS P on L.property_id = P.property_id
                            JOIN customer AS C on L.customer_id = C.customer_id
                            WHERE L.lease_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Me.Close()
            End If


            LeaseIDTextBox.Text = DB.DBDataTable(0)!lease_id
            ActiveCheckBox.Checked = DB.DBDataTable(0)!is_active
            PropertyIDTextBox.Text = DB.DBDataTable(0)!property_id
            UsernameTextBox.Text = DB.DBDataTable(0)!username
            LeaseRateTextBox.Text = DB.DBDataTable(0)!lease_rate
            LeaseStartDateTimePicker.Value = DB.DBDataTable(0)!lease_start_date
            LeaseEndDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date


            EnableFieldsforEdit(False)
        End If
    End Sub

    Private Sub EnableFieldsforEdit(Switch As Boolean)

        LeaseIDTextBox.ReadOnly = True
        PropertyIDTextBox.ReadOnly = True
        UsernameTextBox.ReadOnly = True
        LeaseRateTextBox.ReadOnly = True
        ActiveCheckBox.Enabled = Switch
        LeaseStartDateTimePicker.Enabled = Switch
        LeaseEndDateTimePicker.Enabled = Switch

        If Switch = True Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub
    Private Sub UpdateLease()


        DB.AddParam("@startdate", LeaseStartDateTimePicker.Value)
        DB.AddParam("@enddate", LeaseEndDateTimePicker.Value)
        DB.AddParam("@active", ActiveCheckBox.Checked)
        DB.AddParam("@last_update", Today.Date)


        DB.AddParam("@lease_id", LeaseIDTextBox.Text)

        DB.ExecuteQuery("UPDATE lease SET lease_start_date = ?, lease_end_date = ?, is_active = ?, last_update = ? WHERE lease_id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The Lease record has been updated successfully.")

        LeaseForm.SearchLease(LeaseForm.LeaseIDTextbox.Text, LeaseForm.UserNameTextBox.Text)

    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            'Edit mode
            'Release fields for editing
            EnableFieldsforEdit(True)
            EditSaveButton.Text = "&Save"
        Else
            'Save mode
            'Update the Employee
            UpdateLease()
            EditSaveButton.Text = "&Edit"

            'Restore editing mode
            EnableFieldsforEdit(False)
        End If
        LeaseForm.SearchLease(LeaseIDTextBox.Text, UsernameTextBox.Text)
    End Sub

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class
