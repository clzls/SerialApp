Friend Module ModMain
    Public RawDataListening As Boolean = False
    Public CtrlpadListening As Boolean = False
    Public SerialRunning As Boolean = False

    Public IsRXSpeed As Boolean = False

    Enum Configs
        v1_0_Dare
        v1_1_Uno
    End Enum

    Public nowConf As Configs
End Module
