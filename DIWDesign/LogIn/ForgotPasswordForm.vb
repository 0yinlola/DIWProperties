Imports System.Text.RegularExpressions

Public Class ForgotPasswordForm

    Private DB As New DBAccess

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim rxEmail As New Regex("[a-zA-Z0-9_.+-]+@+[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")

        If ValidateForgotPasswordForm() = False Then
            Exit Sub
        End If

        DB.ExecuteQuery("SELECT * FROM customer where email LIKE '" & EmailTextBox.Text & "'")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If DB.DBDataTable.Rows.Count = 0 Then
            WarningLabel.Text = "Customer information doen't match."
            WarningLabel.Visible = True
            Exit Sub
        End If

        Dim EmailBody As String

        EmailBody = "<p>Dear " & DB.DBDataTable.Rows(0)!first_name & ",</p>" &
                    "<p>Your password is <b>" & DB.DBDataTable.Rows(0)!user_password & "</b>." &
                    " Please login and reset your password.</p>" &
                    "<p>Best regards,<br>" &
                    "DIW Proerty</p>"

        SendEmail(EmailTextBox.Text, "Reset Password", EmailBody)

        MessageBox.Show("The latest password is sent to your email.")

        EmailTextBox.Clear()
        WarningLabel.Visible = False
        GoToLogOn()

    End Sub

    Private Function ValidateForgotPasswordForm() As Boolean

        If String.IsNullOrWhiteSpace(EmailTextBox.Text) Then
            WarningLabel.Text = "Email cannot be empty."
            WarningLabel.Visible = True
            EmailTextBox.SelectAll()
            EmailTextBox.Focus()
            Return False
        End If

        Return True
    End Function




    Private Sub ForgotPasswordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLink.LinkClicked
        HomePage.HomePanel.Visible = True
        With LogInForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            HomePage.HomePanel.Controls.Add(LogInForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GoToLogOn()
        EmailTextBox.Clear()
        Me.Hide()
        LogInForm.Show()
    End Sub

    Private Sub CreateNewAccountLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        EmailTextBox.Clear()
        Me.Hide()
        ApplicationForm.Show()
    End Sub

End Class