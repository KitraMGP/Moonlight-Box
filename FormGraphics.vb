Public Class FormGraphics

    '在窗口打开时使用窗体移动特效
    Sub FormMove(ByVal Type As String, ByVal Form As Form)

        Try

            '当前窗体位置
            Dim TempLocation As Point

            '窗口的目标位置
            Dim ToLocation As Point

            '屏幕长宽
            Dim ScreenWidth As Integer
            Dim ScreenHeight As Integer

            '每次移动的距离（宽度，高度）
            Dim EachStepW As Integer
            Dim EachStepH As Integer

            '每次改变的透明度
            Dim StepOpacity As Double

            '移动次数
            Dim Steps As Integer

            '初始化
            With TempLocation
                .X = 0
                .Y = Form.Location.Y
            End With

            '总共移动50次
            Steps = 50

            '获取窗体位置
            ToLocation = Form.Location

            '获取屏幕长宽
            ScreenWidth = My.Computer.Screen.Bounds.Width
            ScreenHeight = My.Computer.Screen.Bounds.Height

            '计算每次移动距离 Steps为移动总次数
            EachStepW = ToLocation.X / Steps
            EachStepH = ToLocation.Y / Steps

            '计算每次改变的窗体透明度
            StepOpacity = 1 / Steps

            '选择模式
            Select Case Type

            '淡入
                Case "in"

                    '先将窗体设成全透明
                    Form.Opacity = 0

                    '移动窗体并提高不透明度
                    While TempLocation.X < ToLocation.X
                        TempLocation.X = TempLocation.X + EachStepW
                        Form.Location = TempLocation
                        Form.Opacity = Form.Opacity + StepOpacity

                        '延时
                        Delay(5)

                    End While

                    '修正窗体移动产生的微小误差
                    Form.Location = ToLocation

            '淡出
                Case ("out")

                    '先将窗体设成全不透明
                    Form.Opacity = 100

                    '移动窗体，提高透明度
                    TempLocation.X = Form.Location.X
                    While TempLocation.X < ScreenWidth
                        TempLocation.X = TempLocation.X + EachStepW
                        Form.Location = TempLocation
                        Form.Opacity = Form.Opacity - StepOpacity

                        '延时
                        Delay(5)

                    End While


            End Select

            '抛出异常
        Catch ex As Exception
            ShowErr(ex, "未知")

        End Try
    End Sub
End Class
