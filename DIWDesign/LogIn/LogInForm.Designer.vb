<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ForgotPasswordLink = New System.Windows.Forms.LinkLabel()
        Me.EmailWarningLabel = New System.Windows.Forms.Label()
        Me.PasswordWarningLabel = New System.Windows.Forms.Label()
        Me.AuthenticationWarningLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.UsernameTextBox.Location = New System.Drawing.Point(70, 133)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(257, 31)
        Me.UsernameTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 3.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(47, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 1)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Login"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(70, 209)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(257, 31)
        Me.PasswordTextBox.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.Window
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LoginButton.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.LoginButton.Location = New System.Drawing.Point(139, 267)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(115, 33)
        Me.LoginButton.TabIndex = 18
        Me.LoginButton.Text = "Log In"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(42, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DIW Property Management System"
        '
        'ForgotPasswordLink
        '
        Me.ForgotPasswordLink.AutoSize = True
        Me.ForgotPasswordLink.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForgotPasswordLink.LinkColor = System.Drawing.Color.Teal
        Me.ForgotPasswordLink.Location = New System.Drawing.Point(101, 325)
        Me.ForgotPasswordLink.Name = "ForgotPasswordLink"
        Me.ForgotPasswordLink.Size = New System.Drawing.Size(190, 23)
        Me.ForgotPasswordLink.TabIndex = 20
        Me.ForgotPasswordLink.TabStop = True
        Me.ForgotPasswordLink.Text = "Forgot your password?"
        '
        'EmailWarningLabel
        '
        Me.EmailWarningLabel.AutoSize = True
        Me.EmailWarningLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.EmailWarningLabel.Location = New System.Drawing.Point(73, 166)
        Me.EmailWarningLabel.Name = "EmailWarningLabel"
        Me.EmailWarningLabel.Size = New System.Drawing.Size(137, 13)
        Me.EmailWarningLabel.TabIndex = 24
        Me.EmailWarningLabel.Text = "Username cannot be empty"
        Me.EmailWarningLabel.Visible = False
        '
        'PasswordWarningLabel
        '
        Me.PasswordWarningLabel.AutoSize = True
        Me.PasswordWarningLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.PasswordWarningLabel.Location = New System.Drawing.Point(73, 242)
        Me.PasswordWarningLabel.Name = "PasswordWarningLabel"
        Me.PasswordWarningLabel.Size = New System.Drawing.Size(135, 13)
        Me.PasswordWarningLabel.TabIndex = 25
        Me.PasswordWarningLabel.Text = "Password cannot be empty"
        Me.PasswordWarningLabel.Visible = False
        '
        'AuthenticationWarningLabel
        '
        Me.AuthenticationWarningLabel.AutoSize = True
        Me.AuthenticationWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.AuthenticationWarningLabel.Location = New System.Drawing.Point(98, 69)
        Me.AuthenticationWarningLabel.Name = "AuthenticationWarningLabel"
        Me.AuthenticationWarningLabel.Size = New System.Drawing.Size(207, 13)
        Me.AuthenticationWarningLabel.TabIndex = 26
        Me.AuthenticationWarningLabel.Text = "The username or password are not correct"
        Me.AuthenticationWarningLabel.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.AuthenticationWarningLabel)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.PasswordWarningLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.EmailWarningLabel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ForgotPasswordLink)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(419, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 369)
        Me.Panel1.TabIndex = 27
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1224, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LogInForm"
        Me.Text = "LogInForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ForgotPasswordLink As LinkLabel
    Friend WithEvents EmailWarningLabel As Label
    Friend WithEvents PasswordWarningLabel As Label
    Friend WithEvents AuthenticationWarningLabel As Label
    Friend WithEvents Panel1 As Panel
End Class
