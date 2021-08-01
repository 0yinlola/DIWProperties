Imports System.IO
Imports System.Net.Mail
Module GlobalModule
    Private DB As New DBAccess
    Public ActiveUser As New User

    'Private ActiveUser As New User
    Public Function CheckIfExist(Table As String, Field As String, Value As Object)
        If Field = "username" Then
            DB.ExecuteQuery("Select Case username FROM (
                            Select Case username from customer
                            UNION
                            Select Case username from employee
							) as users 
							where users.username =" & Value)
        Else
            DB.ExecuteQuery("SELECT * FROM " & Table & " WHERE " & Field & " = " & Value)
        End If

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Return False
        End If

        If DB.RecordCount = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function AuthenticateUser(Username As String, Password As String) As Boolean
        'Check if ueser exist and if employee or customer
        DB.AddParam("@username", Username)
        DB.AddParam("@password", Password)
        DB.ExecuteQuery("SELECT * FROM (
						SELECT customer_id Id, username, user_password, first_name, last_name, phone_number, email, gender, DOB, street_1, street_2, city, state, zip_code, 'Customer' Type FROM customer
						union 
						SELECT employee_id Id, username, user_password, first_name, last_name, phone_number, email, gender, DOB, street_1, street_2, city, state, zip_code, employee_classification Type FROM employee
						) AS users 
						WHERE users.username = ? AND BINARY users.user_password = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Return False
        End If

        If DB.RecordCount = 0 Then
            MessageBox.Show(DB.Exception)
            Return False
        Else
            OpenSession(DB.DBDataTable(0)!Id,
                        DB.DBDataTable(0)!Type,
                        DB.DBDataTable(0)!username,
                        DB.DBDataTable(0)!first_name,
                        DB.DBDataTable(0)!last_name,
                        DB.DBDataTable(0)!phone_number,
                        DB.DBDataTable(0)!email,
                        DB.DBDataTable(0)!gender,
                        DB.DBDataTable(0)!DOB,
                        DB.DBDataTable(0)!street_1,
                        DB.DBDataTable(0)!city,
                        DB.DBDataTable(0)!state,
                        DB.DBDataTable(0)!zip_code)
            Return True
        End If

    End Function

    Private Sub OpenSession(User_id As Integer,
                            Type As String,
                            Username As String,
                            FirstName As String,
                            LastName As String,
                            PhoneNumber As String,
                            Email As String,
                            Gender As String,
                            DOB As Date,
                            Street1 As String,
                            City As String,
                            State As String,
                            ZipCode As Integer
                            )
        Dim Role As Integer
        ActiveUser.User_id = User_id
        Select Case Type
            Case "Manager"
                Role = 1
            Case "Employee"
                Role = 2
            Case "Customer"
                Role = 3
        End Select

        ActiveUser.Role = Role
        ActiveUser.Username = Username
        ActiveUser.FirstName = FirstName
        ActiveUser.LastName = LastName
        ActiveUser.PhoneNumber = PhoneNumber
        ActiveUser.Email = Email
        ActiveUser.Gender = Gender
        ActiveUser.Street1 = Street1
        ActiveUser.City = City
        ActiveUser.State = State
        ActiveUser.ZipCode = ZipCode
        ActiveUser.DOB = DOB
    End Sub

    Public Sub SendEmail(EmailTo As String, EmailSubject As String, EmailBody As String)

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("propertiesdiw@gmail.com", "BIS698Group2")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("propertiesdiw@gmail.com")
            e_mail.To.Add(EmailTo)
            e_mail.Subject = EmailSubject
            e_mail.IsBodyHtml = True
            e_mail.Body = EmailBody
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Public Function GetLoginEmailID() As String
        Return ActiveUser.Email
    End Function

    Public Function GetLoginUserTitle() As String
        Return ActiveUser.FirstName
    End Function
End Module
