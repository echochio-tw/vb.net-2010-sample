<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BeiJing = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.yuan = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BeiJing
        '
        Me.BeiJing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BeiJing.Location = New System.Drawing.Point(12, 9)
        Me.BeiJing.Name = "BeiJing"
        Me.BeiJing.Size = New System.Drawing.Size(370, 298)
        Me.BeiJing.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'yuan
        '
        Me.yuan.BackColor = System.Drawing.Color.Transparent
        Me.yuan.ForeColor = System.Drawing.Color.Red
        Me.yuan.Location = New System.Drawing.Point(115, 75)
        Me.yuan.Name = "yuan"
        Me.yuan.Size = New System.Drawing.Size(11, 11)
        Me.yuan.TabIndex = 2
        Me.yuan.Text = "●"
        Me.yuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(38, 334)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(37, 12)
        Me.C1.TabIndex = 3
        Me.C1.Text = "Label1"
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(115, 334)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(37, 12)
        Me.C2.TabIndex = 4
        Me.C2.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 366)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.yuan)
        Me.Controls.Add(Me.BeiJing)
        Me.Name = "Form1"
        Me.Text = "球移動"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BeiJing As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents yuan As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.Label

End Class
