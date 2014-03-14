Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyVer As String = My.Application.Info.Version.ToString
        Label2.Text = "Version: " + MyVer
    End Sub

    'Email Sender
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'finnysgames@gmail.com
        'finnyscomputers@gmail.com
        'cameronfindlay123456789@gamil.com
        Dim objApp As Object
        Dim objEmail As Object
        objApp = CreateObject("Outlook.Application")
        objEmail = objApp.CreateItem(0)
        With objEmail
            .To = "cameronfindlay123456789@gamil.com"
            .Subject = "Finnys Radio"
            .body = ""
            .display()
        End With
        objEmail = Nothing
        objApp = Nothing
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Opens My Website Page
        System.Diagnostics.Process.Start("http://finnyscomputers.webs.com")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://plus.google.com/u/0/+derrickfindlay/about")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://plus.google.com/u/0/103430161774735132249/about")
    End Sub
End Class