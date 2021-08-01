Public Class LogInForm
    Private EmployeeLinkLabel As Object

    Private Sub LogInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        'Validation : Check if email is not empty and in proper format
        If String.IsNullOrWhiteSpace(UsernameTextBox.Text) Then
            EmailWarningLabel.Visible = True
            UsernameTextBox.SelectAll()
            UsernameTextBox.Focus()
            Exit Sub
        End If

        'Validation : Check if password is not empty
        If String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            PasswordWarningLabel.Visible = True
            PasswordTextBox.SelectAll()
            PasswordTextBox.Focus()
            Exit Sub
        End If

        EmailWarningLabel.Visible = False
        PasswordWarningLabel.Visible = False

        If AuthenticateUser(UsernameTextBox.Text, PasswordTextBox.Text) Then
            AuthenticationWarningLabel.Visible = False

            Select Case ActiveUser.Role
                Case 1
                    HomePage.Hide()
                    DashboardForm.Show()
                Case 2
                    HomePage.Hide()
                    DashboardForm.Show()
                    If ActiveUser.Role = 2 Then
                        DashboardForm.EmployeeLinkLabel.Visible = False
                    Else
                        DashboardForm.EmployeeLinkLabel.Visible = True
                    End If
                Case 3
                    HomePage.Hide()
                    CustomerHomeForm.Show()
            End Select
        Else
            AuthenticationWarningLabel.Text = "The username or password is not correct"
            AuthenticationWarningLabel.Visible = True
        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub ForgotPasswordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLink.LinkClicked
        HomePage.HomePanel.Visible = True
        With ForgotPasswordForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            HomePage.HomePanel.Controls.Add(ForgotPasswordForm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class