'New Property Form: This form is to enter new property record into the property table.

Imports System.ComponentModel
Public Class NewPropertyForm
    Private DB As New DBAccess
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ClearForm()
        Me.Close()
    End Sub

    Private Sub ClearForm()
        Street1TextBox.Clear()
        Street2TextBox.Clear()
        CityTextBox.Clear()
        StateListBox.ClearSelected()
        ZipCodeTextBox.Clear()
        NumRoomTextBox.Clear()
        BasementCheckBox.Checked = False
        PropertyTypeListBox.ClearSelected()
        NumBathroomTextBox.Clear()
        YearBuiltTextBox.Clear()
        SFTextBox.Clear()
        GarageCheckBox.Checked = False
        RefrigeratorCheckBox.Checked = False
        ACCheckBox.Checked = False
        StoveCheckBox.Checked = False
        DishwasherCheckBox.Checked = False
        WasherCheckBox.Checked = False
        DryerCheckBox.Checked = False
        DisposalCheckBox.Checked = False
        PropertyPictureBox.Image = Nothing
        MonthlyRateTextBox.Clear()
    End Sub

    Private Sub NewPropertyForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearForm()
    End Sub

    Private Sub AddProperty()

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
        DB.AddParam("@monthlyrate", MonthlyRateTextBox.Text) '20th

        'Add image file
        Dim fname As String = Street1TextBox.Text & ".jfif"
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pathstring As String = IO.Path.Combine(path, fname)
        Dim query As String = "Update property set img_link = @fname where street_1 = '" & Street1TextBox.Text & "'"
        Dim a As Image = PropertyPictureBox.Image
        a.Save(pathstring)
        DB.AddParam("@imglink", fname)

        DB.ExecuteQuery("INSERT INTO property(street_1, street_2, city, state, zip_code, number_of_rooms, number_of_bathrooms, square_footage, year_built, property_type, garage, refigerator, air_conditioning, dish_washer, washer, dryer, stove, disposal, basement, monthly_rate, img_link) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A new property is added into the database successfully.")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidNewPropertyData() = False Then 'basic validation
            Exit Sub
        ElseIf DuplicateProperty() = True Then 'higher level validation
            Exit Sub
        End If

        AddProperty()
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearForm()
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
        If NumRoomsInteger < 1 Or NumRoomsInteger > 10 Then
            MessageBox.Show("Number of rooms must be greater than 0 and smaller than 10.")
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
        If NumBathroomsInteger < 1 Or NumBathroomsInteger > 10 Then
            MessageBox.Show("Number of bathrooms must be greater than 0 and less than 10.")
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
        '1. Validate if square footage is integer or not.
        Dim SFInteger As Integer
        If Integer.TryParse(SFTextBox.Text, SFInteger) = False Then
            MessageBox.Show("Square Footage must be integer format.")
            SFTextBox.SelectAll()
            SFTextBox.Focus()
            Return False
        End If

        '2. Validate if square footage is in a valid range.
        If SFInteger < 0 Or SFInteger > 9999 Then
            MessageBox.Show("Square footage must be greater than 0 and less than 10000.")
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

    Private Function DuplicateProperty() As Boolean
        DB.AddParam("@street1", Street1TextBox.Text)
        DB.AddParam("@city", CityTextBox.Text)
        DB.AddParam("@state", StateListBox.SelectedItem)
        DB.ExecuteQuery("SELECT * FROM property WHERE street_1 = ? AND city = ? AND state = ?")

        If DB.RecordCount > 0 Then
            MessageBox.Show("The property has already existed.")
            Return True
        End If

        Return False
    End Function

    Private Sub BrowserImageButton_Click(sender As Object, e As EventArgs) Handles BrowserImageButton.Click
        Dim op As OpenFileDialog = New OpenFileDialog
        If op.ShowDialog = DialogResult.OK Then
            PropertyPictureBox.Image = Image.FromFile(op.FileName)
        End If
    End Sub

End Class