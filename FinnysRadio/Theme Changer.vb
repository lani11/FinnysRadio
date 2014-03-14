Public Class Theme_Changer
    Dim TimeColour As New My.MySettings
    Dim BackgroundColour As New My.MySettings
    Dim FontColour As New My.MySettings
    Private Sub TimeColourChanger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'My.Settings.TimeColour.Add(ComboBox1.SelectedItem)
        'My.Settings.BackgroundColour.Add(ComboBox2.SelectedItem)
        'My.Settings.FontColour.Add(ComboBox3.SelectedItem)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Label96.ForeColor = Color.Lime
        Main.TIMEToolStripMenuItem.ForeColor = Color.Lime
        Main.Label95.ForeColor = Color.Lime
        Main.DATEToolStripMenuItem.ForeColor = Color.Lime
        Main.BackColor = Color.Gray
        Main.Label99.ForeColor = Color.White
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        PictureBox1.BackColor = Color.White
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Time and Date Colours
        Select Case ComboBox1.SelectedIndex
            Case 1
                Main.Label96.ForeColor = Color.Aqua
                Main.TIMEToolStripMenuItem.ForeColor = Color.Aqua
                Main.Label95.ForeColor = Color.Aqua
                Main.DATEToolStripMenuItem.ForeColor = Color.Aqua
                PictureBox1.BackColor = Color.Aqua
            Case 2
                Main.Label96.ForeColor = Color.Aquamarine
                Main.TIMEToolStripMenuItem.ForeColor = Color.Aquamarine
                Main.Label95.ForeColor = Color.Aquamarine
                Main.DATEToolStripMenuItem.ForeColor = Color.Aquamarine
                PictureBox1.BackColor = Color.Aquamarine
            Case 3
                Main.Label96.ForeColor = Color.Black
                Main.TIMEToolStripMenuItem.ForeColor = Color.Black
                Main.Label95.ForeColor = Color.Black
                Main.DATEToolStripMenuItem.ForeColor = Color.Black
                PictureBox1.BackColor = Color.Black
            Case 4
                Main.Label96.ForeColor = Color.Blue
                Main.TIMEToolStripMenuItem.ForeColor = Color.Blue
                Main.Label95.ForeColor = Color.Blue
                Main.DATEToolStripMenuItem.ForeColor = Color.Blue
                PictureBox1.BackColor = Color.Blue
            Case 5
                Main.Label96.ForeColor = Color.Gray
                Main.TIMEToolStripMenuItem.ForeColor = Color.Gray
                Main.Label95.ForeColor = Color.Gray
                Main.DATEToolStripMenuItem.ForeColor = Color.Gray
                PictureBox1.BackColor = Color.Gray
            Case 6
                Main.Label96.ForeColor = Color.Green
                Main.TIMEToolStripMenuItem.ForeColor = Color.Green
                Main.Label95.ForeColor = Color.Green
                Main.DATEToolStripMenuItem.ForeColor = Color.Green
                PictureBox1.BackColor = Color.Green
            Case 7
                Main.Label96.ForeColor = Color.Lime
                Main.TIMEToolStripMenuItem.ForeColor = Color.Lime
                Main.Label95.ForeColor = Color.Lime
                Main.DATEToolStripMenuItem.ForeColor = Color.Lime
                PictureBox1.BackColor = Color.Lime
            Case 8
                Main.Label96.ForeColor = Color.Magenta
                Main.TIMEToolStripMenuItem.ForeColor = Color.Magenta
                Main.Label95.ForeColor = Color.Magenta
                Main.DATEToolStripMenuItem.ForeColor = Color.Magenta
                PictureBox1.BackColor = Color.Magenta
            Case 9
                Main.Label96.ForeColor = Color.Olive
                Main.TIMEToolStripMenuItem.ForeColor = Color.Olive
                Main.Label95.ForeColor = Color.Olive
                Main.DATEToolStripMenuItem.ForeColor = Color.Olive
                PictureBox1.BackColor = Color.Olive
            Case 10
                Main.Label96.ForeColor = Color.Orange
                Main.TIMEToolStripMenuItem.ForeColor = Color.Orange
                Main.Label95.ForeColor = Color.Orange
                Main.DATEToolStripMenuItem.ForeColor = Color.Orange
                PictureBox1.BackColor = Color.Orange
            Case 11
                Main.Label96.ForeColor = Color.Pink
                Main.TIMEToolStripMenuItem.ForeColor = Color.Pink
                Main.Label95.ForeColor = Color.Pink
                Main.DATEToolStripMenuItem.ForeColor = Color.Pink
                PictureBox1.BackColor = Color.Pink
            Case 12
                Main.Label96.ForeColor = Color.Purple
                Main.TIMEToolStripMenuItem.ForeColor = Color.Purple
                Main.Label95.ForeColor = Color.Purple
                Main.DATEToolStripMenuItem.ForeColor = Color.Purple
                PictureBox1.BackColor = Color.Purple
            Case 13
                Main.Label96.ForeColor = Color.Red
                Main.TIMEToolStripMenuItem.ForeColor = Color.Red
                Main.Label95.ForeColor = Color.Red
                Main.DATEToolStripMenuItem.ForeColor = Color.Red
                PictureBox1.BackColor = Color.Red
            Case 14
                Main.Label96.ForeColor = Color.White
                Main.TIMEToolStripMenuItem.ForeColor = Color.White
                Main.Label95.ForeColor = Color.White
                Main.DATEToolStripMenuItem.ForeColor = Color.White
                PictureBox1.BackColor = Color.White
            Case 15
                Main.Label96.ForeColor = Color.Yellow
                Main.TIMEToolStripMenuItem.ForeColor = Color.Yellow
                Main.Label95.ForeColor = Color.Yellow
                Main.DATEToolStripMenuItem.ForeColor = Color.Yellow
                PictureBox1.BackColor = Color.Yellow
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'Background Colours
        Select Case ComboBox2.SelectedIndex
            Case 1
                Main.BackColor = Color.Aqua
                'Me.BackColor = Color.Aqua
                PictureBox1.BackColor = Color.Aqua
            Case 2
                Main.BackColor = Color.Aquamarine
                'Me.BackColor = Color.Aquamarine
                PictureBox1.BackColor = Color.Aquamarine
            Case 3
                Main.BackColor = Color.Black
                'Me.BackColor = Color.Black
                PictureBox1.BackColor = Color.Black
            Case 4
                Main.BackColor = Color.Blue
                'Me.BackColor = Color.Blue
                PictureBox1.BackColor = Color.Blue
            Case 5
                Main.BackColor = Color.Gray
                'Me.BackColor = Color.Gray
                PictureBox1.BackColor = Color.Gray
            Case 6
                Main.BackColor = Color.Green
                'Me.BackColor = Color.Green
                PictureBox1.BackColor = Color.Green
            Case 7
                Main.BackColor = Color.Lime
                'Me.BackColor = Color.Lime
                PictureBox1.BackColor = Color.Lime
            Case 8
                Main.BackColor = Color.Magenta
                'Me.BackColor = Color.Magenta
                PictureBox1.BackColor = Color.Magenta
            Case 9
                Main.BackColor = Color.Olive
                'Me.BackColor = Color.Olive
                PictureBox1.BackColor = Color.Olive
            Case 10
                Main.BackColor = Color.Orange
                'Me.BackColor = Color.Orange
                PictureBox1.BackColor = Color.Orange
            Case 11
                Main.BackColor = Color.Pink
                'Me.BackColor = Color.Pink
                PictureBox1.BackColor = Color.Pink
            Case 12
                Main.BackColor = Color.Purple
                'Me.BackColor = Color.Purple
                PictureBox1.BackColor = Color.Purple
            Case 13
                Main.BackColor = Color.Red
                'Me.BackColor = Color.Red
                PictureBox1.BackColor = Color.Red
            Case 14
                Main.BackColor = Color.White
                'Me.BackColor = Color.White
                PictureBox1.BackColor = Color.White
            Case 15
                Main.BackColor = Color.Yellow
                'Me.BackColor = Color.Yellow
                PictureBox1.BackColor = Color.Yellow
        End Select
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        'Font Colours
        Select Case ComboBox3.SelectedIndex
            Case 1
                Main.Label99.ForeColor = Color.White
                'Me.ForeColor = Color.White
                PictureBox1.BackColor = Color.White
            Case 2
                Main.Label99.ForeColor = Color.Black
                'Me.ForeColor = Color.Black
                PictureBox1.BackColor = Color.Black
            Case 3
                Main.Label99.ForeColor = Color.Gray
                'Me.ForeColor = Color.Gray
                PictureBox1.BackColor = Color.Gray
            Case 4
                Main.Label99.ForeColor = Color.Red
                'Me.ForeColor = Color.Red
                PictureBox1.BackColor = Color.Red
            Case 5
                Main.Label99.ForeColor = Color.Blue
                'Me.ForeColor = Color.Blue
                PictureBox1.BackColor = Color.Blue
            Case 6
                Main.Label99.ForeColor = Color.Green
                'Me.ForeColor = Color.Green
                PictureBox1.BackColor = Color.Green
            Case 7
                Main.Label99.ForeColor = Color.Yellow
                'Me.ForeColor = Color.Yellow
                PictureBox1.BackColor = Color.Yellow
            Case 8
                Main.Label99.ForeColor = Color.Pink
                'Me.ForeColor = Color.Pink
                PictureBox1.BackColor = Color.Pink
            Case 9
                Main.Label99.ForeColor = Color.Purple
                'Me.ForeColor = Color.Purple
                PictureBox1.BackColor = Color.Purple
            Case 10
                Main.Label99.ForeColor = Color.Orange
                'Me.ForeColor = Color.Orange
                PictureBox1.BackColor = Color.Orange
            Case 11
                Main.Label99.ForeColor = Color.Aqua
                'Me.ForeColor = Color.Aqua
                PictureBox1.BackColor = Color.Aqua
        End Select
    End Sub
End Class