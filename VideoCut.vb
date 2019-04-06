Public Class VideoCut
    Private Sub VidCutSrc_Explore_Click(sender As Object, e As EventArgs) Handles VidCutSrc_Explore.Click
        VidCut_OpenFile.ShowDialog()
        VidCut_Src.Text = VidCut_OpenFile.FileName
    End Sub

    Private Sub VidCutOut_Explore_Click(sender As Object, e As EventArgs) Handles VidCutOut_Explore.Click
        VidCut_OutFile.ShowDialog()
        VidCut_Out.Text = VidCut_OutFile.FileName
    End Sub

    '开始转换
    Private Sub VidCut_Start_Click(sender As Object, e As EventArgs) Handles VidCut_Start.Click
        VidCut_Cmd.Text = "ffmpeg -i " + VidCut_Src.Text + " -ss " + VidCut_StartTime.Text + " -t " + VidCut_KeepTime.Text + " -bsf:v h264_mp4toannexb -vcodec copy -acodec copy " + VidCut_Out.Text
        Dim fs = My.Computer.FileSystem
        Dim temp = fs.SpecialDirectories.Temp
        Shell(temp + "/MoonLight_Box/" + VidCut_Cmd.Text, AppWinStyle.NormalFocus)
        'RunCmd("cmd", "", VidCut_Log)
    End Sub
End Class