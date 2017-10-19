<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class write
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
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(157, 205)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(100, 86)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(157, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(157, 47)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 86)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "write char"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "write line"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'write
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 325)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "write"
        Me.Text = "write"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
