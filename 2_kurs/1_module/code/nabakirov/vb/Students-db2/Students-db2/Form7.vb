Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
        Me.СтудентыTableAdapter.Fill(Me.StudentsDataSet.Студенты)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class