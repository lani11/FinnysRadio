Public Class Program_Up_To_Date

    Dim username = My.User.Name

    Private Sub Program_Up_To_Date_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        Dim MyVer As String = My.Application.Info.Version.ToString
        Label2.Text = "Current Installed Version: " + MyVer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        End If
        My.Computer.FileSystem.CopyFile("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\Setup.exe", "C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        System.Diagnostics.Process.Start("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        Main.Close()
    End Sub
End Class