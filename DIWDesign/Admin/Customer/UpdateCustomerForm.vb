Imports System.Text.RegularExpressions
Public Class CustomerProfileForm
    Private DB As New DBAccess

    Private Sub UpdateCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        If String.IsNullOrEmpty(CustomerForm.CustomerIDTextBox.Text) Then
            MessageBox.Show("No customer is selected. Try again.")
            Me.Close()
        Else
            DB.AddParam("@customerID", CustomerForm.CustomerIDTextBox.Text)
            DB.ExecuteQuery("SELECT * FROM customer WHERE customer_id =?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If

        CustomerIDTextBox.Text = DB.DBDataTable(0)("customer_id")
        UserNameTextBox.Text = DB.DBDataTable(0)!username
        PasswordTextBox.Text = DB.DBDataTable(0)!user_password
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        CustomerPhoneTextBox.Text = DB.DBDataTable(0)!phone_number
        EmailTextBox.Text = DB.DBDataTable(0)!email
        GenderListBox.SelectedIndex = GenderListBox.FindStringExact(DB.DBDataTable(0)!gender)
        DOBTextBox.Text = DB.DBDataTable(0)!DOB

        If IsDBNull(DB.DBDataTable(0)!social_security_number) Then 'Do this type of check for each optional field.
            'do not assign this field's null value to the form control
        Else

            SSNTextBox.Text = DB.DBDataTable(0)!social_security_number
        End If
        AddressTextBox.Text = DB.DBDataTable(0)!street_1

        If IsDBNull(DB.DBDataTable(0)!street_2) Then
        Else

            Address2TextBox.Text = DB.DBDataTable(0)!street_2

        End If
        CityTextBox.Text = DB.DBDataTable(0)!city
        StateListBox.SelectedIndex = StateListBox.FindStringExact(DB.DBDataTable(0)!state)
        ZipCodeTextBox.Text = DB.DBDataTable(0)!zip_code
        If IsDBNull(DB.DBDataTable(0)!employer) Then
        Else

            EmployerTextBox.Text = DB.DBDataTable(0)!employer
        End If
        If IsDBNull(DB.DBDataTable(0)!vehicle_make) Then
        Else

            VehicleMakeTextBox.Text = DB.DBDataTable(0)!vehicle_make
        End If

        If IsDBNull(DB.DBDataTable(0)!vehicle_plate_number) Then
        Else
            VehiclePlateNumberTextBox.Text = DB.DBDataTable(0)!vehicle_plate_number
        End If
        If IsDBNull(DB.DBDataTable(0)!driver_license) Then
        Else
            DriverLicenseTextBox.Text = DB.DBDataTable(0)!driver_license
        End If
        LandlordNameTextBox.Text = DB.DBDataTable(0)!previous_landlord_name
        LandlordPhoneTextBox.Text = DB.DBDataTable(0)!previous_landlord_phone_number
        Reference1NameTextBox.Text = DB.DBDataTable(0)!reference_1_full_name
        Reference1PhoneTextBox.Text = DB.DBDataTable(0)!reference_1_phone_number
        Reference2NameTextBox.Text = DB.DBDataTable(0)!reference_2_full_name
        Reference2PhoneTextBox.Text = DB.DBDataTable(0)!reference_2_phone_number
        EmergencyContactNameTextBox.Text = DB.DBDataTable(0)!emergency_contact_full_name
        EmergencyContactPhoneTextBox.Text = DB.DBDataTable(0)!emergency_contact_phone_number
        ActiveCheckBox.Checked = DB.DBDataTable(0)!is_active
        CreateDateTimePicker.Value = DB.DBDataTable(0)!create_date
        LastUpdateDateTimePicker.Value = DB.DBDataTable(0)!last_update

        EnableFieldsToEdit(False)
    End Sub

    Private Sub EnableFieldsToEdit(Switch As Boolean)
        CustomerIDTextBox.ReadOnly = True
        RetypePasswordTextBox.ReadOnly = True
        UserNameTextBox.ReadOnly = True
        PasswordTextBox.ReadOnly = True
        FirstNameTextBox.ReadOnly = Not Switch
        LastNameTextBox.ReadOnly = Not Switch
        CustomerPhoneTextBox.ReadOnly = Not Switch
        EmailTextBox.ReadOnly = True
        GenderListBox.Enabled = Switch
        DOBTextBox.ReadOnly = True
        SSNTextBox.ReadOnly = True
        AddressTextBox.ReadOnly = Not Switch
        Address2TextBox.ReadOnly = Not Switch
        CityTextBox.ReadOnly = Not Switch
        StateListBox.Enabled = Switch
        ZipCodeTextBox.ReadOnly = Not Switch
        EmployerTextBox.ReadOnly = Not Switch
        VehicleMakeTextBox.ReadOnly = Not Switch
        VehiclePlateNumberTextBox.ReadOnly = Not Switch
        DriverLicenseTextBox.ReadOnly = True
        LandlordNameTextBox.ReadOnly = Not Switch
        LandlordPhoneTextBox.ReadOnly = Not Switch
        Reference1NameTextBox.ReadOnly = Not Switch
        Reference1PhoneTextBox.ReadOnly = Not Switch
        Reference2NameTextBox.ReadOnly = Not Switch
        Reference2PhoneTextBox.ReadOnly = Not Switch
        EmergencyContactNameTextBox.ReadOnly = Not Switch
        EmergencyContactPhoneTextBox.ReadOnly = Not Switch
        ActiveCheckBox.Enabled = Switch
        CreateDateTimePicker.Enabled = False
        LastUpdateDateTimePicker.Enabled = False

        If Switch = True Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub

    Private Sub UpdateCustomer()
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
        DB.AddParam("@active", ActiveCheckBox.Checked)     '27th
        DB.AddParam("@createdate", CreateDateTimePicker.Value)   '28th
        DB.AddParam("@customerID", CustomerIDTextBox.Text)   '29th

        DB.ExecuteQuery("UPDATE customer SET username =?, user_password=?, first_name=?, last_name=?, phone_number=?, email=?, gender=?, DOB=?, social_security_number=?, street_1=?, street_2=?, city=?, state=?, zip_code=?, employer=?, vehicle_make=?, vehicle_plate_number=?, driver_license=?, previous_landlord_name=?, previous_landlord_phone_number=?, reference_1_full_name=?, reference_1_phone_number=?, reference_2_full_name=?, reference_2_phone_number=?,emergency_contact_full_name=?, emergency_contact_phone_number=?, is_active=? WHERE customer_id =?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The customer #" & FirstNameTextBox.Text & FirstNameTextBox.Text & "'s record has been updated successfully.")

    End Sub


    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            'edit mode
            'release fields for editing
            EnableFieldsToEdit(True)
            EditSaveButton.Text = "&Save"
        Else
            'save mode
            'update the customer
            UpdateCustomer()
            EditSaveButton.Text = "&Edit"
            'restore back to the editing mode
            EnableFieldsToEdit(False)
        End If
        'CustomerForm.SearchCustomers(CustomerForm.FirstNameTextBox.Text, CustomerForm.LastNameTextBox.Text)
    End Sub

    Private Function ValidateExistingCustomerData() As Boolean
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
        Dim rxEmployer As New Regex("^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$")
        If String.IsNullOrEmpty(EmployerTextBox.Text) = False Then
            If rxEmployer.IsMatch(EmployerTextBox.Text) = False Then
                MessageBox.Show("The employer field cannot be empty and must be alphabets.")
                EmployerTextBox.SelectAll()
                EmployerTextBox.Focus()
                Return False
            End If
        End If

        '16. Validate the vehicle make field
        Dim rxVehiclemake As New Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)")
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
            If rxVehiclemake.IsMatch(VehiclePlateNumberTextBox.Text) = False Then
                MessageBox.Show("The vehicle plate number field cannot be empty and must begin with an alphabet.")
                VehiclePlateNumberTextBox.SelectAll()
                VehiclePlateNumberTextBox.Focus()
                Return False
            End If
        End If

        '18. Validate the driver's license number field
        Dim rxLicense As New Regex("^[A-Z]{3}(\s)?[0-9]{4}$")
        If String.IsNullOrEmpty(DriverLicenseTextBox.Text) = False Then
            If rxLicense.IsMatch(DriverLicenseTextBox.Text) = False Then
                MessageBox.Show("The vehicle make field cannot be empty and must begin with an alphabet.")
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
            MessageBox.Show("The emergency contact's phone number must follow the format 999-999-9999")
            EmergencyContactPhoneTextBox.SelectAll()
            EmergencyContactPhoneTextBox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
End Class