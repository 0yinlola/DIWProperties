Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class NewEmployeeForm
    Private DB As New DBAccess
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub ClearForm()
        UserNameTextBox.Clear()
        PasswordTextBox.Clear()
        FirstNameTextBox.Clear()
        LastNameTextBox.Clear()
        EmployeePhoneTextBox.Clear()
        EmailTextBox.Clear()
        GenderListBox.ClearSelected()
        DOBTextBox.Clear()
        SSNTextBox.Clear()
        AddressTextBox.Clear()
        Address2TextBox.Clear()
        CityTextBox.Clear()
        StateListBox.ClearSelected()
        ZipCodeTextBox.Clear()
        StartDateTextBox.Clear()
        EndDateTextBox.Clear()
        EmergencyContactNameTextBox.Clear()
        EmergencyContactPhoneTextBox.Clear()
        EmployeeClassListBox.ClearSelected()
        ActiveCheckBox.Enabled = False
        ActiveCheckBox.Checked = True
        CreateDateTimePicker.Value = Today.Date
        LastUpdateDateTimePicker.Value = Today.Date
    End Sub

    Private Sub ApplicationForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearForm()
    End Sub

    Private Sub AddEmployee()
        DB.AddParam("@username", UserNameTextBox.Text)   '1st Parameter
        DB.AddParam("@password", PasswordTextBox.Text)  '2nd Parameter
        DB.AddParam("@firstname", FirstNameTextBox.Text)  '3rd Parameter
        DB.AddParam("@lastname", LastNameTextBox.Text)   '4th
        DB.AddParam("@employee_phone", EmployeePhoneTextBox.Text)   '5th
        DB.AddParam("@email", EmailTextBox.Text)          '6th parameter
        DB.AddParam("@gender", GenderListBox.SelectedItem)   '7th
        DB.AddParam("@DOB", DOBTextBox.Text)  '8th
        If String.IsNullOrEmpty(SSNTextBox.Text) Then 'because social security number field is optional
            DB.AddParam("@social_security", DBNull.Value)
        Else
            DB.AddParam("@social_security", SSNTextBox.Text)          '9th
        End If
        DB.AddParam("@street_1", AddressTextBox.Text)       '10th
        If String.IsNullOrEmpty(Address2TextBox.Text) Then 'because Address 2 field is optional
            DB.AddParam("@street_2", DBNull.Value)
        Else
            DB.AddParam("@street_2", Address2TextBox.Text)          '11th
        End If
        DB.AddParam("@city", CityTextBox.Text)                      '12th
        DB.AddParam("@state", StateListBox.SelectedItem)      '13th
        DB.AddParam("@zip_code", ZipCodeTextBox.Text)                 '14th
        DB.AddParam("@start_date", StartDateTextBox.Text) '15th
        If String.IsNullOrEmpty(EndDateTextBox.Text) Then '16th
            DB.AddParam("@end_date", DBNull.Value)
        Else
            DB.AddParam("end_date", EndDateTextBox.Text)
        End If
        DB.AddParam("@emergency_name", EmergencyContactNameTextBox.Text)    '17th
        DB.AddParam("@emergency_phone", EmergencyContactPhoneTextBox.Text)    '18th
        DB.AddParam("@employee_class", EmployeeClassListBox.SelectedItem) '19th
        DB.AddParam("@active", ActiveCheckBox.Checked)     '20th
        DB.AddParam("@createdate", CreateDateTimePicker.Value) '21st
        DB.AddParam("@lastupdate", LastUpdateDateTimePicker.Value) '22nd

        DB.ExecuteQuery("INSERT into 
employee(username, user_password, first_name, last_name, phone_number, email, gender, DOB, social_security_number, 
street_1, street_2, city, state, zip_code, start_date, end_date, emergency_contact_full_name, emergency_contact_phone_number, employee_classification, is_active, create_date, last_update) 
        VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A New Employee Record has been added successfully.")
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        If ValidateEmployeeData() = False Then
            Exit Sub
        ElseIf DuplicateEmployee() = True Then
            Exit Sub
        End If

        AddEmployee()
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearForm()
    End Sub

    Private Function ValidateEmployeeData() As Boolean
        'Validate Username as Input
        '1. Validate if username is empty or not
        If String.IsNullOrWhiteSpace(UserNameTextBox.Text) Then
            MessageBox.Show("The Username Field cannot be empty")
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
            MessageBox.Show("The Password field cannot be empty")
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
            MessageBox.Show("The First Name field cannot be empty.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        'Use regular expressions to check if the first name follows a right pattern.
        Dim rxFirstName As New Regex("^[A-Z]+[a-z]+$")
        If rxFirstName.IsMatch(FirstNameTextBox.Text) = False Then
            MessageBox.Show("First Name has to be alphabets and must start with an upper case letter.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        '4. Validate if Last Name is empty or not
        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            MessageBox.Show("The Last Name field cannot be empty.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If

        ' Use regular expressions to check if the last name follows a right pattern.
        Dim rxLastName As New Regex("^[A-Z]+[a-z]+$")
        If rxLastName.IsMatch(LastNameTextBox.Text) = False Then
            MessageBox.Show("Last Name has to be alphabets and must start with an upper case letter.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()
            Return False
        End If


        '5. validate if Employee phone number is empty or not
        If String.IsNullOrWhiteSpace(EmployeePhoneTextBox.Text) Then
            MessageBox.Show("The Phone Number field cannot be empty")
            EmployeePhoneTextBox.SelectAll()
            EmployeePhoneTextBox.Focus()
            Return False
        End If

        'Validate if Employee phone number is in a valid range.
        Dim rxEmployeePhone As New Regex("\d{3}-\d{3}-\d{4}")
        If rxEmployeePhone.IsMatch(EmployeePhoneTextBox.Text) = False Then
            MessageBox.Show("Phone Number must follow the format 999-999-9999")
            EmployeePhoneTextBox.SelectAll()
            EmployeePhoneTextBox.Focus()
            Return False
        End If

        '6. Validate email
        'Check if email field is empty
        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            MessageBox.Show("The Email field cannot be empty.")
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
            MessageBox.Show("A Gender option must be selected.")
            GenderListBox.Select()
            GenderListBox.Focus()
            Return False
        End If


        'Validate gender field as Input
        '8. validate if gender is empty or not
        If String.IsNullOrWhiteSpace(DOBTextBox.Text) Then
            MessageBox.Show("The Date of Birth field cannot be empty")
            DOBTextBox.SelectAll()
            DOBTextBox.Focus()
            Return False
        End If

        'Validate if date of birth is in a valid range.
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
                MessageBox.Show("The Social Security Number must be numeric and follow format like 000-00-0000")
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
                MessageBox.Show("Address Line 2 cannot be empty and should follow format like apartment or building number")
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
            MessageBox.Show("Select an option for state.")
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
            MessageBox.Show("The Emergency contact name field cannot be empty.")
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
    Private Function DuplicateEmployee() As Boolean
        DB.AddParam("@firstname", FirstNameTextBox.Text)
        DB.AddParam("@lastname", LastNameTextBox.Text)
        DB.AddParam("@birthday", DOBTextBox.Text)
        DB.ExecuteQuery("SELECT * FROM employee WHERE first_name = ? AND last_name = ? AND DOB = ?")
        If DB.RecordCount > 0 Then
            MessageBox.Show("The User already exists.")
            Return True
        End If
        Return False
    End Function

End Class