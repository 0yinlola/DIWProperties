Public Class CustomerPageForm
    Private DB As New DBAccess

    Private Sub CustomerMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(ActiveUser.User_id) Then
            Me.Close()
        Else
            DB.AddParam("@user_id", ActiveUser.User_id)
            DB.ExecuteQuery("
                            SELECT c.customer_id, c.first_name, c.last_name, c.phone_number, c.email, c.street_1, c.city, c.zip_code, c.state, l.lease_start_date, l.lease_end_date, p.street_1, p.city, p.zip_code, p.state, b.amount, b.description, b.due_date  FROM 
                            customer AS c LEFT JOIN lease as l ON c.customer_id = l.customer_id
                            LEFT JOIN property as P on p.property_id = l.lease_id 
                            LEFT JOIN bill as b on b.bill_id = l.lease_id
                            WHERE c.customer_id=?
                            ORDER BY lease_end_date DESC
                            LIMIT 1
                            ")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            CustomerIDTextBox.Text = DB.DBDataTable(0)!customer_id
            FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
            LastNameTextBox.Text = DB.DBDataTable(0)!last_name
            CustomerPhoneTextBox.Text = DB.DBDataTable(0)!phone_number
            EmailTextBox.Text = DB.DBDataTable(0)!email
            AddressTextBox.Text = DB.DBDataTable(0)!street_1
            CityTextBox.Text = DB.DBDataTable(0)!city
            ZipCodeTextBox.Text = DB.DBDataTable(0)!zip_code
            StateTextBox.Text = DB.DBDataTable(0)!state
            'if DBNull
            If IsDBNull(DB.DBDataTable(0)!lease_start_date) Then 'Do this type of check for each optional field.
            Else
                LeaseStartTextBox.Text = DB.DBDataTable(0)!lease_start_date
            End If

            If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then 'Do this type of check for each optional field.
            Else
                LeaseEndTextBox.Text = DB.DBDataTable(0)!lease_end_date
            End If

            If IsDBNull(DB.DBDataTable(0)!amount) Then 'Do this type of check for each optional field.
            Else
                AmountTextBox.Text = DB.DBDataTable(0)!amount
            End If

            If IsDBNull(DB.DBDataTable(0)!description) Then 'Do this type of check for each optional field.
            Else
                DescriptionTextBox.Text = DB.DBDataTable(0)!description
            End If

            If IsDBNull(DB.DBDataTable(0)!due_date) Then 'Do this type of check for each optional field.
            Else
                DueDateTextBox.Text = DB.DBDataTable(0)!due_date
            End If

        End If
    End Sub

End Class