'PropertyCustomerForm: This form is to display property information in data grid view and the image of the property. 
Public Class PropertyCustomerForm
    Private DB As New DBAccess
    Private e As Object

    Private Sub PropertyCustomerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SearchProperty(CityTextBox.Text, PropertyTypeTextBox.Text)
    End Sub

    Friend Sub SearchProperty(City As String, PropertyType As String)
        DB.AddParam("@city", "%" & City & "%")
        DB.AddParam("@propertytype", "%" & PropertyType & "%")

        DB.ExecuteQuery("SELECT * FROM property WHERE city LIKE ? AND property_type LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        DBDataGridView.ReadOnly = True
    End Sub

    Private Sub CityTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles CityTextBox.KeyUp
        SearchProperty(CityTextBox.Text, PropertyTypeTextBox.Text)
    End Sub

    Private Sub PropertyTypeTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PropertyTypeTextBox.KeyUp
        SearchProperty(CityTextBox.Text, PropertyTypeTextBox.Text)
    End Sub

    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick

        If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count - 1 Then
            PropertyIDTextBox.Clear()
            AddressTextBox.Clear()
            Exit Sub
        Else
            PropertyIDTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            AddressTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & DBDataGridView.Rows(e.RowIndex).Cells(2).Value & ", " & DBDataGridView.Rows(e.RowIndex).Cells(3).Value & ", " & DBDataGridView.Rows(e.RowIndex).Cells(4).Value
            TypeTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(11).Value
            NumRoomTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(6).Value
            YearBuiltTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(10).Value
            NumBathRoomTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(7).Value
            MonthlyRateTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(9).Value
            AvailibilityCheckBox.Checked = DBDataGridView.Rows(e.RowIndex).Cells(22).Value

            'Show property image when selecting a property in the DataGridView

            Try
                PropertyFormPictureBox.Image = Image.FromFile(DBDataGridView.Rows(e.RowIndex).Cells(21).Value)
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        ApplicationForm.ShowDialog()
    End Sub
End Class