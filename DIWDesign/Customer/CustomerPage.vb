Public Class CustomerPage
    Private DB As New DBAccess
    Private Sub CustomerPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserNamePlaceHolder.Text = "Welcome," + " " + ActiveUser.Username
        If String.IsNullOrEmpty(ActiveUser.User_id) Then
            Me.Close()
        Else
            DB.AddParam("@user_id", ActiveUser.User_id)
            DB.ExecuteQuery("SELECT c.customer_id, c.first_name, c.last_name, c.phone_number, c.email, l.lease_start_date, l.lease_end_date, p.street_1, p.city, p.zip_code, p.state, b.amount, b.description, b.due_date  FROM 
                  customer AS c JOIN lease as l ON c.customer_id = l.customer_id
                  JOIN property as P on p.property_id = l.lease_id JOIN bill as b on b.bill_id = l.lease_id
                  WHERE c.customer_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            CustomerIDTextBox.Text = DB.DBDataTable(0)("customer_id")
            FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
            LastNameTextBox.Text = DB.DBDataTable(0)!last_name
            CustomerPhoneTextBox.Text = DB.DBDataTable(0)!phone_number
            EmailTextBox.Text = DB.DBDataTable(0)!email
            AddressTextBox.Text = DB.DBDataTable(0)!street_1
            CityTextBox.Text = DB.DBDataTable(0)!city
            ZipCodeTextBox.Text = DB.DBDataTable(0)!zip_code
            StateTextBox.Text = DB.DBDataTable(0)!state
            LeaseStartTextBox.Text = DB.DBDataTable(0)!lease_start_date
            LeaseEndTextBox.Text = DB.DBDataTable(0)!lease_end_date
            AmountTextBox.Text = DB.DBDataTable(0)!amount
            DescriptionTextBox.Text = DB.DBDataTable(0)!description
            DueDateTextBox.Text = DB.DBDataTable(0)!due_date
        End If
        WindowState = FormWindowState.Maximized

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
    Private Sub SignOutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignOutLinkLabel.LinkClicked
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
        With PropertyCustomerForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            CustomerPanel.Controls.Add(PropertyCustomerForm)
            .BringToFront()
            .Show()
        End With

    End Sub
End Class

