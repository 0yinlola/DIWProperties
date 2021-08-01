<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewApplicationExistingCustomerForm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AvailableFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.PropertyIdTextBox = New System.Windows.Forms.TextBox()
        Me.PrefferedStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.PropertyInfoTextBox = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LeaseDurationTextBox = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.PropertyAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AvailableFromDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Controls.Add(Me.Label65)
        Me.GroupBox2.Controls.Add(Me.PropertyIdTextBox)
        Me.GroupBox2.Controls.Add(Me.PrefferedStartDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Label64)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.PropertyInfoTextBox)
        Me.GroupBox2.Controls.Add(Me.Label61)
        Me.GroupBox2.Controls.Add(Me.Label62)
        Me.GroupBox2.Controls.Add(Me.Label63)
        Me.GroupBox2.Controls.Add(Me.LeaseDurationTextBox)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Controls.Add(Me.PropertyAddressTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 100)
        Me.GroupBox2.TabIndex = 172
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lease Information"
        '
        'AvailableFromDateTimePicker
        '
        Me.AvailableFromDateTimePicker.Enabled = False
        Me.AvailableFromDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AvailableFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AvailableFromDateTimePicker.Location = New System.Drawing.Point(128, 66)
        Me.AvailableFromDateTimePicker.Name = "AvailableFromDateTimePicker"
        Me.AvailableFromDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.AvailableFromDateTimePicker.TabIndex = 177
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(42, 69)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(79, 13)
        Me.Label68.TabIndex = 175
        Me.Label68.Text = "Available From:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label11.Location = New System.Drawing.Point(708, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "Number of months"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(701, 63)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(11, 13)
        Me.Label66.TabIndex = 173
        Me.Label66.Text = "*"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(672, 30)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(61, 13)
        Me.Label65.TabIndex = 172
        Me.Label65.Text = "Property Id:"
        '
        'PropertyIdTextBox
        '
        Me.PropertyIdTextBox.Location = New System.Drawing.Point(737, 26)
        Me.PropertyIdTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PropertyIdTextBox.Name = "PropertyIdTextBox"
        Me.PropertyIdTextBox.ReadOnly = True
        Me.PropertyIdTextBox.Size = New System.Drawing.Size(57, 20)
        Me.PropertyIdTextBox.TabIndex = 171
        '
        'PrefferedStartDateTimePicker
        '
        Me.PrefferedStartDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrefferedStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PrefferedStartDateTimePicker.Location = New System.Drawing.Point(428, 66)
        Me.PrefferedStartDateTimePicker.Name = "PrefferedStartDateTimePicker"
        Me.PrefferedStartDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.PrefferedStartDateTimePicker.TabIndex = 170
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Red
        Me.Label64.Location = New System.Drawing.Point(513, 61)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(11, 13)
        Me.Label64.TabIndex = 170
        Me.Label64.Text = "*"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(18, 26)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(104, 13)
        Me.Label52.TabIndex = 34
        Me.Label52.Text = "Property Information:"
        '
        'PropertyInfoTextBox
        '
        Me.PropertyInfoTextBox.Location = New System.Drawing.Point(126, 23)
        Me.PropertyInfoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PropertyInfoTextBox.Name = "PropertyInfoTextBox"
        Me.PropertyInfoTextBox.ReadOnly = True
        Me.PropertyInfoTextBox.Size = New System.Drawing.Size(185, 20)
        Me.PropertyInfoTextBox.TabIndex = 33
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(572, 66)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(0, 13)
        Me.Label61.TabIndex = 32
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(523, 70)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(82, 13)
        Me.Label62.TabIndex = 31
        Me.Label62.Text = "Lease Duration:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(316, 70)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 13)
        Me.Label63.TabIndex = 30
        Me.Label63.Text = "Preferred Start Date:"
        '
        'LeaseDurationTextBox
        '
        Me.LeaseDurationTextBox.Location = New System.Drawing.Point(608, 66)
        Me.LeaseDurationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LeaseDurationTextBox.Name = "LeaseDurationTextBox"
        Me.LeaseDurationTextBox.Size = New System.Drawing.Size(88, 20)
        Me.LeaseDurationTextBox.TabIndex = 29
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(336, 29)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(48, 13)
        Me.Label60.TabIndex = 18
        Me.Label60.Text = "Address:"
        '
        'PropertyAddressTextBox
        '
        Me.PropertyAddressTextBox.Location = New System.Drawing.Point(392, 26)
        Me.PropertyAddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PropertyAddressTextBox.Name = "PropertyAddressTextBox"
        Me.PropertyAddressTextBox.ReadOnly = True
        Me.PropertyAddressTextBox.Size = New System.Drawing.Size(246, 20)
        Me.PropertyAddressTextBox.TabIndex = 17
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.SandyBrown
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(856, 76)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 171
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.SandyBrown
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(856, 28)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 170
        Me.SaveButton.Text = "&Submit"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'NewApplicationExistingCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 135)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Name = "NewApplicationExistingCustomerForm"
        Me.Text = "NewApplicationExistingCustomerForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AvailableFromDateTimePicker As DateTimePicker
    Friend WithEvents Label68 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents PropertyIdTextBox As TextBox
    Friend WithEvents PrefferedStartDateTimePicker As DateTimePicker
    Friend WithEvents Label64 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents PropertyInfoTextBox As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents LeaseDurationTextBox As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents PropertyAddressTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
End Class
