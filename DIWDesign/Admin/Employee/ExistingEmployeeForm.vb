Imports System.Text.RegularExpressions
Public Class ExistingEmployeeForm
    Private DB As New DBAccess

    Friend Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(EmployeeForm.EmployeeIDTextBox.Text) Then
            MessageBox.Show("No Employee is selected. Try again.")
            Me.Close()
        Else
            DB.AddParam("@employeeID", EmployeeForm.EmployeeIDTextBox.Text)
            DB.ExecuteQuery("SELECT * FROM employee WHERE employee_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If

        EmployeeIDTextBox.Text = DB.DBDataTable(0)("employee_id")
        UserNameTextBox.Text = DB.DBDataTable(0)!username
        PasswordTextBox.Text = DB.DBDataTable(0)!user_password
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        EmployeePhoneTextBox.Text = DB.DBDataTable(0)!phone_number
        EmailTextBox.Text = DB.DBDataTable(0)!email
        GenderListBox.SelectedIndex = GenderListBox.FindStringExact(DB.DBDataTable(0)!gender)
        DOBTextBox.Text = DB.DBDataTable(0)!DOB

        If IsDBNull(DB.DBDataTable(0)!social_security_number) Then 'Do this type of check for each optional field.
            'Do not assign this field's null value to the form control
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
        StartDateTextBox.Text = DB.DBDataTable(0)!start_date
        'EndDateTextBox.Text = DB.DBDataTable(0)!end_date
        EmergencyContactNameTextBox.Text = DB.DBDataTable(0)!emergency_contact_full_name
        EmergencyContactPhoneTextBox.Text = DB.DBDataTable(0)!emergency_contact_phone_number
        EmployeeClassListBox.SelectedIndex = EmployeeClassListBox.FindStringExact(DB.DBDataTable(0)!employee_classification)
        ActiveCheckBox.Checked = DB.DBDataTable(0)!is_active
        CreateDateTimePicker.Value = DB.DBDataTable(0)!create_date
        LastUpdateDateTimePicker.Value = DB.DBDataTable(0)!last_update

        EnableFieldsToEdit(False)
    End Sub

    Private Sub EnableFieldsToEdit(Switch As Boolean)
        EmployeeIDTextBox.ReadOnly = True
        UserNameTextBox.ReadOnly = True
        PasswordTextBox.ReadOnly = Not Switch
        FirstNameTextBox.ReadOnly = Not Switch
        LastNameTextBox.ReadOnly = Not Switch
        EmployeePhoneTextBox.ReadOnly = Not Switch
        EmailTextBox.ReadOnly = True
        GenderListBox.Enabled = Switch
        DOBTextBox.ReadOnly = True
        SSNTextBox.ReadOnly = True
        AddressTextBox.ReadOnly = Not Switch
        Address2TextBox.ReadOnly = Not Switch
        CityTextBox.ReadOnly = Not Switch
        StateListBox.Enabled = Switch
        ZipCodeTextBox.ReadOnly = Not Switch
        StartDateTextBox.ReadOnly = True
        EndDateTextBox.ReadOnly = Not Switch
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

    Private Sub UpdateEmployee()

        DB.AddParam("@password", PasswordTextBox.Text)  '1st Parameter
        DB.AddParam("@firstname", FirstNameTextBox.Text)  '2nd Parameter
        DB.AddParam("@lastname", LastNameTextBox.Text)   '3rd
        DB.AddParam("@employee_phone", EmployeePhoneTextBox.Text)   '4th
        DB.AddParam("@gender", GenderListBox.SelectedItem)
        DB.AddParam("@street_1", AddressTextBox.Text)       '5th
        If String.IsNullOrEmpty(Address2TextBox.Text) Then 'because Address 2 field is optional
            DB.AddParam("@street_2", DBNull.Value)
        Else
            DB.AddParam("@street_2", Address2TextBox.Text)          '6th
        End If
        DB.AddParam("@city", CityTextBox.Text)                      '7th
        DB.AddParam("@state", StateListBox.SelectedItem)      '8th
        DB.AddParam("@zip_code", ZipCodeTextBox.Text)                 '9th
        If String.IsNullOrEmpty(EndDateTextBox.Text) Then 'because End Date field is optional
            DB.AddParam("@end_date", DBNull.Value)
        Else
            DB.AddParam("@end_date", EndDateTextBox.Text)          '10th
        End If
        DB.AddParam("@emergency_name", EmergencyContactNameTextBox.Text)    '11th
        DB.AddParam("@emergency_phone", EmergencyContactPhoneTextBox.Text)    '12th
        DB.AddParam("@employee_classification", EmployeeClassListBox.SelectedItem) '13th
        DB.AddParam("@active", ActiveCheckBox.Checked)     '14th

        DB.AddParam("@last_update", Today.Date) '15th

        DB.AddParam("@employee_id", EmployeeIDTextBox.Text) '16th

        DB.ExecuteQuery("UPDATE employee SET user_password=?, first_name=?, last_name=?, phone_number=?, gender=?, street_1=?, street_2=?, city=?, state=?, zip_code=?, end_date=?, emergency_contact_full_name=?, emergency_contact_phone_number=?, employee_classification=?, is_active=?, last_update=? WHERE employee_id=?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("The Employee " & FirstNameTextBox.Text & " " & LastNameTextBox.Text & "'s record has been updated successfully.")

    End Sub


    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            'Edit mode
            'Release fields for editing
            EnableFieldsToEdit(True)
            EditSaveButton.Text = "&Save"
        Else
            'Save mode
            'Update the Employee
            UpdateEmployee()
            EditSaveButton.Text = "&Edit"

            'Restore editing mode
            EnableFieldsToEdit(False)
        End If
        EmployeeForm.SearchEmpolyees(FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub

    Private Function ValidateExistingEmployeeData() As Boolean
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

        Dim rxPassword As New Regex("^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$")
        If rxPassword.IsMatch(PasswordTextBox.Text) = False Then
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


        '5. validate if Employee phone number is empty or not
        If String.IsNullOrWhiteSpace(EmployeePhoneTextBox.Text) Then
            MessageBox.Show("The Phone field cannot be empty")
            EmployeePhoneTextBox.SelectAll()
            EmployeePhoneTextBox.Focus()
            Return False
        End If

        'Validate if Employee phone number is in a valid range.
        Dim rxEmployeePhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxEmployeePhone.IsMatch(EmployeePhoneTextBox.Text) = False Then
            MessageBox.Show("Phone must follow the format 999-999-9999")
            EmployeePhoneTextBox.SelectAll()
            EmployeePhoneTextBox.Focus()
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


        '7. Validate if Gender is empty or not
        If GenderListBox.SelectedIndex = True Then
            MessageBox.Show("Please select an option for gender.")
            GenderListBox.Select()
            GenderListBox.Focus()
            Return False
        End If


        'Validate gender field as Input
        '8. validate if gender is empty or not
        If String.IsNullOrWhiteSpace(DOBTextBox.Text) Then
            MessageBox.Show("Date of Birth cannot be empty")
            DOBTextBox.SelectAll()
            DOBTextBox.Focus()
            Return False
        End If

        'Validate If date of birth is in a valid range.
        Dim rxDob As New Regex("(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")
        If rxDob.IsMatch(DOBTextBox.Text) = False Then
            MessageBox.Show("Date of Birth must follow format yyyy/mm/dd.")
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
            MessageBox.Show("The Address field cannot be empty")
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
            MessageBox.Show("The City field cannot be empty")
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
            MessageBox.Show("The Zipcode field cannot be empty")
            ZipCodeTextBox.SelectAll()
            ZipCodeTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the zip code follows a right pattern.
        Dim rxZipCode As New Regex("^[0-9]{5}(?:-[0-9]{4})?$")
        If rxZipCode.IsMatch(ZipCodeTextBox.Text) = False Then
            MessageBox.Show("Zipcode must be five digits.")
            ZipCodeTextBox.SelectAll()
            ZipCodeTextBox.Focus()
            Return False
        End If

        '14. Validate if state is empty or not
        If EmployeeClassListBox.SelectedIndex = True Then
            MessageBox.Show("Please select an option for Employee Class.")
            EmployeeClassListBox.Select()
            EmployeeClassListBox.Focus()
            Return False
        End If

        '15. Validate if emergency contact Name field is empty or not
        If String.IsNullOrWhiteSpace(EmergencyContactNameTextBox.Text) Then
            MessageBox.Show("Emergency contact name field cannot be empty.")
            EmergencyContactNameTextBox.SelectAll()
            EmergencyContactNameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the Emergency contact name follows a right pattern.
        Dim rxEmergencyContactName As New Regex("^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$")
        If rxEmergencyContactName.IsMatch(EmergencyContactNameTextBox.Text) = False Then
            MessageBox.Show("Emergency contact name must be Alphabets.")
            EmergencyContactNameTextBox.SelectAll()
            EmergencyContactNameTextBox.Focus()
            Return False
        End If

        '16. validate if emergency's phone number is empty or not
        If String.IsNullOrWhiteSpace(EmergencyContactPhoneTextBox.Text) Then
            MessageBox.Show("The Emergency Contact Phone field cannot be empty")
            EmergencyContactPhoneTextBox.SelectAll()
            EmergencyContactPhoneTextBox.Focus()
            Return False
        End If

        'Validate if Employee phone number is in a valid range.
        Dim rxEmergencyContactPhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxEmergencyContactPhone.IsMatch(EmergencyContactPhoneTextBox.Text) = False Then
            MessageBox.Show("The Emergency Contact's Phone Number must follow the format 999-999-9999")
            EmergencyContactPhoneTextBox.SelectAll()
            EmergencyContactPhoneTextBox.Focus()
            Return False
        End If

        '17. Validate if Start date is in a valid range.
        Dim rxStartDate As New Regex("(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")
        If rxStartDate.IsMatch(StartDateTextBox.Text) = False Then
            MessageBox.Show("Start Date must follow format yyyy/mm/dd.")
            StartDateTextBox.SelectAll()
            StartDateTextBox.Focus()
            Return False
        End If

        '18. Validate if End date is in a valid range.
        Dim rxEndDate As New Regex("(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")
        If String.IsNullOrEmpty(EndDateTextBox.Text) = False Then
            If rxEndDate.IsMatch(EndDateTextBox.Text) = False Then
                MessageBox.Show("End Date must follow format yyyy/mm/dd.")
                EndDateTextBox.SelectAll()
                EndDateTextBox.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class