Public Class eib
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If TextBox1.Text = "ein://welcome" Then

        End If
        ToolStripStatusLabel1.Text = "Navigating..."
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        ToolStripStatusLabel1.Text = "Navigation Completed."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate("http://eclipsebroadcasting.info.tm")
    End Sub

    Private Sub SetHomepageToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomePageToolStripMenuItem.Click
        WebBrowser1.Navigate("http://eclipsebroadcasting.info.tm")
    End Sub

    Private Sub PageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageToolStripMenuItem.Click
        WebBrowser1.Navigate("about:blank")
    End Sub

    Private Sub WindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.Click
        Dim n As New eib
        n.Show()
    End Sub
End Class