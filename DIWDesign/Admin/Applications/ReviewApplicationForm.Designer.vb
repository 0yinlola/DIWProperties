<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewApplicationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProcessApplicationButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox()
        Me.UserAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LeaseEndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PropertyAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PropertyAvailableLabel = New System.Windows.Forms.Label()
        Me.PropertyIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CreateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DecisionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProcessDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PreferredStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ApplicationStatusLabel = New System.Windows.Forms.Label()
        Me.DecisionByTextBox = New System.Windows.Forms.TextBox()
        Me.ProcessedByTextBox = New System.Windows.Forms.TextBox()
        Me.LeaseDurationTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicationIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SearchLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SearchApplicationIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SerachCustomerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.RejectedRadioButton = New System.Windows.Forms.RadioButton()
        Me.ApprovedRadioButton = New System.Windows.Forms.RadioButton()
        Me.ProcessingRadioButton = New System.Windows.Forms.RadioButton()
        Me.PendingRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBDataGridView
        '
        Me.DBDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(21, 170)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.Size = New System.Drawing.Size(351, 319)
        Me.DBDataGridView.TabIndex = 0
        '
        'ProcessApplicationButton
        '
        Me.ProcessApplicationButton.Location = New System.Drawing.Point(550, 152)
        Me.ProcessApplicationButton.Name = "ProcessApplicationButton"
        Me.ProcessApplicationButton.Size = New System.Drawing.Size(133, 28)
        Me.ProcessApplicationButton.TabIndex = 1
        Me.ProcessApplicationButton.Text = "Process Application"
        Me.ProcessApplicationButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DOBTextBox)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CustomerIdTextBox)
        Me.GroupBox1.Controls.Add(Me.UserAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 140)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'DOBTextBox
        '
        Me.DOBTextBox.Location = New System.Drawing.Point(389, 76)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.ReadOnly = True
        Me.DOBTextBox.Size = New System.Drawing.Size(155, 20)
        Me.DOBTextBox.TabIndex = 19
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(388, 52)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.ReadOnly = True
        Me.UserNameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.UserNameTextBox.TabIndex = 18
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(388, 23)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.ReadOnly = True
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(156, 20)
        Me.CustomerIdTextBox.TabIndex = 17
        '
        'UserAddressTextBox
        '
        Me.UserAddressTextBox.Location = New System.Drawing.Point(129, 105)
        Me.UserAddressTextBox.Name = "UserAddressTextBox"
        Me.UserAddressTextBox.ReadOnly = True
        Me.UserAddressTextBox.Size = New System.Drawing.Size(415, 20)
        Me.UserAddressTextBox.TabIndex = 16
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(129, 79)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(167, 20)
        Me.PhoneTextBox.TabIndex = 15
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(129, 52)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(167, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(129, 26)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NameTextBox.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Username:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LeaseEndDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.PropertyAddressTextBox)
        Me.GroupBox2.Controls.Add(Me.PropertyAvailableLabel)
        Me.GroupBox2.Controls.Add(Me.PropertyIdTextBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(378, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 92)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Property Information"
        '
        'LeaseEndDateTimePicker
        '
        Me.LeaseEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LeaseEndDateTimePicker.Location = New System.Drawing.Point(406, 26)
        Me.LeaseEndDateTimePicker.Name = "LeaseEndDateTimePicker"
        Me.LeaseEndDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.LeaseEndDateTimePicker.TabIndex = 34
        '
        'PropertyAddressTextBox
        '
        Me.PropertyAddressTextBox.Location = New System.Drawing.Point(129, 55)
        Me.PropertyAddressTextBox.Name = "PropertyAddressTextBox"
        Me.PropertyAddressTextBox.ReadOnly = True
        Me.PropertyAddressTextBox.Size = New System.Drawing.Size(415, 20)
        Me.PropertyAddressTextBox.TabIndex = 21
        '
        'PropertyAvailableLabel
        '
        Me.PropertyAvailableLabel.AutoSize = True
        Me.PropertyAvailableLabel.Location = New System.Drawing.Point(314, 29)
        Me.PropertyAvailableLabel.Name = "PropertyAvailableLabel"
        Me.PropertyAvailableLabel.Size = New System.Drawing.Size(87, 13)
        Me.PropertyAvailableLabel.TabIndex = 13
        Me.PropertyAvailableLabel.Text = "Lease End Date:"
        '
        'PropertyIdTextBox
        '
        Me.PropertyIdTextBox.Location = New System.Drawing.Point(129, 29)
        Me.PropertyIdTextBox.Name = "PropertyIdTextBox"
        Me.PropertyIdTextBox.ReadOnly = True
        Me.PropertyIdTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PropertyIdTextBox.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Property ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CreateDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.DecisionDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.ProcessDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.PreferredStartDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.ApplicationStatusLabel)
        Me.GroupBox3.Controls.Add(Me.DecisionByTextBox)
        Me.GroupBox3.Controls.Add(Me.ProcessedByTextBox)
        Me.GroupBox3.Controls.Add(Me.LeaseDurationTextBox)
        Me.GroupBox3.Controls.Add(Me.ApplicationIdTextBox)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ProcessApplicationButton)
        Me.GroupBox3.Location = New System.Drawing.Point(378, 303)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(692, 186)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lease Information"
        '
        'CreateDateTimePicker
        '
        Me.CreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CreateDateTimePicker.Location = New System.Drawing.Point(129, 65)
        Me.CreateDateTimePicker.Name = "CreateDateTimePicker"
        Me.CreateDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.CreateDateTimePicker.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Create Date"
        '
        'DecisionDateTimePicker
        '
        Me.DecisionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DecisionDateTimePicker.Location = New System.Drawing.Point(553, 96)
        Me.DecisionDateTimePicker.Name = "DecisionDateTimePicker"
        Me.DecisionDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.DecisionDateTimePicker.TabIndex = 37
        '
        'ProcessDateTimePicker
        '
        Me.ProcessDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ProcessDateTimePicker.Location = New System.Drawing.Point(553, 60)
        Me.ProcessDateTimePicker.Name = "ProcessDateTimePicker"
        Me.ProcessDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.ProcessDateTimePicker.TabIndex = 36
        '
        'PreferredStartDateTimePicker
        '
        Me.PreferredStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PreferredStartDateTimePicker.Location = New System.Drawing.Point(129, 102)
        Me.PreferredStartDateTimePicker.Name = "PreferredStartDateTimePicker"
        Me.PreferredStartDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.PreferredStartDateTimePicker.TabIndex = 35
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(601, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Date"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(455, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Name"
        '
        'ApplicationStatusLabel
        '
        Me.ApplicationStatusLabel.AutoSize = True
        Me.ApplicationStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationStatusLabel.Location = New System.Drawing.Point(403, 160)
        Me.ApplicationStatusLabel.Name = "ApplicationStatusLabel"
        Me.ApplicationStatusLabel.Size = New System.Drawing.Size(43, 13)
        Me.ApplicationStatusLabel.TabIndex = 27
        Me.ApplicationStatusLabel.Text = "Status"
        '
        'DecisionByTextBox
        '
        Me.DecisionByTextBox.Location = New System.Drawing.Point(406, 97)
        Me.DecisionByTextBox.Name = "DecisionByTextBox"
        Me.DecisionByTextBox.ReadOnly = True
        Me.DecisionByTextBox.Size = New System.Drawing.Size(137, 20)
        Me.DecisionByTextBox.TabIndex = 26
        '
        'ProcessedByTextBox
        '
        Me.ProcessedByTextBox.Location = New System.Drawing.Point(406, 60)
        Me.ProcessedByTextBox.Name = "ProcessedByTextBox"
        Me.ProcessedByTextBox.ReadOnly = True
        Me.ProcessedByTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ProcessedByTextBox.TabIndex = 25
        '
        'LeaseDurationTextBox
        '
        Me.LeaseDurationTextBox.Location = New System.Drawing.Point(129, 137)
        Me.LeaseDurationTextBox.Name = "LeaseDurationTextBox"
        Me.LeaseDurationTextBox.ReadOnly = True
        Me.LeaseDurationTextBox.Size = New System.Drawing.Size(137, 20)
        Me.LeaseDurationTextBox.TabIndex = 24
        '
        'ApplicationIdTextBox
        '
        Me.ApplicationIdTextBox.Location = New System.Drawing.Point(129, 25)
        Me.ApplicationIdTextBox.Name = "ApplicationIdTextBox"
        Me.ApplicationIdTextBox.ReadOnly = True
        Me.ApplicationIdTextBox.Size = New System.Drawing.Size(137, 20)
        Me.ApplicationIdTextBox.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(302, 160)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Application Status:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(313, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Decision By:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(307, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Processed By:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Lease Duration:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Preferred Start Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Application ID:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Last Name:"
        '
        'SearchLastNameTextBox
        '
        Me.SearchLastNameTextBox.Location = New System.Drawing.Point(97, 49)
        Me.SearchLastNameTextBox.Name = "SearchLastNameTextBox"
        Me.SearchLastNameTextBox.Size = New System.Drawing.Size(94, 20)
        Me.SearchLastNameTextBox.TabIndex = 20
        '
        'SearchApplicationIdTextBox
        '
        Me.SearchApplicationIdTextBox.Location = New System.Drawing.Point(97, 19)
        Me.SearchApplicationIdTextBox.Name = "SearchApplicationIdTextBox"
        Me.SearchApplicationIdTextBox.Size = New System.Drawing.Size(94, 20)
        Me.SearchApplicationIdTextBox.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Application ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.SerachCustomerIdTextBox)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.RejectedRadioButton)
        Me.GroupBox4.Controls.Add(Me.ApprovedRadioButton)
        Me.GroupBox4.Controls.Add(Me.ProcessingRadioButton)
        Me.GroupBox4.Controls.Add(Me.PendingRadioButton)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.SearchApplicationIdTextBox)
        Me.GroupBox4.Controls.Add(Me.SearchLastNameTextBox)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(351, 105)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search Box"
        '
        'SerachCustomerIdTextBox
        '
        Me.SerachCustomerIdTextBox.Location = New System.Drawing.Point(97, 77)
        Me.SerachCustomerIdTextBox.Name = "SerachCustomerIdTextBox"
        Me.SerachCustomerIdTextBox.Size = New System.Drawing.Size(94, 20)
        Me.SerachCustomerIdTextBox.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Customer ID:"
        '
        'RejectedRadioButton
        '
        Me.RejectedRadioButton.AutoSize = True
        Me.RejectedRadioButton.Location = New System.Drawing.Point(239, 79)
        Me.RejectedRadioButton.Name = "RejectedRadioButton"
        Me.RejectedRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.RejectedRadioButton.TabIndex = 27
        Me.RejectedRadioButton.Text = "Rejected"
        Me.RejectedRadioButton.UseVisualStyleBackColor = True
        '
        'ApprovedRadioButton
        '
        Me.ApprovedRadioButton.AutoSize = True
        Me.ApprovedRadioButton.Location = New System.Drawing.Point(239, 56)
        Me.ApprovedRadioButton.Name = "ApprovedRadioButton"
        Me.ApprovedRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.ApprovedRadioButton.TabIndex = 26
        Me.ApprovedRadioButton.Text = "Approved"
        Me.ApprovedRadioButton.UseVisualStyleBackColor = True
        '
        'ProcessingRadioButton
        '
        Me.ProcessingRadioButton.AutoSize = True
        Me.ProcessingRadioButton.Location = New System.Drawing.Point(239, 33)
        Me.ProcessingRadioButton.Name = "ProcessingRadioButton"
        Me.ProcessingRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.ProcessingRadioButton.TabIndex = 25
        Me.ProcessingRadioButton.Text = "Processing"
        Me.ProcessingRadioButton.UseVisualStyleBackColor = True
        '
        'PendingRadioButton
        '
        Me.PendingRadioButton.AutoSize = True
        Me.PendingRadioButton.Checked = True
        Me.PendingRadioButton.Location = New System.Drawing.Point(239, 10)
        Me.PendingRadioButton.Name = "PendingRadioButton"
        Me.PendingRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.PendingRadioButton.TabIndex = 24
        Me.PendingRadioButton.TabStop = True
        Me.PendingRadioButton.Text = "Pending"
        Me.PendingRadioButton.UseVisualStyleBackColor = True
        '
        'ReviewApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 501)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DBDataGridView)
        Me.Name = "ReviewApplicationForm"
        Me.Text = "ProcessApplicationForm"
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents ProcessApplicationButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DOBTextBox As TextBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents CustomerIdTextBox As TextBox
    Friend WithEvents UserAddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PropertyAddressTextBox As TextBox
    Friend WithEvents PropertyAvailableLabel As Label
    Friend WithEvents PropertyIdTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ApplicationStatusLabel As Label
    Friend WithEvents DecisionByTextBox As TextBox
    Friend WithEvents ProcessedByTextBox As TextBox
    Friend WithEvents LeaseDurationTextBox As TextBox
    Friend WithEvents ApplicationIdTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SearchLastNameTextBox As TextBox
    Friend WithEvents SearchApplicationIdTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents SerachCustomerIdTextBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents RejectedRadioButton As RadioButton
    Friend WithEvents ApprovedRadioButton As RadioButton
    Friend WithEvents ProcessingRadioButton As RadioButton
    Friend WithEvents PendingRadioButton As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LeaseEndDateTimePicker As DateTimePicker
    Friend WithEvents DecisionDateTimePicker As DateTimePicker
    Friend WithEvents ProcessDateTimePicker As DateTimePicker
    Friend WithEvents PreferredStartDateTimePicker As DateTimePicker
    Friend WithEvents CreateDateTimePicker As DateTimePicker
    Friend WithEvents Label17 As Label
End Class
