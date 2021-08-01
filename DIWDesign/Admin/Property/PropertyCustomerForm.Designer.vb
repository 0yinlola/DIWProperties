<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyCustomerForm
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
        Me.PropertyFormPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MonthlyRateTextBox = New System.Windows.Forms.TextBox()
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
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PropertyTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.ApplyButton = New System.Windows.Forms.Button()
        CType(Me.PropertyFormPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PropertyFormPictureBox
        '
        Me.PropertyFormPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PropertyFormPictureBox.Location = New System.Drawing.Point(29, 66)
        Me.PropertyFormPictureBox.Name = "PropertyFormPictureBox"
        Me.PropertyFormPictureBox.Size = New System.Drawing.Size(139, 139)
        Me.PropertyFormPictureBox.TabIndex = 17
        Me.PropertyFormPictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MonthlyRateTextBox)
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
        Me.GroupBox2.Location = New System.Drawing.Point(217, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 129)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description"
        '
        'MonthlyRateTextBox
        '
        Me.MonthlyRateTextBox.Location = New System.Drawing.Point(302, 78)
        Me.MonthlyRateTextBox.Name = "MonthlyRateTextBox"
        Me.MonthlyRateTextBox.ReadOnly = True
        Me.MonthlyRateTextBox.Size = New System.Drawing.Size(66, 20)
        Me.MonthlyRateTextBox.TabIndex = 11
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
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(374, 209)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(229, 20)
        Me.AddressTextBox.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Address"
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(279, 209)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.ReadOnly = True
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(42, 20)
        Me.PropertyIDTextBox.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Property ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PropertyTypeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 38)
        Me.GroupBox1.TabIndex = 11
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
        'DBDataGridView
        '
        Me.DBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(19, 237)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.Size = New System.Drawing.Size(584, 128)
        Me.DBDataGridView.TabIndex = 10
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(465, 27)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 18
        Me.ApplyButton.Text = "Apply"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'PropertyCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 377)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.PropertyFormPictureBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PropertyIDTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DBDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PropertyCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Properties"
        CType(Me.PropertyFormPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PropertyFormPictureBox As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MonthlyRateTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents YearBuiltTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AvailibilityCheckBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumRoomTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumBathRoomTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PropertyTypeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents ApplyButton As Button
End Class
