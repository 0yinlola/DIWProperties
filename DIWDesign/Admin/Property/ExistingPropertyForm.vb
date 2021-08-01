'Existing Property Form: This form is to display existing property data and make an update for the property data in the existing property form.
Public Class ExistingPropertyForm
    Private DB As New DBAccess
    Private Sub ExistingPropertyForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If String.IsNullOrWhiteSpace(PropertyEmployeeForm.PropertyIDTextBox.Text) Then
            MessageBox.Show("No property is selected. Try again.")
            Me.Close()
        Else
            DB.AddParam("@propertyID", PropertyEmployeeForm.PropertyIDTextBox.Text)
            DB.ExecuteQuery("SELECT * FROM property WHERE property_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Me.Close()
            End If

            PropertyIDTextBox.Text = DB.DBDataTable(0)("property_id")
            Street1TextBox.Text = DB.DBDataTable(0)!street_1
            Street2TextBox.Text = DB.DBDataTable(0)!street_2
            CityTextBox.Text = DB.DBDataTable(0)!city
            StateListBox.SelectedItem = DB.DBDataTable(0)!state
            ZipCodeTextBox.Text = DB.DBDataTable(0)!zip_code
            NumRoomTextBox.Text = DB.DBDataTable(0)!number_of_rooms
            BasementCheckBox.Checked = DB.DBDataTable(0)!basement
            PropertyTypeListBox.SelectedItem = DB.DBDataTable(0)!property_type
            NumBathroomTextBox.Text = DB.DBDataTable(0)!number_of_bathrooms
            YearBuiltTextBox.Text = DB.DBDataTable(0)!year_built
            SFTextBox.Text = DB.DBDataTable(0)!square_footage
            GarageCheckBox.Checked = DB.DBDataTable(0)!garage
            RefrigeratorCheckBox.Checked = DB.DBDataTable(0)!refigerator
            ACCheckBox.Text = DB.DBDataTable(0)!air_conditioning
            StoveCheckBox.Checked = DB.DBDataTable(0)!stove
            DishwasherCheckBox.Checked = DB.DBDataTable(0)!dish_washer
            WasherCheckBox.Checked = DB.DBDataTable(0)!washer
            DryerCheckBox.Checked = DB.DBDataTable(0)!dryer
            DisposalCheckBox.Checked = DB.DBDataTable(0)!disposal
            ActiveCheckBox.Checked = DB.DBDataTable(0)!is_active
            CreateDateTimePicker.Value = DB.DBDataTable(0)!create_Date
            MonthlyRateTextBox.Text = DB.DBDataTable(0)!monthly_rate

            Try
                PropertyPictureBox.Image = Image.FromFile(DB.DBDataTable(0)!img_link)
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try

            EnableFieldsforEdit(False)
        End If
    End Sub

    Private Sub EnableFieldsforEdit(ToEdit As Boolean)
        PropertyIDTextBox.ReadOnly = True
        Street1TextBox.ReadOnly = Not ToEdit
        Street2TextBox.ReadOnly = Not ToEdit
        CityTextBox.ReadOnly = Not ToEdit
        StateListBox.Enabled = ToEdit
        ZipCodeTextBox.ReadOnly = Not ToEdit
        NumRoomTextBox.ReadOnly = Not ToEdit
        BasementCheckBox.Enabled = ToEdit
        PropertyTypeListBox.Enabled = ToEdit
        NumBathroomTextBox.ReadOnly = Not ToEdit
        YearBuiltTextBox.ReadOnly = Not ToEdit
        SFTextBox.ReadOnly = Not ToEdit
        GarageCheckBox.Enabled = ToEdit
        RefrigeratorCheckBox.Enabled = ToEdit
        ACCheckBox.Enabled = ToEdit
        StoveCheckBox.Enabled = ToEdit
        DishwasherCheckBox.Enabled = ToEdit
        WasherCheckBox.Enabled = ToEdit
        DryerCheckBox.Enabled = ToEdit
        DisposalCheckBox.Enabled = ToEdit
        ActiveCheckBox.Enabled = ToEdit
        MonthlyRateTextBox.ReadOnly = Not ToEdit
        BrowserImageButton.Enabled = ToEdit

        If ToEdit = True Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub

    Private Sub UpdateProperty()

        DB.AddParam("@street1", Street1TextBox.Text) '1st parameter
        DB.AddParam("@street2", Street2TextBox.Text) ' 2nd parameter
        DB.AddParam("@city", CityTextBox.Text) '3rd parameter
        DB.AddParam("@state", StateListBox.SelectedItem) '4th parameter
        DB.AddParam("@zipcode", ZipCodeTextBox.Text) '5th
        DB.AddParam("@numberofrooms", NumRoomTextBox.Text) '6th
        DB.AddParam("@numberofbathrooms", NumBathroomTextBox.Text) '7th
        DB.AddParam("@squarefootage", SFTextBox.Text) '8th
        DB.AddParam("@yearbuilt", YearBuiltTextBox.Text) '9th
        DB.AddParam("@propertytype", PropertyTypeListBox.SelectedItem) '10th
        DB.AddParam("@garage", GarageCheckBox.Checked) '11th
        DB.AddParam("@refrigerator", RefrigeratorCheckBox.Checked) '12th
        DB.AddParam("@airconditioning", ACCheckBox.Checked) '13th
        DB.AddParam("@dishwasher", DishwasherCheckBox.Checked) '14th
        DB.AddParam("@washer", WasherCheckBox.Checked) '15th
        DB.AddParam("@dryer", DryerCheckBox.Checked) '16th
        DB.AddParam("@stove", StoveCheckBox.Checked) '17th
        DB.AddParam("@disposal", DisposalCheckBox.Checked) '18th
        DB.AddParam("@basement", BasementCheckBox.Checked) '19th
        DB.AddParam("@active", ActiveCheckBox.Checked) '20th
        DB.AddParam("@createdate", CreateDateTimePicker.Value) '21th

        'To add an updated image and save a new path and file name to the database
        'Dim fname As String = PropertyIDTextBox.Text & ".jfif"
        'Dim folder As String = "U:\BIS698\GroupProjectChaV2\GroupProjectChaV2\ImageFolder"
        'Dim query As String = "Update property set img_link = @fname where property_id = '" & PropertyIDTextBox.Text & "'"
        'Dim pathstring As String = System.IO.Path.Combine(folder, fname)
        'Dim a As Image = PropertyPictureBox.Image
        'DB.AddParam("imglink", pathstring)

        'Save image in the soution
        Dim fname As String = PropertyIDTextBox.Text & ".jfif"
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pathstring As String = IO.Path.Combine(path, fname)
        Dim query As String = "Update property set img_link = @fname where property_id = '" & PropertyIDTextBox.Text & "'"
        Dim a As Image = PropertyPictureBox.Image
        a.Save(pathstring)

        DB.AddParam("imglink", fname) '22th

        DB.AddParam("@monthlyrate", MonthlyRateTextBox.Text) '22th

        DB.AddParam("@propertyID", PropertyIDTextBox.Text)

        DB.ExecuteQuery("UPDATE property SET street_1=?, street_2=?, city=?, state=?, zip_code=?, number_of_rooms=?, number_of_bathrooms=?, square_footage=?, year_built=?, property_type=?, garage=?, refigerator=?, air_conditioning=?, dish_washer=?, washer=?, dryer=?, stove=?, disposal=?, basement=?, is_active=?, create_date=?, img_link=?, monthly_rate=? WHERE property_id=?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The property #" & PropertyIDTextBox.Text & "'s record has been updated successfully.")

        PropertyEmployeeForm.SearchProperty(PropertyEmployeeForm.CityTextBox.Text, PropertyEmployeeForm.PropertyTypeTextBox.Text)
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            'edit mode
            'release fields for editing
            EnableFieldsforEdit(True)
        Else
            'save mode
            'update the property
            UpdateProperty()
            'restore back to the editing mode
            EnableFieldsforEdit(False)
        End If
    End Sub

    Private Function ValidNewPropertyData() As Boolean
        'Validate Street1 input
        '1. Validate if Street1 is empty or not.
        If String.IsNullOrWhiteSpace(Street1TextBox.Text) Then
            MessageBox.Show("Street 1 can't be empty.")
            Street1TextBox.SelectAll()
            Street1TextBox.Focus()
            Return False
        End If

        'Validate City input
        '1. Validate if City is empty or not.
        If String.IsNullOrWhiteSpace(CityTextBox.Text) Then
            MessageBox.Show("City can't be empty.")
            CityTextBox.SelectAll()
            CityTextBox.Focus()
            Return False
        End If

        'Validate State input
        '1. Validate if State is empty or not.
        If String.IsNullOrWhiteSpace(StateListBox.SelectedItem) Then
            MessageBox.Show("State can't be empty.")
            StateListBox.Focus()
            Return False
        End If

        'Validate number of rooms
        '1. Validate if number of rooms is interger or not.
        Dim NumRoomsInteger As Integer
        If Integer.TryParse(NumRoomTextBox.Text, NumRoomsInteger) = False Then
            MessageBox.Show("Number of rooms must be integer.")
            NumRoomTextBox.SelectAll()
            NumRoomTextBox.Focus()
            Return False
        End If

        '2. Validate if number of rooms is in a valid range.
        If NumRoomsInteger < 1 Then
            MessageBox.Show("Number of rooms must be greater than 0.")
            NumRoomTextBox.SelectAll()
            NumRoomTextBox.Focus()
            Return False
        End If

        'Validate number of bathrooms
        '1. Validate if number of bathrooms is interger or not.
        Dim NumBathroomsInteger As Integer
        If Integer.TryParse(NumBathroomTextBox.Text, NumBathroomsInteger) = False Then
            MessageBox.Show("Number of bathrooms must be integer.")
            NumBathroomTextBox.SelectAll()
            NumBathroomTextBox.Focus()
            Return False
        End If

        '2. Validate if number of bathrooms is in a valid range.
        If NumBathroomsInteger < 1 Then
            MessageBox.Show("Number of bathrooms must be greater than 0.")
            NumBathroomTextBox.SelectAll()
            NumBathroomTextBox.Focus()
            Return False
        End If

        'Validate year built
        '1. Validate if year built is interger or not.
        Dim NumYearBuiltInteger As Integer
        If Integer.TryParse(YearBuiltTextBox.Text, NumYearBuiltInteger) = False Then
            MessageBox.Show("Year built must be integer.")
            YearBuiltTextBox.SelectAll()
            YearBuiltTextBox.Focus()
            Return False
        End If

        '2. Validate if year built is in a valid range.
        If NumYearBuiltInteger < 1 Or NumYearBuiltInteger > 2021 Then
            MessageBox.Show("Year Built must be between 1 and 2021.")
            YearBuiltTextBox.SelectAll()
            YearBuiltTextBox.Focus()
            Return False
        End If

        'Validate square footage
        '1. Validate if square footage is decimal or not.
        Dim SFDecimal As Decimal
        If Decimal.TryParse(SFTextBox.Text, SFDecimal) = False Then
            MessageBox.Show("Square Footage must be decimal format in 0.00.")
            SFTextBox.SelectAll()
            SFTextBox.Focus()
            Return False
        End If

        '2. Validate if square footage is in a valid range.
        If SFDecimal < 0.00 Then
            MessageBox.Show("Square footage must be greater than 0.00.")
            SFTextBox.SelectAll()
            SFTextBox.Focus()
            Return False
        End If

        'Validate monthly rate
        '1. Validate if monthly rate is decimal or not.
        Dim RateDecimal As Decimal
        If Decimal.TryParse(MonthlyRateTextBox.Text, RateDecimal) = False Then
            MessageBox.Show("Monthly rate must be decimal format in 0000.00.")
            MonthlyRateTextBox.SelectAll()
            MonthlyRateTextBox.Focus()
            Return False
        End If

        '2. Validate if monthly rate is in a valid range.
        If RateDecimal < 0.00 Or RateDecimal > 9999.99 Then
            MessageBox.Show("Montly rate must be greater than 0.00 and smaller than 10000.00.")
            MonthlyRateTextBox.SelectAll()
            MonthlyRateTextBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub BrowserImageButton_Click(sender As Object, e As EventArgs) Handles BrowserImageButton.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            PropertyPictureBox.Image = Image.FromFile(op.FileName)
        End If
    End Sub

End Class