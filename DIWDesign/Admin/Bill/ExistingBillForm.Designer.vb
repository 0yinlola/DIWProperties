<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistingBillForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeaseIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BillIdTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.EditSaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(93, 138)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(93, 101)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Lease ID:"
        '
        'LeaseIdTextBox
        '
        Me.LeaseIdTextBox.Location = New System.Drawing.Point(93, 64)
        Me.LeaseIdTextBox.Name = "LeaseIdTextBox"
        Me.LeaseIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LeaseIdTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bill ID:"
        '
        'BillIdTextBox
        '
        Me.BillIdTextBox.Location = New System.Drawing.Point(93, 25)
        Me.BillIdTextBox.Name = "BillIdTextBox"
        Me.BillIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BillIdTextBox.TabIndex = 13
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.SandyBrown
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelButton.Location = New System.Drawing.Point(218, 174)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 22
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'EditSaveButton
        '
        Me.EditSaveButton.BackColor = System.Drawing.Color.SandyBrown
        Me.EditSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditSaveButton.Location = New System.Drawing.Point(93, 174)
        Me.EditSaveButton.Name = "EditSaveButton"
        Me.EditSaveButton.Size = New System.Drawing.Size(100, 23)
        Me.EditSaveButton.TabIndex = 21
        Me.EditSaveButton.Text = "&Edit"
        Me.EditSaveButton.UseVisualStyleBackColor = False
        '
        'ExistingBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 215)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EditSaveButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeaseIdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BillIdTextBox)
        Me.Name = "ExistingBillForm"
        Me.Text = "ExistingBillForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LeaseIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BillIdTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents EditSaveButton As Button
End Class
