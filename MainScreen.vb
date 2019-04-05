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

    '显示贴图
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Main_Close.Image = My.Resources.close_0
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
End Class