Public Class Changelog

    Dim username = My.User.Name

    'My.Settings.Changelog.Add(CheckBox1.Checked.ToString)
    Private Sub Changlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        Dim file As String = Application.StartupPath & "/Changelog.txt"
        If My.Computer.FileSystem.FileExists(file) Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(file)
            RichTextBox1.Text = (fileReader)
        Else
            RichTextBox1.ForeColor = Color.Red
            RichTextBox1.Text = "Couldn't Download Changelog.                               Check your internet Connection."
        End If
    End Sub
End Class