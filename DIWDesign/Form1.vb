Public Class Form1
    Private DB As New DBAccess
    Private Sub ApplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyToolStripMenuItem.Click
        ApplicationForm.ShowDialog()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        CustomerPage.ShowDialog()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Full Screen
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
