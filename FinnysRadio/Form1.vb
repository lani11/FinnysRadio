Imports System.Runtime.InteropServices

Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then

        Else
            MsgBox("You have no Internet Connections. I will close now")
            Me.Close()
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        GroupBox1.Show()
        WebBrowser1.Navigate("www.google.com.au")
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        Process.Start("C:\Windows\System32\SndVol")
    End Sub


    'Radio Buttons

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Rural Ambulance"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Gippsland Police Q1 & Q2"
        Label1.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/6091/web")
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Victoria Police CFA, MFB"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Lime
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Gippsland Vic Fire"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/9866/web")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Victoria State Emergency Services"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Lime
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/11697/web")
    End Sub


    'Notify Icon
    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub PlayRefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayRefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub PauseStopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseStopToolStripMenuItem.Click
        WebBrowser1.Stop()
        GroupBox1.Show()
    End Sub

    Private Sub VolumeSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolumeSettingsToolStripMenuItem.Click
        Process.Start("C:\Windows\System32\SndVol")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ABCClassicFMToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABCClassicFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Gippsland Police Q1 & Q2"
        Label1.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/6091/web")
    End Sub

    Private Sub ABCCountryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABCCountryToolStripMenuItem.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Gippsland Vic Fire"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/9866/web")
    End Sub

    Private Sub ABCDigMusicToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABCDigMusicToolStripMenuItem.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Rural Ambulance"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub ABCExtraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABCExtraToolStripMenuItem.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Victoria Police CFA, MFB"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Lime
        Label10.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub ABCJazzToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ABCJazzToolStripMenuItem.Click
        GroupBox1.Hide()
        Me.Text = "Finnys Scanner-Listen to Victoria State Emergency Services"
        Label1.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label10.ForeColor = Color.Lime
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/11697/web")
    End Sub
End Class
