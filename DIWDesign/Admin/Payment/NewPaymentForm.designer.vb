<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPaymentForm
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
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox()
        Me.BillIdTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(100, 28)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIdTextBox.TabIndex = 0
        '
        'BillIdTextBox
        '
        Me.BillIdTextBox.Location = New System.Drawing.Point(100, 62)
        Me.BillIdTextBox.Name = "BillIdTextBox"
        Me.BillIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BillIdTextBox.TabIndex = 1
        '
        'PaymentDateTimePicker
        '
        Me.PaymentDateTimePicker.Location = New System.Drawing.Point(100, 137)
        Me.PaymentDateTimePicker.Name = "PaymentDateTimePicker"
        Me.PaymentDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PaymentDateTimePicker.TabIndex = 2
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(100, 99)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bill ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Payment Date:"
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.SandyBrown
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(100, 182)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.SandyBrown
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(225, 182)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'NewPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 226)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.PaymentDateTimePicker)
        Me.Controls.Add(Me.BillIdTextBox)
        Me.Controls.Add(Me.CustomerIdTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewPaymentForm"
        Me.Text = "New Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerIdTextBox As TextBox
    Friend WithEvents BillIdTextBox As TextBox
    Friend WithEvents PaymentDateTimePicker As DateTimePicker
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
