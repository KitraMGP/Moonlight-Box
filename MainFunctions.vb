Imports System.IO

Module MainFunctions



    '窗口淡入淡出
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

    '设置字体
    Sub SetFont(ByVal Label As Label, ByVal fontsize As Integer, color As Color)
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim fontpath As String = temp + "/MoonLight_Box/moonlight_toolbox_font.ttf"

        'Dim g As Graphics = Start_Screen.CreateGraphics

        Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
        PFC.AddFontFile(fontpath) '载入一个字符文件

        Dim FFS() As FontFamily = PFC.Families


        '设置字体
        'Start_Screen.Start_Name.Font = New Font(FFS(0), 72)
        'Start_Screen.Start_Status.Font = New Font(FFS(0), 20)
        Label.Font = New Font(FFS(0), fontsize)
        Label.ForeColor = color

    End Sub

    '提取资源文件
    Sub ExtractResources()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
        Dim b1() As Byte = resources.GetObject("font1")
        Dim s1 As IO.Stream = File.Create(temp + "/MoonLight_Box/moonlight_toolbox_font.ttf") '要保存的路径
        s1.Write(b1, 0, b1.Length)
        s1.Close()

        Dim b2() As Byte = resources.GetObject("_7za")
        Dim s2 As IO.Stream = File.Create(temp + "/MoonLight_Box/7za.exe")

        s2.Write(b2, 0, b2.Length)
        s2.Close()

        Dim b3() As Byte = resources.GetObject("ffmpeg")
        Dim s3 As IO.Stream = File.Create(temp + "/MoonLight_Box/ffmpeg.zip")
        s3.Write(b3, 0, b3.Length)
        s3.Close()


        Shell(fs.SpecialDirectories.Temp + "/MoonLight_Box/7za.exe x -o" + fs.SpecialDirectories.Temp + "/MoonLight_Box/ " + fs.SpecialDirectories.Temp + "/MoonLight_Box/ffmpeg.zip", AppWinStyle.NormalFocus)
        Delay(2000)
    End Sub

    '延时
    Sub Delay(ByVal Interval As Integer)
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000  '因为时间是以100纳秒为单位
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub

    '运行程序函数
    'Function RunCmd(ByVal strCMD As String) As String
    ' Dim p As New Process
    'With p.StartInfo
    '.FileName = "cmd.exe"
    '.Arguments = "/c " + strCMD
    '.UseShellExecute = False
    'irectStandardInput = True
    '.RedirectStandardOutput = True
    '.RedirectStandardError = True
    'eNoWindow = True
    ' With
    ' p.Start()
    'Dim result As String = p.StandardOutput.ReadToEnd()
    ' p.Close()
    'Return result
    'End Function


    'Sub RunCmd(ByVal cmd As String, ByVal arg As String, ByVal out As TextBox)
    'Dim oProcess As New Process()
    'Dim oStartInfo As New ProcessStartInfo(cmd, arg)
    '   oStartInfo.UseShellExecute = False
    '  oStartInfo.RedirectStandardOutput = True
    ' oProcess.StartInfo = oStartInfo
    'oProcess.Start()
    '
    'Dim sOutput As String
    'Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
    'While True
    '           out.Text = out.Text + vbCrLf + oStreamReader.ReadLine()
    '          Threading.Thread.Sleep(100)
    'End While
    'End Using
    'End Sub
End Module
