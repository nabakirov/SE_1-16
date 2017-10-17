Imports System
Imports System.IO
Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Create an instance of StreamReader to read from a file.
            Dim sr As StreamReader = New StreamReader("T1.txt")

            Dim line As String
            ' Read and display the lines from the file until the end of the file is reached.
            Do
                line = sr.ReadLine()
                RichTextBox1.Text = RichTextBox1.Text & line & Chr(13)
            Loop Until line Is Nothing
            sr.Close()
            End If
        Finally
            ' Let the user know that all is OK.
            TextBox1.Text = "The file is read:"
        End Try

     
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Create an instance of StreamReader to read from a file.
            Dim sr As StreamReader = New StreamReader("T1.txt")

            Dim line1 As String
            ' Read and display the lines from the file until the end of the file is reached.
            Do
                line1 = sr.ReadLine()
                If IsNumeric(line1) Then
                    RichTextBox2.Text = RichTextBox2.Text & line1 & Chr(13)
                End If
            Loop Until line1 Is Nothing
            sr.Close()

        Finally
            ' Let the user know that all is OK.
            TextBox2.Text = "The file is read:"
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IO.File.WriteAllText("T1.txt", RichTextBox3.Text)
        FileOpen(1, "T1.txt", OpenMode.Output)
        Print(1, RichTextBox3.Text)
        FileClose(1)
    End Sub
End Class
