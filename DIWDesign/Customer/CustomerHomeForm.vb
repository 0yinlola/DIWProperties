Public Class CustomerHomeForm
    Private DB As New DBAccess
    Private Sub CustomerPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNamePlaceHolder.Text = "Welcome back," + " " + ActiveUser.FirstName
        UserNameLabel.Text = ActiveUser.Username

        'WindowState = FormWindowState.Maximized

        With CustomerPageForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(CustomerPageForm)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub LeaseInfoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
    Private Sub CustomerPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim aDialogResult As DialogResult
        aDialogResult = MessageBox.Show("Do you want to exit your account?", "Exit Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If aDialogResult = DialogResult.Cancel Then
            e.Cancel = True 'Stop exiting
        End If
    End Sub


    Private Sub ProfileLinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProfileLinkLabel.LinkClicked
        With EditProfile
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(EditProfile)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub SignOutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub ApplicationLinkLabel_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ApplicationLinkLabel.LinkClicked
        With CustomerApplicationStatus
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(CustomerApplicationStatus)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub NewApplicationLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NewApplicationLinkLabel.LinkClicked
        With ExistingCustomerProperties
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(ExistingCustomerProperties)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub SignOutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignOutLink.LinkClicked
        Me.Close()
        ActiveUser.Clear()
        HomePage.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        With CustomerPageForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(CustomerPageForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PaymentHistoryLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PaymentHistoryLinkLabel.LinkClicked
        With CustomerPaymentHistoryForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(CustomerPaymentHistoryForm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class

