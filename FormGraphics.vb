Public Class FormGraphics
    Sub FormMove(ByVal Type As String, ByVal Form As Form)

        'Dim Count As Integer
        Dim TempLocation As Point
        Dim ToLocation As Point
        Dim ScreenWidth As Integer
        Dim ScreenHeight As Integer
        Dim EachStepW As Integer
        Dim EachStepH As Integer
        'Dim TempOpacity As Double
        Dim StepOpacity As Double

        With TempLocation
            .X = 0
            .Y = Form.Location.Y
        End With


        ToLocation = Form.Location
        ScreenWidth = My.Computer.Screen.Bounds.Width
        ScreenHeight = My.Computer.Screen.Bounds.Height
        EachStepW = ScreenWidth / 50
        EachStepH = ScreenHeight / 50

        StepOpacity = 1 / (ToLocation.X / 50)

        Select Case Type
            Case "in"

                Form.Opacity = 0

                While TempLocation.X < ToLocation.X
                    TempLocation.X = TempLocation.X + EachStepW
                    Form.Location = TempLocation
                    Form.Opacity = Form.Opacity + StepOpacity
                    Delay(20)

                End While

                Form.Location = ToLocation
            Case ("out")

                Form.Opacity = 100
                TempLocation.X = Form.Location.X
                While TempLocation.X < ScreenWidth
                    TempLocation.X = TempLocation.X + EachStepW
                    Form.Location = TempLocation
                    Form.Opacity = Form.Opacity - StepOpacity
                    Delay(20)

                End While


        End Select
    End Sub
End Class
