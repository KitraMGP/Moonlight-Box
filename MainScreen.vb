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
        SetFont(Panel_Win_Desc, 26, Color.White)


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
        Shell("control.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_OpenTempFolder_Click(sender As Object, e As EventArgs) Handles Win_OpenTempFolder.Click
        'Shell("explorer.exe %temp%\", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Programs_Click(sender As Object, e As EventArgs) Handles Win_Programs.Click
        Shell(Application.StartupPath + "\programs.bat", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Win_WinVer_Click(sender As Object, e As EventArgs) Handles Win_WinVer.Click
        'Shell("winver.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_OSInfo_Click(sender As Object, e As EventArgs) Handles Win_OSInfo.Click
        Shell("control.exe system", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Devices_Click(sender As Object, e As EventArgs) Handles Win_Devices.Click
        'Shell("compmgmt.msc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_OpenCmd_Click(sender As Object, e As EventArgs) Handles Win_OpenCmd.Click
        Shell("cmd.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Tasks_Click(sender As Object, e As EventArgs) Handles Win_Tasks.Click
        'Shell("taskschd.msc /s", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Services_Click(sender As Object, e As EventArgs) Handles Win_Services.Click
        'Shell("services.msc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_GPEDIT_Click(sender As Object, e As EventArgs) Handles Win_GPEDIT.Click
        'Shell("gpedit.msc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_TroubleShooting_Click(sender As Object, e As EventArgs) Handles Win_TroubleShooting.Click
        Shell("control.exe /name Microsoft.Troubleshooting", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Regedit_Click(sender As Object, e As EventArgs) Handles Win_Regedit.Click
        'Shell("regedit.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Events_Click(sender As Object, e As EventArgs) Handles Win_Events.Click
        'Shell("eventvwr.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_IPConfig_Click(sender As Object, e As EventArgs) Handles Win_IPConfig.Click
        'Shell("ipconfig.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Securily_Click(sender As Object, e As EventArgs) Handles Win_Securily.Click
        'Shell("wscui.cpl", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_BootOptions_Click(sender As Object, e As EventArgs) Handles Win_BootOptions.Click
        'Shell("msconfig.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Win_Cleaner_Click(sender As Object, e As EventArgs) Handles Win_Cleaner.Click
        Shell("cleanmgr.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("dfrgui.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Vid_Conv_Click(sender As Object, e As EventArgs) Handles Vid_Conv.Click
        VideoConvert.Show()
    End Sub
End Class