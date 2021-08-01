Imports System.ComponentModel

Public Class NewBillForm
    Private DB As New DBAccess

    'Close form
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    'Clearing the form after closing
    Private Sub NewBillForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearForm()
    End Sub

    'Empty fields
    Private Sub ClearForm()
        CustomerIdTextBox.Clear()
        LeaseIdTextBox.Clear()
        AmountTextBox.Clear()
        DueDateDateTimePicker.Value = Today.Date
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateNewBillData() = False Then
            Exit Sub
        End If
        AddBill()
    End Sub

    Private Sub AddBill()
        DB.AddParam("@lease_id", LeaseIdTextBox.Text)
        DB.AddParam("@amount", AmountTextBox.Text)
        DB.AddParam("@description", DescriptionTextBox.Text)
        DB.AddParam("@due_date", DueDateDateTimePicker.Value)
        DB.AddParam("@create_date", Today.Date)

        DB.ExecuteQuery("INSERT INTO bill (lease_id, amount, description, due_date, create_date) VALUES (?, ?, ?, ?, ?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A new bill is added into the database successfully")
        Me.Close()
        BillForm.SearchBills(BillForm.BillIdTextBox.Text, BillForm.LeaseIdTextBox.Text)
    End Sub

    Private Function ValidateNewBillData() As Boolean
        'Validate customer id
        If String.IsNullOrWhiteSpace(CustomerIdTextBox.Text) Then
            MessageBox.Show("Customer ID can't be empty")
            CustomerIdTextBox.SelectAll()
            CustomerIdTextBox.Focus()
            Return False
        End If

        Dim CustomerIdInteger As Integer
        If Integer.TryParse(CustomerIdTextBox.Text, CustomerIdInteger) = False Then
            MessageBox.Show("Customer ID must be integer")
            CustomerIdTextBox.SelectAll()
            CustomerIdTextBox.Focus()
            Return False
        End If

        If (GlobalModule.CheckIfExist("customer", "customer_id", CustomerIdTextBox.Text) = False) Then
            MessageBox.Show("Please enter an existing customer")
            CustomerIdTextBox.SelectAll()
            CustomerIdTextBox.Focus()
            Return False
        End If

        'Validate lease id
        If String.IsNullOrWhiteSpace(LeaseIdTextBox.Text) Then
            MessageBox.Show("Lease ID can't be empty")
            LeaseIdTextBox.SelectAll()
            LeaseIdTextBox.Focus()
            Return False
        End If

        Dim leaseIdInteger As Integer
        If Integer.TryParse(CustomerIdTextBox.Text, leaseIdInteger) = False Then
            MessageBox.Show("Lease ID must be integer")
            LeaseIdTextBox.SelectAll()
            LeaseIdTextBox.Focus()
            Return False
        End If

        If (GlobalModule.CheckIfExist("lease", "lease_id", CustomerIdTextBox.Text) = False) Then
            MessageBox.Show("Please enter an existing lease")
            LeaseIdTextBox.SelectAll()
            LeaseIdTextBox.Focus()
            Return False
        End If

        'Validate Amount
        If String.IsNullOrWhiteSpace(AmountTextBox.Text) Then
            MessageBox.Show("Amount can't be empty")
            AmountTextBox.SelectAll()
            AmountTextBox.Focus()
            Return False
        End If

        Dim AmountDecimal As Integer
        If Decimal.TryParse(AmountTextBox.Text, AmountDecimal) = False Then
            MessageBox.Show("Amount must be a number")
            AmountTextBox.SelectAll()
            AmountTextBox.Focus()
            Return False
        End If

        Return True
    End Function
End Class