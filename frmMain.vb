Imports System.IO.Ports

Public Class frmMain
    Friend errcode As String
    Public ctrl As SharpDX.XInput.Controller
    Public state As SharpDX.XInput.State

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
        Select Case nowConf
            Case Configs.v1_0_Dare
                DataProcess_v1_0(e)
            Case Configs.v1_1_Uno

        End Select

Motherfucker:
    End Sub

    Private Sub SerialPort1_ErrorReceived(sender As Object, e As SerialErrorReceivedEventArgs) Handles SerialPort1.ErrorReceived
        MsgBox(e.EventType)
    End Sub

    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If SerialRunning Then
            Select Case e.KeyChar
                Case "w"
                    SerialPort1.Write("u")
                Case "a"
                    SerialPort1.Write("l")
                Case "s"
                    SerialPort1.Write("d")
                Case "d"
                    SerialPort1.Write("r")
                Case "0" To "9", " "
                    SerialPort1.Write(e.KeyChar)
            End Select
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
        lblCS.Text = My.Settings.CarSpeed
        lblMD.Text = My.Settings.MotorDuty
        lblSA.Text = My.Settings.SteerAngle
        lblFD.Text = My.Settings.EchoLength
        lblYaw.Text = My.Settings.Yaw
        tsslErrChar.Text = errcode

        SerialRunning = SerialPort1.IsOpen()

        If SerialRunning And ctrl.IsConnected Then
            state = ctrl.GetState()
            If (state.Gamepad.RightTrigger > 180) Then SerialPort1.Write("u")
            If (state.Gamepad.LeftTrigger > 180) Then SerialPort1.Write("d")
            If (state.Gamepad.LeftThumbX < -25000) Then SerialPort1.Write("l")
            If (state.Gamepad.LeftThumbX > 25000) Then SerialPort1.Write("r")
            If (state.Gamepad.Buttons And SharpDX.XInput.GamepadButtonFlags.LeftShoulder) Then SerialPort1.Write(" ")
        End If

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
        ctrl = New SharpDX.XInput.Controller(SharpDX.XInput.UserIndex.One)
        If ctrl.IsConnected Then
            tsslErrChar.Text = "检测到手柄"
        End If
        tmrMain.Enabled = True
    End Sub

    Private Sub 芯动计划ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 芯动计划ToolStripMenuItem.Click

    End Sub

    Private Sub DataProcess_v1_0(e As SerialDataReceivedEventArgs)
        Dim buffer(4) As Byte
        Dim itBuff As Integer
        On Error GoTo Motherfucker
        buffer(0) = 0
        While (buffer(0) < &HF0)
            buffer(0) = SerialPort1.ReadByte()
        End While
        SerialPort1.Read(buffer, 1, 3)
        SerialPort1.DiscardInBuffer()
        itBuff = (buffer(1) * &H80) Or (buffer(2))
        Select Case buffer(0)
            Case &HF1 'motor duty
                My.Settings.MotorDuty = Str(itBuff) & "%"
                Exit Select
            Case &HF2 'steer angle
                My.Settings.SteerAngle = Str(itBuff) & "%"
                If (buffer(3) = 2) Then
                    My.Settings.SteerAngle = "左" & My.Settings.SteerAngle
                ElseIf buffer(3) = 1 Then
                    My.Settings.SteerAngle = "右" & My.Settings.SteerAngle
                End If
                Exit Select
            Case &HFA 'car speed
                My.Settings.CarSpeed = Str(itBuff) & "r/min"
                If (buffer(3) = 1) Then '后退
                    My.Settings.CarSpeed = My.Settings.CarSpeed & "退"
                End If
                Exit Select
            Case &HFB 'echo length
                My.Settings.EchoLength = Str(itBuff) & "mm"
                'My.Settings.EchoLength = Str(buffer(1)) & " " & Str(buffer(2)) & "mm"
                Exit Select
            Case &HFC 'Yaw
                My.Settings.Yaw = Str(itBuff) & "deg"
                If (buffer(3) = 2) Then
                    My.Settings.Yaw = "左" & My.Settings.Yaw
                ElseIf buffer(3) = 1 Then
                    My.Settings.Yaw = "右" & My.Settings.Yaw
                ElseIf buffer(3) = 0 Then
                    My.Settings.Yaw = "原位"
                End If
                Exit Select

            Case &HFD '错误调试模块
                Select Case buffer(1)
                    Case &H1
                        errcode = "任务B2执行结束"
                    Case &H2
                        errcode = "任务B3执行结束"
                    Case &H3
                        errcode = "任务D1/2执行结束"
                    Case &H7F
                        errcode = "紧急制动"
                    Case Else
                        errcode = "未知错误"
                End Select
            Case Else
                errcode = "Error receiving " & Hex(buffer(0))
        End Select
Motherfucker:
    End Sub
End Class