Imports System.IO.Ports

''' <summary>
''' 第二代智能车Uno的配置文件
''' </summary>
Public Class Conf_v1_1
    Implements IConfigs

    Public ReadOnly Property IsSteerAngle As Boolean = False Implements IConfigs.IsSteerAngle
    Public ReadOnly Property IsMotorDuty As Boolean = False Implements IConfigs.IsMotorDuty

    ReadOnly Property IsSensor As Boolean Implements IConfigs.IsYaw, IConfigs.IsCarSpeed, IConfigs.IsEchoLength
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property DatapackLength As Integer = 3 Implements IConfigs.DatapackLength

    Public ReadOnly Property ConfName As IConfigs.ConfigNames Implements IConfigs.ConfName
        Get
            Return IConfigs.ConfigNames.v1_1_Uno
        End Get
    End Property

    Public ReadOnly Property ConfNameStr As String Implements IConfigs.ConfNameStr
        Get
            Return "v1.1 Uno"
        End Get
    End Property

    Public Sub DataProcess(port As SerialPort, e As SerialDataReceivedEventArgs) Implements IConfigs.DataProcess
        Try
            While ((buff(0S) And &B1000_0000S) = 0)
                If port.BytesToRead < DatapackLength Then Exit Sub ' Fail to meet a pack now
                buff(0) = CTypeDynamic(Of Byte)(port.ReadByte())
            End While
            port.Read(buff, 1, 2)
        Catch ex As InvalidOperationException
            ' Indicate a Serial corruption
            ' TODO
            MessageBox.Show(ex.Message, "串口状态错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.ErrorMsg = ex.Message
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "数据处理错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.ErrorMsg = ex.Message
            Exit Sub
        End Try

        ' Resolve the number
        Dim itBuff As Integer = (CTypeDynamic(Of Integer)(buff(1)) << 7) Or buff(2)

        With My.Settings
            Select Case buff(0)
                Case &HFD '错误调试模块
                    Select Case buff(1)
                        Case &H1
                            .ErrorMsg = "命令成功执行"
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