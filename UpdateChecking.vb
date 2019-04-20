Imports System.ComponentModel

Public Class UpdateChecking
    Private Sub UpdateChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Show()
        Delay(100)
        '后台运行
        'ChkUpdProcess.RunWorkerAsync()

        Try
            Dim version As String
            version = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/version.txt")

            'MsgBox(version)
            If version.Equals("1.0.2") = True Then
                MsgBox("已是最新版本。")
                Close()

            Else
                UpdateDialog.Show()
                Close()
            End If
        Catch ex As Exception
            ShowErr(ex, "网络连接异常或服务器出错")
            Close()

        End Try
        Close()
    End Sub

    'Private Sub ChkUpdProcess_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ChkUpdProcess.DoWork
    ''获取版本信息

    'Try
    'Dim version As String
    '      version = Download("https://raw.githubusercontent.com/zi-jing/MoonlightBox-UpdateCheck/master/version.txt")
    '
    'MsgBox(version)
    'If version.Equals("1.0.1") = True Then
    '           MsgBox("已是最新版本。")

    'Else
    '           UpdateDialog.Show()

    'End If
    'Catch ex As Exception
    '       ShowErr(ex, "网络连接异常或服务器出错")

    '      ChkUpdProcess.CancelAsync()

    'End Try
    'End Sub

    'Private Sub CancelUpdate_Click(sender As Object, e As EventArgs) Handles CancelUpdate.Click
    '   ChkUpdProcess.CancelAsync()

    'End Sub
End Class