Public Class MD5
    Private Sub GetMD5_Explore_Click(sender As Object, e As EventArgs) Handles GetMD5_Explore.Click
        GetMD5_OpenFile.ShowDialog()
        GetMD5_File.Text = GetMD5_OpenFile.FileName
    End Sub

    Private Sub GetMD5_Run_Click(sender As Object, e As EventArgs) Handles GetMD5_Run.Click
        GetMD5_Result.Text = GetMD5(GetMD5_File.Text)
    End Sub
End Class