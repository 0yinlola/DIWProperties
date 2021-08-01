Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class ApplicationForm
    Private DB As New DBAccess

    Private Sub ApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(PropertyCustomerForm.PropertyIDTextBox.Text) Then
            MessageBox.Show("No property is selected. Try again.")
            Me.Close()
        Else

            DB.AddParam("@property_id", PropertyCustomerForm.PropertyIDTextBox.Text)
            DB.ExecuteQuery("SELECT * 
                                FROM property
                                LEFT JOIN lease
                                ON property.property_id = lease.property_id 
                                WHERE property.property_id = ?
                                ORDER BY lease_end_date DESC
                                LIMIT 1")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then
                AvailableFromDateTimePicker.Value = DateAdd("d", 3, Today.Date)
            Else
                AvailableFromDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date
            End If

            PropertyIdTextBox.Text = DB.DBDataTable(0)!property_id
            PropertyInfoTextBox.Text = DB.DBDataTable(0)!property_type
            PropertyAddressTextBox.Text = DB.DBDataTable(0)!street_1 + ", " + DB.DBDataTable(0)!city + ", " + DB.DBDataTable(0)!state + ", " + Str(DB.DBDataTable(0)!zip_code)
        End If
    End Sub

    Private Sub GroupBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupBox1.Paint

        Dim gfx = e.Graphics
        Dim pen As New Pen(Brushes.Black, 1)
        gfx.DrawLine(pen, 0, 5, 0, e.ClipRectangle.Height - 2)
        gfx.DrawLine(pen, 0, 5, 10, 5)
        gfx.DrawLine(pen, 62, 5, e.ClipRectangle.Width - 2, 5)
        gfx.DrawLine(pen, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2)
        gfx.DrawLine(pen, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2)
        'WindowState = FormWindowState.Maximized
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub


    Private Sub ClearForm()
        UserNameTextBox.Clear()
        PasswordTextBox.Clear()
        RetypePasswordTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        CustomerPhoneTextBox.Clear()
        EmailTextBox.Clear()
        GenderListBox.ClearSelected()
        DOBTextBox.Clear()
        SSNTextBox.Clear()
        AddressTextBox.Clear()
        Address2TextBox.Clear()
        CityTextBox.Clear()
        StateListBox.ClearSelected()
        ZipCodeTextBox.Clear()
        EmployerTextBox.Clear()
        VehicleMakeTextBox.Clear()
        VehiclePlateNumberTextBox.Clear()
        DriverLicenseTextBox.Clear()
        LandlordNameTextBox.Clear()
        LandlordPhoneTextBox.Clear()
        Reference1NameTextBox.Clear()
        Reference1PhoneTextBox.Clear()
        Reference2NameTextBox.Clear()
        Reference2PhoneTextBox.Clear()
        EmergencyContactNameTextBox.Clear()
        EmergencyContactPhoneTextBox.Clear()
    End Sub

    Private Sub ApplicationForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearForm()
    End Sub

    Private Sub Addcustomer()
        If (ActiveUser.User_id) And (ActiveUser.Role = 3) Then
            'Sumbitting application for existing customer
            DB.AddParam("@customer_id", ActiveUser.User_id)
            DB.AddParam("@preferred_date", PrefferedStartDateTimePicker.Value)
            DB.AddParam("@lease_duration", LeaseDurationTextBox.Text)
            DB.AddParam("@createdate", Today.Date)

            DB.ExecuteQuery("INSERT INTO application(property_id, customer_id, preferred_start_date, application_status, lease_duration, create_date) 
                        VALUES ( ?, ?, 'pending', ?, ?)")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("Your application has been submitted successfully, you can log in to your account to review the progress of your application")
            Me.Close()
        Else
            DB.AddParam("@username", UserNameTextBox.Text)   '1st Parameter
            DB.AddParam("@password", PasswordTextBox.Text)  '2nd Parameter
            DB.AddParam("@firstname", FirstNameTextBox.Text)  '3rd Parameter
            DB.AddParam("@lastname", LastNameTextBox.Text)   '4th
            DB.AddParam("@customer_phone", CustomerPhoneTextBox.Text)   '5th
            DB.AddParam("@email", EmailTextBox.Text)          '6th parameter
            DB.AddParam("@gender", GenderListBox.SelectedItem)   '7th
            DB.AddParam("@birthday", DOBTextBox.Text)  '8th
            If String.IsNullOrEmpty(SSNTextBox.Text) Then 'because social security number field is optional
                DB.AddParam("@social_security", DBNull.Value)
            Else
                DB.AddParam("@social_security", SSNTextBox.Text)          '9th
            End If
            DB.AddParam("@street_first", AddressTextBox.Text)       '10th
            If String.IsNullOrEmpty(Address2TextBox.Text) Then 'because Address 2 field is optional
                DB.AddParam("@street_second", DBNull.Value)
            Else
                DB.AddParam("@street_second", Address2TextBox.Text)          '11th
            End If
            DB.AddParam("@city", CityTextBox.Text)                      '12th
            DB.AddParam("@state", StateListBox.SelectedItem)      '13th
            DB.AddParam("@zip_code", ZipCodeTextBox.Text)                 '14th

            If String.IsNullOrEmpty(EmployerTextBox.Text) Then
                DB.AddParam("@employer", DBNull.Value)
            Else
                DB.AddParam("@employer", EmployerTextBox.Text)          '15th
            End If

            If String.IsNullOrEmpty(VehicleMakeTextBox.Text) Then
                DB.AddParam("@vehicle_make", DBNull.Value)          '16th
            Else
                DB.AddParam("@vehicle_make", VehicleMakeTextBox.Text)
            End If

            If String.IsNullOrEmpty(VehiclePlateNumberTextBox.Text) Then
                DB.AddParam("@vehicle_plate", DBNull.Value)
            Else
                DB.AddParam("@vehicle_plate", VehiclePlateNumberTextBox.Text)          '17th
            End If

            If String.IsNullOrEmpty(DriverLicenseTextBox.Text) Then
                DB.AddParam("@driverlicense", DBNull.Value)
            Else
                DB.AddParam("@driverlicense", DriverLicenseTextBox.Text)          '18th
            End If

            DB.AddParam("@landlord_name", LandlordNameTextBox.Text)                 '19th
            DB.AddParam("@landlord_phone", LandlordPhoneTextBox.Text)               '20th
            DB.AddParam("@reference1_name", Reference1NameTextBox.Text)              '21st
            DB.AddParam("@reference1_phone", Reference1PhoneTextBox.Text)            '22nd
            DB.AddParam("@reference2_name", Reference2NameTextBox.Text)               '23rd
            DB.AddParam("@reference2_phone", Reference2PhoneTextBox.Text)              '24th
            DB.AddParam("@emergency_name", EmergencyContactNameTextBox.Text)    '25th
            DB.AddParam("@emergency_phone", EmergencyContactPhoneTextBox.Text)    '26th
            DB.AddParam("@active", 1)     '27th
            DB.AddParam("@createdate", Today.Date)   '28th

            DB.ExecuteQuery("INSERT into 
customer(username, user_password, first_name, last_name, phone_number, email, gender, DOB, social_security_number, street_1, street_2, city, state, zip_code, employer, vehicle_make, vehicle_plate_number, driver_license, previous_landlord_name, previous_landlord_phone_number, reference_1_full_name, reference_1_phone_number, reference_2_full_name, reference_2_phone_number, emergency_contact_full_name, emergency_contact_phone_number, is_active, create_date) 
VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) ")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If

        'Sumbitting application for new customer
        DB.AddParam("@property_id", PropertyIdTextBox.Text)
        DB.AddParam("@username", UserNameTextBox.Text)
        DB.AddParam("@preffered_date", PrefferedStartDateTimePicker.Value)
        DB.AddParam("@lease_duration", LeaseDurationTextBox.Text)
        DB.AddParam("@createdate", Today.Date)

        DB.ExecuteQuery("INSERT INTO application(property_id, customer_id, preferred_start_date, application_status, lease_duration, create_date) 
                        VALUES ( ?, (SELECT customer_id FROM customer WHERE username = ? LIMIT 1), ?, 'pending', ?, ?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("Your application has been submitted successfully, you can log in to your account to review the progress of your application")
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If ValidateNewCustomerData() = False Then
            Exit Sub
        ElseIf DuplicateUser() = True Then
            Exit Sub
        ElseIf DuplicateEmail() = True Then
            Exit Sub
        End If

        Addcustomer()

        ClearForm()
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearForm()
    End Sub

    Private Function ValidateNewCustomerData() As Boolean
        'Validate Username as Input
        '1. validate if username is empty or not
        If String.IsNullOrWhiteSpace(UserNameTextBox.Text) Then
            MessageBox.Show("Username cannot be empty")
            UserNameTextBox.SelectAll()
            UserNameTextBox.Focus()
            Return False
        End If
        'Use regular expressions to check if the username follows a right pattern.

        Dim rxUserName As New Regex("^(?=.*[a-zA-Z])(?=.*[0-9])[A-Za-z0-9]+$")
        If rxUserName.IsMatch(UserNameTextBox.Text) = False Then
            MessageBox.Show("Username must be a combination of alphabets from a-z and numbers from 0-9.")
            UserNameTextBox.SelectAll()
            UserNameTextBox.Focus()
            Return False
        End If

        '2. Validate if password is empty or not
        If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            MessageBox.Show("Password cannot be empty")
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()
            Return False
        End If

        'checking if the password follows the right pattern.
        Dim rxPassordword As New Regex("^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$")
        If rxPassordword.IsMatch(PasswordTextBox.Text) = False Then
            MessageBox.Show("Password must contain:" + Environment.NewLine + "1. At least one digit [0-9]" + Environment.NewLine + "2. At least one lowercase character [a-z]" + Environment.NewLine + "3. At least one uppercase character [A-Z]" + Environment.NewLine + "4. At least one special character [*.!@#$%^&(){}[]:;<>,.?/~_+-=|\]" + Environment.NewLine + "5. At least 10 characters in length")
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()
            Return False
        End If

        ' Validate if retype password is empty or not
        If String.IsNullOrWhiteSpace(RetypePasswordTextBox.Text) Then
            MessageBox.Show("Please retype password.")
            RetypePasswordTextBox.SelectAll()
            RetypePasswordTextBox.Focus()
            Return False
        End If

        'checking if the Retyped password matches the password.
        If PasswordTextBox.Text <> RetypePasswordTextBox.Text Then
            MsgBox("Password does not match!, Please Re-type.", MsgBoxStyle.Critical)
            RetypePasswordTextBox.SelectAll()
            RetypePasswordTextBox.Focus()
            Return False
        End If

        'Validate First name input
        '3. Validate if First Name is empty or not
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            MessageBox.Show("First name cannot be empty.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the first name follows a right pattern.
        Dim rxFirstName As New Regex("^[A-Z]+[a-z]+$")
        If rxFirstName.IsMatch(FirstNameTextBox.Text) = False Then
            MessageBox.Show("First name has to be alphabets and must start with an upper case letter.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        '4. Validate if Last Name is empty or not
        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            MessageBox.Show("Last name field cannot be empty.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        ' Use regular expressions to check if the last name follows a right pattern.
        Dim rxLastName As New Regex("^[A-Z]+[a-z]+$")
        If rxLastName.IsMatch(LastNameTextBox.Text) = False Then
            MessageBox.Show("Last name has to be alphabets and must start with an upper case letter.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If


        '5. validate if customer phone number is empty or not
        If String.IsNullOrWhiteSpace(CustomerPhoneTextBox.Text) Then
            MessageBox.Show("The Phone field cannot be empty")
            CustomerPhoneTextBox.SelectAll()
            CustomerPhoneTextBox.Focus()
            Return False
        End If

        'Validate if customer phone number is in a valid range.
        Dim rxCustomerPhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxCustomerPhone.IsMatch(CustomerPhoneTextBox.Text) = False Then
            MessageBox.Show("Phone must follow the format 999-999-9999")
            CustomerPhoneTextBox.SelectAll()
            CustomerPhoneTextBox.Focus()
            Return False
        End If

        '6. Validate email
        'Check if email field is empty
        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            MessageBox.Show("Email field cannot be empty.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False
        End If
        'Use regular expressions to check if email follows a right pattern
        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")
        If rxEmail.IsMatch(EmailTextBox.Text) = False Then
            MessageBox.Show("Email must follow the format abc@xyz.com")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False

        End If


        '7. Validate if gender is empty or not
        If GenderListBox.SelectedIndex = True Then
            MessageBox.Show("Please select an option for gender.")
            GenderListBox.Select()
            GenderListBox.Focus()
            Return False
        End If


        'Validate gender field as Input
        '8. validate if gender is empty or not
        If String.IsNullOrWhiteSpace(DOBTextBox.Text) Then
            MessageBox.Show("Date of birth cannot be empty")
            DOBTextBox.SelectAll()
            DOBTextBox.Focus()
            Return False
        End If
        'Validate if date of birth is in a valid range.
        Dim rxDob As New Regex("(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")
        If rxDob.IsMatch(DOBTextBox.Text) = False Then
            MessageBox.Show("Date of birth must follow format yyyy/mm/dd.")
            DOBTextBox.SelectAll()
            DOBTextBox.Focus()
            Return False
        End If

        '9. Validate Social security number field
        Dim rxSSN As New Regex("^\d{3}-\d{2}-\d{4}$")
        If String.IsNullOrEmpty(SSNTextBox.Text) = False Then
            If rxSSN.IsMatch(SSNTextBox.Text) = False Then
                MessageBox.Show("Social Security Number must be numeric and follow format like 000-00-0000")
                SSNTextBox.SelectAll()
                SSNTextBox.Focus()
                Return False
            End If
        End If

        '10. Validate if Address field is empty or not
        If String.IsNullOrWhiteSpace(AddressTextBox.Text) Then
            MessageBox.Show("The address field cannot be empty")
            AddressTextBox.SelectAll()
            AddressTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the address follows a right pattern.
        Dim rxAddress1 As New Regex("[0-9a-zA-Z]+")
        If rxAddress1.IsMatch(AddressTextBox.Text) = False Then
            MessageBox.Show("Address must begin with a number followed by alphabets.")
            AddressTextBox.SelectAll()
            AddressTextBox.Focus()
            Return False
        End If

        '11. Validate Address 2 field
        Dim rxAddress2 As New Regex("[a-zA-Z0-9-]+")
        If String.IsNullOrEmpty(Address2TextBox.Text) = False Then
            If rxAddress2.IsMatch(Address2TextBox.Text) = False Then
                MessageBox.Show("Address line 2 cannot be empty and should follow format like apartment or building number")
                Address2TextBox.SelectAll()
                Address2TextBox.Focus()
                Return False
            End If
        End If

        '12. validate if city is empty or not
        If String.IsNullOrWhiteSpace(CityTextBox.Text) Then
            MessageBox.Show("The city field cannot be empty")
            CityTextBox.SelectAll()
            CityTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the city follows a right pattern.
        Dim rxCity As New Regex("^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$")
        If rxCity.IsMatch(CityTextBox.Text) = False Then
            MessageBox.Show("City must be alphabets.")
            CityTextBox.SelectAll()
            CityTextBox.Focus()
            Return False
        End If


        '13. Validate if state is empty or not
        If StateListBox.SelectedIndex = True Then
            MessageBox.Show("Please select an option for state.")
            StateListBox.Select()
            StateListBox.Focus()
            Return False
        End If

        '14. validate if zip code field is empty or not
        If String.IsNullOrWhiteSpace(ZipCodeTextBox.Text) Then
            MessageBox.Show("The zip code field cannot be empty")
            ZipCodeTextBox.SelectAll()
            ZipCodeTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the zip code follows a right pattern.
        Dim rxZipCode As New Regex("^[0-9]{5}(?:-[0-9]{4})?$")
        If rxZipCode.IsMatch(ZipCodeTextBox.Text) = False Then
            MessageBox.Show("Zip code must be five digits.")
            ZipCodeTextBox.SelectAll()
            ZipCodeTextBox.Focus()
            Return False
        End If

        '15. Validate the employer field
        Dim rxEmployer As New Regex("^[a-zA-Z\s]+$")
        If String.IsNullOrEmpty(EmployerTextBox.Text) = False Then
            If rxEmployer.IsMatch(EmployerTextBox.Text) = False Then
                MessageBox.Show("The employer field cannot be empty and must be alphabets.")
                EmployerTextBox.SelectAll()
                EmployerTextBox.Focus()
                Return False
            End If
        End If

        '16. Validate the vehicle make field
        Dim rxVehiclemake As New Regex("^[a-zA-Z\s]+$")
        If String.IsNullOrEmpty(VehicleMakeTextBox.Text) = False Then
            If rxVehiclemake.IsMatch(VehicleMakeTextBox.Text) = False Then
                MessageBox.Show("The vehicle make field cannot be empty and must alphabets.")
                VehicleMakeTextBox.SelectAll()
                VehicleMakeTextBox.Focus()
                Return False
            End If
        End If

        '17. Validate the vehicle plate number field
        Dim rxVehiclePlate As New Regex("^[A-Za-z]{1,3}-[A-Za-z]{1,2}-[0-9]{1,4}$")
        If String.IsNullOrEmpty(VehiclePlateNumberTextBox.Text) = False Then
            If rxVehiclePlate.IsMatch(VehiclePlateNumberTextBox.Text) = False Then
                MessageBox.Show("The vehicle plate number field cannot be empty and must be a combination of alphabets and numbers.")
                VehiclePlateNumberTextBox.SelectAll()
                VehiclePlateNumberTextBox.Focus()
                Return False
            End If
        End If

        '18. Validate the driver's license number field
        Dim rxLicense As New Regex("[^[A-Z]+[\d{12}0-9]+$")
        If String.IsNullOrEmpty(DriverLicenseTextBox.Text) = False Then
            If rxLicense.IsMatch(DriverLicenseTextBox.Text) = False Then
                MessageBox.Show("Drivers License should begin with an alphabet followed by 12 numeric values digits.")
                DriverLicenseTextBox.SelectAll()
                DriverLicenseTextBox.Focus()
                Return False
            End If
        End If

        '19. Validate if landlord's Name is empty or not
        If String.IsNullOrWhiteSpace(LandlordNameTextBox.Text) Then
            MessageBox.Show("Landlord's name cannot be empty.")
            LandlordNameTextBox.SelectAll()
            LandlordNameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the first name follows a right pattern.
        Dim rxLandlordName As New Regex("^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$")
        If rxLandlordName.IsMatch(LandlordNameTextBox.Text) = False Then
            MessageBox.Show("Landlord's name has to be alphabets.")
            LandlordNameTextBox.SelectAll()
            LandlordNameTextBox.Focus()
            Return False
        End If

        '20. validate if landlord's phone number is empty or not
        If String.IsNullOrWhiteSpace(LandlordPhoneTextBox.Text) Then
            MessageBox.Show("The landlord's phone field cannot be empty")
            LandlordPhoneTextBox.SelectAll()
            LandlordPhoneTextBox.Focus()
            Return False
        End If

        'Validate if customer phone number is in a valid range.
        Dim rxLandlordPhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxLandlordPhone.IsMatch(LandlordPhoneTextBox.Text) = False Then
            MessageBox.Show("Phone must follow the format 999-999-9999")
            LandlordPhoneTextBox.SelectAll()
            LandlordPhoneTextBox.Focus()
            Return False
        End If

        '21. Validate if reference 1 Name field is empty or not
        If String.IsNullOrWhiteSpace(Reference1NameTextBox.Text) Then
            MessageBox.Show("The first reference's name cannot be empty.")
            Reference1NameTextBox.SelectAll()
            Reference1NameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the first name follows a right pattern.
        Dim rxReference1Name As New Regex("^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$")
        If rxReference1Name.IsMatch(Reference1NameTextBox.Text) = False Then
            MessageBox.Show("The first reference's name has to be alphabets.")
            Reference1NameTextBox.SelectAll()
            Reference1NameTextBox.Focus()
            Return False
        End If

        '22. validate if refernce 1's phone number is empty or not
        If String.IsNullOrWhiteSpace(Reference1PhoneTextBox.Text) Then
            MessageBox.Show("The first reference phone field cannot be empty")
            Reference1PhoneTextBox.SelectAll()
            Reference1PhoneTextBox.Focus()
            Return False
        End If

        'Validate if reference 1 phone number is in a valid range.
        Dim rxReference1Phone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxReference1Phone.IsMatch(Reference1PhoneTextBox.Text) = False Then
            MessageBox.Show("The first reference phone number must follow the format 999-999-9999")
            Reference1PhoneTextBox.SelectAll()
            Reference1PhoneTextBox.Focus()
            Return False
        End If


        '23. Validate if reference 2 Name field is empty or not
        If String.IsNullOrWhiteSpace(Reference2NameTextBox.Text) Then
            MessageBox.Show("The second reference's name field cannot be empty.")
            Reference2NameTextBox.SelectAll()
            Reference2NameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the refernce 2 name follows a right pattern.
        Dim rxReference2Name As New Regex("^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$")
        If rxReference2Name.IsMatch(Reference2NameTextBox.Text) = False Then
            MessageBox.Show("The second reference's name has to be alphabets.")
            Reference2NameTextBox.SelectAll()
            Reference2NameTextBox.Focus()
            Return False
        End If

        '24. validate if reference 2's phone number is empty or not
        If String.IsNullOrWhiteSpace(Reference2PhoneTextBox.Text) Then
            MessageBox.Show("The second reference phone field cannot be empty")
            Reference2PhoneTextBox.SelectAll()
            Reference2PhoneTextBox.Focus()
            Return False
        End If

        'Validate if reference 2 phone number is in a valid range.
        Dim rxReference2Phone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxReference2Phone.IsMatch(Reference2PhoneTextBox.Text) = False Then
            MessageBox.Show("The second reference phone number must follow the format 999-999-9999")
            Reference2PhoneTextBox.SelectAll()
            Reference2PhoneTextBox.Focus()
            Return False
        End If


        '25. Validate if emergency contact Name field is empty or not
        If String.IsNullOrWhiteSpace(EmergencyContactNameTextBox.Text) Then
            MessageBox.Show("Emergency contact name field cannot be empty.")
            EmergencyContactNameTextBox.SelectAll()
            EmergencyContactNameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the Emergency contact name follows a right pattern.
        Dim rxEmergencyContactName As New Regex("^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$")
        If rxEmergencyContactName.IsMatch(EmergencyContactNameTextBox.Text) = False Then
            MessageBox.Show("Emergency contact name must be alphabets.")
            EmergencyContactNameTextBox.SelectAll()
            EmergencyContactNameTextBox.Focus()
            Return False
        End If

        '26. validate if emergency's phone number is empty or not
        If String.IsNullOrWhiteSpace(EmergencyContactPhoneTextBox.Text) Then
            MessageBox.Show("The emergency contact phone field cannot be empty")
            EmergencyContactPhoneTextBox.SelectAll()
            EmergencyContactPhoneTextBox.Focus()
            Return False
        End If

        'Validate if customer phone number is in a valid range.
        Dim rxEmergencyContactPhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxEmergencyContactPhone.IsMatch(EmergencyContactPhoneTextBox.Text) = False Then
            MessageBox.Show("The first reference phone number must follow the format 999-999-9999")
            EmergencyContactPhoneTextBox.SelectAll()
            EmergencyContactPhoneTextBox.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(LeaseDurationTextBox.Text) Then
            MessageBox.Show("Lease duration cannot be empty")
            LeaseDurationTextBox.SelectAll()
            LeaseDurationTextBox.Focus()
            Return False
        End If

        'checking if the lease duration follows the right pattern.
        Dim rxlease As New Regex("^[0-9]+$")
        If rxlease.IsMatch(LeaseDurationTextBox.Text) = False Then
            MessageBox.Show("Lease duration must be digits")
            LeaseDurationTextBox.SelectAll()
            LeaseDurationTextBox.Focus()
            Return False
        End If


        'Validate preffered start date is after the available date
        If DateDiff("d", AvailableFromDateTimePicker.Value, PrefferedStartDateTimePicker.Value) < 0 Then
            MessageBox.Show("Preferred starting date must be equal or after the available date")
            PrefferedStartDateTimePicker.Focus()
            Return False
        End If

        Return True
    End Function
    Private Function DuplicateEmail() As Boolean
        DB.AddParam("@email", EmailTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM customer WHERE email = ?")
        If DB.RecordCount > 0 Then
            MessageBox.Show("The email address already exists, please login to your account to complete application.")
            Return True
        End If
        Return False
    End Function
    Private Function DuplicateUser() As Boolean
        DB.AddParam("@user_name", UserNameTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM customer WHERE username = ?")
        If DB.RecordCount > 0 Then
            MessageBox.Show("The username is already taken, please use another username.")
            Return True
        End If
        Return False
    End Function

End Class