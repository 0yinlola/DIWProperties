Public Class NewApplicationExistingCustomerForm

    Private DB As New DBAccess

    Private Sub NewApplicationExistingCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If String.IsNullOrWhiteSpace(ExistingCustomerProperties.PropertyIDTextBox.Text) Then
            MessageBox.Show("No property is selected. Try again.")
            Me.Close()
        Else

            DB.AddParam("@property_id", ExistingCustomerProperties.PropertyIDTextBox.Text)
            DB.ExecuteQuery("SELECT * 
                                FROM property
                                LEFT JOIN lease
                                ON property.property_id = lease.property_id 
                                WHERE property.property_id = ?
                                ORDER BY lease_end_date DESC
                                LIMIT 1")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then
                AvailableFromDateTimePicker.Value = DateAdd("d", 3, Today.Date)
            Else
                AvailableFromDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date
            End If

            PropertyIdTextBox.Text = DB.DBDataTable(0)!property_id
            PropertyInfoTextBox.Text = DB.DBDataTable(0)!property_type
            PropertyAddressTextBox.Text = DB.DBDataTable(0)!street_1 + ", " + DB.DBDataTable(0)!city + ", " + DB.DBDataTable(0)!state + ", " + Str(DB.DBDataTable(0)!zip_code)
        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ValidateNewApplication() = False Then
            Exit Sub
        Else
            AddApplication()
        End If


    End Sub

    Private Function ValidateNewApplication()
        'Validate preffered start date is after the available date
        If DateDiff("d", AvailableFromDateTimePicker.Value, PrefferedStartDateTimePicker.Value) < 0 Then
            MessageBox.Show("Preferred starting date must be equal or after the available date.")
            PrefferedStartDateTimePicker.Focus()
            Return False
        End If

        'Validate if selected lease date is after the customer's end lease date
        If Not CheckIfhasCurrentLease() Then
            MessageBox.Show("Preffered starting date must start after the end of your current lease.")
            PrefferedStartDateTimePicker.Focus()
            Return False
        End If

        Return True
    End Function


    Function CheckIfhasCurrentLease()
        DB.AddParam("@customer_id", ActiveUser.User_id)
        DB.ExecuteQuery("
            SELECT lease_end_date
            FROM lease
            WHERE customer_id = ?
            ORDER BY lease_end_date
            LIMIT 1
            ")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Return False
        End If

        If DB.RecordCount = 0 Then
            Return True
        Else
            If DateDiff("d", AvailableFromDateTimePicker.Value, DB.DBDataTable(0)!lease_end_date) < 0 Then
                Return False
            End If
            Return True
        End If
    End Function

    Private Sub AddApplication()
        'Sumbitting application for new customer
        DB.AddParam("@property_id", PropertyIdTextBox.Text)
        DB.AddParam("@customer_id", ActiveUser.User_id)
        DB.AddParam("@preffered_date", PrefferedStartDateTimePicker.Value)
        DB.AddParam("@lease_duration", LeaseDurationTextBox.Text)
        DB.AddParam("@createdate", Today.Date)

        DB.ExecuteQuery("INSERT INTO application(property_id, customer_id, preferred_start_date, application_status, lease_duration, create_date) 
                        VALUES ( ?, ?, ?, 'pending', ?, ?)")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MessageBox.Show("Your application has been submitted successfully, you can log in to your account to review the progress of your application")
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class