
Public Class Start_Screen


    '事件

    '主界面启动

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        FormFade("in") '窗体打开时淡入
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


End Class

