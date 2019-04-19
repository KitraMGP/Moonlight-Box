<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRC32
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRC32))
        Me.GetCRC32_Explore = New System.Windows.Forms.Button()
        Me.GetCRC32_File = New System.Windows.Forms.TextBox()
        Me.GetCRC32_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GetCRC32_Run = New System.Windows.Forms.Button()
        Me.GetCRC32_Result = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GetCRC32_Explore
        '
        Me.GetCRC32_Explore.Location = New System.Drawing.Point(513, 19)
        Me.GetCRC32_Explore.Name = "GetCRC32_Explore"
        Me.GetCRC32_Explore.Size = New System.Drawing.Size(75, 23)
        Me.GetCRC32_Explore.TabIndex = 20
        Me.GetCRC32_Explore.Text = "浏览"
        Me.GetCRC32_Explore.UseVisualStyleBackColor = True
        '
        'GetCRC32_File
        '
        Me.GetCRC32_File.Location = New System.Drawing.Point(84, 21)
        Me.GetCRC32_File.Name = "GetCRC32_File"
        Me.GetCRC32_File.Size = New System.Drawing.Size(423, 21)
        Me.GetCRC32_File.TabIndex = 19
        '
        'GetCRC32_Run
        '
        Me.GetCRC32_Run.Location = New System.Drawing.Point(513, 48)
        Me.GetCRC32_Run.Name = "GetCRC32_Run"
        Me.GetCRC32_Run.Size = New System.Drawing.Size(75, 23)
        Me.GetCRC32_Run.TabIndex = 23
        Me.GetCRC32_Run.Text = "计算"
        Me.GetCRC32_Run.UseVisualStyleBackColor = True
        '
        'GetCRC32_Result
        '
        Me.GetCRC32_Result.Location = New System.Drawing.Point(84, 50)
        Me.GetCRC32_Result.Name = "GetCRC32_Result"
        Me.GetCRC32_Result.ReadOnly = True
        Me.GetCRC32_Result.Size = New System.Drawing.Size(423, 21)
        Me.GetCRC32_Result.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SHA256："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "文件路径："
        '
        'CRC32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 91)
        Me.Controls.Add(Me.GetCRC32_Explore)
        Me.Controls.Add(Me.GetCRC32_File)
        Me.Controls.Add(Me.GetCRC32_Run)
        Me.Controls.Add(Me.GetCRC32_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CRC32"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRC32"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetCRC32_Explore As Button
    Friend WithEvents GetCRC32_File As TextBox
    Friend WithEvents GetCRC32_OpenFile As OpenFileDialog
    Friend WithEvents GetCRC32_Run As Button
    Friend WithEvents GetCRC32_Result As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
