<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SignOutLink = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAvailabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DynamicPanel = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EmployeeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ReportsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ApplicationsLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.BillLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PaymentLink = New System.Windows.Forms.LinkLabel()
        Me.UserNamePlaceHolder = New System.Windows.Forms.Label()
        Me.LeaseLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CustomersLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PropertyLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.DynamicPanel.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.SignOutLink)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 94)
        Me.Panel1.TabIndex = 20
        '
        'SignOutLink
        '
        Me.SignOutLink.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SignOutLink.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.SignOutLink.LinkColor = System.Drawing.Color.Teal
        Me.SignOutLink.Location = New System.Drawing.Point(1169, 38)
        Me.SignOutLink.Name = "SignOutLink"
        Me.SignOutLink.Size = New System.Drawing.Size(77, 23)
        Me.SignOutLink.TabIndex = 39
        Me.SignOutLink.TabStop = True
        Me.SignOutLink.Text = "Sign out"
        Me.SignOutLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertiesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1149, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(105, 29)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPropertiesToolStripMenuItem, Me.CheckAvailabilityToolStripMenuItem})
        Me.PropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(97, 25)
        Me.PropertiesToolStripMenuItem.Text = "Username"
        '
        'ViewPropertiesToolStripMenuItem
        '
        Me.ViewPropertiesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ViewPropertiesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ViewPropertiesToolStripMenuItem.Name = "ViewPropertiesToolStripMenuItem"
        Me.ViewPropertiesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.ViewPropertiesToolStripMenuItem.Text = "&Edit Information"
        '
        'CheckAvailabilityToolStripMenuItem
        '
        Me.CheckAvailabilityToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAvailabilityToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CheckAvailabilityToolStripMenuItem.Name = "CheckAvailabilityToolStripMenuItem"
        Me.CheckAvailabilityToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.CheckAvailabilityToolStripMenuItem.Text = "&Log off"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(496, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(327, 50)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Admin Dashboard"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tan
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 701)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 48)
        Me.Panel2.TabIndex = 22
        '
        'DynamicPanel
        '
        Me.DynamicPanel.Controls.Add(Me.Panel10)
        Me.DynamicPanel.Location = New System.Drawing.Point(175, 93)
        Me.DynamicPanel.Name = "DynamicPanel"
        Me.DynamicPanel.Size = New System.Drawing.Size(1089, 540)
        Me.DynamicPanel.TabIndex = 29
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Button1)
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1099, 607)
        Me.Panel10.TabIndex = 78
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(753, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 20)
        Me.Button1.TabIndex = 83
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Controls.Add(Me.EmployeeLinkLabel)
        Me.Panel3.Controls.Add(Me.ReportsLinkLabel)
        Me.Panel3.Controls.Add(Me.ApplicationsLinkLabel)
        Me.Panel3.Controls.Add(Me.BillLinkLabel)
        Me.Panel3.Controls.Add(Me.PaymentLink)
        Me.Panel3.Controls.Add(Me.PictureBox10)
        Me.Panel3.Controls.Add(Me.UserNamePlaceHolder)
        Me.Panel3.Controls.Add(Me.LeaseLinkLabel)
        Me.Panel3.Controls.Add(Me.CustomersLinkLabel)
        Me.Panel3.Controls.Add(Me.PictureBox9)
        Me.Panel3.Controls.Add(Me.PictureBox8)
        Me.Panel3.Controls.Add(Me.PropertyLinkLabel)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Location = New System.Drawing.Point(0, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(177, 610)
        Me.Panel3.TabIndex = 30
        '
        'EmployeeLinkLabel
        '
        Me.EmployeeLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.EmployeeLinkLabel.AutoSize = True
        Me.EmployeeLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.EmployeeLinkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EmployeeLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.EmployeeLinkLabel.Location = New System.Drawing.Point(51, 563)
        Me.EmployeeLinkLabel.Name = "EmployeeLinkLabel"
        Me.EmployeeLinkLabel.Size = New System.Drawing.Size(104, 25)
        Me.EmployeeLinkLabel.TabIndex = 3
        Me.EmployeeLinkLabel.TabStop = True
        Me.EmployeeLinkLabel.Text = "Employees"
        '
        'ReportsLinkLabel
        '
        Me.ReportsLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.ReportsLinkLabel.AutoSize = True
        Me.ReportsLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsLinkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReportsLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.ReportsLinkLabel.Location = New System.Drawing.Point(51, 501)
        Me.ReportsLinkLabel.Name = "ReportsLinkLabel"
        Me.ReportsLinkLabel.Size = New System.Drawing.Size(78, 25)
        Me.ReportsLinkLabel.TabIndex = 6
        Me.ReportsLinkLabel.TabStop = True
        Me.ReportsLinkLabel.Text = "Reports"
        '
        'ApplicationsLinkLabel
        '
        Me.ApplicationsLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.ApplicationsLinkLabel.AutoSize = True
        Me.ApplicationsLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ApplicationsLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.ApplicationsLinkLabel.Location = New System.Drawing.Point(51, 151)
        Me.ApplicationsLinkLabel.Name = "ApplicationsLinkLabel"
        Me.ApplicationsLinkLabel.Size = New System.Drawing.Size(118, 25)
        Me.ApplicationsLinkLabel.TabIndex = 7
        Me.ApplicationsLinkLabel.TabStop = True
        Me.ApplicationsLinkLabel.Text = "Applications"
        '
        'BillLinkLabel
        '
        Me.BillLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.BillLinkLabel.AutoSize = True
        Me.BillLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BillLinkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BillLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.BillLinkLabel.Location = New System.Drawing.Point(53, 440)
        Me.BillLinkLabel.Name = "BillLinkLabel"
        Me.BillLinkLabel.Size = New System.Drawing.Size(46, 25)
        Me.BillLinkLabel.TabIndex = 1
        Me.BillLinkLabel.TabStop = True
        Me.BillLinkLabel.Text = "Bills"
        '
        'PaymentLink
        '
        Me.PaymentLink.ActiveLinkColor = System.Drawing.Color.White
        Me.PaymentLink.AutoSize = True
        Me.PaymentLink.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PaymentLink.LinkColor = System.Drawing.Color.Black
        Me.PaymentLink.Location = New System.Drawing.Point(53, 385)
        Me.PaymentLink.Name = "PaymentLink"
        Me.PaymentLink.Size = New System.Drawing.Size(95, 25)
        Me.PaymentLink.TabIndex = 0
        Me.PaymentLink.TabStop = True
        Me.PaymentLink.Text = "Payments"
        '
        'UserNamePlaceHolder
        '
        Me.UserNamePlaceHolder.AutoSize = True
        Me.UserNamePlaceHolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UserNamePlaceHolder.Location = New System.Drawing.Point(26, 98)
        Me.UserNamePlaceHolder.Name = "UserNamePlaceHolder"
        Me.UserNamePlaceHolder.Size = New System.Drawing.Size(129, 25)
        Me.UserNamePlaceHolder.TabIndex = 0
        Me.UserNamePlaceHolder.Text = "<UserName>"
        Me.UserNamePlaceHolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LeaseLinkLabel
        '
        Me.LeaseLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.LeaseLinkLabel.AutoSize = True
        Me.LeaseLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LeaseLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.LeaseLinkLabel.Location = New System.Drawing.Point(53, 328)
        Me.LeaseLinkLabel.Name = "LeaseLinkLabel"
        Me.LeaseLinkLabel.Size = New System.Drawing.Size(67, 25)
        Me.LeaseLinkLabel.TabIndex = 2
        Me.LeaseLinkLabel.TabStop = True
        Me.LeaseLinkLabel.Text = "Leases"
        '
        'CustomersLinkLabel
        '
        Me.CustomersLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.CustomersLinkLabel.AutoSize = True
        Me.CustomersLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.CustomersLinkLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CustomersLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.CustomersLinkLabel.Location = New System.Drawing.Point(53, 269)
        Me.CustomersLinkLabel.Name = "CustomersLinkLabel"
        Me.CustomersLinkLabel.Size = New System.Drawing.Size(103, 25)
        Me.CustomersLinkLabel.TabIndex = 5
        Me.CustomersLinkLabel.TabStop = True
        Me.CustomersLinkLabel.Text = "Customers"
        '
        'PropertyLinkLabel
        '
        Me.PropertyLinkLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.PropertyLinkLabel.AutoSize = True
        Me.PropertyLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PropertyLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.PropertyLinkLabel.Location = New System.Drawing.Point(53, 211)
        Me.PropertyLinkLabel.Name = "PropertyLinkLabel"
        Me.PropertyLinkLabel.Size = New System.Drawing.Size(100, 25)
        Me.PropertyLinkLabel.TabIndex = 4
        Me.PropertyLinkLabel.TabStop = True
        Me.PropertyLinkLabel.Text = "Properties"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.DIWDesign.My.Resources.Resources.businessman
        Me.PictureBox11.InitialImage = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox11.Location = New System.Drawing.Point(42, 17)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(97, 70)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 39
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.DIWDesign.My.Resources.Resources.debit_card
        Me.PictureBox10.Location = New System.Drawing.Point(12, 371)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 38
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.DIWDesign.My.Resources.Resources.invoices
        Me.PictureBox9.Location = New System.Drawing.Point(12, 426)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 37
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.DIWDesign.My.Resources.Resources.seo_report
        Me.PictureBox8.Location = New System.Drawing.Point(12, 487)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox2.InitialImage = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox2.Location = New System.Drawing.Point(12, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(12, 549)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 35
        Me.PictureBox7.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DIWDesign.My.Resources.Resources.lease
        Me.PictureBox4.Location = New System.Drawing.Point(12, 314)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 32
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.DIWDesign.My.Resources.Resources.building
        Me.PictureBox6.Location = New System.Drawing.Point(12, 197)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.DIWDesign.My.Resources.Resources.customer
        Me.PictureBox5.Location = New System.Drawing.Point(12, 255)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DIWDesign.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox3.Location = New System.Drawing.Point(1208, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DIWDesign.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1277, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DynamicPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.DynamicPanel.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPropertiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAvailabilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DynamicPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PaymentLink As LinkLabel
    Friend WithEvents BillLinkLabel As LinkLabel
    Friend WithEvents CustomersLinkLabel As LinkLabel
    Friend WithEvents PropertyLinkLabel As LinkLabel
    Friend WithEvents EmployeeLinkLabel As LinkLabel
    Friend WithEvents LeaseLinkLabel As LinkLabel
    Friend WithEvents UserNamePlaceHolder As Label
    Friend WithEvents ReportsLinkLabel As LinkLabel
    Friend WithEvents ApplicationsLinkLabel As LinkLabel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SignOutLink As LinkLabel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox11 As PictureBox
End Class
