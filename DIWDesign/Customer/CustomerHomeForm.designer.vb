<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerHomeForm
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
        Me.CustomerPanel = New System.Windows.Forms.Panel()
        Me.ProfileLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ApplicationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NewApplicationLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SignOutLink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserNamePlaceHolder = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PaymentHistoryLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerPanel
        '
        Me.CustomerPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerPanel.Location = New System.Drawing.Point(236, 95)
        Me.CustomerPanel.Name = "CustomerPanel"
        Me.CustomerPanel.Size = New System.Drawing.Size(1038, 594)
        Me.CustomerPanel.TabIndex = 7
        '
        'ProfileLinkLabel
        '
        Me.ProfileLinkLabel.AutoSize = True
        Me.ProfileLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ProfileLinkLabel.ForeColor = System.Drawing.Color.Black
        Me.ProfileLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.ProfileLinkLabel.Location = New System.Drawing.Point(66, 158)
        Me.ProfileLinkLabel.Name = "ProfileLinkLabel"
        Me.ProfileLinkLabel.Size = New System.Drawing.Size(135, 25)
        Me.ProfileLinkLabel.TabIndex = 0
        Me.ProfileLinkLabel.TabStop = True
        Me.ProfileLinkLabel.Text = "Update Profile"
        '
        'ApplicationLinkLabel
        '
        Me.ApplicationLinkLabel.AutoSize = True
        Me.ApplicationLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ApplicationLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ApplicationLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.ApplicationLinkLabel.Location = New System.Drawing.Point(68, 213)
        Me.ApplicationLinkLabel.Name = "ApplicationLinkLabel"
        Me.ApplicationLinkLabel.Size = New System.Drawing.Size(156, 25)
        Me.ApplicationLinkLabel.TabIndex = 2
        Me.ApplicationLinkLabel.TabStop = True
        Me.ApplicationLinkLabel.Text = "View Application"
        '
        'NewApplicationLinkLabel
        '
        Me.NewApplicationLinkLabel.AutoSize = True
        Me.NewApplicationLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NewApplicationLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NewApplicationLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.NewApplicationLinkLabel.Location = New System.Drawing.Point(69, 271)
        Me.NewApplicationLinkLabel.Name = "NewApplicationLinkLabel"
        Me.NewApplicationLinkLabel.Size = New System.Drawing.Size(154, 25)
        Me.NewApplicationLinkLabel.TabIndex = 5
        Me.NewApplicationLinkLabel.TabStop = True
        Me.NewApplicationLinkLabel.Text = "New Application"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.SignOutLink)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.UserNamePlaceHolder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 94)
        Me.Panel1.TabIndex = 21
        '
        'SignOutLink
        '
        Me.SignOutLink.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SignOutLink.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.SignOutLink.LinkColor = System.Drawing.Color.Teal
        Me.SignOutLink.Location = New System.Drawing.Point(1182, 52)
        Me.SignOutLink.Name = "SignOutLink"
        Me.SignOutLink.Size = New System.Drawing.Size(77, 23)
        Me.SignOutLink.TabIndex = 39
        Me.SignOutLink.TabStop = True
        Me.SignOutLink.Text = "Sign out"
        Me.SignOutLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DIWDesign.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UserNamePlaceHolder
        '
        Me.UserNamePlaceHolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNamePlaceHolder.AutoSize = True
        Me.UserNamePlaceHolder.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75!, System.Drawing.FontStyle.Bold)
        Me.UserNamePlaceHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UserNamePlaceHolder.Location = New System.Drawing.Point(519, 14)
        Me.UserNamePlaceHolder.Name = "UserNamePlaceHolder"
        Me.UserNamePlaceHolder.Size = New System.Drawing.Size(250, 50)
        Me.UserNamePlaceHolder.TabIndex = 2
        Me.UserNamePlaceHolder.Text = "<UserName>"
        Me.UserNamePlaceHolder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaShell
        Me.Panel3.Controls.Add(Me.PictureBox10)
        Me.Panel3.Controls.Add(Me.PaymentHistoryLinkLabel)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.NewApplicationLinkLabel)
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Controls.Add(Me.UserNameLabel)
        Me.Panel3.Controls.Add(Me.ProfileLinkLabel)
        Me.Panel3.Controls.Add(Me.ApplicationLinkLabel)
        Me.Panel3.Location = New System.Drawing.Point(0, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 608)
        Me.Panel3.TabIndex = 31
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.DIWDesign.My.Resources.Resources.building
        Me.PictureBox6.Location = New System.Drawing.Point(25, 255)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 42
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.DIWDesign.My.Resources.Resources.lease
        Me.PictureBox4.Location = New System.Drawing.Point(25, 199)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 41
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox2.InitialImage = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox2.Location = New System.Drawing.Point(25, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.DIWDesign.My.Resources.Resources.businessman
        Me.PictureBox11.InitialImage = Global.DIWDesign.My.Resources.Resources.form
        Me.PictureBox11.Location = New System.Drawing.Point(75, 17)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(97, 70)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 39
        Me.PictureBox11.TabStop = False
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UserNameLabel.Location = New System.Drawing.Point(59, 98)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(129, 25)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "<UserName>"
        Me.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tan
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 684)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 65)
        Me.Panel2.TabIndex = 32
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.DIWDesign.My.Resources.Resources.MicrosoftTeams_image
        Me.PictureBox3.Location = New System.Drawing.Point(1178, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PaymentHistoryLinkLabel
        '
        Me.PaymentHistoryLinkLabel.AutoSize = True
        Me.PaymentHistoryLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PaymentHistoryLinkLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaymentHistoryLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.PaymentHistoryLinkLabel.Location = New System.Drawing.Point(68, 334)
        Me.PaymentHistoryLinkLabel.Name = "PaymentHistoryLinkLabel"
        Me.PaymentHistoryLinkLabel.Size = New System.Drawing.Size(155, 25)
        Me.PaymentHistoryLinkLabel.TabIndex = 43
        Me.PaymentHistoryLinkLabel.TabStop = True
        Me.PaymentHistoryLinkLabel.Text = "Payment History"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.DIWDesign.My.Resources.Resources.debit_card
        Me.PictureBox10.Location = New System.Drawing.Point(27, 320)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(35, 39)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 44
        Me.PictureBox10.TabStop = False
        '
        'CustomerHomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1277, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustomerPanel)
        Me.Name = "CustomerHomeForm"
        Me.Text = "s"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomerPanel As Panel
    Friend WithEvents NewApplicationLinkLabel As LinkLabel
    Friend WithEvents ApplicationLinkLabel As LinkLabel
    Friend WithEvents ProfileLinkLabel As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SignOutLink As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UserNamePlaceHolder As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PaymentHistoryLinkLabel As LinkLabel
    Friend WithEvents PictureBox10 As PictureBox
End Class
