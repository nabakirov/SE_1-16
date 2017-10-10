<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.aValue = New System.Windows.Forms.TextBox()
        Me.bValue = New System.Windows.Forms.TextBox()
        Me.eValue = New System.Windows.Forms.TextBox()
        Me.reqValue = New System.Windows.Forms.TextBox()
        Me.simValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.kjjk = New System.Windows.Forms.Label()
        Me.jhbhj = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'aValue
        '
        Me.aValue.Location = New System.Drawing.Point(127, 34)
        Me.aValue.Name = "aValue"
        Me.aValue.Size = New System.Drawing.Size(100, 20)
        Me.aValue.TabIndex = 0
        '
        'bValue
        '
        Me.bValue.Location = New System.Drawing.Point(127, 78)
        Me.bValue.Name = "bValue"
        Me.bValue.Size = New System.Drawing.Size(100, 20)
        Me.bValue.TabIndex = 1
        '
        'eValue
        '
        Me.eValue.Location = New System.Drawing.Point(108, 133)
        Me.eValue.Name = "eValue"
        Me.eValue.Size = New System.Drawing.Size(100, 20)
        Me.eValue.TabIndex = 2
        '
        'reqValue
        '
        Me.reqValue.Location = New System.Drawing.Point(173, 237)
        Me.reqValue.Name = "reqValue"
        Me.reqValue.Size = New System.Drawing.Size(100, 20)
        Me.reqValue.TabIndex = 3
        '
        'simValue
        '
        Me.simValue.Location = New System.Drawing.Point(173, 185)
        Me.simValue.Name = "simValue"
        Me.simValue.Size = New System.Drawing.Size(100, 20)
        Me.simValue.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "точность"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Метод Симпсона"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Метод прямоугольников"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'kjjk
        '
        Me.kjjk.AutoSize = True
        Me.kjjk.Location = New System.Drawing.Point(93, 41)
        Me.kjjk.Name = "kjjk"
        Me.kjjk.Size = New System.Drawing.Size(13, 13)
        Me.kjjk.TabIndex = 8
        Me.kjjk.Text = "a"
        '
        'jhbhj
        '
        Me.jhbhj.AutoSize = True
        Me.jhbhj.Location = New System.Drawing.Point(93, 85)
        Me.jhbhj.Name = "jhbhj"
        Me.jhbhj.Size = New System.Drawing.Size(13, 13)
        Me.jhbhj.TabIndex = 9
        Me.jhbhj.Text = "b"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 292)
        Me.Controls.Add(Me.jhbhj)
        Me.Controls.Add(Me.kjjk)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.simValue)
        Me.Controls.Add(Me.reqValue)
        Me.Controls.Add(Me.eValue)
        Me.Controls.Add(Me.bValue)
        Me.Controls.Add(Me.aValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aValue As TextBox
    Friend WithEvents bValue As TextBox
    Friend WithEvents eValue As TextBox
    Friend WithEvents reqValue As TextBox
    Friend WithEvents simValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents kjjk As Label
    Friend WithEvents jhbhj As Label
End Class
