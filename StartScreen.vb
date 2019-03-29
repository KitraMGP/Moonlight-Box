
Public Class Start_Screen


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


    '事件

    '主界面启动

    Private Sub Start_Screen_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.DoubleBuffered = True '采用缓冲，解决窗体闪烁问题
        ExtractResources() '提取资源文件
        SetFont() '设置字体
        FormFade("in") '窗体打开时淡入
        Start_Close.Image = My.Resources.close_0
        Start_Progress.Value = 20
        Delay(1000)
        Start_Progress.Value = 60
        Start_Status.Text = "载入中..."
        Delay(500)
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
        Close()
    End Sub

    '关闭窗口时
    Private Sub Start_Screen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormFade("out")
    End Sub

End Class

