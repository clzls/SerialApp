Imports System.IO.Ports

#Const DisableXInputSupport = 0

Public Class frmMain
#If DisableXInputSupport = 0 Then
    Public ctrl As SharpDX.XInput.Controller
    Public state As SharpDX.XInput.State
#End If

    Private Sub 退出EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出EToolStripMenuItem.Click, 退出XToolStripMenuItem.Click
        If SerialPort1.IsOpen Then SerialPort1.Close()
        Dispose()
        End
    End Sub

    Private Sub 选项OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选项OToolStripMenuItem.Click
        frmCtrl.ShowDialog()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub 自定义CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RawDataToolStripMenuItem.Click
        frmRawData.Show()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        On Error GoTo Motherfucker
        If RawDataListening Then Exit Sub

        If SerialPort1.BytesToRead < nowConf.DatapackLength Then Exit Sub
        nowConf.DataProcess(SerialPort1, e)

Motherfucker:
    End Sub

    Private Sub SerialPort1_ErrorReceived(sender As Object, e As SerialErrorReceivedEventArgs) Handles SerialPort1.ErrorReceived
        MsgBox(e.EventType)
    End Sub

    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If SerialRunning Then
            Try
                Select Case e.KeyChar
                    Case "w"c, "W"c
                        SerialPort1.Write("u")
                    Case "a"c, "A"c
                        SerialPort1.Write("l")
                    Case "s"c, "S"c
                        SerialPort1.Write("d")
                    Case "d"c, "D"c
                        SerialPort1.Write("r")
                    Case "0"c To "9"c, " "c
                        SerialPort1.Write(e.KeyChar)
                End Select
            Catch ex As IO.IOException
                My.Settings.ErrorMsg = ex.Message
            Catch ex As Exception
                MessageBox.Show(ex.Message, "错误：" & ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.W
                pbW.Image = My.Resources.前箭头_按下
            Case Keys.A
                pbA.Image = My.Resources.左转向灯_按下
            Case Keys.S
                pbS.Image = My.Resources.后箭头_按下
            Case Keys.D
                pbD.Image = My.Resources.右转向灯_按下
        End Select
    End Sub

    Private Sub frmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.W
                pbW.Image = My.Resources.前箭头
            Case Keys.A
                pbA.Image = My.Resources.左转向灯
            Case Keys.S
                pbS.Image = My.Resources.后箭头
            Case Keys.D
                pbD.Image = My.Resources.右转向灯
        End Select
    End Sub

    Private Sub 关于AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        'Refreshing the dashboard
        With My.Settings
            lblCS.Text = .CarSpeed
            lblMD.Text = .MotorDuty
            lblSA.Text = .SteerAngle
            lblFD.Text = .EchoLength
            lblYW.Text = .Yaw
            tsslErrChar.Text = .ErrorMsg
        End With

        'Serial detection
        SerialRunning = SerialPort1.IsOpen()
        With tsslSerialStatus
            If SerialRunning Then
                .Text = My.Resources.strSerialRunning
                .ForeColor = Color.Black
            Else
                .Text = My.Resources.strSerialDisabled
                .ForeColor = Color.Red
            End If
        End With

#If DisableXInputSupport = 0 Then
        'Game controller detection
        If My.Settings.EnableGamepadSupport Then
            If ctrl.IsConnected Then
                tsslHardwareDetect.Text = "DirectX 兼容手柄"
            Else
                tsslHardwareDetect.Text = "无硬件"
            End If
        Else
            tsslHardwareDetect.Text = "硬件支持已关闭"
        End If
#End If

        'Freeze unused controls
        lblCST.Enabled = SerialRunning And nowConf.IsCarSpeed
        lblYWT.Enabled = SerialRunning And nowConf.IsYaw
        lblSAT.Enabled = SerialRunning And nowConf.IsSteerAngle
        lblFDT.Enabled = SerialRunning And nowConf.IsEchoLength
        lblMDT.Enabled = SerialRunning And nowConf.IsMotorDuty

        lblCS.Enabled = lblCST.Enabled
        lblYW.Enabled = lblYWT.Enabled
        lblSA.Enabled = lblSAT.Enabled
        lblFD.Enabled = lblFDT.Enabled
        lblMD.Enabled = lblMDT.Enabled

#If DisableXInputSupport = 0 Then
        'Game controller signal generating
        If SerialRunning And ctrl.IsConnected Then
            state = ctrl.GetState()
            If (state.Gamepad.RightTrigger > 180) Then SerialPort1.Write("u")
            If (state.Gamepad.LeftTrigger > 180) Then SerialPort1.Write("d")
            If (state.Gamepad.LeftThumbX < -25000) Then SerialPort1.Write("l")
            If (state.Gamepad.LeftThumbX > 25000) Then SerialPort1.Write("r")

            If (CTypeDynamic(Of Boolean)(state.Gamepad.Buttons And SharpDX.XInput.GamepadButtonFlags.LeftShoulder)) Then SerialPort1.Write(" ")
        End If
#End If
    End Sub

    Private Sub pbW_Click(sender As Object, e As EventArgs) Handles pbW.Click
        If SerialRunning Then SerialPort1.Write("u")
    End Sub

    Private Sub pbS_Click(sender As Object, e As EventArgs) Handles pbS.Click
        If SerialRunning Then SerialPort1.Write("d")
    End Sub

    Private Sub pbA_Click(sender As Object, e As EventArgs) Handles pbA.Click
        If SerialRunning Then SerialPort1.Write("l")
    End Sub

    Private Sub pbD_Click(sender As Object, e As EventArgs) Handles pbD.Click
        If SerialRunning Then SerialPort1.Write("r")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
#If DisableXInputSupport = 0 Then
        If My.Settings.EnableGamepadSupport Then
            ctrl = New SharpDX.XInput.Controller(SharpDX.XInput.UserIndex.Any)
        End If
#End If
        tmrMain.Start()
        tsmConfV1_0.Checked = True
        tsmConfV1_1.Checked = False
        nowConf = New Conf_v1_0
    End Sub

    Private Sub DataProcess_v1_0(e As SerialDataReceivedEventArgs)

    End Sub

    Private Sub tsmConfV1_0_Click(sender As Object, e As EventArgs) Handles tsmConfV1_0.Click
        tsmConfV1_0.Checked = True
        tsmConfV1_1.Checked = False
        nowConf = New Conf_v1_0
    End Sub

    Private Sub tsmConfV1_1_Click(sender As Object, e As EventArgs) Handles tsmConfV1_1.Click
        tsmConfV1_0.Checked = False
        tsmConfV1_1.Checked = True
        nowConf = New Conf_v1_1
    End Sub

    Private Sub GamepadCtrl()

    End Sub

    Private Sub 显示主窗口OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示主窗口OToolStripMenuItem.Click
        Show()
    End Sub
End Class