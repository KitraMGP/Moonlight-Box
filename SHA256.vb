Public Class SHA256

    Private Sub GetSHA256_Explore_Click(sender As Object, e As EventArgs) Handles GetSHA256_Explore.Click
        GetSHA256_OpenFile.ShowDialog()
        GetSHA256_File.Text = GetSHA256_OpenFile.FileName
    End Sub
    Private Sub GetMD5_Run_Click(sender As Object, e As EventArgs) Handles GetSHA256_Run.Click
        Dim Crypt = New Crypt
        GetSHA256_Result.Text = Crypt.GetSHA256(GetSHA256_File.Text)
    End Sub

End Class