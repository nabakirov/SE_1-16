Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double = CDbl(TextBox1.Text)
        Dim b As Double = CDbl(TextBox2.Text)
        Dim c As Double = CDbl(TextBox3.Text)
        Dim x1 As Double
        Dim x2 As Double
        Dim x As Double
        Dim k As Double
       
        Dim i As Integer
        Dim i1 As Double = 0
        k = (Math.Sqrt(5) - 1) / 2
        x1 = a * 0.618 + 0.382 * b
        x2 = 0.382 * a + 0.618 * b
        While Math.Abs(x1 - x2) > c
            If f(x1) < f(x2) Then
                a = x1
                x1 = x2
                x2 = a + k * (b - a)
            Else
                b = x2
                x2 = x1
                x1 = a + (1 - k) * (b - a)

            End If
        End While

        x = (x1 + x2) / 2
        TextBox4.Text = f(x)
        TextBox5.Text = x
    End Sub
    Function f(x As Double)
        x = 3 * Math.Sin(x) + (Math.Sin(3 * x))
        Return x
    End Function
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    
End Class
