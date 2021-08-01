<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExistingPropertyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PropertyTypeListBox = New System.Windows.Forms.ListBox()
        Me.SFTextBox = New System.Windows.Forms.TextBox()
        Me.YearBuiltTextBox = New System.Windows.Forms.TextBox()
        Me.NumBathroomTextBox = New System.Windows.Forms.TextBox()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.NumRoomTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StateListBox = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Street2TextBox = New System.Windows.Forms.TextBox()
        Me.Street1TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BasementCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.CreateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BrowserImageButton = New System.Windows.Forms.Button()
        Me.PropertyPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DisposalCheckBox = New System.Windows.Forms.CheckBox()
        Me.DryerCheckBox = New System.Windows.Forms.CheckBox()
        Me.WasherCheckBox = New System.Windows.Forms.CheckBox()
        Me.DishwasherCheckBox = New System.Windows.Forms.CheckBox()
        Me.StoveCheckBox = New System.Windows.Forms.CheckBox()
        Me.ACCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefrigeratorCheckBox = New System.Windows.Forms.CheckBox()
        Me.GarageCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MonthlyRateTextBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropertyTypeListBox
        '
        Me.PropertyTypeListBox.FormattingEnabled = True
        Me.PropertyTypeListBox.Items.AddRange(New Object() {"Condominium", "Townhouse", "Single House"})
        Me.PropertyTypeListBox.Location = New System.Drawing.Point(320, 19)
        Me.PropertyTypeListBox.Name = "PropertyTypeListBox"
        Me.PropertyTypeListBox.Size = New System.Drawing.Size(92, 30)
        Me.PropertyTypeListBox.TabIndex = 18
        '
        'SFTextBox
        '
        Me.SFTextBox.Location = New System.Drawing.Point(356, 53)
        Me.SFTextBox.MaxLength = 10
        Me.SFTextBox.Name = "SFTextBox"
        Me.SFTextBox.Size = New System.Drawing.Size(56, 20)
        Me.SFTextBox.TabIndex = 17
        '
        'YearBuiltTextBox
        '
        Me.YearBuiltTextBox.Location = New System.Drawing.Point(218, 53)
        Me.YearBuiltTextBox.MaxLength = 4
        Me.YearBuiltTextBox.Name = "YearBuiltTextBox"
        Me.YearBuiltTextBox.Size = New System.Drawing.Size(48, 20)
        Me.YearBuiltTextBox.TabIndex = 16
        '
        'NumBathroomTextBox
        '
        Me.NumBathroomTextBox.Location = New System.Drawing.Point(124, 53)
        Me.NumBathroomTextBox.MaxLength = 6
        Me.NumBathroomTextBox.Name = "NumBathroomTextBox"
        Me.NumBathroomTextBox.Size = New System.Drawing.Size(41, 20)
        Me.NumBathroomTextBox.TabIndex = 15
        Me.NumBathroomTextBox.Text = " "
        '
        'EditSaveButton
        '
        Me.EditSaveButton.Location = New System.Drawing.Point(314, 349)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 24
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = True
        '
        'NumRoomTextBox
        '
        Me.NumRoomTextBox.Location = New System.Drawing.Point(110, 27)
        Me.NumRoomTextBox.MaxLength = 6
        Me.NumRoomTextBox.Name = "NumRoomTextBox"
        Me.NumRoomTextBox.Size = New System.Drawing.Size(35, 20)
        Me.NumRoomTextBox.TabIndex = 12
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(291, 53)
        Me.ZipCodeTextBox.MaxLength = 5
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(113, 20)
        Me.ZipCodeTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StateListBox)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.ZipCodeTextBox)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.Street2TextBox)
        Me.GroupBox1.Controls.Add(Me.Street1TextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 84)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'StateListBox
        '
        Me.StateListBox.AllowDrop = True
        Me.StateListBox.FormattingEnabled = True
        Me.StateListBox.Items.AddRange(New Object() {"AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"})
        Me.StateListBox.Location = New System.Drawing.Point(186, 51)
        Me.StateListBox.Name = "StateListBox"
        Me.StateListBox.Size = New System.Drawing.Size(58, 30)
        Me.StateListBox.TabIndex = 22
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(169, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(40, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(59, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "*"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(57, 53)
        Me.CityTextBox.MaxLength = 15
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(75, 20)
        Me.CityTextBox.TabIndex = 7
        '
        'Street2TextBox
        '
        Me.Street2TextBox.Location = New System.Drawing.Point(291, 27)
        Me.Street2TextBox.MaxLength = 50
        Me.Street2TextBox.Name = "Street2TextBox"
        Me.Street2TextBox.Size = New System.Drawing.Size(113, 20)
        Me.Street2TextBox.TabIndex = 6
        '
        'Street1TextBox
        '
        Me.Street1TextBox.Location = New System.Drawing.Point(76, 27)
        Me.Street1TextBox.MaxLength = 50
        Me.Street1TextBox.Name = "Street1TextBox"
        Me.Street1TextBox.Size = New System.Drawing.Size(159, 20)
        Me.Street1TextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Street 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Zip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Street 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(156, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Basement"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Square Footage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Number of Bathrooms"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(314, 390)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 25
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BasementCheckBox)
        Me.GroupBox2.Controls.Add(Me.PropertyTypeListBox)
        Me.GroupBox2.Controls.Add(Me.SFTextBox)
        Me.GroupBox2.Controls.Add(Me.YearBuiltTextBox)
        Me.GroupBox2.Controls.Add(Me.NumBathroomTextBox)
        Me.GroupBox2.Controls.Add(Me.NumRoomTextBox)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 80)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Property Description"
        '
        'BasementCheckBox
        '
        Me.BasementCheckBox.AutoSize = True
        Me.BasementCheckBox.Location = New System.Drawing.Point(212, 30)
        Me.BasementCheckBox.Name = "BasementCheckBox"
        Me.BasementCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.BasementCheckBox.TabIndex = 26
        Me.BasementCheckBox.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Property Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Year Built"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Number of Rooms"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 13)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Property ID"
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(83, 7)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PropertyIDTextBox.TabIndex = 28
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(93, 305)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ActiveCheckBox.TabIndex = 29
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'CreateDateTimePicker
        '
        Me.CreateDateTimePicker.Location = New System.Drawing.Point(208, 303)
        Me.CreateDateTimePicker.Name = "CreateDateTimePicker"
        Me.CreateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CreateDateTimePicker.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(31, 305)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Is Active?"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(135, 306)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Create Date"
        '
        'BrowserImageButton
        '
        Me.BrowserImageButton.Location = New System.Drawing.Point(183, 349)
        Me.BrowserImageButton.Name = "BrowserImageButton"
        Me.BrowserImageButton.Size = New System.Drawing.Size(107, 23)
        Me.BrowserImageButton.TabIndex = 34
        Me.BrowserImageButton.Text = "&Browse Image"
        Me.BrowserImageButton.UseVisualStyleBackColor = True
        '
        'PropertyPictureBox
        '
        Me.PropertyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PropertyPictureBox.Location = New System.Drawing.Point(68, 336)
        Me.PropertyPictureBox.Name = "PropertyPictureBox"
        Me.PropertyPictureBox.Size = New System.Drawing.Size(91, 84)
        Me.PropertyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PropertyPictureBox.TabIndex = 33
        Me.PropertyPictureBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DisposalCheckBox)
        Me.GroupBox3.Controls.Add(Me.DryerCheckBox)
        Me.GroupBox3.Controls.Add(Me.WasherCheckBox)
        Me.GroupBox3.Controls.Add(Me.DishwasherCheckBox)
        Me.GroupBox3.Controls.Add(Me.StoveCheckBox)
        Me.GroupBox3.Controls.Add(Me.ACCheckBox)
        Me.GroupBox3.Controls.Add(Me.RefrigeratorCheckBox)
        Me.GroupBox3.Controls.Add(Me.GarageCheckBox)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 81)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ameniy"
        '
        'DisposalCheckBox
        '
        Me.DisposalCheckBox.AutoSize = True
        Me.DisposalCheckBox.Location = New System.Drawing.Point(257, 47)
        Me.DisposalCheckBox.Name = "DisposalCheckBox"
        Me.DisposalCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DisposalCheckBox.TabIndex = 32
        Me.DisposalCheckBox.UseVisualStyleBackColor = True
        '
        'DryerCheckBox
        '
        Me.DryerCheckBox.AutoSize = True
        Me.DryerCheckBox.Location = New System.Drawing.Point(130, 48)
        Me.DryerCheckBox.Name = "DryerCheckBox"
        Me.DryerCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DryerCheckBox.TabIndex = 31
        Me.DryerCheckBox.UseVisualStyleBackColor = True
        '
        'WasherCheckBox
        '
        Me.WasherCheckBox.AutoSize = True
        Me.WasherCheckBox.Location = New System.Drawing.Point(61, 47)
        Me.WasherCheckBox.Name = "WasherCheckBox"
        Me.WasherCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.WasherCheckBox.TabIndex = 30
        Me.WasherCheckBox.UseVisualStyleBackColor = True
        '
        'DishwasherCheckBox
        '
        Me.DishwasherCheckBox.AutoSize = True
        Me.DishwasherCheckBox.Location = New System.Drawing.Point(381, 20)
        Me.DishwasherCheckBox.Name = "DishwasherCheckBox"
        Me.DishwasherCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DishwasherCheckBox.TabIndex = 29
        Me.DishwasherCheckBox.UseVisualStyleBackColor = True
        '
        'StoveCheckBox
        '
        Me.StoveCheckBox.AutoSize = True
        Me.StoveCheckBox.Location = New System.Drawing.Point(286, 19)
        Me.StoveCheckBox.Name = "StoveCheckBox"
        Me.StoveCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.StoveCheckBox.TabIndex = 28
        Me.StoveCheckBox.UseVisualStyleBackColor = True
        '
        'ACCheckBox
        '
        Me.ACCheckBox.AutoSize = True
        Me.ACCheckBox.Location = New System.Drawing.Point(218, 20)
        Me.ACCheckBox.Name = "ACCheckBox"
        Me.ACCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.ACCheckBox.TabIndex = 27
        Me.ACCheckBox.UseVisualStyleBackColor = True
        '
        'RefrigeratorCheckBox
        '
        Me.RefrigeratorCheckBox.AutoSize = True
        Me.RefrigeratorCheckBox.Location = New System.Drawing.Point(156, 20)
        Me.RefrigeratorCheckBox.Name = "RefrigeratorCheckBox"
        Me.RefrigeratorCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.RefrigeratorCheckBox.TabIndex = 26
        Me.RefrigeratorCheckBox.UseVisualStyleBackColor = True
        '
        'GarageCheckBox
        '
        Me.GarageCheckBox.AutoSize = True
        Me.GarageCheckBox.Location = New System.Drawing.Point(61, 20)
        Me.GarageCheckBox.Name = "GarageCheckBox"
        Me.GarageCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.GarageCheckBox.TabIndex = 25
        Me.GarageCheckBox.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(162, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Garbage Disposal"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(247, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Stove"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(94, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Dryer"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Washer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(315, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Dishwasher"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "A/C"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Refrigerator"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Garage"
        '
        'MonthlyRateTextBox
        '
        Me.MonthlyRateTextBox.Location = New System.Drawing.Point(295, 7)
        Me.MonthlyRateTextBox.Name = "MonthlyRateTextBox"
        Me.MonthlyRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MonthlyRateTextBox.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(221, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "Monthy Rate"
        '
        'ExistingPropertyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 432)
        Me.Controls.Add(Me.MonthlyRateTextBox)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BrowserImageButton)
        Me.Controls.Add(Me.PropertyPictureBox)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.CreateDateTimePicker)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.PropertyIDTextBox)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExistingPropertyForm"
        Me.Text = "Existing Property"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PropertyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PropertyTypeListBox As ListBox
    Friend WithEvents SFTextBox As TextBox
    Friend WithEvents YearBuiltTextBox As TextBox
    Friend WithEvents NumBathroomTextBox As TextBox
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents NumRoomTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StateListBox As ListBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Street2TextBox As TextBox
    Friend WithEvents Street1TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents CreateDateTimePicker As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents BrowserImageButton As Button
    Friend WithEvents PropertyPictureBox As PictureBox
    Friend WithEvents BasementCheckBox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DisposalCheckBox As CheckBox
    Friend WithEvents DryerCheckBox As CheckBox
    Friend WithEvents WasherCheckBox As CheckBox
    Friend WithEvents DishwasherCheckBox As CheckBox
    Friend WithEvents StoveCheckBox As CheckBox
    Friend WithEvents ACCheckBox As CheckBox
    Friend WithEvents RefrigeratorCheckBox As CheckBox
    Friend WithEvents GarageCheckBox As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MonthlyRateTextBox As TextBox
    Friend WithEvents Label26 As Label
End Class
