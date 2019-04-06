Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

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
    'Sub SetFont(ByVal Label As Label, ByVal fontsize As Integer)
    'Dim fs = My.Computer.FileSystem
    'Dim temp = fs.SpecialDirectories.Temp
    'Dim fontpath As String = temp + "/MoonLight_Box/moonlight_toolbox_font.ttf"
    '
    'Dim g As Graphics = Start_Screen.CreateGraphics

    'Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
    '   PFC.AddFontFile(fontpath) '载入一个字符文件

    'Dim FFS() As FontFamily = PFC.Families


    '设置字体
    'Start_Screen.Start_Name.Font = New Font(FFS(0), 72)
    'Start_Screen.Start_Status.Font = New Font(FFS(0), 20)
    '   Label.Font = New Font(FFS(0), fontsize)


    'End Sub

    '提取资源文件
    Sub ExtractResources()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
        Dim b1() As Byte = resources.GetObject("font1")
        If fs.DirectoryExists(temp + "/MoonLight_Box") = True Then
            fs.DeleteDirectory(temp + "/MoonLight_Box", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        fs.CreateDirectory(temp + "/MoonLight_Box")
        'Dim s1 As IO.Stream = File.Create(temp + "/MoonLight_Box/moonlight_toolbox_font.ttf") '要保存的路径
        's1.Write(b1, 0, b1.Length)
        's1.Close()

        Dim b2() As Byte = resources.GetObject("_7za")
        Dim s2 As IO.Stream = File.Create(temp + "/MoonLight_Box/7za.exe")

        s2.Write(b2, 0, b2.Length)
        s2.Close()

        Dim b3() As Byte = resources.GetObject("ffmpeg")
        Dim s3 As IO.Stream = File.Create(temp + "/MoonLight_Box/ffmpeg.zip")
        s3.Write(b3, 0, b3.Length)
        s3.Close()

        Dim b4() As Byte = resources.GetObject("ipc")
        Dim s4 As IO.Stream = File.Create(temp + "/MoonLight_Box/ipc.bat")
        s4.Write(b4, 0, b4.Length)
        s4.Close()


        Shell(fs.SpecialDirectories.Temp + "/MoonLight_Box/7za.exe x -o" + fs.SpecialDirectories.Temp + "/MoonLight_Box/ " + fs.SpecialDirectories.Temp + "/MoonLight_Box/ffmpeg.zip", AppWinStyle.MinimizedFocus)
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


    Function Download(ByVal url As String)

        '定义一个WinHttpRequest类的实体变量
        Dim http = New WinHttp.WinHttpRequest

        '调用Open函数，传入参数为请求方法，URL
        '如果是get方法,URL由baseurl+？+字段名+&+字段值构成
        http.Open("GET", url, False)

        '发送请求
        http.Send()

        '请求结果为http.ResponseText
        Return http.ResponseText



    End Function



    'Sub RunCmd(ByVal cmd As String, ByVal arg As String, ByVal out As TextBox)
    'Dim oProcess As New Process()
    'Dim oStartInfo As New ProcessStartInfo(cmd, arg)
    'oStartInfo.UseShellExecute = False
    'oStartInfo.RedirectStandardOutput = True
    'oProcess.StartInfo = oStartInfo
    'oProcess.Start()

    'Dim sOutput As String
    'Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
    'While True
    'out.Text = out.Text + vbCrLf + oStreamReader.ReadToEnd()
    'Threading.Thread.Sleep(100)
    'End While
    'End Using

    'Using Process As Process = New Process()

    'Process.StartInfo.FileName = cmd
    '  Process.StartInfo.Arguments = arg
    '    Process.StartInfo.UseShellExecute = False
    '      Process.StartInfo.RedirectStandardOutput = True


    'Process.Start()
    '
    ' Synchronously read the standard output of the spawned process. 
    'Dim reader As StreamReader = Process.StandardOutput
    '  Dim output As String = reader.ReadToEnd()

    ' Write the redirected output to this application's window.
    'Console.WriteLine(output)
    'out.Text = out.Text + vbCrLf + output

    'Process.WaitForExit()
    'End Using
    'End Sub


    '获取MD5
    Function GetMD5(ByVal strSource As String) As String
        Dim result As String = ""

        Try

            Dim fstream As New FileStream(strSource, FileMode.Open, FileAccess.Read)
            Dim dataToHash(fstream.Length - 1) As Byte
            fstream.Read(dataToHash, 0, fstream.Length)
            fstream.Close()
            Dim hashvalue As Byte() = CType(CryptoConfig.CreateFromName("MD5"), HashAlgorithm).ComputeHash(dataToHash)
            Dim i As Integer
            For i = 0 To hashvalue.Length - 1
                result += Microsoft.VisualBasic.Right("00" + Hex(hashvalue(i)).ToLower, 2)
            Next
            Return result
        Catch ex As Exception

            Return result
        End Try

    End Function
End Module
