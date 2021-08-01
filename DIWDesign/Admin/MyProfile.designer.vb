<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfile
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyProfileCreateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LastUpdate = New System.Windows.Forms.Label()
        Me.MyProfilelastupdateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RoleNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Bisque
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.5!)
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(0, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(605, 53)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "   My Profile"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.Window
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UpdateButton.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.UpdateButton.Location = New System.Drawing.Point(152, 478)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 30)
        Me.UpdateButton.TabIndex = 81
        Me.UpdateButton.Text = "&Edit"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MyProfileCreateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.LastUpdate)
        Me.GroupBox1.Controls.Add(Me.MyProfilelastupdateTimePicker)
        Me.GroupBox1.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.RoleNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ContactNumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(542, 410)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Create Date:"
        '
        'MyProfileCreateDateTimePicker
        '
        Me.MyProfileCreateDateTimePicker.Enabled = False
        Me.MyProfileCreateDateTimePicker.Location = New System.Drawing.Point(160, 307)
        Me.MyProfileCreateDateTimePicker.Name = "MyProfileCreateDateTimePicker"
        Me.MyProfileCreateDateTimePicker.Size = New System.Drawing.Size(252, 23)
        Me.MyProfileCreateDateTimePicker.TabIndex = 204
        '
        'LastUpdate
        '
        Me.LastUpdate.AutoSize = True
        Me.LastUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastUpdate.Location = New System.Drawing.Point(59, 348)
        Me.LastUpdate.Name = "LastUpdate"
        Me.LastUpdate.Size = New System.Drawing.Size(84, 16)
        Me.LastUpdate.TabIndex = 203
        Me.LastUpdate.Text = "Last Update:"
        '
        'MyProfilelastupdateTimePicker
        '
        Me.MyProfilelastupdateTimePicker.Enabled = False
        Me.MyProfilelastupdateTimePicker.Location = New System.Drawing.Point(160, 348)
        Me.MyProfilelastupdateTimePicker.Name = "MyProfilelastupdateTimePicker"
        Me.MyProfilelastupdateTimePicker.Size = New System.Drawing.Size(252, 23)
        Me.MyProfilelastupdateTimePicker.TabIndex = 202
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(160, 266)
        Me.ConfirmPasswordTextBox.MaxLength = 45
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTextBox.ReadOnly = True
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(150, 25)
        Me.ConfirmPasswordTextBox.TabIndex = 199
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(20, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 18)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Confirm Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(160, 228)
        Me.PasswordTextBox.MaxLength = 45
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(150, 25)
        Me.PasswordTextBox.TabIndex = 197
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(72, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 18)
        Me.Label14.TabIndex = 196
        Me.Label14.Text = "Password:"
        '
        'RoleNameTextBox
        '
        Me.RoleNameTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.RoleNameTextBox.Location = New System.Drawing.Point(160, 55)
        Me.RoleNameTextBox.MaxLength = 45
        Me.RoleNameTextBox.Name = "RoleNameTextBox"
        Me.RoleNameTextBox.ReadOnly = True
        Me.RoleNameTextBox.Size = New System.Drawing.Size(120, 25)
        Me.RoleNameTextBox.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(103, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Role:"
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(160, 186)
        Me.ContactNumberTextBox.MaxLength = 10
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.ReadOnly = True
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(148, 25)
        Me.ContactNumberTextBox.TabIndex = 186
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label19.Location = New System.Drawing.Point(34, 186)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 18)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "Contact Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(26, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 18)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "*"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(160, 150)
        Me.EmailTextBox.MaxLength = 45
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(227, 25)
        Me.EmailTextBox.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(44, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Email Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(58, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 18)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "*"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.LastNameTextBox.Location = New System.Drawing.Point(160, 115)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(187, 25)
        Me.LastNameTextBox.TabIndex = 178
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(71, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 177
        Me.Label7.Text = "Last Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(57, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 18)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "*"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.FirstNameTextBox.Location = New System.Drawing.Point(160, 85)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(187, 25)
        Me.FirstNameTextBox.TabIndex = 175
        '
        'Label24
        '
        Me.Label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label24.Location = New System.Drawing.Point(71, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 18)
        Me.Label24.TabIndex = 174
        Me.Label24.Text = "First Name:"
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.UserIDTextBox.Location = New System.Drawing.Point(161, 24)
        Me.UserIDTextBox.MaxLength = 1
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.ReadOnly = True
        Me.UserIDTextBox.Size = New System.Drawing.Size(50, 25)
        Me.UserIDTextBox.TabIndex = 172
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(92, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 171
        Me.Label16.Text = "User ID:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(329, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 529)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "MyProfile"
        Me.Text = "Admin Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RoleNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContactNumberTextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MyProfileCreateDateTimePicker As DateTimePicker
    Friend WithEvents LastUpdate As Label
    Friend WithEvents MyProfilelastupdateTimePicker As DateTimePicker
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button1 As Button
End Class
