Imports System, System.IO

Public Class write
    Public x As Integer = 0
    Public x1 As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim sr As StreamWriter = New StreamWriter("Writen.txt")
            Dim line As String

            For i = 0 To x - 1
                sr.WriteLine(RichTextBox1.Lines(i))
            Next

            sr.Close()
        Finally

            TextBox1.Text = "The file is recorded:"
            x = 0
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim sr As StreamWriter = New StreamWriter("Writen2.txt")
            For i = 0 To x1 - 1
                sr.Write(RichTextBox2.Lines(i))
            Next
            sr.Close()
        Finally

            TextBox2.Text = "The file is recorded:"
            x1 = 0
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim ar() As String = RichTextBox1.Lines
        If ar(ar.Length - 1) <> "" Then
            x = ar.Length
        End If
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

        Dim ar() As String = RichTextBox2.Lines
        If ar(ar.Length - 1) <> "" Then

            x1 = ar.Length

        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class