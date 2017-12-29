

Public Class Form1
    Dim a_field As Double, b_field As Double, e_field As Double

    Function init()
        a_field = A.Text
        b_field = B.Text
        e_field = E.Text
    End Function

    Function f(x)
        'Return Math.Tan(a) - 1 / Math.Pow(a, 2)
        Return x + Math.Pow(x, 3) - 5

        'Dim ans As Double
        'ans = Math.Log10(x) - (1 / x)
        'Math.l
        'Return ans
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        init()
        If f(a_field) * f(b_field) > 0 Then
            R.Text = "Корня нет"
        Else
            Do
                x = (a_field + b_field) / 2
                If f(a_field) * f(x) > 0 Then
                    a_field = x
                Else
                    b_field = x
                End If
                If Math.Abs(f(x)) < e_field Then
                    Exit Do
                End If
            Loop
            R.Text = x
            R2.Text = f(x)
        End If

    End Sub
End Class
