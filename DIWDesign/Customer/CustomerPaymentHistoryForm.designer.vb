<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerPaymentHistoryForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaymentDateTextBox = New System.Windows.Forms.TextBox()
        Me.BillDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BillAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BillDBDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BillDBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PaymentDateTextBox)
        Me.GroupBox1.Controls.Add(Me.BillDescriptionTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BillAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 69)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Bill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Payment Date:"
        '
        'PaymentDateTextBox
        '
        Me.PaymentDateTextBox.Location = New System.Drawing.Point(613, 37)
        Me.PaymentDateTextBox.Name = "PaymentDateTextBox"
        Me.PaymentDateTextBox.ReadOnly = True
        Me.PaymentDateTextBox.Size = New System.Drawing.Size(104, 22)
        Me.PaymentDateTextBox.TabIndex = 4
        '
        'BillDescriptionTextBox
        '
        Me.BillDescriptionTextBox.Location = New System.Drawing.Point(315, 34)
        Me.BillDescriptionTextBox.Name = "BillDescriptionTextBox"
        Me.BillDescriptionTextBox.ReadOnly = True
        Me.BillDescriptionTextBox.Size = New System.Drawing.Size(159, 22)
        Me.BillDescriptionTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bill Description:"
        '
        'BillAmountTextBox
        '
        Me.BillAmountTextBox.Location = New System.Drawing.Point(83, 34)
        Me.BillAmountTextBox.Name = "BillAmountTextBox"
        Me.BillAmountTextBox.Size = New System.Drawing.Size(104, 22)
        Me.BillAmountTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill Amount:"
        '
        'BillDBDataGridView
        '
        Me.BillDBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BillDBDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.BillDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDBDataGridView.Location = New System.Drawing.Point(12, 109)
        Me.BillDBDataGridView.Name = "BillDBDataGridView"
        Me.BillDBDataGridView.Size = New System.Drawing.Size(877, 234)
        Me.BillDBDataGridView.TabIndex = 12
        '
        'CustomerPaymentHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(894, 484)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BillDBDataGridView)
        Me.Name = "CustomerPaymentHistoryForm"
        Me.Text = "CustomerPaymentHistoryForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BillDBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BillDBDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PaymentDateTextBox As TextBox
    Friend WithEvents BillDescriptionTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BillAmountTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
