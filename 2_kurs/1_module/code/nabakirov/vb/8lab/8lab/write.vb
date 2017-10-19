Imports System, System.IO
Public Class write
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sr As StreamWriter = New StreamWriter("Writen.txt")
            Dim line As String

            For i = 0 To 10
                sr.WriteLine(RichTextBox1.Lines(i))
            Next

            sr.Close()
        Finally

            TextBox1.Text = "The file is read:"
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim sr As StreamWriter = New StreamWriter("Writen2.txt")
            Dim line As String

            For i = 0 To 10
                sr.Write(RichTextBox2.Lines(i))
            Next

            sr.Close()
        Finally

            TextBox2.Text = "The file is read:"
        End Try
    End Sub
End Class