Imports System.IO
Imports System.Text.RegularExpressions

Public Class MyProfile
    Private DB As New DbAccess

    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Data   
        LoadProfileData()
    End Sub

    Public Sub LoadProfileData()
        If String.IsNullOrWhiteSpace(ActiveUser.User_id) Then
            MessageBox.Show("Please Login.")
            Me.Close()
            LogInForm.Show()
        Else
            'ActiveUser.User_id = 1
            'ActiveUser.Role = 1
            Dim Type As String = ""
            Select Case ActiveUser.Role
                Case "1"
                    Type = "manager"
                Case "2"
                    Type = "employee"
                Case "3"
                    Type = "customer"
            End Select

            DB.AddParam("@user_id", ActiveUser.User_id)
            DB.AddParam("@role_name", Type)
            DB.ExecuteQuery("SELECT * FROM (
						SELECT employee_id user_id, first_name, last_name, employee_classification role_name, email email_address, phone_number contact_number, create_date created_on, last_update updated_on FROM employee
						) AS users 
						WHERE users.user_id = ? AND users.role_name = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            UserIDTextBox.Text = DB.DBDataTable(0)!user_id
            FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
            LastNameTextBox.Text = DB.DBDataTable(0)!last_name
            RoleNameTextBox.Text = DB.DBDataTable(0)!role_name
            EmailTextBox.Text = DB.DBDataTable(0)!email_address
            ContactNumberTextBox.Text = If(IsDBNull(DB.DBDataTable(0)!contact_number), String.Empty, DB.DBDataTable(0)!contact_number)
            MyProfileCreateDateTimePicker.Value = DB.DBDataTable(0)!created_on
            PasswordTextBox.Text = String.Empty
            ConfirmPasswordTextBox.Text = String.Empty
            MyProfilelastupdateTimePicker.Value = DB.DBDataTable(0)!updated_on

        End If
    End Sub

    Private Sub UpdateProfile()
        If ValidateProfileData() = False Then
            Exit Sub
        End If


        DB.AddParam("@Role", RoleNameTextBox.Text)
        DB.AddParam("@first_name", FirstNameTextBox.Text)
        DB.AddParam("@last_name", LastNameTextBox.Text)
        DB.AddParam("@email_address", EmailTextBox.Text)
        DB.AddParam("@contact_number", If(String.IsNullOrWhiteSpace(ContactNumberTextBox.Text), DBNull.Value, ContactNumberTextBox.Text))
        DB.AddParam("@password", PasswordTextBox.Text)
        DB.AddParam("@employee_id", ActiveUser.User_id)

        DB.ExecuteQuery("UPDATE employee set employee_classification=?, first_name=?, last_name=?, email=?, phone_number=?,user_password=? where employee_id=?")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("Profile data has been updated successfully.")

        LoadProfileData()
        EnableFieldsforEdit(False)

    End Sub

    Private Function ValidateProfileData() As Boolean

        'Validate first name
        'a: if first name is empty or not
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            MessageBox.Show("First Name cannot be empty.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        'b: if first name is non alphabets
        Dim rxFirstName As New Regex("[a-zA-Z]+")
        If Not rxFirstName.IsMatch(FirstNameTextBox.Text) Then
            MessageBox.Show("First Name must be alphabets.")
            FirstNameTextBox.SelectAll()
            FirstNameTextBox.Focus()
            Return False
        End If

        'Validate last name
        'a: if last name is empty or not
        If String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            MessageBox.Show("Last Name cannot be empty.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()

            Return False
        End If

        'b: if last name is non alphabets
        Dim rxLastName As New Regex("[a-zA-Z]+")
        If Not rxLastName.IsMatch(LastNameTextBox.Text) Then
            MessageBox.Show("Last Name must be alphabets.")
            LastNameTextBox.SelectAll()
            LastNameTextBox.Focus()

            Return False
        End If

        'Validate email
        'a: if email is empty or not
        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            MessageBox.Show("Email Address cannot be empty.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()

            Return False
        End If

        'b: if email is in improper format
        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]")
        If Not rxEmail.IsMatch(EmailTextBox.Text) Then
            MessageBox.Show("Email must follow the right email format such as abc@xyz.com.")
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()

            Return False
        End If

        'Validate contact number if entered        
        'a: check contact number is a valid 10 digit number
        Dim rxContactNumber As New Regex("\d{3}-\d{3}-\d{4}")
        If Not String.IsNullOrEmpty(ContactNumberTextBox.Text) Then
            If Not rxContactNumber.IsMatch(ContactNumberTextBox.Text) Then
                MessageBox.Show("Contact number should be 10 digits.")
                ContactNumberTextBox.SelectAll()
                ContactNumberTextBox.Focus()

                Return False
            End If
        End If

        'Validate password
        'a: if password is empty or not
        If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            MessageBox.Show("Password cannot be empty.")
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()

            Return False
        End If

        'b: check password policy
        Dim rxPassword As New Regex("^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,45}$")
        If Not rxPassword.IsMatch(PasswordTextBox.Text) Then
            MessageBox.Show("Password should be in between 6 to 45 characters and should contain minimum one uppercase, one lowercase and one number.")
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()

            Return False
        End If

        'c: check if password and confirm password are same
        If PasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            MessageBox.Show("Password and confirm password should be same.")
            ConfirmPasswordTextBox.SelectAll()
            ConfirmPasswordTextBox.Focus()

            Return False
        End If

        Return True
    End Function
    Public Sub EnableFieldsforEdit(ToEdit As Boolean)

        FirstNameTextBox.ReadOnly = Not ToEdit
        LastNameTextBox.ReadOnly = Not ToEdit
        ContactNumberTextBox.ReadOnly = Not ToEdit
        PasswordTextBox.ReadOnly = Not ToEdit
        ConfirmPasswordTextBox.ReadOnly = Not ToEdit
        EmailTextBox.ReadOnly = Not ToEdit


        If ToEdit Then
            UpdateButton.Text = "&Save"
        Else
            UpdateButton.Text = "&Edit"
        End If

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If UpdateButton.Text = "&Edit" Then
            'edit mode
            EnableFieldsforEdit(True)
        Else
            'save mode
            'save updates for the existing profile
            UpdateProfile()
        End If

    End Sub

    Private Sub MyProfile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadProfileData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
