Public Class LeaseForm

    Private DB As New DBAccess
    Private Sub LeaseForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SearchLease(LeaseIDTextbox.Text, UserNameTextBox.Text)

    End Sub

    Friend Sub SearchLease(LeaseID As String, UserName As String)
        DB.AddParam("@leaseid", "%" & LeaseID & "%") '1ST ?
        DB.AddParam("@username", UserName & "%")


        DB.ExecuteQuery("SELECT 
                        L.lease_id, 
                        P.property_id,
                        C.username AS 'Username', 
                        C.first_name,
                        C.last_name,
                        P.street_1,
                        P.street_2,
                        P.city,
                        P.state,
                        P.zip_code,
                        L.lease_rate, 
                        L.security_deposit,
                        L.lease_start_date, 
                        L.lease_end_date,
                        L.late_fee,
                        L.application_fee,
                        L.is_active,
                        L.last_update
                        FROM 
                        lease AS L 
                    LEFT JOIN property AS P on L.property_id = P.property_id
                    LEFT JOIN customer AS C on L.customer_id = C.customer_id
                WHERE
                       L.lease_id LIKE ? AND C.username LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordCountToolStripStatusLabel.Text = "Number of Lease: " &
                DB.RecordCount.ToString
        DBDataGridView.ReadOnly = True
    End Sub

    Private Sub LeaseIDTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles LeaseIDTextbox.KeyUp, UserNameTextBox.KeyUp
        SearchLease(LeaseIDTextbox.Text, UserNameTextBox.Text)
    End Sub


    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count - 1 Then
            LeaseStartTextBox.Clear()
            LeaseEndTextBox.Clear()
            Exit Sub
        Else
            LeaseIDTextbox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            LeaseStartTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(12).Value
            LeaseEndTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(13).Value
        End If

    End Sub

    Private Sub LeaseStartTextBox_TextChanged(sender As Object, e As EventArgs) Handles LeaseStartTextBox.TextChanged
        If String.IsNullOrWhiteSpace(LeaseStartTextBox.Text) Then
            EditToolStripMenuItem.Enabled = False
        Else
            EditToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ExistingLeaseForm.ShowDialog()
    End Sub

End Class