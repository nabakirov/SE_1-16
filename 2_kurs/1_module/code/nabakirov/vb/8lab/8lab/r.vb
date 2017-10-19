Imports System
Imports System.IO

Public Class r


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sr As StreamReader = New StreamReader("File.txt")
            Dim line As String

            Do
                line = sr.ReadLine()
                RichTextBox1.Text = RichTextBox1.Text & line & Chr(13)
            Loop Until line Is Nothing
            sr.Close()
        Finally

            TextBox1.Text = "The file is read:"
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim sr As StreamReader = New StreamReader("File2.txt")
            Dim line As String
            Dim buf(100) As Char
            Dim numToRead As Integer = 100
            Dim i As Integer = 0

            Do
                line = sr.Read(buf, 0, 100)

                i = i + 1

            Loop Until i = 10
            For i = 0 To 100
                RichTextBox2.Text = RichTextBox2.Text & buf(i) & Chr(13)
            Next
            sr.Close()
        Finally

            TextBox2.Text = "The file is read:"
        End Try
    End Sub
End Class