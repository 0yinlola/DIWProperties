<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.EmployeeClassTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RecordCountToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeClassTextBox
        '
        Me.EmployeeClassTextBox.Location = New System.Drawing.Point(794, 11)
        Me.EmployeeClassTextBox.Name = "EmployeeClassTextBox"
        Me.EmployeeClassTextBox.ReadOnly = True
        Me.EmployeeClassTextBox.Size = New System.Drawing.Size(126, 20)
        Me.EmployeeClassTextBox.TabIndex = 7
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(668, 14)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(120, 13)
        Me.CustomerNameLabel.TabIndex = 6
        Me.CustomerNameLabel.Text = "Employee Classification:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(564, 13)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.ReadOnly = True
        Me.UserNameTextBox.Size = New System.Drawing.Size(99, 20)
        Me.UserNameTextBox.TabIndex = 5
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(496, 15)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(63, 13)
        Me.CustomerIDLabel.TabIndex = 4
        Me.CustomerIDLabel.Text = "User Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(239, 14)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(64, 14)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(111, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(427, 15)
        Me.EmployeeIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.ReadOnly = True
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(36, 20)
        Me.EmployeeIDTextBox.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordCountToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(940, 22)
        Me.StatusStrip1.TabIndex = 318
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RecordCountToolStripStatusLabel
        '
        Me.RecordCountToolStripStatusLabel.Name = "RecordCountToolStripStatusLabel"
        Me.RecordCountToolStripStatusLabel.Size = New System.Drawing.Size(119, 17)
        Me.RecordCountToolStripStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.EmployeeIDTextBox)
        Me.GroupBox1.Controls.Add(Me.EmployeeClassTextBox)
        Me.GroupBox1.Controls.Add(Me.CustomerNameLabel)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 37)
        Me.GroupBox1.TabIndex = 319
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'DBDataGridView
        '
        Me.DBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(12, 106)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.ReadOnly = True
        Me.DBDataGridView.Size = New System.Drawing.Size(919, 327)
        Me.DBDataGridView.TabIndex = 317
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.MenuStrip1.TabIndex = 322
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeesToolStripMenuItem.Text = "&Employee"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(940, 456)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DBDataGridView)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EmployeeForm"
        Me.Text = "Employee Form"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeClassTextBox As TextBox
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RecordCountToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
