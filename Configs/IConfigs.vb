Public Interface IConfigs
    Enum ConfigNames
        v1_0_Dare
        v1_1_Uno
    End Enum

    ReadOnly Property IsYaw As Boolean
    ReadOnly Property IsMotorDuty As Boolean
    ReadOnly Property IsSteerAngle As Boolean

    ''' <summary>
    ''' 返回一个值，表示该配置文件是否支持车速检测。
    ''' </summary>
    ''' <returns>是否支持车速检测</returns>
    ReadOnly Property IsCarSpeed As Boolean

    ''' <summary>
    ''' 返回一个值，表示该配置文件是否支持超声模块。
    ''' </summary>
    ''' <returns>是否支持超声模块</returns>
    ReadOnly Property IsEchoLength As Boolean

    ReadOnly Property DatapackLength As Integer

    ''' <summary>
    ''' 返回该配置文件的名称。
    ''' </summary>
    ''' <returns>配置文件的名称</returns>
    ReadOnly Property ConfName As ConfigNames

    ''' <summary>
    ''' 返回该配置文件的文本化名称。
    ''' </summary>
    ''' <returns>配置文件的文本化名称</returns>
    ReadOnly Property ConfNameStr As String

    ''' <summary>
    ''' 
    ''' </summary>
    Sub DataProcess(port As IO.Ports.SerialPort, e As IO.Ports.SerialDataReceivedEventArgs)
End Interface
