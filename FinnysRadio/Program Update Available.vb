Public Class Program_Update_Available

    Dim username = My.User.Name

    Private Sub Program_Update_Available_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        Dim MyVer As String = My.Application.Info.Version.ToString
        Label2.Text = "Current Installed Version: " + MyVer

        Dim fileReader3 As String
        fileReader3 = My.Computer.FileSystem.ReadAllText("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\VersionNEW.txt")
        Label3.Text = "Lastest Version: " + (fileReader3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        End If
        My.Computer.FileSystem.CopyFile("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\Setup.exe", "C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        System.Diagnostics.Process.Start("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup.exe")
        Main.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If My.Computer.FileSystem.FileExists("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\beta\Setup_Beta.exe") Then
            If My.Computer.FileSystem.FileExists("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\beta\Setup_Beta.exe") Then
                My.Computer.FileSystem.DeleteFile("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\beta\Setup_Beta.exe")
            End If
            My.Computer.FileSystem.CopyFile("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\beta\Setup_Beta.exe", "C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup_Beta.exe")
            System.Diagnostics.Process.Start("C:\Users\" & username & "\AppData\Roaming\Finnys Radio\Setup_Beta.exe")
            Main.Close()
        End If
    End Sub
End Class