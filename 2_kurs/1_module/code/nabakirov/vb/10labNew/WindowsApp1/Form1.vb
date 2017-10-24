Public Class Form1
    Private Sub КнигиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КнигиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КнигиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooksDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet.книги' table. You can move, or remove it, as needed.
        Me.КнигиTableAdapter.Fill(Me.BooksDataSet.книги)

    End Sub
End Class
