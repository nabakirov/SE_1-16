Public Class Form1
    Dim a, b, c, d As Double
    Dim paper As Graphics
    Dim mypen As Pen = New Pen(Color.Black)
    Private Function TheFunction(ByVal x As Double) As Double
        Return a * x * x * x + b * x * x + c * x + d
    End Function

    Private Function ScaleX(ByVal xPixel As Integer) As Double
        Dim xStart As Double = -5, xEnd As Double = 5
        Dim xScale As Double = PictureBox1.Width / (xEnd - xStart)
        Return (xPixel - (PictureBox1.Width / 2)) / xScale
    End Function

    Private Function ScaleY(ByVal y As Double) As Integer
        Dim yStart As Double = -5, yEnd As Double = 5
        Dim pixelCoord As Integer
        Dim yScale As Double = PictureBox1.Height / (yEnd - yStart)
        pixelCoord = CInt(-y * yScale) + CInt(PictureBox1.Height / 2)
        Return pixelCoord
    End Function
    Private Sub Draw()
        Dim x, y, nextX, nextY As Double
        Dim xpixel, ypixel, nextXPixeL, nextYPixel As Integer
        For xpixel = 0 To PictureBox1.Width
            x = ScaleX(xpixel)
            y = TheFunction(x)
            ypixel = ScaleY(y)
            nextXPixeL = xpixel + 1
            nextX = ScaleX(nextXPixeL)
            nextY = TheFunction(nextX)
            nextYPixel = ScaleY(nextY)
            paper.DrawLine(mypen, xpixel, ypixel, nextXPixeL, nextYPixel)

        Next
    End Sub

    Private Sub DrawGraph()
      
        a = CDbl(TextBox1.Text)
        b = CDbl(TextBox2.Text)
        c = CDbl(TextBox3.Text)
        d = CDbl(TextBox4.Text)
      
        paper.Clear(Color.White)
        Draw()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
     
       
        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
            Dim h, h_m As Integer
            Dim w, w_m As Integer
            h = PictureBox1.Height
            w = PictureBox1.Width
            h_m = h / 2
            w_m = w / 2
            paper = PictureBox1.CreateGraphics()
           
            DrawGraph()
            paper.DrawLine(mypen, 0, h_m, w, h_m)
            paper.DrawLine(mypen, w_m, 0, w_m, h)
        Else
            MsgBox("Wrong input!")


        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
