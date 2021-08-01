Public Class CustomerForm
    Private DB As New DBAccess
    Private SelectedCustomerStatus As String

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DB.ExecuteQuery("SELECT * FROM customer")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordCountToolStripStatusLabel.Text = "Number of customers: " & DB.RecordCount.ToString
        DBDataGridView.ReadOnly = True
    End Sub

    Friend Sub SearchCustomers(FirstName As String, LastName As String)
        DB.AddParam("@firstname", FirstName & "%") '1ST ?'
        DB.AddParam("@lastname", LastName & "%")   '2ND ?'
        DB.ExecuteQuery("SELECT * FROM customer WHERE first_name LIKE ? AND last_name LIKE ?")


        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordCountToolStripStatusLabel.Text = "Number of customers:  " & DB.RecordCount.ToString
    End Sub

    Private Sub NameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp, LastNameTextBox.KeyUp
        SearchCustomers(FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub


    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count - 1 Then
            CustomerIDTextBox.Clear()
            CustomerNameTextBox.Clear()
            DateTextBox.Clear()
            AmountTextBox.Clear()
            SelectedCustomerStatus = String.Empty
        Else
            CustomerIDTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            CustomerNameTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & DBDataGridView.Rows(e.RowIndex).Cells(2).Value
            DateTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(8).Value
            AmountTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        If String.IsNullOrWhiteSpace(CustomerIDTextBox.Text) Then
            EditToolStripMenuItem.Enabled = False
        Else
            EditToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        CustomerProfileForm.ShowDialog()
    End Sub
End Class


