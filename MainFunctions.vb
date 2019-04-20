Imports System.IO
Imports System.Net
Imports System.Text

Module MainFunctions



    '窗口淡入淡出
    Sub FormFade(ByVal FType As String, ByVal Form As Form)
        Select Case FType
            Case ("in")
                Dim FadeCount As Integer
                For FadeCount = 10 To 100 Step 10
                    Form.Opacity = FadeCount / 100
                    'Form.Refresh()
                    Delay(30)
                Next
            Case ("out")
                Dim FadeCount As Integer
                For FadeCount = 90 To 0 Step -10
                    Form.Opacity = FadeCount / 100
                    'Form.Refresh()
                    Delay(30)
                Next
        End Select

    End Sub

    '设置字体
    'Sub SetFont(ByVal Label As Label, ByVal fontsize As Integer)
    'Dim fs = My.Computer.FileSystem
    'Dim temp = fs.SpecialDirectories.Temp
    'Dim fontpath As String = temp + "/MoonLight_Box/moonlight_toolbox_font.ttf"
    '
    'Dim g As Graphics = Start_Screen.CreateGraphics

    'Dim PFC As New Drawing.Text.PrivateFontCollection()
    '   PFC.AddFontFile(fontpath) '载入一个字符文件

    'Dim FFS() As FontFamily = PFC.Families


    '设置字体
    'Start_Screen.Start_Name.Font = New Font(FFS(0), 72)
    'Start_Screen.Start_Status.Font = New Font(FFS(0), 20)
    '   Label.Font = New Font(FFS(0), fontsize)


    'End Sub

    '提取资源文件
    'Sub ExtractResources()
    '    Try
    '        Dim fs = My.Computer.FileSystem
    '        Dim temp = fs.SpecialDirectories.Temp
    '        Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
    '        'Dim b1() As Byte = resources.GetObject("font1")
    '        If fs.DirectoryExists(temp + "/MoonLight_Box") = True Then
    '            fs.DeleteDirectory(temp + "/MoonLight_Box", FileIO.DeleteDirectoryOption.DeleteAllContents)
    '        End If
    '        fs.CreateDirectory(temp + "/MoonLight_Box")
    '        'Dim s1 As IO.Stream = File.Create(temp + "/MoonLight_Box/moonlight_toolbox_font.ttf") '要保存的路径
    '        's1.Write(b1, 0, b1.Length)
    '        's1.Close()

    '        Dim b2() As Byte = resources.GetObject("_7zr")
    '        Dim s2 As IO.Stream = File.Create(temp + "/MoonLight_Box/7zr.exe")

    '        s2.Write(b2, 0, b2.Length)
    '        s2.Close()

    '        Dim b3() As Byte = resources.GetObject("ffmpeg")
    '        Dim s3 As IO.Stream = File.Create(temp + "/MoonLight_Box/ffmpeg.7z")
    '        s3.Write(b3, 0, b3.Length)
    '        s3.Close()

    '        Dim b4() As Byte = resources.GetObject("ipc")
    '        Dim s4 As IO.Stream = File.Create(temp + "/MoonLight_Box/ipc.bat")
    '        s4.Write(b4, 0, b4.Length)
    '        s4.Close()

    '        Dim b5() As Byte = resources.GetObject("runffmpeg")
    '        Dim s5 As IO.Stream = File.Create(temp + "/MoonLight_Box/runffmpeg.bat")
    '        s5.Write(b5, 0, b5.Length)
    '        s5.Close()

    '        'Delay(3000)
    '        Shell(fs.SpecialDirectories.Temp + "/MoonLight_Box/7zr.exe x -o" + fs.SpecialDirectories.Temp + "/MoonLight_Box/ " + fs.SpecialDirectories.Temp + "/MoonLight_Box/ffmpeg.7z", AppWinStyle.MinimizedFocus)
    '        Delay(2000)
    '    Catch ex As Exception
    '        ShowErr(ex, "未知")
    '    End Try
    'End Sub

    '延时
    Sub Delay(ByVal Interval As Integer)
        '获取现在时间
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000  '因为时间是以100纳秒为单位
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub


    '获取网络上文件的内容
    Function Download(ByVal url As String)


        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        webRequest = WebRequest.Create(url)
        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream(), Encoding.UTF8)
        Return inStream.ReadToEnd

    End Function


    '显示崩溃报告
    Sub ShowErr(ByVal ex As Exception, ByVal advice As String)

        Try
            '生成崩溃报告
            Dim ReportText As String = ("月光宝盒崩溃报告" +
            vbCrLf +
            "---------------------------" + vbCrLf +
            "崩溃原因：" + ex.Message + vbCrLf +
            "错误源：" + ex.Source + vbCrLf +
            "出错位置：" + ex.StackTrace + vbCrLf +
            "---------------------------" + vbCrLf +
            "详细信息：" + ex.ToString + vbCrLf)

            '显示崩溃报告
            With ErrReport
                .ErrorName.Text = ex.Message
                .ErrorReason.Text = advice
                .ErrReportText.Text = ReportText
            End With

            ErrReport.Show()

        Catch ex2 As Exception

            '虽然我觉得这基本上是不可能的，但还是加上更好
            MsgBox(ex2.ToString, 0, "创建崩溃报告时出错")
        End Try
    End Sub




End Module


