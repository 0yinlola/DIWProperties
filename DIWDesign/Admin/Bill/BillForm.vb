Public Class BillForm
    Private DB As New DBAccess

    'Search fields
    Private Sub ReadDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchCustomer(FirstNameTextBox.Text, LastNameTextBox.Text)
        'SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
    End Sub

    'Customer DGV Search parameters
    Public Sub SearchCustomer(FirstName As String, LastName As String)
        DB.AddParam("@first_name", FirstName & "%")
        DB.AddParam("@last_name", LastName & "%")

        DB.ExecuteQuery("SELECT
                        customer.customer_id,
                        customer.first_name,
                        customer.last_name,
                        lease.lease_id,
                        lease.property_id,
                        lease.lease_rate,
                        lease.lease_start_date,
                        lease.lease_end_date,
                        customer.phone_number,
                        customer.email
                        FROM customer
                        JOIN lease
                        ON customer.customer_id = lease.customer_id
                        WHERE first_name LIKE ? AND 
                        last_name LIKE ?
                        GROUP BY customer_id")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridViewCustomer.DataSource = DB.DBDataTable
        DBDataGridViewCustomer.ReadOnly = True
    End Sub

    'Bill DGV Search parameters
    Public Sub SearchBills(BillId As String, LeaseId As String)
        DB.AddParam("@bill_id", BillId & "%")
        DB.AddParam("@lease_id", LeaseId & "%")

        DB.ExecuteQuery("SELECT
                        bill.bill_id AS 'Bill No.',
                        lease.lease_id,
                        bill.description,
                        bill.amount AS 'Amount',
                        SUM(payment.amount) AS 'Paid',
                        bill.amount - SUM(payment.amount) AS 'Remaining',
                        bill.due_date,
                        bill.create_date,
                        bill.last_update
                        FROM bill
                        LEFT JOIN payment
                        ON payment.bill_id = bill.bill_id
                        JOIN lease
                        ON lease.lease_id = bill.lease_id
                        JOIN customer
                        ON customer.customer_id = lease.customer_id
                        WHERE bill.bill_id LIKE ? AND lease.lease_id LIKE ?
                        GROUP BY bill.bill_id
                        ORDER BY create_date DESC")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DBDataGridViewBill.DataSource = DB.DBDataTable
        DBDataGridViewBill.ReadOnly = True
    End Sub

    ' Customer DGV search values
    Private Sub SearchCustomerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp, LastNameTextBox.KeyUp
        SearchCustomer(FirstNameTextBox.Text, LastNameTextBox.Text)
    End Sub

    ' Bill DGV search values
    Private Sub SearchBillTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles BillIdTextBox.KeyUp, LeaseIdTextBox.KeyUp
        SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
    End Sub

    'New Bill Form
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewBillForm.ShowDialog()
    End Sub

    'New Payment
    Private Sub NewPaymentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewPaymentToolStripMenuItem1.Click
        NewPaymentForm.ShowDialog()
    End Sub

    'Edit Bill Form
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        ExistingBillForm.ShowDialog()
    End Sub

    'Delete Bill
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim aDialogResult As DialogResult

        aDialogResult = MessageBox.Show("Do you really want to delete payment #" & SelectedBillTextBox.Text & "'s record",
                        "Delete Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

        If aDialogResult = vbNo Then
            Exit Sub
        Else
            DB.AddParam("@bill_id", SelectedBillTextBox.Text)
            DB.ExecuteQuery("UPDATE bill SET is_active = False WHERE bill_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("The bill  #" & SelectedBillTextBox.Text & "'s record has been deleted successfully.")

            SelectedBillTextBox.Clear()

            'refresh DataGridView
            SearchBills(BillIdTextBox.Text, LeaseIdTextBox.Text)
        End If

    End Sub

    'Customer DGV Selected value
    Private Sub DBDataGridViewCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridViewCustomer.CellClick

        If e.RowIndex < 0 Or e.RowIndex = DBDataGridViewCustomer.Rows.Count Then
            SelectedCustomerTextBox.Clear()
            SelectedBillTextBox.Clear()
        Else
            FirstNameTextBox.Text = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(1).Value
            LastNameTextBox.Text = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(2).Value
            SelectedCustomerTextBox.Text = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(0).Value
            PaymentForm.SelectedCustomer = DBDataGridViewCustomer.Rows(e.RowIndex).Cells(0).Value
            'Clear bill text box after search customer
            SelectedBillTextBox.Clear()
            PaymentForm.SelectedBill = Integer.TryParse(PaymentForm.SelectedBill, PaymentForm.SelectedBill)
            SearchBills(BillIdTextBox.Text, DBDataGridViewCustomer.Rows(e.RowIndex).Cells(3).Value)
        End If
    End Sub

    'Bill DGV Selected value
    Private Sub DBDataGridViewBill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridViewBill.CellClick

        If e.RowIndex < 0 Or e.RowIndex = DBDataGridViewBill.Rows.Count Then
            SelectedBillTextBox.Clear()
        Else
            BillIdTextBox.Text = DBDataGridViewBill.Rows(e.RowIndex).Cells(0).Value
            LeaseIdTextBox.Text = DBDataGridViewBill.Rows(e.RowIndex).Cells(1).Value
            SelectedBillTextBox.Text = DBDataGridViewBill.Rows(e.RowIndex).Cells(0).Value
            PaymentForm.SelectedBill = SelectedBillTextBox.Text
        End If
    End Sub

    Private Sub BillIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SelectedBillTextBox.TextChanged
        If String.IsNullOrWhiteSpace(SelectedBillTextBox.Text) Then
            DeleteToolStripMenuItem.Enabled = False
            EditToolStripMenuItem.Enabled = False
        Else
            DeleteToolStripMenuItem.Enabled = True
            EditToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub DBDataGridViewBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DBDataGridViewBill.CellContentClick

    End Sub
End Class