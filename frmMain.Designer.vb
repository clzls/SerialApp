<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.退出EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RawDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbD = New System.Windows.Forms.PictureBox()
        Me.pbA = New System.Windows.Forms.PictureBox()
        Me.pbS = New System.Windows.Forms.PictureBox()
        Me.pbW = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSA = New System.Windows.Forms.Label()
        Me.lblSAT = New System.Windows.Forms.Label()
        Me.lblMD = New System.Windows.Forms.Label()
        Me.lblMDT = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblYaw = New System.Windows.Forms.Label()
        Me.lblYawT = New System.Windows.Forms.Label()
        Me.lblFD = New System.Windows.Forms.Label()
        Me.lblCS = New System.Windows.Forms.Label()
        Me.lblFDT = New System.Windows.Forms.Label()
        Me.lblCST = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslErrChar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.配置文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.芯动计划ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Uno机械迷城ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsslHardwareDetect = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslSerialStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsNotify.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotify
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'cmsNotify
        '
        Me.cmsNotify.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.cmsNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出EToolStripMenuItem})
        Me.cmsNotify.Name = "cmsNotify"
        Me.cmsNotify.Size = New System.Drawing.Size(127, 28)
        '
        '退出EToolStripMenuItem
        '
        Me.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem"
        Me.退出EToolStripMenuItem.Size = New System.Drawing.Size(126, 24)
        Me.退出EToolStripMenuItem.Text = "退出(&E)"
        '
        'SerialPort1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.工具TToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(566, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '工具TToolStripMenuItem
        '
        Me.工具TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RawDataToolStripMenuItem, Me.选项OToolStripMenuItem, Me.ToolStripSeparator1, Me.配置文件FToolStripMenuItem})
        Me.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem"
        Me.工具TToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.工具TToolStripMenuItem.Text = "工具(&T)"
        '
        'RawDataToolStripMenuItem
        '
        Me.RawDataToolStripMenuItem.Name = "RawDataToolStripMenuItem"
        Me.RawDataToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RawDataToolStripMenuItem.Text = "高级(&C)"
        '
        '选项OToolStripMenuItem
        '
        Me.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem"
        Me.选项OToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.选项OToolStripMenuItem.Text = "选项(&O)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.关于AToolStripMenuItem.Text = "关于(&A)..."
        '
        'pbD
        '
        Me.pbD.Image = Global.SerialApp.My.Resources.Resources.右转向灯
        Me.pbD.Location = New System.Drawing.Point(408, 170)
        Me.pbD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbD.Name = "pbD"
        Me.pbD.Size = New System.Drawing.Size(57, 53)
        Me.pbD.TabIndex = 5
        Me.pbD.TabStop = False
        '
        'pbA
        '
        Me.pbA.Image = Global.SerialApp.My.Resources.Resources.左转向灯
        Me.pbA.Location = New System.Drawing.Point(284, 170)
        Me.pbA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbA.Name = "pbA"
        Me.pbA.Size = New System.Drawing.Size(57, 53)
        Me.pbA.TabIndex = 4
        Me.pbA.TabStop = False
        '
        'pbS
        '
        Me.pbS.Image = Global.SerialApp.My.Resources.Resources.后箭头
        Me.pbS.Location = New System.Drawing.Point(346, 226)
        Me.pbS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbS.Name = "pbS"
        Me.pbS.Size = New System.Drawing.Size(57, 53)
        Me.pbS.TabIndex = 3
        Me.pbS.TabStop = False
        '
        'pbW
        '
        Me.pbW.Image = Global.SerialApp.My.Resources.Resources.前箭头
        Me.pbW.Location = New System.Drawing.Point(346, 112)
        Me.pbW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbW.Name = "pbW"
        Me.pbW.Size = New System.Drawing.Size(57, 53)
        Me.pbW.TabIndex = 2
        Me.pbW.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSA, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSAT, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMD, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMDT, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYaw, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYawT, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFD, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCS, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFDT, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCST, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 29)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(265, 307)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'lblSA
        '
        Me.lblSA.AutoSize = True
        Me.lblSA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSA.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSA.Location = New System.Drawing.Point(147, 255)
        Me.lblSA.Name = "lblSA"
        Me.lblSA.Size = New System.Drawing.Size(115, 52)
        Me.lblSA.TabIndex = 11
        Me.lblSA.Text = "未知"
        '
        'lblSAT
        '
        Me.lblSAT.AutoSize = True
        Me.lblSAT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSAT.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSAT.Location = New System.Drawing.Point(3, 255)
        Me.lblSAT.Name = "lblSAT"
        Me.lblSAT.Size = New System.Drawing.Size(138, 52)
        Me.lblSAT.TabIndex = 10
        Me.lblSAT.Text = "舵机占空比："
        '
        'lblMD
        '
        Me.lblMD.AutoSize = True
        Me.lblMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMD.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMD.Location = New System.Drawing.Point(147, 204)
        Me.lblMD.Name = "lblMD"
        Me.lblMD.Size = New System.Drawing.Size(115, 51)
        Me.lblMD.TabIndex = 9
        Me.lblMD.Text = "未知"
        '
        'lblMDT
        '
        Me.lblMDT.AutoSize = True
        Me.lblMDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMDT.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMDT.Location = New System.Drawing.Point(3, 204)
        Me.lblMDT.Name = "lblMDT"
        Me.lblMDT.Size = New System.Drawing.Size(138, 51)
        Me.lblMDT.TabIndex = 8
        Me.lblMDT.Text = "电机占空比："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 51)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "未知"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 51)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "车速："
        Me.Label5.Visible = False
        '
        'lblYaw
        '
        Me.lblYaw.AutoSize = True
        Me.lblYaw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblYaw.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYaw.Location = New System.Drawing.Point(147, 102)
        Me.lblYaw.Name = "lblYaw"
        Me.lblYaw.Size = New System.Drawing.Size(115, 51)
        Me.lblYaw.TabIndex = 5
        Me.lblYaw.Text = "未知"
        '
        'lblYawT
        '
        Me.lblYawT.AutoSize = True
        Me.lblYawT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblYawT.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblYawT.Location = New System.Drawing.Point(3, 102)
        Me.lblYawT.Name = "lblYawT"
        Me.lblYawT.Size = New System.Drawing.Size(138, 51)
        Me.lblYawT.TabIndex = 4
        Me.lblYawT.Text = "航向角："
        '
        'lblFD
        '
        Me.lblFD.AutoSize = True
        Me.lblFD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFD.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFD.Location = New System.Drawing.Point(147, 51)
        Me.lblFD.Name = "lblFD"
        Me.lblFD.Size = New System.Drawing.Size(115, 51)
        Me.lblFD.TabIndex = 3
        Me.lblFD.Text = "未知"
        '
        'lblCS
        '
        Me.lblCS.AutoSize = True
        Me.lblCS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCS.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCS.Location = New System.Drawing.Point(147, 0)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(115, 51)
        Me.lblCS.TabIndex = 2
        Me.lblCS.Text = "未知"
        '
        'lblFDT
        '
        Me.lblFDT.AutoSize = True
        Me.lblFDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFDT.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblFDT.Location = New System.Drawing.Point(3, 51)
        Me.lblFDT.Name = "lblFDT"
        Me.lblFDT.Size = New System.Drawing.Size(138, 51)
        Me.lblFDT.TabIndex = 1
        Me.lblFDT.Text = "前方距离"
        '
        'lblCST
        '
        Me.lblCST.AutoSize = True
        Me.lblCST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCST.Font = New System.Drawing.Font("宋体", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCST.Location = New System.Drawing.Point(3, 0)
        Me.lblCST.Name = "lblCST"
        Me.lblCST.Size = New System.Drawing.Size(138, 51)
        Me.lblCST.TabIndex = 0
        Me.lblCST.Text = "车速："
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 200
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslErrChar, Me.tsslHardwareDetect, Me.tsslSerialStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 412)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(566, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslErrChar
        '
        Me.tsslErrChar.Name = "tsslErrChar"
        Me.tsslErrChar.Size = New System.Drawing.Size(18, 20)
        Me.tsslErrChar.Text = "0"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        '配置文件FToolStripMenuItem
        '
        Me.配置文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.芯动计划ToolStripMenuItem, Me.Uno机械迷城ToolStripMenuItem})
        Me.配置文件FToolStripMenuItem.Name = "配置文件FToolStripMenuItem"
        Me.配置文件FToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.配置文件FToolStripMenuItem.Text = "配置文件(&F)"
        '
        '芯动计划ToolStripMenuItem
        '
        Me.芯动计划ToolStripMenuItem.Checked = True
        Me.芯动计划ToolStripMenuItem.CheckOnClick = True
        Me.芯动计划ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.芯动计划ToolStripMenuItem.Name = "芯动计划ToolStripMenuItem"
        Me.芯动计划ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.芯动计划ToolStripMenuItem.Text = "1.0 Dare 芯动计划"
        '
        'Uno机械迷城ToolStripMenuItem
        '
        Me.Uno机械迷城ToolStripMenuItem.Name = "Uno机械迷城ToolStripMenuItem"
        Me.Uno机械迷城ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.Uno机械迷城ToolStripMenuItem.Text = "1.1 Uno 机械迷城"
        '
        'tsslHardwareDetect
        '
        Me.tsslHardwareDetect.Name = "tsslHardwareDetect"
        Me.tsslHardwareDetect.Size = New System.Drawing.Size(54, 20)
        Me.tsslHardwareDetect.Text = "无硬件"
        '
        'tsslSerialStatus
        '
        Me.tsslSerialStatus.Name = "tsslSerialStatus"
        Me.tsslSerialStatus.Size = New System.Drawing.Size(99, 20)
        Me.tsslSerialStatus.Text = "串口通信关闭"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 437)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pbD)
        Me.Controls.Add(Me.pbA)
        Me.Controls.Add(Me.pbS)
        Me.Controls.Add(Me.pbW)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.SerialApp.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.Opacity = Global.SerialApp.My.MySettings.Default.Opacity
        Me.Text = "中国代表二队 小车配套软件"
        Me.cmsNotify.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents cmsNotify As ContextMenuStrip
    Friend WithEvents 退出EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RawDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbW As PictureBox
    Friend WithEvents pbS As PictureBox
    Friend WithEvents pbA As PictureBox
    Friend WithEvents pbD As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblSA As Label
    Friend WithEvents lblSAT As Label
    Friend WithEvents lblMD As Label
    Friend WithEvents lblMDT As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblYaw As Label
    Friend WithEvents lblYawT As Label
    Friend WithEvents lblFD As Label
    Friend WithEvents lblCS As Label
    Friend WithEvents lblFDT As Label
    Friend WithEvents lblCST As Label
    Friend WithEvents tmrMain As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tsslErrChar As ToolStripStatusLabel
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 配置文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 芯动计划ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Uno机械迷城ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsslHardwareDetect As ToolStripStatusLabel
    Friend WithEvents tsslSerialStatus As ToolStripStatusLabel
End Class
