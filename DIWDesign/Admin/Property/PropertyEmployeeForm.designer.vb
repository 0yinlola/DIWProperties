<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PropertyEmployeeForm
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
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RecordCountToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PropertyTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.YearBuiltTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AvailibilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumRoomTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumBathRoomTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PropertyFormPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PropertyFormPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBDataGridView
        '
        Me.DBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(12, 214)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.Size = New System.Drawing.Size(791, 138)
        Me.DBDataGridView.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordCountToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(815, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RecordCountToolStripStatusLabel
        '
        Me.RecordCountToolStripStatusLabel.Name = "RecordCountToolStripStatusLabel"
        Me.RecordCountToolStripStatusLabel.Size = New System.Drawing.Size(119, 17)
        Me.RecordCountToolStripStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PropertyTypeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 38)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'PropertyTypeTextBox
        '
        Me.PropertyTypeTextBox.Location = New System.Drawing.Point(242, 15)
        Me.PropertyTypeTextBox.Name = "PropertyTypeTextBox"
        Me.PropertyTypeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.PropertyTypeTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Property Type"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(52, 15)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CityTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(815, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PropertyToolStripMenuItem
        '
        Me.PropertyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.PropertyToolStripMenuItem.Name = "PropertyToolStripMenuItem"
        Me.PropertyToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PropertyToolStripMenuItem.Text = "&Properties"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Enabled = False
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Property ID"
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(474, 188)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.ReadOnly = True
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(42, 20)
        Me.PropertyIDTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(569, 188)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(213, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.YearBuiltTextBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.AvailibilityCheckBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.NumRoomTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TypeTextBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.NumBathRoomTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 129)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(302, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(66, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(223, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Monthly Rate"
        '
        'YearBuiltTextBox
        '
        Me.YearBuiltTextBox.Location = New System.Drawing.Point(302, 50)
        Me.YearBuiltTextBox.Name = "YearBuiltTextBox"
        Me.YearBuiltTextBox.ReadOnly = True
        Me.YearBuiltTextBox.Size = New System.Drawing.Size(66, 20)
        Me.YearBuiltTextBox.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(223, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Year Built"
        '
        'AvailibilityCheckBox
        '
        Me.AvailibilityCheckBox.AutoSize = True
        Me.AvailibilityCheckBox.Location = New System.Drawing.Point(127, 103)
        Me.AvailibilityCheckBox.Name = "AvailibilityCheckBox"
        Me.AvailibilityCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.AvailibilityCheckBox.TabIndex = 7
        Me.AvailibilityCheckBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Is Property Available?"
        '
        'NumRoomTextBox
        '
        Me.NumRoomTextBox.Location = New System.Drawing.Point(126, 49)
        Me.NumRoomTextBox.Name = "NumRoomTextBox"
        Me.NumRoomTextBox.ReadOnly = True
        Me.NumRoomTextBox.Size = New System.Drawing.Size(80, 20)
        Me.NumRoomTextBox.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Number of Rooms"
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(106, 23)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.ReadOnly = True
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TypeTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Property Type"
        '
        'NumBathRoomTextBox
        '
        Me.NumBathRoomTextBox.Location = New System.Drawing.Point(126, 75)
        Me.NumBathRoomTextBox.Name = "NumBathRoomTextBox"
        Me.NumBathRoomTextBox.ReadOnly = True
        Me.NumBathRoomTextBox.Size = New System.Drawing.Size(80, 20)
        Me.NumBathRoomTextBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Number of Bathrooms"
        '
        'PropertyFormPictureBox
        '
        Me.PropertyFormPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PropertyFormPictureBox.Location = New System.Drawing.Point(145, 29)
        Me.PropertyFormPictureBox.Name = "PropertyFormPictureBox"
        Me.PropertyFormPictureBox.Size = New System.Drawing.Size(139, 139)
        Me.PropertyFormPictureBox.TabIndex = 9
        Me.PropertyFormPictureBox.TabStop = False
        '
        'PropertyEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(815, 377)
        Me.Controls.Add(Me.PropertyFormPictureBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PropertyIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DBDataGridView)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PropertyEmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peoperties"
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PropertyFormPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RecordCountToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PropertyTypeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PropertyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumBathRoomTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumRoomTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AvailibilityCheckBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PropertyFormPictureBox As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents YearBuiltTextBox As TextBox
    Friend WithEvents Label9 As Label
End Class
