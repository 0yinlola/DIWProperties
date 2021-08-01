Public Class PaymentForm
    Private DB As New DBAccess

    Public SelectedBill As Integer
    Public SelectedCustomer As Integer


    'Search fields
    Private Sub ReadDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchPayments(PaymentTextBox.Text, CustomerTextBox.Text)
    End Sub

    'Search parameters
    Friend Sub SearchPayments(paymentId As String, LastName As String)
        DB.AddParam("@payment_id", paymentId & "%")
        DB.AddParam("@last_name", LastName & "%")

        DB.ExecuteQuery("SELECT 
                        payment.payment_id AS 'Payment No.',
                        customer.last_name,
                        customer.first_name,
                        customer.customer_id,
                        bill.bill_id AS 'Bill No.',
                        payment.amount,
                        payment.payment_date
                        FROM payment 
                        JOIN bill
                        ON payment.bill_id = bill.bill_id
                        JOIN customer
                        ON customer.customer_id = payment.customer_id
                        WHERE payment.payment_id LIKE ? AND customer.last_name LIKE ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        DBDataGridView.ReadOnly = True
    End Sub

    'Insert search values
    Private Sub NameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles PaymentTextBox.KeyUp, CustomerTextBox.KeyUp
        SearchPayments(PaymentTextBox.Text, CustomerTextBox.Text)
    End Sub

    'Selected value
    Private Sub DBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = DBDataGridView.Rows.Count Then
            SelectedPaymentTextBox.Clear()
        Else
            SelectedPaymentTextBox.Text = DBDataGridView.Rows(e.RowIndex).Cells(0).Value
            SelectedCustomer = DBDataGridView.Rows(e.RowIndex).Cells(3).Value
            SelectedBill = DBDataGridView.Rows(e.RowIndex).Cells(4).Value
        End If
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SelectedPaymentTextBox.TextChanged
        If String.IsNullOrWhiteSpace(SelectedPaymentTextBox.Text) Then
            EditToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
        Else
            EditToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewPaymentForm.ShowDialog()
    End Sub

    Private Sub EditToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ExistingPaymentForm.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim aDialogResult As DialogResult

        aDialogResult = MessageBox.Show("Do you really want to delete payment #" & SelectedPaymentTextBox.Text & "'s record",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then
            Exit Sub
        Else
            DB.AddParam("@paymentId", SelectedPaymentTextBox.Text)
            DB.ExecuteQuery("UPDATE payment SET is_active = False WHERE payment_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("The payment  #" & SelectedPaymentTextBox.Text & "'s record has been deleted successfully.")

            SelectedPaymentTextBox.Clear()

            'refresh DataGridView
            SearchPayments(PaymentTextBox.Text, CustomerTextBox.Text)
        End If
    End Sub
End Class