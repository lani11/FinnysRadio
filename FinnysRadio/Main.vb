﻿'Made By Cameron Findlay (AKA cam18)
'Test By Derrick Findlay (AKA dezza), Alanna Findlay (AKA lani11)
'Thanks to Alanna Findlay for some code help

Imports System.Runtime.InteropServices
Imports System

Public Class Main

    Dim username = My.User.Name

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        username = username.Substring(username.IndexOf("\"), username.Length - username.IndexOf("\"))
        Dim MyVer As String = My.Application.Info.Version.ToString

        Me.Text = "Finnys Radio " + MyVer

        'Loads Theme
        Label95.ForeColor = My.Settings.TimeColour
        Label96.ForeColor = My.Settings.TimeColour
        BackColor = My.Settings.BackgroundColour
        ForeColor = My.Settings.FontColour
        TIMEToolStripMenuItem.ForeColor = My.Settings.TimeColour
        DATEToolStripMenuItem.ForeColor = My.Settings.TimeColour

        'Show/Hide Clock
        If My.Settings.ShowClock = True Then
            TimeDateTimer.Enabled = True
            TimeDateTimer.Interval = 1000
            Label95.Show()
            Label96.Show()
        Else
            TimeDateTimer.Enabled = False
            TimeDateTimer.Interval = 1000
            Label95.Hide()
            Label96.Hide()
        End If

        'Play Last Play Station
        If My.Settings.PlayStartup = True Then
            GroupBox1.Hide()
            WebBrowser1.Navigate(My.Settings.PlayPause)
        Else
            GroupBox1.Show()
            WebBrowser1.Navigate("")
        End If

        'Hotkeys Timer
        If My.Settings.Hotkeys = True Then
            HotKeysTimer.Enabled = True
            HotKeysTimer.Interval = 1000
        Else
            HotKeysTimer.Enabled = False
            HotKeysTimer.Interval = 1000
        End If

    End Sub

    'Auto Updater
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Settings.AutoUpdater = True Then
            Dim file As String = Application.StartupPath & "/VersionNEW.txt"
            Dim MyVer As String = My.Application.Info.Version.ToString
            If My.Computer.Network.IsAvailable Then
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

                    End If
                End If
            End If
        End If
    End Sub

    'Hot Keys
    Private Sub HotKeysTimer_Tick(sender As Object, e As EventArgs) Handles HotKeysTimer.Tick
        'Play Music
        If (GetAsyncKeyState(36)) Then
            GroupBox1.Hide()
            WebBrowser1.Navigate(My.Settings.PlayPause)
        End If

        'Stop Music
        If (GetAsyncKeyState(35)) Then
            GroupBox1.Show()
            WebBrowser1.Navigate("")
        End If

        'Show From Taskbar
        If (GetAsyncKeyState(33)) Then
            Me.Show()
            HideRadioToolStripMenuItem.Enabled = True
        End If

        'Hide To Taskbar
        If (GetAsyncKeyState(34)) Then
            Me.Hide()
            HideRadioToolStripMenuItem.Enabled = False
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Finnys Radio"
            NotifyIcon1.BalloonTipText = "FINNYS RADIO IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
            NotifyIcon1.ShowBalloonTip(1)
        End If
    End Sub

    'Clock And Date
    Private Sub TimeDateTimer_Tick(sender As Object, e As EventArgs) Handles TimeDateTimer.Tick
        Label96.Text = "TIME: " + TimeOfDay
        TIMEToolStripMenuItem.Text = "TIME: " + TimeOfDay

        Label95.Text = "DATE: " + Date.Today
        DATEToolStripMenuItem.Text = "DATE: " + Date.Today
    End Sub

    'Email Sender
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

    'Menu Controls
    Private Sub ScanerModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanerModeToolStripMenuItem.Click
        'Scanner Mode
        GroupBox1.Show()
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red

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
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke

        Me.Hide()
        Scanner.Show()
    End Sub

    Private Sub MiniModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiniModeToolStripMenuItem.Click
        Me.Hide()
        Mini_Player.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        'Hide Radio
        Me.Hide()
        HideRadioToolStripMenuItem.Enabled = False
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "Finnys Radio"
        NotifyIcon1.BalloonTipText = "FINNYS RADIO IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close Radio
        Me.Close()
    End Sub

    Private Sub PlayLastStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayLastStationToolStripMenuItem.Click
        'Play Last Station
        GroupBox1.Hide()
        WebBrowser1.Navigate(My.Settings.PlayPause)
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
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red

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
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
    End Sub

    Private Sub ThemeChangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemeChangerToolStripMenuItem.Click
        'Shows Preferences
        Preferences.Show()
    End Sub

    Private Sub ChangelogToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem1.Click
        'Shows Changelog
        Changelog.Show()
    End Sub

    Private Sub AboutRadioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutRadioToolStripMenuItem1.Click
        'Show About Radio
        About.Show()
    End Sub

    Private Sub DebugingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DebugingToolStripMenuItem1.Click
        'Show Debuging Tool
        Debuging.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem1.Click
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

    'Mini Mode
    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Mini_Player.Show()
    End Sub

    'Hide To Taskbar Button
    Private Sub Button100_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HideRadioToolStripMenuItem.Enabled = False
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "Finnys Radio"
        NotifyIcon1.BalloonTipText = "FINNYS RADIO IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
        NotifyIcon1.ShowBalloonTip(1)
    End Sub

    'Notify Icon
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'Show Radio Double Click
        Me.Show()
        HideRadioToolStripMenuItem.Enabled = True
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

    Private Sub PlayLastStationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PlayLastStationToolStripMenuItem2.Click
        'Play Last Station
        GroupBox1.Hide()
        WebBrowser1.Navigate(My.Settings.PlayPause)
    End Sub

    Private Sub StopToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem2.Click
        'Stop Playing Station
        GroupBox1.Show()
        WebBrowser1.Navigate("")
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem2.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
    End Sub


    'Radio Stations Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Lime
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/classic/player/")
        My.Settings.PlayPause = "http://www.abc.net.au/classic/player/"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Classic FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.Lime
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Lime
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abccountry.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abccountry.net.au/player-popup.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Country"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.Lime
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abcdigmusic.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abcdigmusic.net.au/player-popup.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Dig Music"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.Lime
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra")
        My.Settings.PlayPause = "http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Extra"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.Lime
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abcjazz.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abcjazz.net.au/player-popup.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Jazz"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.Lime
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Lime
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/newsradio/audio/streaming.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/newsradio/audio/streaming.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.Lime
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Lime
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.radioaustralia.net.au/listen/")
        My.Settings.PlayPause = "http://www.radioaustralia.net.au/listen/"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio Australia"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.Lime
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Lime
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/rn/legacy/player.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/rn/legacy/player.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio National"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.Lime
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Lime
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Red
        Mini_Player.Label9.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://right-click.com.au/rcPlayer/index.php?c=gippslandfm")
        My.Settings.PlayPause = "http://right-click.com.au/rcPlayer/index.php?c=gippslandfm"

        NotifyIcon1.Text = "Finnys Radio-Listen to Gippsland FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.Lime
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Lime
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Red
        Mini_Player.Label9.ForeColor = Color.Red
        Mini_Player.Label10.ForeColor = Color.Lime
        Mini_Player.Label11.ForeColor = Color.Red
        Mini_Player.Label12.ForeColor = Color.Red
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://www.countrymusicradio.com.au/CMR_Online.cfm")
        WebBrowser1.Navigate("http://www.countrymusicradio.com.au/")
        Process.Start("http://www.countrymusicradio.com.au/CMR_Online.cfm")
        My.Settings.PlayPause = "http://www.countrymusicradio.com.au/"

        NotifyIcon1.Text = "Finnys Radio-Listen to Country Music Radio.com"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.Lime
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Lime
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label11.ForeColor = Color.Lime
        Mini_Player.Label12.ForeColor = Color.Red
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://player.arn.com.au/gold1043.aspx")
        'My.Settings.PlayPause = "http://player.arn.com.au/gold1043.aspx"
        Process.Start("http://player.arn.com.au/gold1043.aspx")

        NotifyIcon1.Text = "Finnys Radio-Listen to Gold 104.3"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.Lime
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Lime
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label12.ForeColor = Color.Lime
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242")
        My.Settings.PlayPause = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242"

        NotifyIcon1.Text = "Finnys Radio-Listen to Gold 1242"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.Lime
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Lime
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label13.ForeColor = Color.Lime
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.kidsfm.com.au/")
        My.Settings.PlayPause = "http://www.kidsfm.com.au/"

        NotifyIcon1.Text = "Finnys Radio-Listen to Kids FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.Lime
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Lime
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label14.ForeColor = Color.Lime
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://www.myspace.com/music/player")
        'My.Settings.PlayPause = "http://www.myspace.com/music/player"
        Process.Start("http://www.myspace.com/music/player")

        NotifyIcon1.Text = "Finnys Radio-Listen to MySpace Music"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.Lime
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Lime
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label15.ForeColor = Color.Lime
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.star1045.com.au/player.aspx")
        My.Settings.PlayPause = "http://www.star1045.com.au/player.aspx"

        NotifyIcon1.Text = "Finnys Radio-Listen to Star FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.Lime
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Lime
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label16.ForeColor = Color.Lime
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM")
        My.Settings.PlayPause = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM"

        NotifyIcon1.Text = "Finnys Radio-Listen to TR FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.Lime
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Lime
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label17.ForeColor = Color.Lime
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/triplej.htm")
        WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/triplej.htm")
        My.Settings.PlayPause = ""

        NotifyIcon1.Text = "Finnys Radio-Listen to Triple J"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.Lime
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Lime
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label18.ForeColor = Color.Lime
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/unearthed.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/triplej/player/unearthed.htm"

        NotifyIcon1.Text = "Finnys Radio-Listen to Tripple J Unearthed"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.Lime
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Lime
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label19.ForeColor = Color.Lime
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.triplem.com.au/melbourne/player/")
        My.Settings.PlayPause = "http://www.triplem.com.au/melbourne/player/"

        NotifyIcon1.Text = "Finnys Radio-Listen to Triple M"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Lime
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Lime
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://alamo.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://alamo.mediaradioplayer.com/flash.html"

        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 1"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Lime
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Lime
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://eriador.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://eriador.mediaradioplayer.com/flash.html"

        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 2"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Lime
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Lime
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://elrond.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://elrond.mediaradioplayer.com/flash.html"

        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 3"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Lime

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Lime

        WebBrowser1.Navigate("http://excalibur.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://excalibur.mediaradioplayer.com/flash.html"

        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 4"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.Lime
    End Sub


    '######################################################################################################################################################


    'Notify Icon Radio Stations
    Private Sub ABCClassicFMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCClassicFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Lime
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/classic/player/")
        My.Settings.PlayPause = "http://www.abc.net.au/classic/player/"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Classic FM"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Classic FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.Lime
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCCountryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCCountryToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Lime
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abccountry.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abccountry.net.au/player-popup.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Country"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Country"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.Lime
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCDigMusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCDigMusicToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Lime
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abcdigmusic.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abcdigmusic.net.au/player-popup.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Dig Music"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Dig Music"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.Lime
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCExtraToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Lime
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra")
        My.Settings.PlayPause = "http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Extra"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Extra"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.Lime
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCJazzToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCJazzToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Lime
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://abcjazz.net.au/player-popup.htm")
        My.Settings.PlayPause = "http://abcjazz.net.au/player-popup.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Jazz"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Jazz"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.Lime
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCRadioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCRadioToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Lime
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/newsradio/audio/streaming.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/newsradio/audio/streaming.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Radio"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.Lime
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCRadioAustraliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCRadioAustraliaToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Lime
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.radioaustralia.net.au/listen/")
        My.Settings.PlayPause = "http://www.radioaustralia.net.au/listen/"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Radio Australia"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio Australia"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.Lime
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ABCRadioNationalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCRadioNationalToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Lime
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/rn/legacy/player.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/rn/legacy/player.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to ABC Radio National"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio National"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.Lime
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CountryMusicRadiocomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountryMusicRadiocomToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Lime
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Red
        Mini_Player.Label9.ForeColor = Color.Red
        Mini_Player.Label10.ForeColor = Color.Lime
        Mini_Player.Label11.ForeColor = Color.Red
        Mini_Player.Label12.ForeColor = Color.Red
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.countrymusicradio.com.au/CMR_Online.cfm")
        My.Settings.PlayPause = "http://www.countrymusicradio.com.au/CMR_Online.cfm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Country Music Radio.com"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Country Music Radio.com"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.Lime
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub GippslandFMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GippslandFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Lime
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

        Mini_Player.Label1.ForeColor = Color.Red
        Mini_Player.Label2.ForeColor = Color.Red
        Mini_Player.Label3.ForeColor = Color.Red
        Mini_Player.Label4.ForeColor = Color.Red
        Mini_Player.Label5.ForeColor = Color.Red
        Mini_Player.Label6.ForeColor = Color.Red
        Mini_Player.Label7.ForeColor = Color.Red
        Mini_Player.Label8.ForeColor = Color.Red
        Mini_Player.Label9.ForeColor = Color.Lime
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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://right-click.com.au/rcPlayer/index.php?c=gippslandfm")
        My.Settings.PlayPause = "http://right-click.com.au/rcPlayer/index.php?c=gippslandfm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Gippsland FM"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Gippsland FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.Lime
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Gold1043ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gold1043ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Lime
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label11.ForeColor = Color.Lime
        Mini_Player.Label12.ForeColor = Color.Red
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://player.arn.com.au/gold1043.aspx")
        My.Settings.PlayPause = "http://player.arn.com.au/gold1043.aspx"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Gold 104.3"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Gold 104.3"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.Lime
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Gold1242ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Gold1242ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Lime
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label12.ForeColor = Color.Lime
        Mini_Player.Label13.ForeColor = Color.Red
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242")
        My.Settings.PlayPause = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Gold 1242"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Gold 1242"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.Lime
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub KidsFMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KidsFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Lime
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label13.ForeColor = Color.Lime
        Mini_Player.Label14.ForeColor = Color.Red
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.kidsfm.com.au/")
        My.Settings.PlayPause = "http://www.kidsfm.com.au/"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Kids FM"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Kids FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.Lime
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub MySpaceMusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySpaceMusicToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Lime
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label14.ForeColor = Color.Lime
        Mini_Player.Label15.ForeColor = Color.Red
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.myspace.com/music/player")
        My.Settings.PlayPause = "http://www.myspace.com/music/player"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to MySpace Music"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to MySpace Music"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.Lime
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub StarFMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StarFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Lime
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label15.ForeColor = Color.Lime
        Mini_Player.Label16.ForeColor = Color.Red
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.star1045.com.au/player.aspx")
        My.Settings.PlayPause = "http://www.star1045.com.au/player.aspx"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Star FM"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Star FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.Lime
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TRFMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRFMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Lime
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label16.ForeColor = Color.Lime
        Mini_Player.Label17.ForeColor = Color.Red
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM")
        My.Settings.PlayPause = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to TR FM"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to TR FM"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.Lime
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TripleJToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TripleJToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Lime
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label17.ForeColor = Color.Lime
        Mini_Player.Label18.ForeColor = Color.Red
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/triplej.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/triplej/player/triplej.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Triple J"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Triple J"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.Lime
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TripleJUnearthedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TripleJUnearthedToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Lime
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label18.ForeColor = Color.Lime
        Mini_Player.Label19.ForeColor = Color.Red
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/unearthed.htm")
        My.Settings.PlayPause = "http://www.abc.net.au/triplej/player/unearthed.htm"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Triple J Unearthed"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Triple J Unearthed"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.Lime
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TripleMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TripleMToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Lime
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label19.ForeColor = Color.Lime
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://www.triplem.com.au/melbourne/player/")
        My.Settings.PlayPause = "http://www.triplem.com.au/melbourne/player/"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Triple M"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Tripple M"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub YimagoRadio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YimagoRadio1ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Lime
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Lime
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://alamo.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://alamo.mediaradioplayer.com/flash.html"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Yimago Radio 1"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 1"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub YimagoRadio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YimagoRadio2ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Lime
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Lime
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://eriador.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://eriador.mediaradioplayer.com/flash.html"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Yimago Radio 2"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 2"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub YimagoRadio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YimagoRadio3ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Lime
        Label23.ForeColor = Color.Red

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Lime
        Mini_Player.Label23.ForeColor = Color.Red

        WebBrowser1.Navigate("http://elrond.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://elrond.mediaradioplayer.com/flash.html"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Yimago Radio 3"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 3"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.Lime
        YimagoRadio4ToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub YimagoRadio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YimagoRadio4ToolStripMenuItem.Click
        GroupBox1.Hide()
        Label1.ForeColor = Color.Red
        Label2.ForeColor = Color.Red
        Label3.ForeColor = Color.Red
        Label4.ForeColor = Color.Red
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label7.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.ForeColor = Color.Red
        Label13.ForeColor = Color.Red
        Label14.ForeColor = Color.Red
        Label15.ForeColor = Color.Red
        Label16.ForeColor = Color.Red
        Label17.ForeColor = Color.Red
        Label18.ForeColor = Color.Red
        Label19.ForeColor = Color.Red
        Label20.ForeColor = Color.Red
        Label21.ForeColor = Color.Red
        Label22.ForeColor = Color.Red
        Label23.ForeColor = Color.Lime

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
        Mini_Player.Label20.ForeColor = Color.Red
        Mini_Player.Label21.ForeColor = Color.Red
        Mini_Player.Label22.ForeColor = Color.Red
        Mini_Player.Label23.ForeColor = Color.Lime

        WebBrowser1.Navigate("http://excalibur.mediaradioplayer.com/flash.html")
        My.Settings.PlayPause = "http://excalibur.mediaradioplayer.com/flash.html"

        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "INFO"
        NotifyIcon1.BalloonTipText = "Listen to Yimago Radio 4"
        NotifyIcon1.ShowBalloonTip(1)
        NotifyIcon1.Text = "Finnys Radio-Listen to Yimago Radio 4"

        ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioAustraliaToolStripMenuItem.BackColor = Color.WhiteSmoke
        ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        CountryMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio1ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio2ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio3ToolStripMenuItem.BackColor = Color.WhiteSmoke
        YimagoRadio4ToolStripMenuItem.BackColor = Color.Lime
    End Sub
End Class