<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRawData
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRawData))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbxConsole = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.模式设置MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文本模式TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HEX模式HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tbxSend = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.tmrManual = New System.Windows.Forms.Timer(Me.components)
        Me.清空CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbxConsole)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Size = New System.Drawing.Size(570, 463)
        Me.SplitContainer1.SplitterDistance = 342
        Me.SplitContainer1.TabIndex = 0
        '
        'tbxConsole
        '
        Me.tbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxConsole.Location = New System.Drawing.Point(0, 32)
        Me.tbxConsole.Multiline = True
        Me.tbxConsole.Name = "tbxConsole"
        Me.tbxConsole.ReadOnly = True
        Me.tbxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxConsole.Size = New System.Drawing.Size(570, 310)
        Me.tbxConsole.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.模式设置MToolStripMenuItem, Me.清空CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '模式设置MToolStripMenuItem
        '
        Me.模式设置MToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文本模式TToolStripMenuItem, Me.HEX模式HToolStripMenuItem})
        Me.模式设置MToolStripMenuItem.Name = "模式设置MToolStripMenuItem"
        Me.模式设置MToolStripMenuItem.Size = New System.Drawing.Size(124, 28)
        Me.模式设置MToolStripMenuItem.Text = "模式设置(&M)"
        '
        '文本模式TToolStripMenuItem
        '
        Me.文本模式TToolStripMenuItem.Checked = True
        Me.文本模式TToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.文本模式TToolStripMenuItem.Name = "文本模式TToolStripMenuItem"
        Me.文本模式TToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.文本模式TToolStripMenuItem.Text = "文本模式(&T)"
        '
        'HEX模式HToolStripMenuItem
        '
        Me.HEX模式HToolStripMenuItem.Name = "HEX模式HToolStripMenuItem"
        Me.HEX模式HToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.HEX模式HToolStripMenuItem.Text = "HEX模式(&H)"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tbxSend)
        Me.SplitContainer2.Panel1MinSize = 100
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2MinSize = 100
        Me.SplitContainer2.Size = New System.Drawing.Size(567, 117)
        Me.SplitContainer2.SplitterDistance = 412
        Me.SplitContainer2.TabIndex = 1
        '
        'tbxSend
        '
        Me.tbxSend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxSend.Location = New System.Drawing.Point(0, 0)
        Me.tbxSend.Multiline = True
        Me.tbxSend.Name = "tbxSend"
        Me.tbxSend.Size = New System.Drawing.Size(412, 117)
        Me.tbxSend.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 117)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "发送"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 117)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'tmrManual
        '
        Me.tmrManual.Enabled = True
        '
        '清空CToolStripMenuItem
        '
        Me.清空CToolStripMenuItem.Name = "清空CToolStripMenuItem"
        Me.清空CToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.清空CToolStripMenuItem.Text = "清空(&C)"
        '
        'frmRawData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 463)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Opacity", Global.SerialApp.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRawData"
        Me.Opacity = Global.SerialApp.My.MySettings.Default.Opacity
        Me.Text = "高级调试页"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tbxConsole As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 模式设置MToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents tbxSend As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Button1 As Button
    Friend WithEvents 文本模式TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HEX模式HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrManual As Timer
    Friend WithEvents 清空CToolStripMenuItem As ToolStripMenuItem
End Class
