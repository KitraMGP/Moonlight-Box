Public Class UpdateDialog
    Private Sub DownloadUpdate_Click(sender As Object, e As EventArgs) Handles DownloadUpdate.Click
        Process.Start("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/MoonLight_Box.exe")
    End Sub

    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeLogBox.Text = "正在获取更新日志..."
        Dim changelog As String
        Try
            changelog = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/changelog.txt")
            ChangeLogBox.Text = changelog
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class