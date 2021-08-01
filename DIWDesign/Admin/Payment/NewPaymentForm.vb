Imports System.ComponentModel

Public Class NewPaymentForm
    Private DB As New DBAccess

    'Check if bill is selected
    Private Sub NewPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SelectedBill As Integer
        Dim SelectedCustomer As Integer

        If Integer.TryParse(PaymentForm.SelectedBill, SelectedBill) = True And PaymentForm.SelectedBill >= 0 Then
            BillIdTextBox.Text = SelectedBill
            BillIdTextBox.ReadOnly = True
        Else
            BillIdTextBox.ReadOnly = False
        End If

        If Integer.TryParse(PaymentForm.SelectedCustomer, SelectedCustomer) = True And PaymentForm.SelectedCustomer >= 0 Then
            CustomerIdTextBox.Text = SelectedCustomer
            CustomerIdTextBox.ReadOnly = True
        Else
            CustomerIdTextBox.ReadOnly = False
        End If

    End Sub

    'Close form
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    'Clearing the form after closing
    Private Sub NewPaymentForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ClearForm()
    End Sub

    'Empty fields
    Private Sub ClearForm()
        CustomerIdTextBox.Clear()
        BillIdTextBox.Clear()
        AmountTextBox.Clear()
        PaymentDateTimePicker.Value = Today.Date
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateNewPaymentData() = False Then
            Exit Sub
        End If
        AddPayment()
    End Sub

    ' Add Payment
    Private Sub AddPayment()
        DB.AddParam("@customerId", CustomerIdTextBox.Text)
        DB.AddParam("@billId", BillIdTextBox.Text)
        DB.AddParam("@paymentDate", PaymentDateTimePicker.Value)
        DB.AddParam("@amount", AmountTextBox.Text)
        DB.AddParam("@createDate", Today.Date)

        DB.ExecuteQuery("INSERT INTO payment (customer_id, bill_id, payment_date, amount, create_date) VALUES (?, ?, ?, ?, ?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("A new payment is added into the database successfully")
        Me.Close()

        'Clear and search
        PaymentForm.SelectedCustomer = 0
        PaymentForm.SelectedBill = 0
        PaymentForm.SearchPayments(PaymentForm.PaymentTextBox.Text, PaymentForm.CustomerTextBox.Text)
        BillForm.SearchCustomer(BillForm.FirstNameTextBox.Text, BillForm.LastNameTextBox.Text)
        BillForm.SearchBills(BillForm.BillIdTextBox.Text, BillForm.LeaseIdTextBox.Text)
    End Sub

    Private Function ValidateNewPaymentData() As Boolean
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

        'Validate bill id
        If String.IsNullOrWhiteSpace(BillIdTextBox.Text) Then
            MessageBox.Show("Bill ID can't be empty")
            BillIdTextBox.SelectAll()
            BillIdTextBox.Focus()
            Return False
        End If

        Dim BillIdInteger As Integer
        If Integer.TryParse(BillIdTextBox.Text, BillIdInteger) = False Then
            MessageBox.Show("Bill ID must be integer")
            BillIdTextBox.SelectAll()
            BillIdTextBox.Focus()
            Return False
        End If

        If (GlobalModule.CheckIfExist("bill", "bill_id", BillIdTextBox.Text) = False) Then
            MessageBox.Show("Please enter an existing bill")
            CustomerIdTextBox.SelectAll()
            CustomerIdTextBox.Focus()
            Return False
        End If

        'Validate amount
        If String.IsNullOrWhiteSpace(AmountTextBox.Text) Then
            MessageBox.Show("Amount can't be empty")
            AmountTextBox.SelectAll()
            AmountTextBox.Focus()
            Return False
        End If

        Dim AmountIdDecimal As Decimal
        If Integer.TryParse(AmountTextBox.Text, AmountIdDecimal) = False Then
            MessageBox.Show("Amount must be a number")
            AmountTextBox.SelectAll()
            AmountTextBox.Focus()
            Return False
        End If

        Return True

    End Function


End Class