Public Class Changelog

    Dim username = My.User.Name

    Private Sub Changlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        'Loads Theme
        BackColor = My.Settings.BackgroundColour
        ForeColor = My.Settings.FontColour

        Dim file As String = Application.StartupPath & "/Changelog.txt"
        If My.Computer.FileSystem.FileExists(file) Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(file)
            WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath(".\Changelog.txt"))
        Else
            WebBrowser1.Navigate("about:blank")
        End If
    End Sub
End Class