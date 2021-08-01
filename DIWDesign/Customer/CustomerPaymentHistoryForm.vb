Public Class CustomerPaymentHistoryForm
    Private DB As New DBAccess
    Private Sub CustomerPaymentHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(ActiveUser.User_id) Then
            Me.Close()
        Else
            DB.AddParam("@user_id", ActiveUser.User_id)
            DB.ExecuteQuery("SELECT b.amount AS 'Bill Amount', b.description AS 'Bill Description', b.due_date AS 'Due Date', l.late_fee AS 'Late Fee', p.payment_date AS 'Payment Date', p.amount AS 'Payment Amount' FROM bill as b JOIN lease as l ON b.bill_id = l.lease_id JOIN payment as p ON p.payment_id = b.bill_id WHERE p.customer_id=?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
        End If

        BillDBDataGridView.DataSource = DB.DBDataTable
        BillDBDataGridView.ReadOnly = True

    End Sub
    Friend Sub SearchAmount(Amount As String)

        DB.AddParam("@amount", Amount & "%") '1ST ?'
            DB.ExecuteQuery("SELECT b.amount AS 'Bill Amount', b.description AS 'Bill Description', b.due_date AS 'Due Date', l.late_fee AS 'Late Fee', p.payment_date AS 'Payment Date', p.amount AS 'Payment Amount' FROM bill as b JOIN lease as l ON b.bill_id = l.lease_id JOIN payment as p ON p.payment_id = b.bill_id WHERE b.amount LIKE ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub

            End If

        BillDBDataGridView.DataSource = DB.DBDataTable


    End Sub

    Private Sub BillAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles BillAmountTextBox.KeyUp
        SearchAmount(BillAmountTextBox.Text)
    End Sub
    Private Sub BillDBDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDBDataGridView.CellClick
        If e.RowIndex < 0 Or e.RowIndex = BillDBDataGridView.Rows.Count - 1 Then
            BillDescriptionTextBox.Clear()
            PaymentDateTextBox.Clear()
            Exit Sub
        Else
            BillDescriptionTextBox.Text = BillDBDataGridView.Rows(e.RowIndex).Cells(1).Value
            PaymentDateTextBox.Text = BillDBDataGridView.Rows(e.RowIndex).Cells(4).Value
        End If
    End Sub
End Class