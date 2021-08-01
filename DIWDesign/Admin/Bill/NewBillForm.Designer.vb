<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBillForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeaseIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Customer ID:"
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(97, 12)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIdTextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lease ID:"
        '
        'LeaseIdTextBox
        '
        Me.LeaseIdTextBox.Location = New System.Drawing.Point(97, 51)
        Me.LeaseIdTextBox.Name = "LeaseIdTextBox"
        Me.LeaseIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LeaseIdTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(97, 90)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(97, 125)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Due Date:"
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(97, 161)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 13
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.SandyBrown
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(222, 207)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.SandyBrown
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(97, 207)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 23)
        Me.SaveButton.TabIndex = 15
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(203, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(203, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(203, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "*"
        '
        'NewBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(316, 242)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DueDateDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeaseIdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerIdTextBox)
        Me.Name = "NewBillForm"
        Me.Text = "NewBillForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerIdTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LeaseIdTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DueDateDateTimePicker As DateTimePicker
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
