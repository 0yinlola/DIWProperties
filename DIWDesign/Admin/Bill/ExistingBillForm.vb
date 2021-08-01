Public Class ExistingBillForm
    Private db As New DBAccess
    Private Sub ExistingBillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(BillForm.SelectedBillTextBox.Text) Then
            MessageBox.Show("No bill is selected")
            Me.Close()
        Else
            db.AddParam("@billId", BillForm.SelectedBillTextBox.Text)
            db.ExecuteQuery("SELECT * FROM bill WHERE bill_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            BillIdTextBox.Text = db.DBDataTable(0)("bill_id")
            LeaseIdTextBox.Text = db.DBDataTable(0)!lease_id
            AmountTextBox.Text = db.DBDataTable(0)!amount
            DescriptionTextBox.Text = db.DBDataTable(0)!description

            'Enable edit
            EnableFieldsForEdit(False)
        End If
    End Sub

    Private Sub EnableFieldsForEdit(ToEdit As Boolean)
        BillIdTextBox.ReadOnly = True
        LeaseIdTextBox.ReadOnly = True
        AmountTextBox.ReadOnly = Not ToEdit
        DescriptionTextBox.ReadOnly = Not ToEdit

        If ToEdit Then
            EditSaveButton.Text = "&Save"
        Else
            EditSaveButton.Text = "&Edit"
        End If
    End Sub

    Private Sub UpdateBill()

        db.AddParam("@amount", AmountTextBox.Text)
        db.AddParam("@description", DescriptionTextBox.Text)
        db.AddParam("@last_update", Today.Date)

        db.AddParam("@billId", BillIdTextBox.Text)

        db.ExecuteQuery("UPDATE bill SET amount = ?, description = ?, last_update = ? WHERE bill_id = ?")

        If db.Exception <> String.Empty Then
            MessageBox.Show(db.Exception)
            Exit Sub
        End If

        MessageBox.Show("Payment information is updated successfully")
        BillForm.SearchBills(BillForm.BillIdTextBox.Text, BillForm.LeaseIdTextBox.Text)
    End Sub

    Private Sub EditSaveButton_Click(sender As Object, e As EventArgs) Handles EditSaveButton.Click
        If EditSaveButton.Text = "&Edit" Then
            EnableFieldsForEdit(True)
        Else
            If ValidateExistingBill() = False Then
                Exit Sub
            Else
                UpdateBill()
            End If
            EnableFieldsForEdit(False)
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Function ValidateExistingBill() As Boolean
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