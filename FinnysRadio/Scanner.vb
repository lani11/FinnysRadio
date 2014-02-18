'Made By Cameron Findlay (AKA cam18)
'Test By Derrick Findlay (AKA dezza), Alanna Findlay (AKA lani11)
'Thanks to Alanna Findlay for some code help

Public Class Scanner

    Dim username = My.User.Name

    Private Sub Scanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Close()
        GroupBox1.Show()
        WebBrowser1.Navigate("http://finnyscomputers.webs.com")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
    End Sub

    Private Sub Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        'Enables Timer
        TimeDateTimer.Enabled = True
        TimeDateTimer.Interval = 1000
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Lime
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Lime
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/11697/web")
    End Sub

    'Clock And Date
    Private Sub TimeDateTimer_Tick(sender As Object, e As EventArgs) Handles TimeDateTimer.Tick
        Label96.Text = "TIME: " + TimeOfDay
        TIMEToolStripMenuItem.Text = "TIME: " + TimeOfDay

        Label95.Text = "DATE: " + Date.Today
        DATEToolStripMenuItem.Text = "DATE: " + Date.Today
    End Sub

    Private Sub RadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioToolStripMenuItem.Click
        GroupBox1.Show()
        WebBrowser1.Navigate("http://finnyscomputers.webs.com")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        'Hide Radio
        Me.Hide()
        'HideRadioToolStripMenuItem.Enabled = False
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "Finnys Scannner"
        NotifyIcon1.BalloonTipText = "FINNYS SCANNER IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close Radio
        Main.Close()
        Me.Close()
    End Sub

    Private Sub PlayLastStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayLastStationToolStripMenuItem.Click
        'Play Last Station
        GroupBox1.Hide()
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        'Stop Playing Station
        GroupBox1.Show()
        WebBrowser1.Navigate("http://finnyscomputers.webs.com")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Red
        Mini_Player.Label9.ForeColor = Color.Red
        Mini_Player.Label10.ForeColor = Color.Red
        Mini_Player.Label11.ForeColor = Color.Red
        Mini_Player.Label12.ForeColor = Color.Red
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
    End Sub

    Private Sub ThemeChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemeChangerToolStripMenuItem.Click

    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        'Shows Changelog
        Changelog.Show()
    End Sub

    Private Sub AboutRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutRadioToolStripMenuItem.Click
        'Show About Radio
        About.Show()
    End Sub

    Private Sub DebugingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugingToolStripMenuItem.Click
        Debuging.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        'Manual Updater
        Dim file As String = Application.StartupPath & "/VersionNEW.txt"
        Dim MyVer As String = My.Application.Info.Version.ToString

        If My.Computer.FileSystem.DirectoryExists("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio") Then
            If My.Computer.FileSystem.FileExists(file) Then
                My.Computer.FileSystem.DeleteFile(file)
            End If

            If My.Computer.FileSystem.FileExists("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\VersionNEW.txt") Then
                My.Computer.Network.DownloadFile("\\SERVER-PC\Network Drive 1\Programs\FinnysRadio\VersionNEW.txt", file)
                Dim LastVer As String = My.Computer.FileSystem.ReadAllText(file)
                If Not MyVer = LastVer Then
                    Me.Hide()
                    Updater.Show()
                Else
                    'MsgBox("Program Is Update to Date")
                    Program_Up_To_Date.Show()
                End If
            End If
        Else
            'MsgBox("Could'nt Check For Updates. CHECK YOUR INTERNET")
            No_Network.Show()
        End If
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UninstallToolStripMenuItem.Click
        'Uninstalls Radio
        Me.Close()
        System.Diagnostics.Process.Start("C:\Users\" & username & "\AppData\Roaming\FinnysRadio\Finnys Radio Uninstaller.exe")
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        'About Me
        About_Me.Show()
    End Sub
End Class