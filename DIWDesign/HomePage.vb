Public Class HomePage
    Private Sub ApplyToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ApplicationForm.ShowDialog()
        Me.Hide()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        HomePanel.Visible = True
        With LogInForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            HomePanel.Controls.Add(LogInForm)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomePanel.Visible = False
        ' Full Screen
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        HomePanel.Visible = True
        With PropertyCustomerForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .WindowState = FormWindowState.Maximized
            HomePanel.Controls.Add(PropertyCustomerForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 
        HomePanel.Hide()
    End Sub
End Class
