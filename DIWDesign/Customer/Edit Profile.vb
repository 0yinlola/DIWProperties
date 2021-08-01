Imports System.Text.RegularExpressions
Public Class EditProfile
    Private DB As New DBAccess
    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(ActiveUser.User_id) Then
            Me.Close()
        Else
            DB.AddParam("@customerID", ActiveUser.User_id)
            DB.ExecuteQuery("SELECT customer_id, username, first_name, last_name, phone_number, email, gender, DOB, social_security_number, employer, vehicle_make, vehicle_plate_number, driver_license, reference_1_full_name, reference_1_phone_number, reference_2_full_name, reference_2_phone_number, emergency_contact_full_name, emergency_contact_phone_number FROM customer WHERE customer_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If

        CustomerIDTextBox.Text = DB.DBDataTable(0)("customer_id")
        UserNameTextBox.Text = DB.DBDataTable(0)!username
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        CustomerPhoneTextBox.Text = DB.DBDataTable(0)!phone_number
        EmailTextBox.Text = DB.DBDataTable(0)!email
        GenderListBox.SelectedIndex = GenderListBox.FindStringExact(DB.DBDataTable(0)!gender)
        DOBDateTimePicker.Value = DB.DBDataTable(0)!DOB

        If IsDBNull(DB.DBDataTable(0)!social_security_number) Then 'Do this type of check for each optional field.
            'do not assign this field's null value to the form control
        Else

            SSNTextBox.Text = DB.DBDataTable(0)!social_security_number
        End If
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
        Reference1NameTextBox.Text = DB.DBDataTable(0)!reference_1_full_name
        Reference1PhoneTextBox.Text = DB.DBDataTable(0)!reference_1_phone_number
        Reference2NameTextBox.Text = DB.DBDataTable(0)!reference_2_full_name
        Reference2PhoneTextBox.Text = DB.DBDataTable(0)!reference_2_phone_number
        EmergencyContactNameTextBox.Text = DB.DBDataTable(0)!emergency_contact_full_name
        EmergencyContactPhoneTextBox.Text = DB.DBDataTable(0)!emergency_contact_phone_number



        EnableFieldsToEdit(False)
    End Sub

    Private Sub EnableFieldsToEdit(Switch As Boolean)
        CustomerIDTextBox.ReadOnly = True
        UserNameTextBox.ReadOnly = True
        FirstNameTextBox.ReadOnly = True
        LastNameTextBox.ReadOnly = True
        CustomerPhoneTextBox.ReadOnly = Not Switch
        EmailTextBox.ReadOnly = True
        GenderListBox.Enabled = Switch
        DOBDateTimePicker.Enabled = False
        SSNTextBox.ReadOnly = True
        EmployerTextBox.ReadOnly = Not Switch
        VehicleMakeTextBox.ReadOnly = Not Switch
        VehiclePlateNumberTextBox.ReadOnly = Not Switch
        DriverLicenseTextBox.ReadOnly = True
        Reference1NameTextBox.ReadOnly = Not Switch
        Reference1PhoneTextBox.ReadOnly = Not Switch
        Reference2NameTextBox.ReadOnly = Not Switch
        Reference2PhoneTextBox.ReadOnly = Not Switch
        EmergencyContactNameTextBox.ReadOnly = Not Switch
        EmergencyContactPhoneTextBox.ReadOnly = Not Switch



        If Switch = True Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub

    Private Sub UpdateCustomer()
        DB.AddParam("@username", UserNameTextBox.Text)   '1st Parameter
        DB.AddParam("@firstname", FirstNameTextBox.Text)  '3rd Parameter
        DB.AddParam("@lastname", LastNameTextBox.Text)   '4th
        DB.AddParam("@customer_phone", CustomerPhoneTextBox.Text)   '5th
        DB.AddParam("@email", EmailTextBox.Text)          '6th parameter
        DB.AddParam("@gender", GenderListBox.SelectedItem)   '7th
        DB.AddParam("@birthday", DOBDateTimePicker.Value)  '8th
        If String.IsNullOrEmpty(SSNTextBox.Text) Then 'because social security number field is optional
            DB.AddParam("@social_security", DBNull.Value)
        Else
            DB.AddParam("@social_security", SSNTextBox.Text)          '9th
        End If
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
        DB.AddParam("@reference1_name", Reference1NameTextBox.Text)              '21st
        DB.AddParam("@reference1_phone", Reference1PhoneTextBox.Text)            '22nd
        DB.AddParam("@reference2_name", Reference2NameTextBox.Text)               '23rd
        DB.AddParam("@reference2_phone", Reference2PhoneTextBox.Text)              '24th
        DB.AddParam("@emergency_name", EmergencyContactNameTextBox.Text)    '25th
        DB.AddParam("@emergency_phone", EmergencyContactPhoneTextBox.Text)    '26th
        DB.AddParam("@customerID", CustomerIDTextBox.Text)   '29th

        DB.ExecuteQuery("UPDATE customer SET username =?, first_name=?, last_name=?, phone_number=?, email=?, gender=?, DOB=?, social_security_number=?, employer=?, vehicle_make=?, vehicle_plate_number=?, driver_license=?, reference_1_full_name=?, reference_1_phone_number=?, reference_2_full_name=?, reference_2_phone_number=?,emergency_contact_full_name=?, emergency_contact_phone_number=? WHERE customer_id =?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("Your record has been updated successfully.")

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

End Class