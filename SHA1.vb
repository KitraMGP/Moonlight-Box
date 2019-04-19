Public Class SHA1
    Private Sub GetSHA1_Explore_Click(sender As Object, e As EventArgs) Handles GetSHA1_Explore.Click
        GetSHA1_OpenFile.ShowDialog()
        GetSHA1_File.Text = GetSHA1_OpenFile.FileName
    End Sub
    Private Sub GetSHA1_Run_Click(sender As Object, e As EventArgs) Handles GetSHA1_Run.Click
        Dim Crypt = New Crypt
        GetSHA1_Result.Text = Crypt.GetSHA1(GetSHA1_File.Text)
    End Sub
End Class