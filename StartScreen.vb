Imports System.IO

Public Class Start_Screen

    '------------------------------函数声明------------------------------

    '窗口淡入淡出函数
    Private Sub FormFade(ByVal FType)
        Select Case FType
            Case ("in")
                Dim FadeCount As Integer
                For FadeCount = 10 To 100 Step 10
                    Me.Opacity = FadeCount / 100
                    Me.Refresh()
                    Threading.Thread.Sleep(30)
                Next
            Case ("out")
                Dim FadeCount As Integer
                For FadeCount = 90 To 0 Step -10
                    Me.Opacity = FadeCount / 100
                    Me.Refresh()
                    Threading.Thread.Sleep(30)
                Next
        End Select

    End Sub



    '移动窗口函数
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Start_Screen_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Start_Screen_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Start_Screen_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub


    '设置字体函数
    Private Sub SetFont()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim fontpath As String = temp + "/moonlight_toolbox_font.ttf"

        Dim g As Graphics = Me.CreateGraphics

        Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
        PFC.AddFontFile(fontpath) '载入一个字符文件

        Dim FFS() As FontFamily = PFC.Families

        Dim FName As String = FFS(0).Name

        'New Font(FFS(0), 72) '创建字符
        'New SolidBrush(Color.Blue) '字体颜色

        '设置字体
        Start_Name.Font = New Font(FName, 72, FontStyle.Regular)
        Start_Status.Font = New Font(FName, 20, FontStyle.Regular)

    End Sub

    '提取资源文件
    Private Sub ExtractResources()
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Dim resources As System.Resources.ResourceManager = My.Resources.ResourceManager
        Dim b() As Byte = resources.GetObject("font1")
        Dim s As IO.Stream = File.Create(temp + "/moonlight_toolbox_font.ttf") '要保存的路径
        s.Write(b, 0, b.Length)
        s.Close()
    End Sub

    '延时函数
    Private Sub delay(ByVal Interval As Integer)
        Dim __time As DateTime = DateTime.Now
        Dim __Span As Int64 = Interval * 10000  '因为时间是以100纳秒为单位
        While (DateTime.Now.Ticks - __time.Ticks < __Span)
            Application.DoEvents()
        End While
    End Sub


    '事件

    '------------------------------程序启动界面------------------------------

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim fs = My.Computer.FileSystem
        'Dim temp = fs.SpecialDirectories.Temp
        'moonlight_toolbox_font.ttf

        Me.DoubleBuffered = True '采用缓冲，解决窗体闪烁问题
        ExtractResources() '提取资源文件
        SetFont() '设置字体
        FormFade("in") '窗体打开时淡入
        Start_Close.Image = My.Resources.close_0
        Start_Progress.Value = 20
        delay(1000)
        Start_Progress.Value = 60
        Start_Status.Text = "载入中..."
        delay(500)
        Start_Progress.Value = 100
        Start_Status.Text = "完成"

    End Sub
    '关闭按钮按钮选中时
    Private Sub Close_MouseMove(sender As Object, e As MouseEventArgs) Handles Start_Close.MouseMove
        Start_Close.Image = My.Resources.close_1
    End Sub

    '关闭按钮按下时
    Private Sub Close_MouseDown(sender As Object, e As MouseEventArgs) Handles Start_Close.MouseDown
        Start_Close.Image = My.Resources.close_2

    End Sub

    '关闭按钮移开时
    Private Sub Close_MouseLeave(sender As Object, e As EventArgs) Handles Start_Close.MouseLeave
        Start_Close.Image = My.Resources.close_0
    End Sub

    '关闭按钮单击时
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Start_Close.Click
        FormFade("out")
        End
    End Sub

    '关闭窗口时
    Private Sub Start_Screen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormFade("out")
    End Sub

    '------------------------------结束------------------------------
End Class

