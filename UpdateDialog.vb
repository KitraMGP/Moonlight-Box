Public Class UpdateDialog
    Private Sub DownloadUpdate_Click(sender As Object, e As EventArgs) Handles DownloadUpdate.Click
        Process.Start("https://github.com/zi-jing/MoonlightBox-UpdateCheck/raw/master/version.txt")
    End Sub
End Class