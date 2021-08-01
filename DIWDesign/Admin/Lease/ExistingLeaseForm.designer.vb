<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingLeaseForm
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LeaseIDTextBox = New System.Windows.Forms.TextBox()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.LeaseEndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LeaseStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.LeaseRateTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 41)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 483
        Me.Label10.Text = "Lease ID:"
        '
        'LeaseIDTextBox
        '
        Me.LeaseIDTextBox.Location = New System.Drawing.Point(150, 37)
        Me.LeaseIDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseIDTextBox.Name = "LeaseIDTextBox"
        Me.LeaseIDTextBox.ReadOnly = True
        Me.LeaseIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.LeaseIDTextBox.TabIndex = 482
        '
        'EditSaveButton
        '
        Me.EditSaveButton.BackColor = System.Drawing.Color.White
        Me.EditSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveButton.Location = New System.Drawing.Point(54, 395)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSaveButton.TabIndex = 505
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.White
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(176, 395)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 504
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'LeaseEndDateTimePicker
        '
        Me.LeaseEndDateTimePicker.Location = New System.Drawing.Point(144, 283)
        Me.LeaseEndDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseEndDateTimePicker.Name = "LeaseEndDateTimePicker"
        Me.LeaseEndDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.LeaseEndDateTimePicker.TabIndex = 503
        '
        'LeaseStartDateTimePicker
        '
        Me.LeaseStartDateTimePicker.Location = New System.Drawing.Point(144, 233)
        Me.LeaseStartDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseStartDateTimePicker.Name = "LeaseStartDateTimePicker"
        Me.LeaseStartDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.LeaseStartDateTimePicker.TabIndex = 502
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(84, 339)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 501
        Me.Label13.Text = "Active:"
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.AutoSize = True
        Me.ActiveCheckBox.Location = New System.Drawing.Point(144, 333)
        Me.ActiveCheckBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(29, 17)
        Me.ActiveCheckBox.TabIndex = 500
        Me.ActiveCheckBox.Text = " "
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 290)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 497
        Me.Label6.Text = "Lease End Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 496
        Me.Label5.Text = "Lease Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 495
        Me.Label3.Text = "Lease Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 494
        Me.Label2.Text = "Property ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 493
        Me.Label1.Text = "Username:"
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(150, 86)
        Me.PropertyIDTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.ReadOnly = True
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.PropertyIDTextBox.TabIndex = 492
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(144, 141)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = True
        Me.UsernameTextBox.Size = New System.Drawing.Size(99, 20)
        Me.UsernameTextBox.TabIndex = 491
        '
        'LeaseRateTextBox
        '
        Me.LeaseRateTextBox.Location = New System.Drawing.Point(144, 183)
        Me.LeaseRateTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseRateTextBox.Name = "LeaseRateTextBox"
        Me.LeaseRateTextBox.ReadOnly = True
        Me.LeaseRateTextBox.Size = New System.Drawing.Size(54, 20)
        Me.LeaseRateTextBox.TabIndex = 490
        '
        'ExistingLeaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 456)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.LeaseEndDateTimePicker)
        Me.Controls.Add(Me.LeaseStartDateTimePicker)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PropertyIDTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.LeaseRateTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LeaseIDTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ExistingLeaseForm"
        Me.Text = "ExistingLeaseForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents LeaseIDTextBox As TextBox
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents LeaseEndDateTimePicker As DateTimePicker
    Friend WithEvents LeaseStartDateTimePicker As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents ActiveCheckBox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents LeaseRateTextBox As TextBox
End Class
