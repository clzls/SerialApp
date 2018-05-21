Imports System.ComponentModel

Public Class frmCtrl
    Private Const DefaultBaudrate As String = "9600"

    Private Sub FrmCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSerials()
    End Sub

    Public Sub LoadSerials()
        If SerialRunning Then Exit Sub

        Dim strLast As String = cbxSerials.Text
        cbxSerials.Items.Clear()

        With My.Computer.Ports
            For Each str As String In .SerialPortNames
                cbxSerials.Items.Add(str)
                cbxSerials.Text = str
            Next

            If .SerialPortNames.Contains(strLast) Then cbxSerials.Text = strLast
        End With

        If cbxSerials.Items.Count = 0 Then
            cbxSerials.Text = My.Resources.strSerialNotFound
            btnOpenClose.Enabled = False
        Else
            btnOpenClose.Enabled = True
        End If

    End Sub

    Private Sub cbxSerials_Click(sender As Object, e As EventArgs) Handles cbxSerials.Click
        LoadSerials()
    End Sub

    Private Sub btnOpenClose_Click(sender As Object, e As EventArgs) Handles btnOpenClose.Click
        Dim baudrt As Integer
        baudrt = CTypeDynamic(Of Integer)(Val(cbxBaudrate.Text))
        btnOpenClose.Enabled = False
        With frmMain.SerialPort1
            If Not SerialRunning Then
                If Not My.Computer.Ports.SerialPortNames.Contains(cbxSerials.Text) Then Exit Sub
                If .IsOpen Then .Close() 'bug prevent

                '显式指定串口数据
                .PortName = cbxSerials.Text
                .BaudRate = baudrt
                '.DataBits = 8
                '.StopBits = IO.Ports.StopBits.One
                '.ReceivedBytesThreshold = 1
                Try
                    .Open()
                Catch er As Exception
                    tsslStatus.Text = er.Message
                End Try
            Else
                If .IsOpen() Then .Close()
            End If
            SerialRunning = .IsOpen
        End With

        If SerialRunning Then
            btnOpenClose.Text = "关闭串口"
            cbxSerials.Enabled = False
            Close()
        Else
            btnOpenClose.Text = "打开串口"
            cbxSerials.Enabled = True
        End If
        btnOpenClose.Enabled = True
    End Sub

    Private Sub cbxBaudrate_Validating(sender As Object, e As CancelEventArgs) Handles cbxBaudrate.Validating
        If (Val(cbxBaudrate.Text) < 400) Or (Val(cbxBaudrate.Text) > 116500) Then
            MessageBox.Show(text:="不支持的波特率。重置为" & DefaultBaudrate & " bps.", caption:="不支持的波特率", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Exclamation)
            cbxBaudrate.Text = DefaultBaudrate
        End If
    End Sub

    Private Sub 仪表盘数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 仪表盘数据ToolStripMenuItem.Click
        FontDlg.Font = My.Settings.fntHUD
        If FontDlg.ShowDialog() = DialogResult.OK Then
            My.Settings.fntHUD = FontDlg.Font
            My.Settings.Save()
            My.Settings.Upgrade()
        End If

    End Sub
End Class
