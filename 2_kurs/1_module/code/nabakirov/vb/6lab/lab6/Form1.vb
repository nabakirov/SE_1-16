Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim ee As Double


    Private Function init()
        If IsNumeric(aValue.Text) Then
            a = aValue.Text
        Else
            MsgBox("a value is not numeric")
        End If
        If IsNumeric(bValue.Text) Then
            b = bValue.Text
        Else
            MsgBox("b value is not numeric")
        End If
        If IsNumeric(eValue.Text) Then
            ee = eValue.Text
        Else
            MsgBox("e value is not numeric")
        End If

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles reqValue.TextChanged

    End Sub
    Function f(ByVal x)
        Dim ans As Double
        ans = Math.Sin(x) * (1 + Math.Pow(x, 3))
        Return ans
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        init()
        Dim s As Double = 0
        Dim s0 As Double
        Dim h As Double
        Dim x As Double
        Dim n As Double = 8
        Do
            s0 = s
            h = (b - a) / n
            s = 0
            x = a + h / 2
            Do
                s = s + f(x) * h
                x = x + h
            Loop While x < b
            n = n * 2
        Loop While math.Abs(s - s0) > ee
        reqValue.Text = s
    End Sub

    Private Function f2(ByVal x)
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        init()
        Dim I As Double = 0
        Dim n As Double = 4
        Dim h As Double = (b - a) / n
        Dim I2 As Double
        Dim j As Double
        Dim x0 As Double, x1 As Double, x2 As Double
        Dim y0 As Double, y1 As Double, y2 As Double
        Dim S As Double
        Do
            I2 = 0
            j = 2
            Do
                x2 = a + j * h
                x1 = x2 - h
                x0 = x1 - h

                y0 = f(x0)
                y1 = f(x1)
                y2 = f(x2)
                S = y0 + y1 + y2
                I2 = I2 + S
                If j < n Then
                    j = j + 2
                Else
                    Exit Do
                End If
            Loop
            I2 = I2 * h / 3

            If Math.Abs(I - I2) < ee Then
                Exit Do
            Else
                I = I2
                n = n * 2
                h = h / 2
            End If
        Loop
        simValue.Text = I2
    End Sub
End Class
