<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordLink = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.WarningLabel.Location = New System.Drawing.Point(83, 156)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(93, 13)
        Me.WarningLabel.TabIndex = 23
        Me.WarningLabel.Text = "Warning Message"
        Me.WarningLabel.Visible = False
        '
        'ForgotPasswordLink
        '
        Me.ForgotPasswordLink.AutoSize = True
        Me.ForgotPasswordLink.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.ForgotPasswordLink.LinkColor = System.Drawing.Color.Teal
        Me.ForgotPasswordLink.Location = New System.Drawing.Point(142, 230)
        Me.ForgotPasswordLink.Name = "ForgotPasswordLink"
        Me.ForgotPasswordLink.Size = New System.Drawing.Size(111, 23)
        Me.ForgotPasswordLink.TabIndex = 20
        Me.ForgotPasswordLink.TabStop = True
        Me.ForgotPasswordLink.Text = "Back to Login"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(41, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 26)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DIW Property Management System"
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.Window
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LoginButton.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.LoginButton.Location = New System.Drawing.Point(81, 178)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(241, 33)
        Me.LoginButton.TabIndex = 18
        Me.LoginButton.Text = "Reset Password"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 3.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(46, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(309, 1)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email Address"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.EmailTextBox.Location = New System.Drawing.Point(81, 123)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(241, 31)
        Me.EmailTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.WarningLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ForgotPasswordLink)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Location = New System.Drawing.Point(404, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 278)
        Me.Panel1.TabIndex = 28
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1224, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ForgotPasswordForm"
        Me.Text = "ForgotPasswordForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ForgotPasswordLink As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents WarningLabel As Label
    Friend WithEvents Panel1 As Panel
End Class
