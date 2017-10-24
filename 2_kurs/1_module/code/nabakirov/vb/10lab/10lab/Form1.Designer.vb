<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BooksDataSet = New _10lab.booksDataSet()
        Me.КнигиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КнигиTableAdapter = New _10lab.booksDataSetTableAdapters.книгиTableAdapter()
        Me.TableAdapterManager = New _10lab.booksDataSetTableAdapters.TableAdapterManager()
        Me.КнигиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.КнигиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.КнигиDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.BooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КнигиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КнигиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.КнигиBindingNavigator.SuspendLayout()
        CType(Me.КнигиDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BooksDataSet
        '
        Me.BooksDataSet.DataSetName = "booksDataSet"
        Me.BooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КнигиBindingSource
        '
        Me.КнигиBindingSource.DataMember = "книги"
        Me.КнигиBindingSource.DataSource = Me.BooksDataSet
        '
        'КнигиTableAdapter
        '
        Me.КнигиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = _10lab.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.книгиTableAdapter = Me.КнигиTableAdapter
        '
        'КнигиBindingNavigator
        '
        Me.КнигиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.КнигиBindingNavigator.BindingSource = Me.КнигиBindingSource
        Me.КнигиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.КнигиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.КнигиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.КнигиBindingNavigatorSaveItem})
        Me.КнигиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.КнигиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.КнигиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.КнигиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.КнигиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.КнигиBindingNavigator.Name = "КнигиBindingNavigator"
        Me.КнигиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.КнигиBindingNavigator.Size = New System.Drawing.Size(452, 25)
        Me.КнигиBindingNavigator.TabIndex = 0
        Me.КнигиBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'КнигиBindingNavigatorSaveItem
        '
        Me.КнигиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КнигиBindingNavigatorSaveItem.Image = CType(resources.GetObject("КнигиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.КнигиBindingNavigatorSaveItem.Name = "КнигиBindingNavigatorSaveItem"
        Me.КнигиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.КнигиBindingNavigatorSaveItem.Text = "Save Data"
        '
        'КнигиDataGridView
        '
        Me.КнигиDataGridView.AutoGenerateColumns = False
        Me.КнигиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.КнигиDataGridView.DataSource = Me.КнигиBindingSource
        Me.КнигиDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.КнигиDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.КнигиDataGridView.Name = "КнигиDataGridView"
        Me.КнигиDataGridView.Size = New System.Drawing.Size(452, 299)
        Me.КнигиDataGridView.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 324)
        Me.Controls.Add(Me.КнигиDataGridView)
        Me.Controls.Add(Me.КнигиBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КнигиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КнигиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.КнигиBindingNavigator.ResumeLayout(False)
        Me.КнигиBindingNavigator.PerformLayout()
        CType(Me.КнигиDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooksDataSet As booksDataSet
    Friend WithEvents КнигиBindingSource As BindingSource
    Friend WithEvents КнигиTableAdapter As booksDataSetTableAdapters.книгиTableAdapter
    Friend WithEvents TableAdapterManager As booksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents КнигиBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents КнигиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents КнигиDataGridView As DataGridView
End Class
