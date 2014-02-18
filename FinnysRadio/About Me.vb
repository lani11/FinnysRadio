Public Class About_Me

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Opens My Google+ Page
        Web_Browser.Show()
        Web_Browser.WebBrowser1.Navigate("https://plus.google.com/u/0/115931187799209728972/posts")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Opens My Facebook Page
        Web_Browser.Show()
        Web_Browser.WebBrowser1.Navigate("https://www.facebook.com/cam18")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Opens My Twitter Page
        Web_Browser.Show()
        Web_Browser.WebBrowser1.Navigate("https://twitter.com/Finnys1")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        'Opens My Website Page
        Web_Browser.Show()
        Web_Browser.WebBrowser1.Navigate("http://finnyscomputers.webs.com/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/19cam92")
    End Sub
End Class