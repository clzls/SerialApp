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
        Me.cbxBaudrate = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.字体FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.仪表盘数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDlg = New System.Windows.Forms.FontDialog()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SerialBaudratesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialBaudratesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 1500
        Me.SerialPort1.WriteTimeout = 1500
        '
        'cbxSerials
        '
        Me.cbxSerials.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxSerials.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbxSerials.FormattingEnabled = True
        Me.cbxSerials.Location = New System.Drawing.Point(127, 39)
        Me.cbxSerials.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxSerials.Name = "cbxSerials"
        Me.cbxSerials.Size = New System.Drawing.Size(150, 28)
        Me.cbxSerials.Sorted = True
        Me.cbxSerials.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "通信串口："
        '
        'btnOpenClose
        '
        Me.btnOpenClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOpenClose.Location = New System.Drawing.Point(0, 263)
        Me.btnOpenClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpenClose.Name = "btnOpenClose"
        Me.btnOpenClose.Size = New System.Drawing.Size(311, 53)
        Me.btnOpenClose.TabIndex = 2
        Me.btnOpenClose.Text = "开启串口"
        Me.btnOpenClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "波特率："
        '
        'cbxBaudrate
        '
        Me.cbxBaudrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbxBaudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxBaudrate.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbxBaudrate.FormattingEnabled = True
        Me.cbxBaudrate.Items.AddRange(New Object() {"115200", "14400", "19200", "38600", "400", "9600"})
        Me.cbxBaudrate.Location = New System.Drawing.Point(127, 71)
        Me.cbxBaudrate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxBaudrate.Name = "cbxBaudrate"
        Me.cbxBaudrate.Size = New System.Drawing.Size(150, 28)
        Me.cbxBaudrate.Sorted = True
        Me.cbxBaudrate.TabIndex = 4
        Me.cbxBaudrate.Text = "115200"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 241)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(311, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(69, 20)
        Me.tsslStatus.Text = "等待指令"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字体FToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '字体FToolStripMenuItem
        '
        Me.字体FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.仪表盘数据ToolStripMenuItem})
        Me.字体FToolStripMenuItem.Name = "字体FToolStripMenuItem"
        Me.字体FToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.字体FToolStripMenuItem.Text = "字体(&F)"
        '
        '仪表盘数据ToolStripMenuItem
        '
        Me.仪表盘数据ToolStripMenuItem.Name = "仪表盘数据ToolStripMenuItem"
        Me.仪表盘数据ToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.仪表盘数据ToolStripMenuItem.Text = "仪表盘数据"
        '
        'frmCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 316)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cbxBaudrate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxSerials)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.SerialApp.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCtrl"
        Me.Opacity = Global.SerialApp.My.MySettings.Default.Opacity
        Me.Text = "设置"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialBaudratesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents cbxSerials As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnOpenClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxBaudrate As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 字体FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 仪表盘数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDlg As FontDialog
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents SerialBaudratesBindingSource As BindingSource
End Class
