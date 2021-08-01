<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LeaseForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LeaseEndTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LeaseStartTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeaseIDTextbox = New System.Windows.Forms.TextBox()
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordCountToolStripStatusLabel = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LeaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LeaseEndTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LeaseStartTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LeaseIDTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(871, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "UserName:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(205, 17)
        Me.UserNameTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(174, 20)
        Me.UserNameTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(628, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lease End Date:"
        '
        'LeaseEndTextBox
        '
        Me.LeaseEndTextBox.Location = New System.Drawing.Point(720, 18)
        Me.LeaseEndTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseEndTextBox.Name = "LeaseEndTextBox"
        Me.LeaseEndTextBox.ReadOnly = True
        Me.LeaseEndTextBox.Size = New System.Drawing.Size(116, 20)
        Me.LeaseEndTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lease Start Date:"
        '
        'LeaseStartTextBox
        '
        Me.LeaseStartTextBox.Location = New System.Drawing.Point(498, 18)
        Me.LeaseStartTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseStartTextBox.Name = "LeaseStartTextBox"
        Me.LeaseStartTextBox.ReadOnly = True
        Me.LeaseStartTextBox.Size = New System.Drawing.Size(106, 20)
        Me.LeaseStartTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lease ID:"
        '
        'LeaseIDTextbox
        '
        Me.LeaseIDTextbox.Location = New System.Drawing.Point(70, 18)
        Me.LeaseIDTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaseIDTextbox.Name = "LeaseIDTextbox"
        Me.LeaseIDTextbox.Size = New System.Drawing.Size(56, 20)
        Me.LeaseIDTextbox.TabIndex = 0
        '
        'DBDataGridView
        '
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(9, 82)
        Me.DBDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.RowTemplate.Height = 24
        Me.DBDataGridView.Size = New System.Drawing.Size(871, 300)
        Me.DBDataGridView.TabIndex = 1
        '
        'RecordCountToolStripStatusLabel
        '
        Me.RecordCountToolStripStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RecordCountToolStripStatusLabel.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RecordCountToolStripStatusLabel.Location = New System.Drawing.Point(0, 387)
        Me.RecordCountToolStripStatusLabel.Name = "RecordCountToolStripStatusLabel"
        Me.RecordCountToolStripStatusLabel.Size = New System.Drawing.Size(889, 25)
        Me.RecordCountToolStripStatusLabel.TabIndex = 2
        Me.RecordCountToolStripStatusLabel.Text = "ToolStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LeaseToolStripMenuItem
        '
        Me.LeaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.LeaseToolStripMenuItem.Name = "LeaseToolStripMenuItem"
        Me.LeaseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.LeaseToolStripMenuItem.Text = "&Lease"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'LeaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 412)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RecordCountToolStripStatusLabel)
        Me.Controls.Add(Me.DBDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LeaseForm"
        Me.Text = "Lease Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents LeaseEndTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LeaseStartTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LeaseIDTextbox As TextBox
    Friend WithEvents RecordCountToolStripStatusLabel As ToolStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LeaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
