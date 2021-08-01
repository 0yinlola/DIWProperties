<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingPaymentForm
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BillIdTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaymentIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.SandyBrown
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(232, 250)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 19
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'EditSaveButton
        '
        Me.EditSaveButton.BackColor = System.Drawing.Color.SandyBrown
        Me.EditSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditSaveButton.Location = New System.Drawing.Point(107, 250)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(100, 23)
        Me.EditSaveButton.TabIndex = 18
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Payment Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Bill ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer ID:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(107, 167)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 13
        '
        'PaymentDateTimePicker
        '
        Me.PaymentDateTimePicker.Location = New System.Drawing.Point(107, 205)
        Me.PaymentDateTimePicker.Name = "PaymentDateTimePicker"
        Me.PaymentDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PaymentDateTimePicker.TabIndex = 12
        '
        'BillIdTextBox
        '
        Me.BillIdTextBox.Location = New System.Drawing.Point(107, 130)
        Me.BillIdTextBox.Name = "BillIdTextBox"
        Me.BillIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BillIdTextBox.TabIndex = 11
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(107, 96)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIdTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Payment ID:"
        '
        'PaymentIdTextBox
        '
        Me.PaymentIdTextBox.Location = New System.Drawing.Point(107, 58)
        Me.PaymentIdTextBox.Name = "PaymentIdTextBox"
        Me.PaymentIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaymentIdTextBox.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Full Name:"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(107, 21)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FullNameTextBox.TabIndex = 22
        '
        'ExistingPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 288)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaymentIdTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.PaymentDateTimePicker)
        Me.Controls.Add(Me.BillIdTextBox)
        Me.Controls.Add(Me.CustomerIdTextBox)
        Me.Name = "ExistingPaymentForm"
        Me.Text = "ExistingPaymentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents PaymentDateTimePicker As DateTimePicker
    Friend WithEvents BillIdTextBox As TextBox
    Friend WithEvents CustomerIdTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PaymentIdTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FullNameTextBox As TextBox
End Class
