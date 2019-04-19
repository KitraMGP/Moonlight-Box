Public Class CRC32
    Private Sub GetCRC32_Explore_Click(sender As Object, e As EventArgs) Handles GetCRC32_Explore.Click
        GetCRC32_OpenFile.ShowDialog()
        GetCRC32_File.Text = GetCRC32_OpenFile.FileName
    End Sub
    Private Sub GetMD5_Run_Click(sender As Object, e As EventArgs) Handles GetCRC32_Run.Click
        Dim Crypt = New Crypt
        GetCRC32_Result.Text = Crypt.GetCRC32(GetCRC32_File.Text)
    End Sub
End Class