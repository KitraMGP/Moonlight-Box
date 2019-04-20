Public Class UpdateDialog
    Private Sub DownloadUpdate_Click(sender As Object, e As EventArgs) Handles DownloadUpdate.Click
        Try
            Dim binurl As String
            binurl = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/url.txt")
            Process.Start(binurl)
        Catch ex As Exception
            ShowErr(ex, "网络连接错误或服务器错误")
        End Try
    End Sub

    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChangeLogBox.Text = "正在获取更新日志..."
        Dim changelog As String

        Try
            changelog = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/changelog.txt")

            ChangeLogBox.Text = changelog
        Catch ex As Exception
            ShowErr(ex, "网络连接错误或服务器错误")
        End Try
    End Sub
End Class