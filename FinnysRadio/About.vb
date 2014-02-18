'Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyVer As String = My.Application.Info.Version.ToString
        Label2.Text = "Version: " + MyVer
    End Sub

    'Email Sender
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'finnysgames@gmail.com
        'finnyscomputers@gmail.com
        'Dim objOutlk As New Outlook.Application 'Outlook
        'Const olMailItem As Integer = 0
        'Dim objMail As New System.Object

        'objMail = objOutlk.CreateItem(olMailItem) 'Email item

        'Insert "To" address
        'objMail.To = "finnyscomputers@gmail.com"

        'Insert "CC" address
        'objMail.cc = "" 'Enter an address here To include a carbon copy; bcc is For blind carbon copy's

        'Set up Subject Line
        'objMail.subject = "Finnys Radio"

        'To add an attachment
        'objMail.attachments.add("enter your attachment path here")

        'Set up your message body
        'Dim msg As String

        'msg = ""
        'objMail.body = msg
        'Use this To display before sending, otherwise call (use) objMail.Send to send without reviewing
        'objMail.display()

        'Clean up
        'objMail = Nothing
        'objOutlk = Nothing
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Opens My Website Page
        Web_Browser.Show()
        Web_Browser.WebBrowser1.Navigate("http://finnyscomputers.webs.com/")
    End Sub
End Class