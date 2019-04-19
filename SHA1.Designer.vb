<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHA1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHA1))
        Me.GetSHA1_Explore = New System.Windows.Forms.Button()
        Me.GetSHA1_File = New System.Windows.Forms.TextBox()
        Me.GetSHA1_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GetSHA1_Run = New System.Windows.Forms.Button()
        Me.GetSHA1_Result = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GetSHA1_Explore
        '
        Me.GetSHA1_Explore.Location = New System.Drawing.Point(513, 10)
        Me.GetSHA1_Explore.Name = "GetSHA1_Explore"
        Me.GetSHA1_Explore.Size = New System.Drawing.Size(75, 23)
        Me.GetSHA1_Explore.TabIndex = 8
        Me.GetSHA1_Explore.Text = "浏览"
        Me.GetSHA1_Explore.UseVisualStyleBackColor = True
        '
        'GetSHA1_File
        '
        Me.GetSHA1_File.Location = New System.Drawing.Point(84, 12)
        Me.GetSHA1_File.Name = "GetSHA1_File"
        Me.GetSHA1_File.Size = New System.Drawing.Size(423, 21)
        Me.GetSHA1_File.TabIndex = 7
        '
        'GetSHA1_Run
        '
        Me.GetSHA1_Run.Location = New System.Drawing.Point(513, 39)
        Me.GetSHA1_Run.Name = "GetSHA1_Run"
        Me.GetSHA1_Run.Size = New System.Drawing.Size(75, 23)
        Me.GetSHA1_Run.TabIndex = 11
        Me.GetSHA1_Run.Text = "计算"
        Me.GetSHA1_Run.UseVisualStyleBackColor = True
        '
        'GetSHA1_Result
        '
        Me.GetSHA1_Result.Location = New System.Drawing.Point(84, 41)
        Me.GetSHA1_Result.Name = "GetSHA1_Result"
        Me.GetSHA1_Result.ReadOnly = True
        Me.GetSHA1_Result.Size = New System.Drawing.Size(423, 21)
        Me.GetSHA1_Result.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SHA1："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "文件路径："
        '
        'SHA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 91)
        Me.Controls.Add(Me.GetSHA1_Explore)
        Me.Controls.Add(Me.GetSHA1_File)
        Me.Controls.Add(Me.GetSHA1_Run)
        Me.Controls.Add(Me.GetSHA1_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SHA1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHA1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetSHA1_Explore As Button
    Friend WithEvents GetSHA1_File As TextBox
    Friend WithEvents GetSHA1_OpenFile As OpenFileDialog
    Friend WithEvents GetSHA1_Run As Button
    Friend WithEvents GetSHA1_Result As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
