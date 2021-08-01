Imports ClosedXML.Excel
Public Class DashboardForm
    Private DB As New DBAccess
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserNamePlaceHolder.Text = ActiveUser.Username
        PropertiesToolStripMenuItem.Text = "Hello, " + ActiveUser.FirstName

        With Reports
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(Reports)
            .BringToFront()
            .Show()
        End With

        If ActiveUser.Role = 2 Then
            EmployeeLinkLabel.Visible = False
            PictureBox7.Visible = False
        Else
            EmployeeLinkLabel.Visible = True
            PictureBox7.Visible = True
        End If

    End Sub

    Private Sub PropertyLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PropertyLinkLabel.LinkClicked
        With PropertyEmployeeForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(PropertyEmployeeForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub CustomersLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustomersLinkLabel.LinkClicked
        With CustomerForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(CustomerForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PaymentLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PaymentLink.LinkClicked
        With PaymentForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(PaymentForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BillLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BillLinkLabel.LinkClicked
        With BillForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(BillForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EmployeeLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EmployeeLinkLabel.LinkClicked
        With EmployeeForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(EmployeeForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ReportsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ReportsLinkLabel.LinkClicked
        With Reports
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(Reports)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub LeaseLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LeaseLinkLabel.LinkClicked
        With LeaseForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(LeaseForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ApplicationsLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ApplicationsLinkLabel.LinkClicked
        With ReviewApplicationForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            DynamicPanel.Controls.Add(ReviewApplicationForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ViewPropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPropertiesToolStripMenuItem.Click
        MyProfile.ShowDialog()
    End Sub

    Private Sub SignOutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignOutLink.LinkClicked
        Me.Close()
        ActiveUser.Clear()
        HomePage.Show()
    End Sub


End Class

