Imports System.ComponentModel

Public Class UpdateChecking
    Private Sub UpdateChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show()

        '后台运行
        ChkUpdProcess.RunWorkerAsync(1)
    End Sub

    Private Sub ChkUpdProcess_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ChkUpdProcess.DoWork
        '获取版本信息

        Try
            e.Result = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/version.txt")
        Catch ex As Exception
            ShowErr(ex, "网络连接异常或服务器出错")

            ChkUpdProcess.CancelAsync()
        End Try
    End Sub

    Private Sub ChkUpdProcess_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles ChkUpdProcess.RunWorkerCompleted

        Try
            'version = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/version.txt")


            Dim version As String
            version = e.Result

            'MsgBox(version)
            If version.Equals("1.0.1") = True Then
                MsgBox("已是最新版本。")
                Me.Close()

            Else
                UpdateDialog.Show()
                Me.Close()

            End If
        Catch ex As Exception
            ShowErr(ex, "未知")
        End Try
    End Sub

    Private Sub CancelUpdate_Click(sender As Object, e As EventArgs) Handles CancelUpdate.Click
        ChkUpdProcess.CancelAsync()
        Close()
    End Sub
End Class