Public Class Desktop
    Private Sub PictureBox21_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox21.DoubleClick
        MsgBox("Whoops! Looks like File Explorer couldn't load. Error 0x000034D - The File does not exist.")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim highlighttext = Color.DodgerBlue
        Me.Label1.BackColor = highlighttext
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        MsgBox("Whoops! Looks like File Explorer couldn't load. Error 0x000034D - The File does not exist.")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Dim highlighttext = Color.DodgerBlue
        Me.Label1.BackColor = highlighttext
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ToolStripDropDownButton1.ShowDropDown()
    End Sub

    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim highlighttext = Color.Teal
        Me.Label1.BackColor = highlighttext
        Me.Label2.BackColor = highlighttext
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim highlighttext = Color.DodgerBlue
        Me.Label2.BackColor = highlighttext
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim highlighttext = Color.DodgerBlue
        Me.Label2.BackColor = highlighttext
    End Sub

    Private Sub Desktop_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick

    End Sub
End Class
