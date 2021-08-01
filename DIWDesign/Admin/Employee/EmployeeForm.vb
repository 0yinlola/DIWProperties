
Public Class EmployeeForm


        Private DB As New DBAccess
        Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
            SearchEmpolyees(FirstNameTextBox.Text, LastNameTextBox.Text)

        End Sub

        Friend Sub SearchEmpolyees(FirstName As String, LastName As String)
            DB.AddParam("@firstname", "%" & FirstName & "%") '1ST ?
            DB.AddParam("@lastname", "%" & LastName & "%")   '2ND ?

            DB.ExecuteQuery("SELECT * FROM employee WHERE first_name LIKE ? AND last_name LIKE ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            DBDataGridView.DataSource = DB.DBDataTable
            RecordCountToolStripStatusLabel.Text = "Number of Employees: " &
                DB.RecordCount.ToString
            DBDataGridView.ReadOnly = True
        End Sub

        Private Sub FirstNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp, LastNameTextBox.KeyUp
            SearchEmpolyees(FirstNameTextBox.Text, LastNameTextBox.Text)
        End Sub


        Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
            If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count - 1 Then
                UserNameTextBox.Clear()
                EmployeeIDTextBox.Clear()
                EmployeeClassTextBox.Clear()
                Exit Sub
            Else
                UserNameTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(1).Value
                EmployeeIDTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
                EmployeeClassTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(19).Value
            End If

        End Sub

    Private Sub EmployeeIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmployeeIDTextBox.TextChanged
        If String.IsNullOrWhiteSpace(EmployeeIDTextBox.Text) Then
            EditToolStripMenuItem.Enabled = False
        Else
            EditToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewEmployeeForm.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ExistingEmployeeForm.ShowDialog()
    End Sub
End Class
