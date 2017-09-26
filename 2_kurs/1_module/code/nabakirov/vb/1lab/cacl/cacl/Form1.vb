

Public Class Form1
    Private i = 1
    Public clicked_1 As Boolean
    Public clicked_2 As Boolean


    Public Sub load() Handles Me.Activated
        clicked_1 = False
        clicked_2 = False
    End Sub
    Private Sub ac_plus_Click(sender As Object, e As EventArgs) Handles ac_plus.Click
        Dim a, b As Double
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            action.Text = ac_plus.Text
            a = operand1.Text
            b = operand2.Text
            result.Text = a + b
        Else
            MsgBox("Only Number")
        End If





    End Sub

    Private Sub ac_mult_Click(sender As Object, e As EventArgs) Handles ac_mult.Click
        Dim a, b As Double
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            a = operand1.Text
            b = operand2.Text
            result.Text = a * b
            action.Text = ac_mult.Text
        Else
            MsgBox("Only Number")
        End If
    End Sub

    Private Sub ac_minus_Click(sender As Object, e As EventArgs) Handles ac_minus.Click
        Dim a, b As Double
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            a = operand1.Text
            b = operand2.Text
            result.Text = a - b
            action.Text = ac_minus.Text
        Else
            MsgBox("Only Number")
        End If
    End Sub

    Private Sub ac_div_Click(sender As Object, e As EventArgs) Handles ac_div.Click
        Dim a, b As Double
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            If operand2.Text <> 0 Then
                a = operand1.Text
                b = operand2.Text
                result.Text = a / b
                action.Text = ac_div.Text
            Else
                MsgBox("Can not devide to zero")
            End If
        Else
            MsgBox("Only Number")
        End If
    End Sub

    Private Sub ac_sin_Click(sender As Object, e As EventArgs) Handles ac_sin.Click
        If IsNumeric(operand1.Text) Then
            result.Text = Math.Sin(operand1.Text * 3.14 / 180)
            action.Text = ac_sin.Text
            operand2.Text = ""
        Else
            MsgBox("Only Number")
        End If
    End Sub

    Private Sub num_dot_Click(sender As Object, e As EventArgs) Handles num_dot.Click

        If i = 1 And clicked_1 = False Then
            If operand1.TextLength = 0 Then
                operand1.Text = operand1.Text & 0 & num_dot.Text
            Else
                operand1.Text = operand1.Text & num_dot.Text
            End If
            clicked_1 = True
        ElseIf i = 2 And clicked_2 = False Then
            If operand2.TextLength = 0 Then
                operand2.Text = operand2.Text & 0 & num_dot.Text
            Else
                operand2.Text = operand2.Text & num_dot.Text
            End If
            clicked_2 = True
        End If
    End Sub

    Private Sub num_1_Click(sender As Object, e As EventArgs) Handles num_1.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_1.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_1.Text
        End If
    End Sub

    Private Sub num_2_Click(sender As Object, e As EventArgs) Handles num_2.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_2.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_2.Text
        End If
    End Sub

    Private Sub num_3_Click(sender As Object, e As EventArgs) Handles num_3.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_3.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_3.Text
        End If
    End Sub

    Private Sub num_0_Click(sender As Object, e As EventArgs) Handles num_0.Click
        If i = 1 Then
            If operand1.Text <> "00" Then
                operand1.Text = operand1.Text & num_0.Text
            Else
                MsgBox("error")
            End If

        ElseIf i = 2 Then
            If operand2.Text <> "00" Then
                operand2.Text = operand2.Text & num_0.Text
            Else
                MsgBox("error")
            End If
        End If
    End Sub

    Private Sub num_4_Click(sender As Object, e As EventArgs) Handles num_4.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_4.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_4.Text
        End If
    End Sub

    Private Sub num_5_Click(sender As Object, e As EventArgs) Handles num_5.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_5.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_5.Text
        End If
    End Sub

    Private Sub num_6_Click(sender As Object, e As EventArgs) Handles num_6.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_6.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_6.Text
        End If
    End Sub

    Private Sub num_7_Click(sender As Object, e As EventArgs) Handles num_7.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_7.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_7.Text
        End If
    End Sub

    Private Sub num_8_Click(sender As Object, e As EventArgs) Handles num_8.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_8.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_8.Text
        End If
    End Sub

    Private Sub num_9_Click(sender As Object, e As EventArgs) Handles num_9.Click
        If i = 1 Then
            operand1.Text = operand1.Text & num_9.Text
        ElseIf i = 2 Then
            operand2.Text = operand2.Text & num_9.Text
        End If
    End Sub

    Private Sub operand1_TextChanged(sender As Object, e As EventArgs) Handles operand1.Click

        i = 1
    End Sub

    Private Sub operand2_TextChanged(sender As Object, e As EventArgs) Handles operand2.Click
        i = 2
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub ac_pow_2_Click(sender As Object, e As EventArgs) Handles ac_pow_2.Click
        If IsNumeric(operand1.Text) Then
            result.Text = Math.Pow(operand1.Text, 2)
            action.Text = ac_pow_2.Text
            operand2.Text = ""
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub ac_pow_3_Click(sender As Object, e As EventArgs) Handles ac_pow_3.Click
        If IsNumeric(operand1.Text) Then
            result.Text = Math.Pow(operand1.Text, 3)
            action.Text = ac_pow_3.Text
            operand2.Text = ""
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub ac_mod_Click(sender As Object, e As EventArgs) Handles ac_mod.Click
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            result.Text = operand1.Text Mod operand2.Text
            action.Text = ac_mod.Text
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub ac_pow_Click(sender As Object, e As EventArgs) Handles ac_pow.Click
        If IsNumeric(operand1.Text) And IsNumeric(operand2.Text) Then
            result.Text = Math.Pow(operand1.Text, operand2.Text)
            action.Text = ac_pow.Text
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub ac_1_div_Click(sender As Object, e As EventArgs) Handles ac_1_div.Click
        If IsNumeric(operand1.Text) And operand2.Text <> 0 Then
            result.Text = 1 / operand1.Text
            action.Text = ac_1_div.Text
            operand2.Text = ""
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub num_pm_Click(sender As Object, e As EventArgs) Handles num_pm.Click
        Dim sign As Char
        Dim num As Double
        If i = 1 Then
            If operand1.TextLength = 0 Then
                operand1.Text = "-"
            Else
                num = operand1.Text
                operand1.Text = num * -1
            End If


        ElseIf i = 2 Then
            If operand2.TextLength = 0 Then
                operand2.Text = "-"
            Else
                num = operand2.Text
                operand2.Text = num * -1
            End If

        End If
    End Sub

    Private Sub ac_cos_Click(sender As Object, e As EventArgs) Handles ac_cos.Click
        If IsNumeric(operand1.Text) Then
            result.Text = Math.Cos(operand1.Text * 3.14 / 180)
            action.Text = ac_sin.Text
            operand2.Text = ""
        Else
            MsgBox("Only Number")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(operand1.Text) Then
            result.Text = Math.Sqrt(operand1.Text)
            operand2.Text = ""
            action.Text = Button3.Text
        Else
            MsgBox("invalid input")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
