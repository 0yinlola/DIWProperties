Public Class ExistingPaymentForm
    Private db As New DBAccess
    Private Sub ExistingPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(PaymentForm.SelectedPaymentTextBox.Text) Then
            MessageBox.Show("No payment is selected")
            Me.Close()
        Else
            DB.AddParam("@paymentID", PaymentForm.SelectedPaymentTextBox.Text)
            db.ExecuteQuery("SELECT * FROM payment JOIN customer ON customer.customer_id = payment.customer_id WHERE payment_id = ?")

            If db.Exception <> String.Empty Then
                MessageBox.Show(db.Exception)
                Exit Sub
            End If

            FullNameTextBox.Text = db.DBDataTable(0)!first_name + " " + db.DBDataTable(0)!last_name
            PaymentIdTextBox.Text = db.DBDataTable(0)("payment_id")
            CustomerIdTextBox.Text = db.DBDataTable(0)!customer_id
            BillIdTextBox.Text = db.DBDataTable(0)!bill_id
            AmountTextBox.Text = db.DBDataTable(0)!amount

            'Enable edit
            EnableFieldsForEdit(False)
        End If
    End Sub

    Private Sub EnableFieldsForEdit(ToEdit As Boolean)
        FullNameTextBox.ReadOnly = True
        PaymentIdTextBox.ReadOnly = True
        CustomerIdTextBox.ReadOnly = True
        BillIdTextBox.ReadOnly = True
        AmountTextBox.ReadOnly = Not ToEdit
        PaymentDateTimePicker.Enabled = ToEdit

        If ToEdit Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub

    Private Sub UpdatePayment()

        db.AddParam("@customerId", CustomerIdTextBox.Text)
        db.AddParam("@billId", BillIdTextBox.Text)
        db.AddParam("@paymentDate", PaymentDateTimePicker.Value)
        db.AddParam("@amount", AmountTextBox.Text)
        db.AddParam("@last_update", Today.Date)

        db.AddParam("@paymentId", PaymentIdTextBox.Text)

        db.ExecuteQuery("UPDATE payment SET customer_id = ?, bill_id = ?, payment_date = ?, amount = ?, last_update = ? WHERE payment_id = ?")

        If db.Exception <> String.Empty Then
            MessageBox.Show(db.Exception)
            Exit Sub
        End If

        MessageBox.Show("Payment information is updated successfully")
        PaymentForm.SearchPayments(PaymentForm.PaymentTextBox.Text, PaymentForm.CustomerTextBox.Text)
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            EnableFieldsForEdit(True)
        Else
            If ValidateNewPaymentData() = False Then
                Exit Sub
            Else
                UpdatePayment()
            End If
            EnableFieldsForEdit(False)
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    'Validate new payment data
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
        If Decimal.TryParse(AmountTextBox.Text, AmountIdDecimal) = False Then
            MessageBox.Show("Amount must be a number")
            AmountTextBox.SelectAll()
            AmountTextBox.Focus()
            Return False
        End If

        Return True

    End Function


End Class