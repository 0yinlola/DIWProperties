Public Class ProcessApplicationForm
    Private DB As New DBAccess
    Private Sub ProcessApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillForm(ReviewApplicationForm.SelectedApplication)
    End Sub

    Private Sub LeaseAmount_KeyUp(sender As Object, e As KeyEventArgs) Handles LeaseRateTextBox.KeyUp
        SecurityDepositTextBox.Text = LeaseRateTextBox.Text
    End Sub

    Private Sub FillForm(ApplicationId As Integer)
        DB.AddParam("@application_id", ApplicationId & "%")

        DB.ExecuteQuery("SELECT * 
                        FROM application
                        JOIN customer
                        ON application.customer_id = customer.customer_id
                        JOIN property
                        ON application.property_id = property.property_id
                        LEFT JOIN lease
                        ON property.property_id = lease.property_id
                        WHERE application.application_id = ?")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        ' disable button depend on the case
        FieldsActivation(DB.DBDataTable(0)!application_status)

        ApplicationStatusLabel.Text = DB.DBDataTable(0)!application_status

        'Customer information
        CustomerIDTextBox.Text = DB.DBDataTable(0)("customer_id")
        UserNameTextBox.Text = DB.DBDataTable(0)!username
        FirstNameTextBox.Text = DB.DBDataTable(0)!first_name
        LastNameTextBox.Text = DB.DBDataTable(0)!last_name
        CustomerPhoneTextBox.Text = DB.DBDataTable(0)!phone_number
        EmailTextBox.Text = DB.DBDataTable(0)!email
        GenderTextBox.Text = DB.DBDataTable(0)!gender
        DOBTextBox.Text = DB.DBDataTable(0)!DOB
        CityTextBox.Text = DB.DBDataTable(0)!city
        StateTextBox.Text = DB.DBDataTable(0)!state
        AddressTextBox.Text = DB.DBDataTable(0)!street_1
        If IsDBNull(DB.DBDataTable(0)!street_2) Then 'Do this type of check for each optional field.
        Else
            Address2TextBox.Text = DB.DBDataTable(0)!street_2
        End If

        LandlordNameTextBox.Text = DB.DBDataTable(0)!previous_landlord_name
        LandlordPhoneTextBox.Text = DB.DBDataTable(0)!previous_landlord_phone_number

        If IsDBNull(DB.DBDataTable(0)!social_security_number) Then 'Do this type of check for each optional field.
        Else
            SSNTextBox.Text = DB.DBDataTable(0)!social_security_number
        End If
        If IsDBNull(DB.DBDataTable(0)!employer) Then
        Else
            EmployerTextBox.Text = DB.DBDataTable(0)!employer
        End If
        If IsDBNull(DB.DBDataTable(0)!vehicle_make) Then
        Else
            VehicleMakeTextBox.Text = DB.DBDataTable(0)!vehicle_make
        End If
        If IsDBNull(DB.DBDataTable(0)!vehicle_plate_number) Then
        Else
            VehiclePlateNumberTextBox.Text = DB.DBDataTable(0)!vehicle_plate_number
        End If
        If IsDBNull(DB.DBDataTable(0)!driver_license) Then
        Else
            DriverLicenseTextBox.Text = DB.DBDataTable(0)!driver_license
        End If

        Reference1NameTextBox.Text = DB.DBDataTable(0)!reference_1_full_name
        Reference1PhoneTextBox.Text = DB.DBDataTable(0)!reference_1_phone_number
        Reference2NameTextBox.Text = DB.DBDataTable(0)!reference_2_full_name
        Reference2PhoneTextBox.Text = DB.DBDataTable(0)!reference_2_phone_number
        EmergencyContactNameTextBox.Text = DB.DBDataTable(0)!emergency_contact_full_name
        EmergencyContactPhoneTextBox.Text = DB.DBDataTable(0)!emergency_contact_phone_number

        'Property information
        PropertyIDTextBox.Text = Str(DB.DBDataTable(0)!property_id)
        Street1TextBox.Text = DB.DBDataTable(0)!street_11
        Street2TextBox.Text = DB.DBDataTable(0)!street_21
        PropertyCityTextBox.Text = DB.DBDataTable(0)!city1
        PropertyStateTextBox.Text = DB.DBDataTable(0)!state1
        ZipCodeTextBox.Text = DB.DBDataTable(0)!zip_code1
        NumRoomTextBox.Text = DB.DBDataTable(0)!number_of_rooms
        NumBasementTextBox.Text = DB.DBDataTable(0)!basement
        PropertyTypeTextBox.Text = DB.DBDataTable(0)!property_type
        NumBathroomTextBox.Text = DB.DBDataTable(0)!number_of_bathrooms
        YearBuiltTextBox.Text = DB.DBDataTable(0)!year_built
        MonthlyRateTextBox.Text = DB.DBDataTable(0)!monthly_rate
        SFTextBox.Text = DB.DBDataTable(0)!square_footage
        GarageCheckBox.Checked = DB.DBDataTable(0)!garage
        RefrigeratorCheckBox.Checked = DB.DBDataTable(0)!refigerator
        ACCheckBox.Checked = DB.DBDataTable(0)!air_conditioning
        StoveCheckBox.Checked = DB.DBDataTable(0)!stove
        DishWasherCheckBox.Checked = DB.DBDataTable(0)!dish_washer
        WasherCheckBox.Checked = DB.DBDataTable(0)!washer
        DryerCheckBox.Checked = DB.DBDataTable(0)!dryer
        GarbageDisposalCheckBox.Checked = DB.DBDataTable(0)!disposal
        If IsDBNull(DB.DBDataTable(0)!lease_end_date) Then
            CurrentLeaseEndDateTimePicker.Visible = False
            AvailabilityLabel.Text = "Available for rental"
        Else
            CurrentLeaseEndDateTimePicker.Value = DB.DBDataTable(0)!lease_end_date
        End If

        'Application
        ApplicationIdTextBox.Text = DB.DBDataTable(0)!application_id
        LeaseDurationTextBox.Text = DB.DBDataTable(0)!lease_duration
        PreferredStartDateTimePicker.Value = DB.DBDataTable(0)!preferred_start_date

        'Lease information
        LeaseStartDateTimePicker.Value = DB.DBDataTable(0)!preferred_start_date
        LeaseEndDateTimePicker.Value = DateAdd("m", DB.DBDataTable(0)!lease_duration, DB.DBDataTable(0)!preferred_start_date)
    End Sub

    Private Sub ChangeStatus_Click(sender As Object, e As EventArgs) Handles ChangeStatusButton.Click
        If String.IsNullOrEmpty(ApplicationIdTextBox.Text) Then
            MessageBox.Show("No application selected is selected")
            Me.Close()
        Else
            DB.AddParam("@active_employee", ActiveUser.User_id)
            DB.AddParam("@application_id", ApplicationIdTextBox.Text)

            DB.ExecuteQuery("UPDATE application SET application_status = 'processing', process_by = ? WHERE application_id = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            MessageBox.Show("Application status is changed to processing")
            FillForm(ReviewApplicationForm.SelectedApplication)
        End If
        Dim EmailBody As String
        EmailBody = "<p>Dear" & ApplicationForm.UserNameTextBox.Text & ",</p>" &
                "<p>Thank you for submitting the application.</p>" &
                "<p>Your application is being processed.</p>" &
                "<p>Regards,<br>" &
                "DIWProperties</p>"
        SendEmail(EmailTextBox.Text, "DIWProperties - Application Status", EmailBody)
    End Sub

    Private Sub ApproveButton_Click(sender As Object, e As EventArgs) Handles ApproveButton.Click
        If ValidateNewApplication() = False Then
            Exit Sub
        End If


        If Desclaimer1Checkbox.Checked = True And Desclaimer2Checkbox.Checked = True Then

            Dim aDialogResult As DialogResult

            aDialogResult = MessageBox.Show("Are you sure to Approve Cusomter #" & CustomerIDTextBox.Text & "'s application",
                        "Approval Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

            If aDialogResult = vbNo Then
                Exit Sub
            Else
                'Create Lease
                DB.AddParam("@property_id", PropertyIDTextBox.Text)
                DB.AddParam("@employee_id", ActiveUser.User_id)
                DB.AddParam("@customer_id", CustomerIDTextBox.Text)
                DB.AddParam("@lease_rate", LeaseRateTextBox.Text)
                DB.AddParam("@security_deposit", SecurityDepositTextBox.Text)
                DB.AddParam("@start_date", LeaseStartDateTimePicker.Value)
                DB.AddParam("@end_date", LeaseEndDateTimePicker.Value)
                DB.AddParam("@late_fee", LateFeeTextBox.Text)
                DB.AddParam("@application_fee", ApplicationFeeTextBox.Text)
                DB.AddParam("@create_date", Today.Date)
                DB.AddParam("@create_date", Today.Date)

                DB.ExecuteQuery("INSERT INTO lease (property_id, employee_id, customer_id, lease_rate, security_deposit, lease_start_date, lease_end_date, late_fee, application_fee, create_date, last_update) 
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If

                'Update application
                DB.AddParam("@active_employee", 1) ' Change this to ActiveUser.User_id
                DB.AddParam("@application_id", ApplicationIdTextBox.Text)

                DB.ExecuteQuery("UPDATE application SET application_status = 'approved', decision_by = ? WHERE application_id = ?")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If

                'Update property to inactive
                DB.AddParam("@property_id", PropertyIDTextBox.Text)

                DB.ExecuteQuery("UPDATE property SET is_active = 0 WHERE property_id = ?")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If

                'Generate Bills
                'Adminstration fee
                DB.AddParam("@customer_id", CustomerIDTextBox.Text)
                DB.AddParam("@property_id", PropertyIDTextBox.Text)
                DB.AddParam("@amount", ApplicationFeeTextBox.Text)
                DB.AddParam("@due_date", DateAdd("d", 7, Today.Date)) ' 7 days from the application
                DB.AddParam("@create_date", Today.Date)

                DB.ExecuteQuery("INSERT INTO bill (lease_id, amount, description, due_date, create_date) 
                            VALUES ((SELECT lease_id FROM lease WHERE customer_id = ? AND property_id = ? LIMIT 1)  , ?, 'Adminstrative Fee', ?, ?)")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If

                'Security Deposit
                DB.AddParam("@customer_id", CustomerIDTextBox.Text)
                DB.AddParam("@property_id", PropertyIDTextBox.Text)
                DB.AddParam("@amount", SecurityDepositTextBox.Text)
                DB.AddParam("@due_date", DateAdd("d", 7, Today.Date)) ' 7 days from the application
                DB.AddParam("@create_date", Today.Date)

                DB.ExecuteQuery("INSERT INTO bill (lease_id, amount, description, due_date, create_date) 
                            VALUES ((SELECT lease_id FROM lease WHERE customer_id = ? AND property_id = ? LIMIT 1)  , ?, 'Security Deposit', ?, ?)")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If


                'Monthly payments
                Dim months As Long = DateDiff("m", LeaseStartDateTimePicker.Value, LeaseEndDateTimePicker.Value)

                For index As Integer = 1 To months
                    Dim NameMonth As String
                    NameMonth = MonthName(Month(DateAdd("m", index, LeaseStartDateTimePicker.Value)))

                    DB.AddParam("@customer_id", CustomerIDTextBox.Text)
                    DB.AddParam("@property_id", PropertyIDTextBox.Text)
                    DB.AddParam("@amount", MonthlyRateTextBox.Text)
                    DB.AddParam("@desc", NameMonth + "'s Monthly Bill")
                    DB.AddParam("@due_date", DateAdd("d", 7, DateAdd("m", index, LeaseStartDateTimePicker.Value))) ' 7 days after each month
                    DB.AddParam("@create_date", Today.Date)

                    DB.ExecuteQuery("INSERT INTO bill (lease_id, amount, description, due_date, create_date) 
                            VALUES ((SELECT lease_id FROM lease WHERE customer_id = ? AND property_id = ? LIMIT 1)  , ?, ?, ?, ?)")

                    If DB.Exception <> String.Empty Then
                        MessageBox.Show(DB.Exception)
                        Exit Sub
                    End If

                Next

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If

                FillForm(ReviewApplicationForm.SelectedApplication)
            End If
        Else
            MessageBox.Show("Please make sure to read and approve the desclaimer")
            FillForm(ReviewApplicationForm.SelectedApplication)
        End If

        Dim EmailBody As String
        EmailBody = "<p>Dear " & ApplicationForm.UserNameTextBox.Text & ",</p>" &
                "<p>Thank you for submitting the application.</p>" &
                "<p>Your application is approved.</p>" &
                "<p>Regards,<br>" &
                "DIWProperties</p>"
        SendEmail(EmailTextBox.Text, " DIWProperties - Application Status", EmailBody)

    End Sub

    Private Sub RejectButton_Click(sender As Object, e As EventArgs) Handles RejectButton.Click
        If Desclaimer1Checkbox.Checked = True And Desclaimer2Checkbox.Checked = True Then
            Dim aDialogResult As DialogResult

            aDialogResult = MessageBox.Show("Are you sure to Approve Cusomter #" & CustomerIDTextBox.Text & "'s application",
                        "Approval Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

            If aDialogResult = vbNo Then
                Exit Sub
            Else
                'Update application
                DB.AddParam("@active_employee", ActiveUser.User_id)
                DB.AddParam("@application_id", ApplicationIdTextBox.Text)

                DB.ExecuteQuery("UPDATE application SET application_status = 'rejected', decision_by = ? WHERE application_id = ?")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                End If
            End If

        Else
            MessageBox.Show("Please make sure to read and approve the desclaimer")
            FillForm(ReviewApplicationForm.SelectedApplication)
        End If
        Dim EmailBody As String

        EmailBody = "<p>Dear" & ApplicationForm.UserNameTextBox.Text & ",</p>" &
                "<p>Thank you for submitting the application.</p>" &
                "<p>We are sorry to inform you that your application is Denied. For futher enquiries on application, please contact DIWProperties frontdesk. </p>" &
                "<p>Regards,<br>" &
                "DIWProperties</p>"
        SendEmail(EmailTextBox.Text, "DIWProperties - Application Status", EmailBody)
    End Sub
    Private Sub FieldsActivation(ApplicationStatus As String)
        Dim FieldsStatus As Boolean

        If ApplicationStatus = "pending" Then
            FieldsStatus = True
            ChangeStatusButton.Enabled = True
        ElseIf ApplicationStatus = "processing" Then
            FieldsStatus = True
            ChangeStatusButton.Enabled = False
        ElseIf ApplicationStatus = "approved" Or ApplicationStatus = "rejected" Then
            FieldsStatus = False
            ChangeStatusButton.Enabled = False
        End If

        ApproveButton.Enabled = FieldsStatus
        RejectButton.Enabled = FieldsStatus

        LeaseRateTextBox.Enabled = FieldsStatus
        SecurityDepositTextBox.Enabled = FieldsStatus
        LateFeeTextBox.Enabled = FieldsStatus
        LeaseStartDateTimePicker.Enabled = FieldsStatus
        LeaseEndDateTimePicker.Enabled = FieldsStatus
        ApplicationFeeTextBox.Enabled = FieldsStatus
        Desclaimer1Checkbox.Enabled = FieldsStatus
        Desclaimer2Checkbox.Enabled = FieldsStatus

    End Sub

    Private Function ValidateNewApplication() As Boolean

        ' Confirmation for non matching lease
        If LeaseRateTextBox.Text <> MonthlyRateTextBox.Text Then
            Dim LeaseDialogResult As DialogResult
            LeaseDialogResult = MessageBox.Show("The selected lease rate doesn't match the apartment lease rate. are you sure you want to proceed?",
                        "Approval Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2)

            If LeaseDialogResult = vbNo Then
                Return False
            End If
        End If

        'Lease Rate
        If String.IsNullOrWhiteSpace(LeaseRateTextBox.Text) Then
            MessageBox.Show("Lease rate can't be empty")
            LeaseRateTextBox.SelectAll()
            LeaseRateTextBox.Focus()
            Return False
        End If

        Dim LeaseRateDecimal As Decimal
        If Decimal.TryParse(LeaseRateTextBox.Text, LeaseRateDecimal) = False Then
            MessageBox.Show("Lease rate must be a number")
            LeaseRateTextBox.SelectAll()
            LeaseRateTextBox.Focus()
            Return False
        End If

        'Application fee
        If String.IsNullOrWhiteSpace(ApplicationFeeTextBox.Text) Then
            MessageBox.Show("Application fee can't be empty")
            ApplicationFeeTextBox.SelectAll()
            ApplicationFeeTextBox.Focus()
            Return False
        End If

        Dim ApplicationFeeDecimal As Decimal
        If Decimal.TryParse(ApplicationFeeTextBox.Text, ApplicationFeeDecimal) = False Then
            MessageBox.Show("Application fee must be a number")
            ApplicationFeeTextBox.SelectAll()
            ApplicationFeeTextBox.Focus()
            Return False
        End If

        'Security Deposit
        If String.IsNullOrWhiteSpace(SecurityDepositTextBox.Text) Then
            MessageBox.Show("Security deposit can't be empty")
            SecurityDepositTextBox.SelectAll()
            SecurityDepositTextBox.Focus()
            Return False
        End If

        Dim SecurityDepositDecimal As Decimal
        If Decimal.TryParse(SecurityDepositTextBox.Text, SecurityDepositDecimal) = False Then
            MessageBox.Show("Secuirty deposit must be a number")
            SecurityDepositTextBox.SelectAll()
            SecurityDepositTextBox.Focus()
            Return False
        End If

        'Late fee
        If String.IsNullOrWhiteSpace(LateFeeTextBox.Text) Then
            MessageBox.Show("Late fee can't be empty")
            LateFeeTextBox.SelectAll()
            LateFeeTextBox.Focus()
            Return False
        End If

        Dim LateFeeDecimal As Decimal
        If Decimal.TryParse(LateFeeTextBox.Text, LateFeeDecimal) = False Then
            MessageBox.Show("Late fee must be a number")
            LateFeeTextBox.SelectAll()
            LateFeeTextBox.Focus()
            Return False
        End If

        'Lease date end can't be before start date
        If DateDiff("d", LeaseStartDateTimePicker.Value, LeaseEndDateTimePicker.Value) < 0 Then
            MessageBox.Show("Lease start date can't be after the lease end date")
            Return False
        End If

        ' You cannot overlap lease
        If DateDiff("d", CurrentLeaseEndDateTimePicker.Value, LeaseStartDateTimePicker.Value) < 0 Then
            MessageBox.Show("The property is not available for this period of time")
            Return False
        End If

        Return True
    End Function
End Class