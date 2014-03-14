Public Class About_Me

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Opens My Google+ Page
        System.Diagnostics.Process.Start("https://plus.google.com/u/0/+CameronFindlay92/about")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Opens My Facebook Page
        System.Diagnostics.Process.Start("https://www.facebook.com/cam18")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Opens My Twitter Page
        System.Diagnostics.Process.Start("https://twitter.com/Finnys1")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Opens My Website Page
        System.Diagnostics.Process.Start("http://finnyscomputers.webs.com/")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'Opens My Github Page
        System.Diagnostics.Process.Start("https://github.com/19cam92")
    End Sub
End Class