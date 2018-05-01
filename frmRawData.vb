Public Class frmRawData
    Friend IsHEX As Boolean
    Private Sub frmRawData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 600
        Me.Height = 500
        文本模式TToolStripMenuItem_Click(sender, e)
        RawDataListening = True
        If Not SerialRunning Then
            tmrManual.Enabled = False
            MessageBox.Show("串口尚未打开。", "串口尚未打开", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not SerialRunning Then Exit Sub
        frmMain.SerialPort1.Write(tbxSend.Text)
        tbxConsole.Text = tbxConsole.Text & "[Send]" & tbxSend.Text & "[/Send]" & vbCrLf
    End Sub

    Private Sub frmRawData_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        RawDataListening = False
    End Sub

    Private Sub tmrManual_Tick(sender As Object, e As EventArgs) Handles tmrManual.Tick
        Dim buffer As String
        If Not SerialRunning Then Exit Sub
        buffer = frmMain.SerialPort1.ReadExisting
        If buffer <> "" Then
            If (IsHEX) Then
                For Each p As Char In buffer
                    tbxConsole.Text = tbxConsole.Text & Hex(Asc(p)) & " "
                Next
            Else
                tbxConsole.Text = tbxConsole.Text & "[rec]" & buffer & "[/rec]" & vbCrLf
            End If
        End If
    End Sub

    Private Sub HEX模式HToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HEX模式HToolStripMenuItem.Click
        文本模式TToolStripMenuItem.Checked = False
        HEX模式HToolStripMenuItem.Checked = True
        IsHEX = True
    End Sub

    Private Sub 文本模式TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文本模式TToolStripMenuItem.Click
        文本模式TToolStripMenuItem.Checked = True
        HEX模式HToolStripMenuItem.Checked = False
        IsHEX = False
    End Sub

    Private Sub 清空CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清空CToolStripMenuItem.Click
        tbxConsole.Text = "[Clear]" & vbCrLf
    End Sub
End Class