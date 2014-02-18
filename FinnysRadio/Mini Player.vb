Public Class Mini_Player

    Private Sub Mini_Player_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub

    Private Sub Mini_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Menu Controls
    Private Sub FullModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullModeToolStripMenuItem.Click
        'Full Mode
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        'Hide Radio
        Me.Hide()
        Main.HideRadioToolStripMenuItem.Enabled = False
        Main.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        Main.NotifyIcon1.BalloonTipTitle = "Finnys Radio"
        Main.NotifyIcon1.BalloonTipText = "FINNYS RADIO IS STILL RUNNING RIGHT CLICK FOR OPTIONS DOUBLE CLICK TO SHOW"
        Main.NotifyIcon1.ShowBalloonTip(1)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Close Mini Radio Show Full Radio
        Me.Close()
        Main.Show()
    End Sub

    Private Sub PlayLastStationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayLastStationToolStripMenuItem.Click
        'Play Last Station
        Main.GroupBox1.Hide()
        Main.WebBrowser1.Navigate(Main.TextBox1.Text)
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        'Stop Playing Station
        Main.GroupBox1.Show()
        Main.WebBrowser1.Navigate("http://finnyscomputers.webs.com")
        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

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

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        'Volume Control
        Process.Start("C:\Windows\System32\SndVol")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'Full Mode
        Me.Hide()
        Main.Show()
    End Sub


    'Radio Stations Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Lime
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/classic/player/")
        Main.TextBox1.Text = "http://www.abc.net.au/classic/player/"


        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Classic FM"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.Lime
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Lime
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://abccountry.net.au/player-popup.htm")
        Main.TextBox1.Text = "http://abccountry.net.au/player-popup.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Country"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.Lime
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Lime
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://abcdigmusic.net.au/player-popup.htm")
        Main.TextBox1.Text = "http://abcdigmusic.net.au/player-popup.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Dig Music"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.Lime
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Lime
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra")
        Main.TextBox1.Text = "http://www.abc.net.au/local/players/internet_radio.htm?streamFile=extra"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Extra"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.Lime
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Lime
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://abcjazz.net.au/player-popup.htm")
        Main.TextBox1.Text = "http://abcjazz.net.au/player-popup.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Jazz"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.Lime
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Lime
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/newsradio/audio/streaming.htm")
        Main.TextBox1.Text = "http://www.abc.net.au/newsradio/audio/streaming.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.Lime
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Lime
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.radioaustralia.net.au/listen/")
        Main.TextBox1.Text = "http://www.radioaustralia.net.au/listen/"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio Australia"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.Lime
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Lime
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/rn/legacy/player.htm")
        Main.TextBox1.Text = "http://www.abc.net.au/rn/legacy/player.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to ABC Radio National"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.Lime
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Lime
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://right-click.com.au/rcPlayer/index.php?c=gippslandfm")
        Main.TextBox1.Text = "http://right-click.com.au/rcPlayer/index.php?c=gippslandfm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Gippsland FM"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.Lime
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Lime
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://www.countrymusicradio.com.au/CMR_Online.cfm")
        Main.WebBrowser1.Navigate("http://www.countrymusicradio.com.au/")
        Process.Start("http://www.countrymusicradio.com.au/CMR_Online.cfm")
        Main.TextBox1.Text = "http://www.countrymusicradio.com.au/"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Country Music Radio.com"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.Lime
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Lime
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://player.arn.com.au/gold1043.aspx")
        'TextBox1.Text = "http://player.arn.com.au/gold1043.aspx"
        Process.Start("http://player.arn.com.au/gold1043.aspx")

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Gold 104.3"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.Lime
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Lime
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242")
        Main.TextBox1.Text = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=GOLD1242"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Gold 1242"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.Lime
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Lime
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.kidsfm.com.au/")
        Main.TextBox1.Text = "http://www.kidsfm.com.au/"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Kids FM"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.Lime
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Lime
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        'WebBrowser1.Navigate("http://www.myspace.com/music/player")
        'TextBox1.Text = "http://www.myspace.com/music/player"
        Process.Start("http://www.myspace.com/music/player")

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to MySpace Music"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.Lime
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Lime
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.star1045.com.au/player.aspx")
        Main.TextBox1.Text = "http://www.star1045.com.au/player.aspx"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Star FM"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.Lime
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Lime
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM")
        Main.TextBox1.Text = "http://player.streamtheworld.com/_players/aceradiobroadcast/?market=gippsland&callsign=TRFM"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to TR FM"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.Lime
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Lime
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/triplej.htm")
        Main.WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/triplej.htm")
        Main.TextBox1.Text = ""

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Triple J"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.Lime
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Lime
        Main.Label19.ForeColor = Color.Red

        Main.WebBrowser1.Navigate("http://www.abc.net.au/triplej/player/unearthed.htm")
        Main.TextBox1.Text = "http://www.abc.net.au/triplej/player/unearthed.htm"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Tripple J Unearthed"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.Lime
        Main.TripleMToolStripMenuItem.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Main.GroupBox1.Hide()
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

        Main.Label1.ForeColor = Color.Red
        Main.Label2.ForeColor = Color.Red
        Main.Label3.ForeColor = Color.Red
        Main.Label4.ForeColor = Color.Red
        Main.Label5.ForeColor = Color.Red
        Main.Label6.ForeColor = Color.Red
        Main.Label7.ForeColor = Color.Red
        Main.Label8.ForeColor = Color.Red
        Main.Label9.ForeColor = Color.Red
        Main.Label10.ForeColor = Color.Red
        Main.Label11.ForeColor = Color.Red
        Main.Label12.ForeColor = Color.Red
        Main.Label13.ForeColor = Color.Red
        Main.Label14.ForeColor = Color.Red
        Main.Label15.ForeColor = Color.Red
        Main.Label16.ForeColor = Color.Red
        Main.Label17.ForeColor = Color.Red
        Main.Label18.ForeColor = Color.Red
        Main.Label19.ForeColor = Color.Lime

        Main.WebBrowser1.Navigate("http://www.triplem.com.au/melbourne/player/")
        Main.TextBox1.Text = "http://www.triplem.com.au/melbourne/player/"

        Main.NotifyIcon1.Text = "Finnys Radio-Listen to Triple M"

        Main.ABCClassicFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCCountryToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCDigMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCExtraToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCJazzToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioAustrailiaToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ABCRadioNationalToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.GippslandFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.ConnrtyMusicRadiocomToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1043ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.Gold1242ToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.KidsFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.MySpaceMusicToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.StarFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TRFMToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleJUnearthedToolStripMenuItem.BackColor = Color.WhiteSmoke
        Main.TripleMToolStripMenuItem.BackColor = Color.Lime
    End Sub
End Class