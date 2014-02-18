Public Class Updater

    Dim username = My.User.Name

    Private Sub ChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        Dim MyVer As String = My.Application.Info.Version.ToString
        Label4.Text = MyVer

        Dim fileReader3 As String
        fileReader3 = My.Computer.FileSystem.ReadAllText("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\VersionNEW.txt")
        Label5.Text = (fileReader3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.Close()
        Me.Close()
        System.Diagnostics.Process.Start("C:\Users\" & username & "\AppData\Roaming\FinnysRadio\Finnys Radio Updater.exe")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()
    End Sub
End Class