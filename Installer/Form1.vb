Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Start.Hide()


        LICENSE.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start.Show()
        LICENSE.Hide()
        Settings.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FolderBrowserDialog1.ShowDialog()
        InstallLocation.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Settings.Show()
        LICENSE.Hide()
        InstallLocation.Text = My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Moonlight_Box_zi_jing"
    End Sub
End Class
