Public Class BETA

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Scanner.Show()
    End Sub

    Private Sub BETA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads Theme
        BackColor = My.Settings.BackgroundColour
        ForeColor = My.Settings.FontColour
    End Sub
End Class