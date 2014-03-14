Public Class Debuging

    Dim Ip As String

    Private Sub Debuging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 500
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Computer Info
        TextBox1.Text = My.Computer.Name
        TextBox2.Text = My.User.Name
        TextBox3.Text = My.Computer.Info.OSFullName
        TextBox4.Text = My.Computer.Info.OSPlatform
        TextBox5.Text = My.Computer.Info.OSVersion
        TextBox6.Text = My.Computer.Screen.WorkingArea.ToString
        TextBox7.Text = My.Computer.Network.IsAvailable
        TextBox8.Text = My.Computer.Ports.SerialPortNames.Count
        TextBox9.Text = My.Computer.FileSystem.Drives.Count
        TextBox10.Text = My.Computer.Info.TotalPhysicalMemory
        TextBox11.Text = My.Computer.Info.AvailablePhysicalMemory

        'CPU & RAM Usage
        ProgressBar1.Value = PerformanceCounter1.NextValue
        ProgressBar2.Value = PerformanceCounter2.NextValue
        ProgressBar3.Value = PerformanceCounter3.NextValue
        ProgressBar4.Value = PerformanceCounter4.NextValue
        Label16.Text = ProgressBar1.Value.ToString + "%"
        Label15.Text = ProgressBar2.Value.ToString + "%"
        Label13.Text = ProgressBar3.Value.ToString + "%"
        Label12.Text = ProgressBar4.Value.ToString + "%"

        ProgressBar5.Value = PerformanceCounterRAM.NextValue
        Label27.Text = ProgressBar5.Value.ToString + "%"
    End Sub
End Class