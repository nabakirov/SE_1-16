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
        Me.operand1 = New System.Windows.Forms.TextBox()
        Me.operand2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Operandd = New System.Windows.Forms.Label()
        Me.Operandf = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.Label()
        Me.action = New System.Windows.Forms.Label()
        Me.ac_plus = New System.Windows.Forms.Button()
        Me.ac_mult = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ac_minus = New System.Windows.Forms.Button()
        Me.ac_div = New System.Windows.Forms.Button()
        Me.ac_pow_2 = New System.Windows.Forms.Button()
        Me.ac_sin = New System.Windows.Forms.Button()
        Me.ac_cos = New System.Windows.Forms.Button()
        Me.ac_pow_3 = New System.Windows.Forms.Button()
        Me.ac_mod = New System.Windows.Forms.Button()
        Me.ac_pow = New System.Windows.Forms.Button()
        Me.ac_1_div = New System.Windows.Forms.Button()
        Me.num_dot = New System.Windows.Forms.Button()
        Me.num_1 = New System.Windows.Forms.Button()
        Me.num_2 = New System.Windows.Forms.Button()
        Me.num_3 = New System.Windows.Forms.Button()
        Me.num_0 = New System.Windows.Forms.Button()
        Me.num_4 = New System.Windows.Forms.Button()
        Me.num_5 = New System.Windows.Forms.Button()
        Me.num_6 = New System.Windows.Forms.Button()
        Me.num_pm = New System.Windows.Forms.Button()
        Me.num_7 = New System.Windows.Forms.Button()
        Me.num_8 = New System.Windows.Forms.Button()
        Me.num_9 = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'operand1
        '
        Me.operand1.Location = New System.Drawing.Point(85, 32)
        Me.operand1.Name = "operand1"
        Me.operand1.Size = New System.Drawing.Size(100, 20)
        Me.operand1.TabIndex = 0
        '
        'operand2
        '
        Me.operand2.Location = New System.Drawing.Point(85, 80)
        Me.operand2.Name = "operand2"
        Me.operand2.Size = New System.Drawing.Size(100, 20)
        Me.operand2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Результат"
        '
        'Operandd
        '
        Me.Operandd.AutoSize = True
        Me.Operandd.Location = New System.Drawing.Point(85, 13)
        Me.Operandd.Name = "Operandd"
        Me.Operandd.Size = New System.Drawing.Size(57, 13)
        Me.Operandd.TabIndex = 3
        Me.Operandd.Text = "Операнд1"
        '
        'Operandf
        '
        Me.Operandf.AutoSize = True
        Me.Operandf.Location = New System.Drawing.Point(88, 61)
        Me.Operandf.Name = "Operandf"
        Me.Operandf.Size = New System.Drawing.Size(57, 13)
        Me.Operandf.TabIndex = 4
        Me.Operandf.Text = "Операнд2"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(85, 107)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 13)
        Me.result.TabIndex = 5
        '
        'action
        '
        Me.action.AutoSize = True
        Me.action.Location = New System.Drawing.Point(40, 60)
        Me.action.Name = "action"
        Me.action.Size = New System.Drawing.Size(0, 13)
        Me.action.TabIndex = 6
        '
        'ac_plus
        '
        Me.ac_plus.Location = New System.Drawing.Point(22, 174)
        Me.ac_plus.Name = "ac_plus"
        Me.ac_plus.Size = New System.Drawing.Size(50, 23)
        Me.ac_plus.TabIndex = 7
        Me.ac_plus.Text = "+"
        Me.ac_plus.UseVisualStyleBackColor = True
        '
        'ac_mult
        '
        Me.ac_mult.Location = New System.Drawing.Point(77, 174)
        Me.ac_mult.Name = "ac_mult"
        Me.ac_mult.Size = New System.Drawing.Size(50, 23)
        Me.ac_mult.TabIndex = 8
        Me.ac_mult.Text = "*"
        Me.ac_mult.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 174)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "√a"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ac_minus
        '
        Me.ac_minus.Location = New System.Drawing.Point(22, 203)
        Me.ac_minus.Name = "ac_minus"
        Me.ac_minus.Size = New System.Drawing.Size(50, 23)
        Me.ac_minus.TabIndex = 10
        Me.ac_minus.Text = "-"
        Me.ac_minus.UseVisualStyleBackColor = True
        '
        'ac_div
        '
        Me.ac_div.Location = New System.Drawing.Point(77, 203)
        Me.ac_div.Name = "ac_div"
        Me.ac_div.Size = New System.Drawing.Size(50, 23)
        Me.ac_div.TabIndex = 11
        Me.ac_div.Text = "/"
        Me.ac_div.UseVisualStyleBackColor = True
        '
        'ac_pow_2
        '
        Me.ac_pow_2.Location = New System.Drawing.Point(135, 203)
        Me.ac_pow_2.Name = "ac_pow_2"
        Me.ac_pow_2.Size = New System.Drawing.Size(50, 23)
        Me.ac_pow_2.TabIndex = 12
        Me.ac_pow_2.Text = "a^2"
        Me.ac_pow_2.UseVisualStyleBackColor = True
        '
        'ac_sin
        '
        Me.ac_sin.Location = New System.Drawing.Point(22, 232)
        Me.ac_sin.Name = "ac_sin"
        Me.ac_sin.Size = New System.Drawing.Size(50, 23)
        Me.ac_sin.TabIndex = 13
        Me.ac_sin.Text = "sin"
        Me.ac_sin.UseVisualStyleBackColor = True
        '
        'ac_cos
        '
        Me.ac_cos.Location = New System.Drawing.Point(77, 232)
        Me.ac_cos.Name = "ac_cos"
        Me.ac_cos.Size = New System.Drawing.Size(50, 23)
        Me.ac_cos.TabIndex = 14
        Me.ac_cos.Text = "cos"
        Me.ac_cos.UseVisualStyleBackColor = True
        '
        'ac_pow_3
        '
        Me.ac_pow_3.Location = New System.Drawing.Point(135, 232)
        Me.ac_pow_3.Name = "ac_pow_3"
        Me.ac_pow_3.Size = New System.Drawing.Size(50, 23)
        Me.ac_pow_3.TabIndex = 15
        Me.ac_pow_3.Text = "a^3"
        Me.ac_pow_3.UseVisualStyleBackColor = True
        '
        'ac_mod
        '
        Me.ac_mod.Location = New System.Drawing.Point(22, 261)
        Me.ac_mod.Name = "ac_mod"
        Me.ac_mod.Size = New System.Drawing.Size(50, 23)
        Me.ac_mod.TabIndex = 16
        Me.ac_mod.Text = "mod"
        Me.ac_mod.UseVisualStyleBackColor = True
        '
        'ac_pow
        '
        Me.ac_pow.Location = New System.Drawing.Point(77, 261)
        Me.ac_pow.Name = "ac_pow"
        Me.ac_pow.Size = New System.Drawing.Size(50, 23)
        Me.ac_pow.TabIndex = 17
        Me.ac_pow.Text = "a^b"
        Me.ac_pow.UseVisualStyleBackColor = True
        '
        'ac_1_div
        '
        Me.ac_1_div.Location = New System.Drawing.Point(135, 261)
        Me.ac_1_div.Name = "ac_1_div"
        Me.ac_1_div.Size = New System.Drawing.Size(50, 23)
        Me.ac_1_div.TabIndex = 18
        Me.ac_1_div.Text = "1/a"
        Me.ac_1_div.UseVisualStyleBackColor = True
        '
        'num_dot
        '
        Me.num_dot.Location = New System.Drawing.Point(217, 174)
        Me.num_dot.Name = "num_dot"
        Me.num_dot.Size = New System.Drawing.Size(29, 23)
        Me.num_dot.TabIndex = 19
        Me.num_dot.Text = "."
        Me.num_dot.UseVisualStyleBackColor = True
        '
        'num_1
        '
        Me.num_1.Location = New System.Drawing.Point(252, 174)
        Me.num_1.Name = "num_1"
        Me.num_1.Size = New System.Drawing.Size(29, 23)
        Me.num_1.TabIndex = 20
        Me.num_1.Text = "1"
        Me.num_1.UseVisualStyleBackColor = True
        '
        'num_2
        '
        Me.num_2.Location = New System.Drawing.Point(287, 174)
        Me.num_2.Name = "num_2"
        Me.num_2.Size = New System.Drawing.Size(29, 23)
        Me.num_2.TabIndex = 21
        Me.num_2.Text = "2"
        Me.num_2.UseVisualStyleBackColor = True
        '
        'num_3
        '
        Me.num_3.Location = New System.Drawing.Point(322, 174)
        Me.num_3.Name = "num_3"
        Me.num_3.Size = New System.Drawing.Size(29, 23)
        Me.num_3.TabIndex = 22
        Me.num_3.Text = "3"
        Me.num_3.UseVisualStyleBackColor = True
        '
        'num_0
        '
        Me.num_0.Location = New System.Drawing.Point(217, 203)
        Me.num_0.Name = "num_0"
        Me.num_0.Size = New System.Drawing.Size(29, 23)
        Me.num_0.TabIndex = 23
        Me.num_0.Text = "0"
        Me.num_0.UseVisualStyleBackColor = True
        '
        'num_4
        '
        Me.num_4.Location = New System.Drawing.Point(252, 203)
        Me.num_4.Name = "num_4"
        Me.num_4.Size = New System.Drawing.Size(29, 23)
        Me.num_4.TabIndex = 24
        Me.num_4.Text = "4"
        Me.num_4.UseVisualStyleBackColor = True
        '
        'num_5
        '
        Me.num_5.Location = New System.Drawing.Point(287, 203)
        Me.num_5.Name = "num_5"
        Me.num_5.Size = New System.Drawing.Size(29, 23)
        Me.num_5.TabIndex = 25
        Me.num_5.Text = "5"
        Me.num_5.UseVisualStyleBackColor = True
        '
        'num_6
        '
        Me.num_6.Location = New System.Drawing.Point(322, 203)
        Me.num_6.Name = "num_6"
        Me.num_6.Size = New System.Drawing.Size(29, 23)
        Me.num_6.TabIndex = 26
        Me.num_6.Text = "6"
        Me.num_6.UseVisualStyleBackColor = True
        '
        'num_pm
        '
        Me.num_pm.Location = New System.Drawing.Point(217, 232)
        Me.num_pm.Name = "num_pm"
        Me.num_pm.Size = New System.Drawing.Size(29, 23)
        Me.num_pm.TabIndex = 27
        Me.num_pm.Text = "+/-"
        Me.num_pm.UseVisualStyleBackColor = True
        '
        'num_7
        '
        Me.num_7.Location = New System.Drawing.Point(252, 232)
        Me.num_7.Name = "num_7"
        Me.num_7.Size = New System.Drawing.Size(29, 23)
        Me.num_7.TabIndex = 28
        Me.num_7.Text = "7"
        Me.num_7.UseVisualStyleBackColor = True
        '
        'num_8
        '
        Me.num_8.Location = New System.Drawing.Point(287, 232)
        Me.num_8.Name = "num_8"
        Me.num_8.Size = New System.Drawing.Size(29, 23)
        Me.num_8.TabIndex = 29
        Me.num_8.Text = "8"
        Me.num_8.UseVisualStyleBackColor = True
        '
        'num_9
        '
        Me.num_9.Location = New System.Drawing.Point(322, 232)
        Me.num_9.Name = "num_9"
        Me.num_9.Size = New System.Drawing.Size(29, 23)
        Me.num_9.TabIndex = 30
        Me.num_9.Text = "9"
        Me.num_9.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Location = New System.Drawing.Point(348, 285)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(49, 23)
        Me.exit_btn.TabIndex = 31
        Me.exit_btn.Text = "выход"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 352)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.num_9)
        Me.Controls.Add(Me.num_8)
        Me.Controls.Add(Me.num_7)
        Me.Controls.Add(Me.num_pm)
        Me.Controls.Add(Me.num_6)
        Me.Controls.Add(Me.num_5)
        Me.Controls.Add(Me.num_4)
        Me.Controls.Add(Me.num_0)
        Me.Controls.Add(Me.num_3)
        Me.Controls.Add(Me.num_2)
        Me.Controls.Add(Me.num_1)
        Me.Controls.Add(Me.num_dot)
        Me.Controls.Add(Me.ac_1_div)
        Me.Controls.Add(Me.ac_pow)
        Me.Controls.Add(Me.ac_mod)
        Me.Controls.Add(Me.ac_pow_3)
        Me.Controls.Add(Me.ac_cos)
        Me.Controls.Add(Me.ac_sin)
        Me.Controls.Add(Me.ac_pow_2)
        Me.Controls.Add(Me.ac_div)
        Me.Controls.Add(Me.ac_minus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ac_mult)
        Me.Controls.Add(Me.ac_plus)
        Me.Controls.Add(Me.action)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Operandf)
        Me.Controls.Add(Me.Operandd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.operand2)
        Me.Controls.Add(Me.operand1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents operand1 As TextBox
    Friend WithEvents operand2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Operandd As Label
    Friend WithEvents Operandf As Label
    Friend WithEvents result As Label
    Friend WithEvents action As Label
    Friend WithEvents ac_plus As Button
    Friend WithEvents ac_mult As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ac_minus As Button
    Friend WithEvents ac_div As Button
    Friend WithEvents ac_pow_2 As Button
    Friend WithEvents ac_sin As Button
    Friend WithEvents ac_cos As Button
    Friend WithEvents ac_pow_3 As Button
    Friend WithEvents ac_mod As Button
    Friend WithEvents ac_pow As Button
    Friend WithEvents ac_1_div As Button
    Friend WithEvents num_dot As Button
    Friend WithEvents num_1 As Button
    Friend WithEvents num_2 As Button
    Friend WithEvents num_3 As Button
    Friend WithEvents num_0 As Button
    Friend WithEvents num_4 As Button
    Friend WithEvents num_5 As Button
    Friend WithEvents num_6 As Button
    Friend WithEvents num_pm As Button
    Friend WithEvents num_7 As Button
    Friend WithEvents num_8 As Button
    Friend WithEvents num_9 As Button
    Friend WithEvents exit_btn As Button
End Class
