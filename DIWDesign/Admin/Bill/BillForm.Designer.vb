<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeaseIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BillIdTextBox = New System.Windows.Forms.TextBox()
        Me.DBDataGridViewBill = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SelectedBillTextBox = New System.Windows.Forms.TextBox()
        Me.DBDataGridViewCustomer = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SelectedCustomerTextBox = New System.Windows.Forms.TextBox()
        Me.BillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPaymentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBDataGridViewBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataGridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LeaseIdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BillIdTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 40)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Bill"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lease No."
        '
        'LeaseIdTextBox
        '
        Me.LeaseIdTextBox.Location = New System.Drawing.Point(312, 13)
        Me.LeaseIdTextBox.Name = "LeaseIdTextBox"
        Me.LeaseIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LeaseIdTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bill No."
        '
        'BillIdTextBox
        '
        Me.BillIdTextBox.Location = New System.Drawing.Point(109, 14)
        Me.BillIdTextBox.Name = "BillIdTextBox"
        Me.BillIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BillIdTextBox.TabIndex = 0
        '
        'DBDataGridViewBill
        '
        Me.DBDataGridViewBill.AllowUserToAddRows = False
        Me.DBDataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridViewBill.Location = New System.Drawing.Point(12, 288)
        Me.DBDataGridViewBill.Name = "DBDataGridViewBill"
        Me.DBDataGridViewBill.Size = New System.Drawing.Size(1049, 206)
        Me.DBDataGridViewBill.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(529, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Selected Bill:"
        '
        'SelectedBillTextBox
        '
        Me.SelectedBillTextBox.Location = New System.Drawing.Point(634, 231)
        Me.SelectedBillTextBox.Name = "SelectedBillTextBox"
        Me.SelectedBillTextBox.ReadOnly = True
        Me.SelectedBillTextBox.Size = New System.Drawing.Size(144, 20)
        Me.SelectedBillTextBox.TabIndex = 9
        '
        'DBDataGridViewCustomer
        '
        Me.DBDataGridViewCustomer.AllowUserToAddRows = False
        Me.DBDataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridViewCustomer.Location = New System.Drawing.Point(12, 83)
        Me.DBDataGridViewCustomer.Name = "DBDataGridViewCustomer"
        Me.DBDataGridViewCustomer.Size = New System.Drawing.Size(1049, 122)
        Me.DBDataGridViewCustomer.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 40)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(312, 13)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "First Name:."
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(109, 14)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'SelectedCustomerTextBox
        '
        Me.SelectedCustomerTextBox.Location = New System.Drawing.Point(634, 53)
        Me.SelectedCustomerTextBox.Name = "SelectedCustomerTextBox"
        Me.SelectedCustomerTextBox.ReadOnly = True
        Me.SelectedCustomerTextBox.Size = New System.Drawing.Size(144, 20)
        Me.SelectedCustomerTextBox.TabIndex = 14
        '
        'BillsToolStripMenuItem
        '
        Me.BillsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.BillsToolStripMenuItem.Name = "BillsToolStripMenuItem"
        Me.BillsToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.BillsToolStripMenuItem.Text = "&Bill"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Enabled = False
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPaymentToolStripMenuItem1})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "&Payment"
        '
        'NewPaymentToolStripMenuItem1
        '
        Me.NewPaymentToolStripMenuItem1.Name = "NewPaymentToolStripMenuItem1"
        Me.NewPaymentToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.NewPaymentToolStripMenuItem1.Text = "&New"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillsToolStripMenuItem, Me.PaymentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1073, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(529, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Selected Customer:"
        '
        'BillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1073, 515)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SelectedCustomerTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DBDataGridViewCustomer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DBDataGridViewBill)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SelectedBillTextBox)
        Me.Name = "BillForm"
        Me.Text = "BillForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBDataGridViewBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataGridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LeaseIdTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BillIdTextBox As TextBox
    Friend WithEvents DBDataGridViewBill As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents SelectedBillTextBox As TextBox
    Friend WithEvents DBDataGridViewCustomer As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SelectedCustomerTextBox As TextBox
    Friend WithEvents BillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPaymentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label6 As Label
End Class
