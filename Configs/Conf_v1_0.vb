Imports System.IO.Ports

''' <summary>
''' 第一代智能车Dare的配置文件
''' </summary>
Public Class Conf_v1_0
    Implements IConfigs

    Public ReadOnly Property IsSteerAngle As Boolean = True Implements IConfigs.IsSteerAngle
    Public ReadOnly Property IsMotorDuty As Boolean = True Implements IConfigs.IsMotorDuty

    Public ReadOnly Property IsSensor As Boolean = True Implements IConfigs.IsYaw, IConfigs.IsCarSpeed, IConfigs.IsEchoLength

    Public ReadOnly Property DatapackLength As Integer = 4 Implements IConfigs.DatapackLength

    Public ReadOnly Property ConfName As IConfigs.ConfigNames Implements IConfigs.ConfName
        Get
            Return IConfigs.ConfigNames.v1_0_Dare
        End Get
    End Property

    Public ReadOnly Property ConfNameStr As String Implements IConfigs.ConfNameStr
        Get
            Return "v1.0 Dare"
        End Get
    End Property
    Public Sub DataProcess(port As SerialPort, e As SerialDataReceivedEventArgs) Implements IConfigs.DataProcess
        Dim itBuff As Integer
        Try
            While (buff(0) < &B1111_0000)
                If port.BytesToRead < DatapackLength Then Exit Sub ' Fail to meet a pack now
                buff(0) = CTypeDynamic(Of Byte)(port.ReadByte())
            End While
            port.Read(buff, 1, 3)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "数据处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.ErrorMsg = ex.Message
        End Try

        ' Resolve the number
        itBuff = (CTypeDynamic(Of Integer)(buff(1)) << 7) Or buff(2)

        With My.Settings
            Select Case buff(0)
                Case &HF1 'motor duty
                    .MotorDuty = Str(itBuff) & "%"
                    Exit Select
                Case &HF2 'steer angle
                    .SteerAngle = Str(itBuff) & "%"
                    If (buff(3) = 2) Then
                        .SteerAngle = "左" & .SteerAngle
                    ElseIf buff(3) = 1 Then
                        .SteerAngle = "右" & .SteerAngle
                    End If
                    Exit Select
                Case &HFA 'car speed
                    .CarSpeed = Str(itBuff) & "r/min"
                    If (buff(3) = 1) Then '后退
                        .CarSpeed = .CarSpeed & "退"
                    End If
                    Exit Select
                Case &HFB 'echo length
                    .EchoLength = Str(itBuff) & "mm"
                    Exit Select
                Case &HFC 'Yaw
                    .Yaw = Str(itBuff) & "deg"
                    If (buff(3) = 2) Then
                        .Yaw = "左" & .Yaw
                    ElseIf buff(3) = 1 Then
                        .Yaw = "右" & .Yaw
                    ElseIf buff(3) = 0 Then
                        .Yaw = "原位"
                    End If
                    Exit Select

                Case &HFD '错误调试模块
                    Select Case buff(1)
                        Case &H1
                            .ErrorMsg = "任务B2执行结束"
                        Case &H2
                            .ErrorMsg = "任务B3执行结束"
                        Case &H3
                            .ErrorMsg = "任务D1/2执行结束"
                        Case &H7F
                            .ErrorMsg = "紧急制动"
                        Case Else
                            .ErrorMsg = "未知错误"
                    End Select
                Case Else
                    .ErrorMsg = "错误符号" & Hex(buff(0))
            End Select
        End With

        buff.Initialize()
    End Sub

    Private buff(DatapackLength) As Byte
End Class
