Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each str As String In My.Computer.Ports.SerialPortNames
            MsgBox(str)
        Next
    End Sub

    Public Sub LoadSerials()
        For Each str As String In My.Computer.Ports.SerialPortNames

        Next
    End Sub
End Class
