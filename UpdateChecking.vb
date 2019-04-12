Public Class UpdateChecking
    Private Sub UpdateChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '获取版本信息
        Dim version As String

        Try
            version = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/version.txt")


            'MsgBox(version)
            If version.Equals("1.0.1") = True Then
                MsgBox("已是最新版本。")
                Me.Close()

            Else
                UpdateDialog.Show()
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class