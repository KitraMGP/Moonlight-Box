Public Class MainScreen

    '移动窗口
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


    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load

        'SetFont(Panel_Win_Desc, 26)
        'SetFont(Panel2_Desc, 26)
        'SetFont(Panel3_Desc, 26)
        'SetFont(Panel4_Desc, 26)
        'SetFont(Label2, 20)
        'SetFont(Label3, 20)
        'SetFont(LinkLabel1, 20)
        'Dim fs = My.Computer.FileSystem
        'Dim temp = fs.SpecialDirectories.Temp
        'Dim fontpath As String = temp + "/MoonLight_Box/moonlight_toolbox_font.ttf"

        'Dim g As Graphics = Start_Screen.CreateGraphics

        'Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
        'PFC.AddFontFile(fontpath) '载入一个字符文件

        'Dim FFS() As FontFamily = PFC.Families
        'LinkLabel1.Font = New Font(FFS(0), 20)


        'Dim g As Graphics = Me.CreateGraphics()
        'Dim fs = My.Computer.FileSystem
        'Dim temp = fs.SpecialDirectories.Temp
        'Dim fontpath As String = temp + "/moonlight_toolbox_font.ttf"
        '
        'Dim brush As New SolidBrush(Color.White)
        'Dim PFC As New Drawing.Text.PrivateFontCollection() '私有字符集和
        'PFC.AddFontFile(fontpath) '载入一个字符文件
        '
        'Dim FFS() As FontFamily = PFC.Families
        '
        'Dim font As Font = New Font(FFS(0), 10, FontStyle.Regular)
        'g.DrawString("233", font, brush, 1, 1)


    End Sub

    '鼠标移动到关闭按钮时
    Private Sub Main_Close_MouseMove(sender As Object, e As MouseEventArgs) Handles Main_Close.MouseMove
        Main_Close.Image = My.Resources.close_1
    End Sub
    '关闭
    Private Sub Main_Close_MouseDown(sender As Object, e As MouseEventArgs) Handles Main_Close.MouseDown
        Main_Close.Image = My.Resources.close_2
        Close()
    End Sub
    '恢复贴图
    Private Sub Main_Close_MouseLeave(sender As Object, e As EventArgs) Handles Main_Close.MouseLeave
        Main_Close.Image = My.Resources.close_0
    End Sub




    '-----------------------------主界面-----------------------------

    '---------------------------选项卡按钮---------------------------


    '选项卡按钮功能
    Private Sub Icon_Win_MouseDown(sender As Object, e As EventArgs) Handles Icon_Win.MouseDown
        Icon_Win.BackgroundImage = My.Resources.winicon_2
        Panel_MMedia.Hide()
        Panel_Others.Hide()
        Panel_Settings.Hide()
        Panel_Win.Show()
    End Sub

    Private Sub Icon_MMedia_MouseDown(sender As Object, e As EventArgs) Handles Icon_MMedia.MouseDown
        Icon_MMedia.BackgroundImage = My.Resources.video_2
        Panel_Win.Hide()
        Panel_Others.Hide()
        Panel_Settings.Hide()
        Panel_MMedia.Show()
    End Sub

    Private Sub Icon_Others_MouseDown(sender As Object, e As EventArgs) Handles Icon_Others.MouseDown
        Icon_Others.BackgroundImage = My.Resources.pen_2
        Panel_Win.Hide()
        Panel_MMedia.Hide()
        Panel_Settings.Hide()
        Panel_Others.Show()
    End Sub

    Private Sub Icon_Settings_MouseDown(sender As Object, e As EventArgs) Handles Icon_Settings.MouseDown
        Icon_Settings.BackgroundImage = My.Resources.settings_2
        Panel_Win.Hide()
        Panel_MMedia.Hide()
        Panel_Others.Hide()
        Panel_Settings.Show()
    End Sub



    '选项卡按钮选中
    Private Sub Icon_Win_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_Win.MouseMove
        Icon_Win.BackgroundImage = My.Resources.winicon_1
    End Sub

    Private Sub Icon_MMedia_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_MMedia.MouseMove
        Icon_MMedia.BackgroundImage = My.Resources.video_1
    End Sub

    Private Sub Icon_Others_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_Others.MouseMove
        Icon_Others.BackgroundImage = My.Resources.pen_1
    End Sub

    Private Sub Icon_Settings_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_Settings.MouseMove
        Icon_Settings.BackgroundImage = My.Resources.settings_1
    End Sub


    '鼠标离开按钮
    Private Sub Icon_Win_MouseLeave(sender As Object, e As EventArgs) Handles Icon_Win.MouseLeave
        Icon_Win.BackgroundImage = My.Resources.winicon_0
    End Sub

    Private Sub Icon_MMedia_MouseLeave(sender As Object, e As EventArgs) Handles Icon_MMedia.MouseLeave
        Icon_MMedia.BackgroundImage = My.Resources.video_0
    End Sub

    Private Sub Icon_Others_MouseLeave(sender As Object, e As EventArgs) Handles Icon_Others.MouseLeave
        Icon_Others.BackgroundImage = My.Resources.pen_0
    End Sub

    Private Sub Icon_Settings_MouseLeave(sender As Object, e As EventArgs) Handles Icon_Settings.MouseLeave
        Icon_Settings.BackgroundImage = My.Resources.settings_0
    End Sub


    '---------------------------选项卡1---------------------------

    '防止滚动时背景撕裂
    Private Sub Panel_Win_Main_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel_Win_Main.Scroll
        Panel_Win_Main.Refresh()
    End Sub
    '防止滚动时背景撕裂
    Private Sub Panel_Win_Main_MouseWheel(sender As Object, e As MouseEventArgs) Handles Panel_Win_Main.MouseWheel
        Panel_Win_Main.Refresh()
    End Sub

    Private Sub Win_OpenControl_Click(sender As Object, e As EventArgs) Handles Win_OpenControl.Click
        Shell("control.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_OpenTempFolder_Click(sender As Object, e As EventArgs)
        'Shell("explorer.exe %temp%\", AppWinStyle.MinimizedFocus)
        Try
            System.Diagnostics.Process.Start("%temp%")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Win_Programs_Click(sender As Object, e As EventArgs) Handles Win_Programs.Click
        Shell("cmd.exe /c start appwiz.cpl", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_WinVer_Click(sender As Object, e As EventArgs) Handles Win_WinVer.Click
        Shell("cmd.exe /c start winver.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_OSInfo_Click(sender As Object, e As EventArgs) Handles Win_OSInfo.Click
        Shell("cmd.exe /c start control.exe system", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_Devices_Click(sender As Object, e As EventArgs) Handles Win_Devices.Click
        Shell("cmd.exe /c start compmgmt.msc", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_OpenCmd_Click(sender As Object, e As EventArgs) Handles Win_OpenCmd.Click
        Shell("cmd.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Tasks_Click(sender As Object, e As EventArgs) Handles Win_Tasks.Click
        Shell("cmd.exe /c start taskschd.msc /s", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_Services_Click(sender As Object, e As EventArgs) Handles Win_Services.Click
        Shell("cmd.exe /c start services.msc", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_GPEDIT_Click(sender As Object, e As EventArgs) Handles Win_GPEDIT.Click
        Shell("cmd.exe /c start gpedit.msc", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_TroubleShooting_Click(sender As Object, e As EventArgs) Handles Win_TroubleShooting.Click
        Shell("cmd.exe /c start control.exe /name Microsoft.Troubleshooting", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_Regedit_Click(sender As Object, e As EventArgs) Handles Win_Regedit.Click
        Shell("cmd.exe /c start regedit.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_Events_Click(sender As Object, e As EventArgs) Handles Win_Events.Click
        Shell("cmd.exe /c start eventvwr.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_IPConfig_Click(sender As Object, e As EventArgs) Handles Win_IPConfig.Click
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Shell(temp + "/MoonLight_Box/ipc.bat", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Securily_Click(sender As Object, e As EventArgs) Handles Win_Securily.Click
        Shell("cmd.exe /c start wscui.cpl", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_BootOptions_Click(sender As Object, e As EventArgs) Handles Win_BootOptions.Click
        Shell("cmd.exe /c start msconfig.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_Cleaner_Click(sender As Object, e As EventArgs) Handles Win_Cleaner.Click
        Shell("cmd.exe /c start cleanmgr.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("cmd.exe /c start dfrgui.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Vid_Conv_Click(sender As Object, e As EventArgs) Handles Vid_Conv.Click
        VideoConvert.Show()
    End Sub

    Private Sub Vid_Cut_Click(sender As Object, e As EventArgs) Handles Vid_Cut.Click
        VideoCut.Show()
    End Sub

    Private Sub Vid_Play_Click(sender As Object, e As EventArgs) Handles Vid_Play.Click
        VideoPlay.Show()
    End Sub

    Private Sub Vid_FFMpeg_Click(sender As Object, e As EventArgs) Handles Vid_FFMpeg.Click
        VideoRunCmd.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MD5.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            System.Diagnostics.Process.Start(LinkLabel1.Text)
        Catch ex As Exception
        End Try
    End Sub

    '检查更新
    Private Sub GetNewVersion_Click(sender As Object, e As EventArgs) Handles GetNewVersion.Click
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        '获取版本信息
        Dim version As String
        Try
            version = Download("https://github.com/zi-jing/MoonlightBox-UpdateCheck/raw/master/version.txt")

            'MsgBox(version)
            If version.Equals("1.0.0") = True Then
                MsgBox("已是最新版本。")
            Else
                UpdateDialog.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class