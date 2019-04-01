
Public Class Start_Screen


    '事件

    '主界面启动

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        ExtractResources() '提取资源文件
        SetFont() '设置字体
        FormFade("in") '窗体打开时淡入

        'Start_Progress.Value = 20
        'Delay(1000)
        'Start_Progress.Value = 60
        'Start_Status.Text = "载入中..."
        Delay(500)
        Start_Progress.Value = 100
        Start_Status.Text = "完成"
        Delay(500)
        MainScreen.Show()
        Close()

    End Sub


End Class

