
Imports System.ComponentModel

Public Class Start_Screen


    '事件

    '主界面启动

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Show()

        '防止进程重复运行
        If UBound(Diagnostics.Process.GetProcessesByName(
Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            MsgBox("该程序已经在运行了，请先将它关闭。", 0, "启动失败")
            End
        End If



        'FormFade("in", Me) '窗体打开时淡入

        Dim FormGraphics As New FormGraphics
        FormGraphics.FormMove("in", Me)

        'Delay(300)
        Start_Progress.Value = 10
        Me.Start_Status.Text = "正在提取资源文件..."
        ExtractResources() '提取资源文件

        'Delay(100)
        Me.Start_Progress.Value = 40
        Me.Start_Status.Text = ""




        Start_Progress.Value = 100
        Start_Status.Text = "完成"
        MainScreen.Show()
        Close()



    End Sub

    Private Sub Start_Screen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim FormGraphics As New FormGraphics
        FormGraphics.FormMove("out", Me)
    End Sub
End Class

