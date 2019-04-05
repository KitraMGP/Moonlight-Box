
Public Class Start_Screen


    '事件

    '主界面启动

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        FormFade("in") '窗体打开时淡入
        'Delay(300)
        Start_Progress.Value = 10
        Start_Status.Text = "正在提取资源文件..."
        ExtractResources() '提取资源文件
        'Delay(100)
        Start_Progress.Value = 40
        Start_Status.Text = "正在设置字体..."
        SetFont(Start_Name, 72, Color.White)
        SetFont(Start_Status, 20, Color.White) '设置字体




        Start_Progress.Value = 100
        Start_Status.Text = "完成"
        MainScreen.Show()
        Close()

    End Sub


End Class

