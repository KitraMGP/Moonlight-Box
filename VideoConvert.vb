Public Class VideoConvert
    Private Sub VideoConvert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '自动填入路径
    Private Sub VidConvertSrc_Explore_Click(sender As Object, e As EventArgs) Handles VidConvertSrc_Explore.Click
        VidConvert_OpenFile.ShowDialog()
        VidConvert_Src.Text = VidConvert_OpenFile.FileName
    End Sub

    Private Sub VidConvertOut_Explore_Click(sender As Object, e As EventArgs) Handles VidConvertOut_Explore.Click
        VidConvert_OutFile.ShowDialog()
        VidConvert_Out.Text = VidConvert_OutFile.FileName
    End Sub


    '开始转换
    Private Sub VidConvert_Start_Click(sender As Object, e As EventArgs) Handles VidConvert_Start.Click


        VidConvert_Cmd.Text = "ffmpeg -i " + VidConvert_Src.Text + " -r " + VidConvert_FPS.Text + " -b:v " + VidConvert_Kbps.Text + "k -bufsize " + VidConvert_Kbps.Text + "k -maxrate " + VidConvert_Kbps.Text + "k " + VidConvert_Out.Text
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp

        'Shell(temp + " / " + VidConvert_Cmd.Text, AppWinStyle.NormalFocus)
        'Shell(temp + "/" + VidConvert_Cmd.Text, AppWinStyle.NormalFocus)
        'RunCmd(temp + "\MoonLight_Box\ffmpeg.exe", "-i " + VidConvert_Src.Text + " -r " + VidConvert_FPS.Text + " -b:v " + VidConvert_Kbps.Text + "k -bufsize " + VidConvert_Kbps.Text + "k -maxrate " + VidConvert_Kbps.Text + "k " + VidConvert_Out.Text, VidConvert_Log)

        Shell(temp + "/MoonLight_Box/" + VidConvert_Cmd.Text, AppWinStyle.NormalFocus)
    End Sub

End Class