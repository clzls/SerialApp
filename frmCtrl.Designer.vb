<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtrl
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCtrl))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cbxSerials = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOpenClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxSerials
        '
        Me.cbxSerials.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSerials.FormattingEnabled = True
        Me.cbxSerials.Location = New System.Drawing.Point(102, 9)
        Me.cbxSerials.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxSerials.Name = "cbxSerials"
        Me.cbxSerials.Size = New System.Drawing.Size(150, 23)
        Me.cbxSerials.Sorted = True
        Me.cbxSerials.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "通信串口："
        '
        'btnOpenClose
        '
        Me.btnOpenClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOpenClose.Location = New System.Drawing.Point(0, 237)
        Me.btnOpenClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpenClose.Name = "btnOpenClose"
        Me.btnOpenClose.Size = New System.Drawing.Size(346, 53)
        Me.btnOpenClose.TabIndex = 2
        Me.btnOpenClose.Text = "开启串口"
        Me.btnOpenClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "波特率："
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"38600", "115200"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 39)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 23)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "115200"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 212)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(346, 25)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(69, 20)
        Me.tsslStatus.Text = "等待指令"
        '
        'frmCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 290)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxSerials)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.SerialApp.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCtrl"
        Me.Opacity = Global.SerialApp.My.MySettings.Default.Opacity
        Me.Text = "设置"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents cbxSerials As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
End Class
