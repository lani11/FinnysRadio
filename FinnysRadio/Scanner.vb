﻿'Made By Cameron Findlay (AKA cam18)
'Test By Derrick Findlay (AKA dezza), Alanna Findlay (AKA lani11)
'Thanks to Alanna Findlay for some code help

Public Class Scanner

    Dim username = My.User.Name

    Private Sub Scanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Close()
        GroupBox1.Show()
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
    End Sub

    Private Sub Scanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))

        'Loads Theme
        Label95.ForeColor = My.Settings.TimeColour
        Label96.ForeColor = My.Settings.TimeColour
        BackColor = My.Settings.BackgroundColour
        ForeColor = My.Settings.FontColour

        If My.Settings.ShowClock = True Then
            Label95.Show()
            Label96.Show()
        Else
            Label95.Hide()
            Label96.Hide()
        End If

        'Enables Timer
        TimeDateTimer.Enabled = True
        TimeDateTimer.Interval = 1000
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
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        'Hide Scanner
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
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red

        GippslandPoliceQ1Q2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandVicFireToolStripMenuItem.BackColor = Color.WhiteSmoke
        RuralAmbulanceToolStripMenuItem.BackColor = Color.WhiteSmoke
        VictoriaPoliceCFAMFBToolStripMenuItem.BackColor = Color.WhiteSmoke
        VictoriaStateEmergencyToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
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
                    Program_Update_Available.Show()
                Else
                    Program_Up_To_Date.Show()
                End If
            End If
        Else
            No_Network.Show()
        End If
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMeToolStripMenuItem.Click
        'About Me
        About_Me.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
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

    Private Sub ShowRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowRadioToolStripMenuItem.Click
        'Show Radio
        Me.Show()
        HideRadioToolStripMenuItem.Enabled = True
    End Sub

    Private Sub HideRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideRadioToolStripMenuItem.Click
        'Hide Radio
        Me.Hide()
        HideRadioToolStripMenuItem.Enabled = False
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "Finnys Radio"
        NotifyIcon1.BalloonTipText = "FINNYS RADIO IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub CloseRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseRadioToolStripMenuItem.Click
        'Close Radio
        Me.Close()
    End Sub

    Private Sub PlayLastStationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayLastStationToolStripMenuItem1.Click
        'Play Last Station
        GroupBox1.Hide()
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub StopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem1.Click
        'Stop Playing Station
        GroupBox1.Show()
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red

        GippslandPoliceQ1Q2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandVicFireToolStripMenuItem.BackColor = Color.WhiteSmoke
        RuralAmbulanceToolStripMenuItem.BackColor = Color.WhiteSmoke
        VictoriaPoliceCFAMFBToolStripMenuItem.BackColor = Color.WhiteSmoke
        VictoriaStateEmergencyToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem1.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
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


    '######################################################################################################################################################


    'Notify Icon Radio Stations

    Private Sub GippslandPoliceQ1Q2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GippslandPoliceQ1Q2ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Lime
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub GippslandVicFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GippslandVicFireToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Lime
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub RuralAmbulanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuralAmbulanceToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/7061/web")
    End Sub

    Private Sub VictoriaPoliceCFAMFBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VictoriaPoliceCFAMFBToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/13368/web")
    End Sub

    Private Sub VictoriaStateEmergencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VictoriaStateEmergencyToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        WebBrowser1.Navigate("http://www.broadcastify.com/listen/feed/11697/web")
    End Sub
End Class