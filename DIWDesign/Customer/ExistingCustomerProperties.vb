Public Class ExistingCustomerProperties
    Private DB As New DBAccess
    Private e As Object

    Private Sub PropertyCustomerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SearchProperty(CityTextBox.Text, PropertyTypeTextBox.Text)
    End Sub

    Friend Sub SearchProperty(City As String, PropertyType As String)
        DB.AddParam("@city", "%" & City & "%")
        DB.AddParam("@propertytype", "%" & PropertyType & "%")

        DB.ExecuteQuery("SELECT 
                        property_id,
                        property_type,
                        state,
                        city,
                        number_of_rooms,
                        square_footage
                        FROM property
                        WHERE city LIKE ? AND property_type LIKE ?")

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
            FillTable(PropertyIDTextBox.Text)
        End If
    End Sub

    Private Sub FillTable(PropertyId As String)
        DB.AddParam("@property_id", PropertyId)
        DB.ExecuteQuery("SELECT * 
                        FROM property
                        LEFT JOIN lease
                        ON property.property_id = lease.property_id 
                        WHERE property.property_id Like ?
                        ORDER BY lease_end_date DESC
                        LIMIT 1")

        AddressTextBox.Text = DB.DBDataTable(0)!street_1 & ", " & DB.DBDataTable(0)!street_2 & ", " & DB.DBDataTable(0)!city & ", " & DB.DBDataTable(0)!state
        If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then
            AvailableFromDateTimePicker.Value = DateAdd("d", 3, Today.Date)
        Else
            AvailableFromDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date
        End If
        TypeTextBox.Text = DB.DBDataTable(0)!property_type
        SquareFootageTextBox.Text = DB.DBDataTable(0)!square_footage
        NumRoomTextBox.Text = DB.DBDataTable(0)!number_of_rooms
        YearBuiltTextBox.Text = DB.DBDataTable(0)!year_built
        NumBathRoomTextBox.Text = DB.DBDataTable(0)!number_of_bathrooms
        MonthlyRateTextBox.Text = DB.DBDataTable(0)!monthly_rate
        isAvailableCheckBox.Checked = DB.DBDataTable(0)!is_active
        GarageCheckBox.Checked = DB.DBDataTable(0)!garage
        RefrigeratorCheckBox.Checked = DB.DBDataTable(0)!refigerator
        ACCheckBox.Checked = DB.DBDataTable(0)!air_conditioning
        StoveCheckBox.Checked = DB.DBDataTable(0)!stove
        DishWasherCheckBox.Checked = DB.DBDataTable(0)!dish_washer
        WasherCheckBox.Checked = DB.DBDataTable(0)!washer
        DryerCheckBox.Checked = DB.DBDataTable(0)!dryer
        GarbageDisposalCheckBox.Checked = DB.DBDataTable(0)!disposal


        'Show property image when selecting a property in the DataGridView
        Try
            PropertyFormPictureBox.Image = Image.FromFile(DB.DBDataTable(0)!img_link)
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub ApplicationButton_Click(sender As Object, e As EventArgs) Handles ApplicationButton.Click
        NewApplicationExistingCustomerForm.ShowDialog()
    End Sub
End Class