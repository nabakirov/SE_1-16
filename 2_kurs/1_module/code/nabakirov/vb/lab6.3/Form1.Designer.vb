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
        Me.A = New System.Windows.Forms.TextBox()
        Me.B = New System.Windows.Forms.TextBox()
        Me.E = New System.Windows.Forms.TextBox()
        Me.R = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.R2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(68, 53)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(100, 20)
        Me.A.TabIndex = 0
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(68, 91)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(100, 20)
        Me.B.TabIndex = 1
        '
        'E
        '
        Me.E.Location = New System.Drawing.Point(68, 130)
        Me.E.Name = "E"
        Me.E.Size = New System.Drawing.Size(100, 20)
        Me.E.TabIndex = 2
        '
        'R
        '
        Me.R.Location = New System.Drawing.Point(68, 229)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(100, 20)
        Me.R.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.Location = New System.Drawing.Point(68, 255)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(100, 20)
        Me.R2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 300)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.E)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A As TextBox
    Friend WithEvents B As TextBox
    Friend WithEvents E As TextBox
    Friend WithEvents R As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents R2 As TextBox
End Class
