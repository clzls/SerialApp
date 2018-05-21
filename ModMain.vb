Imports System.IO.Ports

Friend Module ModMain
    Public RawDataListening As Boolean = False
    Public CtrlpadListening As Boolean = False
    Public SerialRunning As Boolean = False

    Public IsRXSpeed As Boolean = False

    Public nowConf As IConfigs
End Module
