Public Class frmCtrl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSerials()
    End Sub

    Public Sub LoadSerials()
        cbxSerials.Items.Clear()
        For Each str As String In My.Computer.Ports.SerialPortNames
            cbxSerials.Items.Add(str)
            cbxSerials.Text = str
        Next
        If cbxSerials.Items.Count = 0 Then
            btnOpenClose.Enabled = False
        End If
    End Sub

    Private Sub cbxSerials_Click(sender As Object, e As EventArgs) Handles cbxSerials.Click
        LoadSerials()
    End Sub

    Private Sub btnOpenClose_Click(sender As Object, e As EventArgs) Handles btnOpenClose.Click
        btnOpenClose.Enabled = False
        With frmMain.SerialPort1
            If Not SerialRunning Then
                If cbxSerials.Text = Nothing Then Exit Sub

                If .IsOpen Then .Close() 'bug prevent
                '显式指定串口数据
                .PortName = cbxSerials.Text
                .BaudRate = Val(cbxSerials.Text)
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .ReceivedBytesThreshold = 4
                Try
                    .Open()
                Catch er As System.Exception
                    tsslStatus.Text = er.Message
                End Try
            Else
                If .IsOpen() Then .Close()
            End If
            SerialRunning = .IsOpen
        End With

        If SerialRunning Then
            btnOpenClose.Text = "关闭串口"
            Close()
        Else
            btnOpenClose.Text = "打开串口"
        End If
        btnOpenClose.Enabled = True
    End Sub

End Class
