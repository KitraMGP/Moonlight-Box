Imports System.IO

Module MainFunctions



    '窗口淡入淡出函数
    Sub FormFade(ByVal FType)
        Select Case FType
            Case ("in")
                Dim FadeCount As Integer
                For FadeCount = 10 To 100 Step 10
                    Start_Screen.Opacity = FadeCount / 100
                    Start_Screen.Refresh()
                    Threading.Thread.Sleep(30)
                Next
            Case ("out")
                Dim FadeCount As Integer
                For FadeCount = 90 To 0 Step -10
                    Start_Screen.Opacity = FadeCount / 100
                    Start_Screen.Refresh()
                    Threading.Thread.Sleep(30)
                Next
        End Select

    End Sub

    '设置字体函数
    Sub SetFont()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim fontpath As String = temp + "/moonlight_toolbox_font.ttf"

        Dim g As Graphics = Start_Screen.CreateGraphics

        Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
        PFC.AddFontFile(fontpath) '载入一个字符文件

        Dim FFS() As FontFamily = PFC.Families

        'New Font(FFS(0), 72)

        '设置字体
        Start_Screen.Start_Name.Font = New Font(FFS(0), 72)
        Start_Screen.Start_Status.Font = New Font(FFS(0), 20)

    End Sub

    '提取资源文件
    Sub ExtractResources()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
        Dim b() As Byte = resources.GetObject("font1")
        Dim s As IO.Stream = File.Create(temp + "/moonlight_toolbox_font.ttf") '要保存的路径
        s.Write(b, 0, b.Length)
        s.Close()
    End Sub

    '延时函数
    Sub Delay(ByVal Interval As Integer)
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000  '因为时间是以100纳秒为单位
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub

End Module
