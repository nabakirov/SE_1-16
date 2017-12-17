<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim Дата_экзамена1Label As System.Windows.Forms.Label
        Dim Код_предмета1Label As System.Windows.Forms.Label
        Dim Оценка1Label As System.Windows.Forms.Label
        Dim Дата_экзамена2Label As System.Windows.Forms.Label
        Dim Код_предмета2Label As System.Windows.Forms.Label
        Dim Оценка2Label As System.Windows.Forms.Label
        Dim Дата_экзамена3Label As System.Windows.Forms.Label
        Dim Код_предмета3Label As System.Windows.Forms.Label
        Dim Оценка3Label As System.Windows.Forms.Label
        Dim Средний_баллLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New Students_db2.StudentsDataSet()
        Me.ОценкиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОценкиTableAdapter = New Students_db2.StudentsDataSetTableAdapters.ОценкиTableAdapter()
        Me.TableAdapterManager = New Students_db2.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.ОценкиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ОценкиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Дата_экзамена1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета1TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка1TextBox = New System.Windows.Forms.TextBox()
        Me.Дата_экзамена2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета2TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка2TextBox = New System.Windows.Forms.TextBox()
        Me.Дата_экзамена3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета3TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка3TextBox = New System.Windows.Forms.TextBox()
        Me.Средний_баллTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Дата_экзамена1Label = New System.Windows.Forms.Label()
        Код_предмета1Label = New System.Windows.Forms.Label()
        Оценка1Label = New System.Windows.Forms.Label()
        Дата_экзамена2Label = New System.Windows.Forms.Label()
        Код_предмета2Label = New System.Windows.Forms.Label()
        Оценка2Label = New System.Windows.Forms.Label()
        Дата_экзамена3Label = New System.Windows.Forms.Label()
        Код_предмета3Label = New System.Windows.Forms.Label()
        Оценка3Label = New System.Windows.Forms.Label()
        Средний_баллLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОценкиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОценкиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ОценкиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Таблица ""Оценки"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ОценкиBindingSource
        '
        Me.ОценкиBindingSource.DataMember = "Оценки"
        Me.ОценкиBindingSource.DataSource = Me.StudentsDataSet
        '
        'ОценкиTableAdapter
        '
        Me.ОценкиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Students_db2.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Me.ОценкиTableAdapter
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностиTableAdapter = Nothing
        Me.TableAdapterManager.СтудентыTableAdapter = Nothing
        '
        'ОценкиBindingNavigator
        '
        Me.ОценкиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ОценкиBindingNavigator.BindingSource = Me.ОценкиBindingSource
        Me.ОценкиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ОценкиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ОценкиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ОценкиBindingNavigatorSaveItem})
        Me.ОценкиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ОценкиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ОценкиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ОценкиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ОценкиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ОценкиBindingNavigator.Name = "ОценкиBindingNavigator"
        Me.ОценкиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ОценкиBindingNavigator.Size = New System.Drawing.Size(481, 25)
        Me.ОценкиBindingNavigator.TabIndex = 5
        Me.ОценкиBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
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
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
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
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'ОценкиBindingNavigatorSaveItem
        '
        Me.ОценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ОценкиBindingNavigatorSaveItem.Image = CType(resources.GetObject("ОценкиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ОценкиBindingNavigatorSaveItem.Name = "ОценкиBindingNavigatorSaveItem"
        Me.ОценкиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ОценкиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Дата_экзамена1Label
        '
        Дата_экзамена1Label.AutoSize = True
        Дата_экзамена1Label.Location = New System.Drawing.Point(42, 76)
        Дата_экзамена1Label.Name = "Дата_экзамена1Label"
        Дата_экзамена1Label.Size = New System.Drawing.Size(95, 13)
        Дата_экзамена1Label.TabIndex = 5
        Дата_экзамена1Label.Text = "Дата экзамена1:"
        '
        'Дата_экзамена1DateTimePicker
        '
        Me.Дата_экзамена1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата экзамена1", True))
        Me.Дата_экзамена1DateTimePicker.Location = New System.Drawing.Point(143, 72)
        Me.Дата_экзамена1DateTimePicker.Name = "Дата_экзамена1DateTimePicker"
        Me.Дата_экзамена1DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена1DateTimePicker.TabIndex = 6
        '
        'Код_предмета1Label
        '
        Код_предмета1Label.AutoSize = True
        Код_предмета1Label.Location = New System.Drawing.Point(51, 110)
        Код_предмета1Label.Name = "Код_предмета1Label"
        Код_предмета1Label.Size = New System.Drawing.Size(86, 13)
        Код_предмета1Label.TabIndex = 6
        Код_предмета1Label.Text = "код предмета1:"
        '
        'Код_предмета1TextBox
        '
        Me.Код_предмета1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "код предмета1", True))
        Me.Код_предмета1TextBox.Location = New System.Drawing.Point(143, 107)
        Me.Код_предмета1TextBox.Name = "Код_предмета1TextBox"
        Me.Код_предмета1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета1TextBox.TabIndex = 7
        '
        'Оценка1Label
        '
        Оценка1Label.AutoSize = True
        Оценка1Label.Location = New System.Drawing.Point(85, 136)
        Оценка1Label.Name = "Оценка1Label"
        Оценка1Label.Size = New System.Drawing.Size(52, 13)
        Оценка1Label.TabIndex = 7
        Оценка1Label.Text = "оценка1:"
        '
        'Оценка1TextBox
        '
        Me.Оценка1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "оценка1", True))
        Me.Оценка1TextBox.Location = New System.Drawing.Point(143, 133)
        Me.Оценка1TextBox.Name = "Оценка1TextBox"
        Me.Оценка1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка1TextBox.TabIndex = 8
        '
        'Дата_экзамена2Label
        '
        Дата_экзамена2Label.AutoSize = True
        Дата_экзамена2Label.Location = New System.Drawing.Point(42, 175)
        Дата_экзамена2Label.Name = "Дата_экзамена2Label"
        Дата_экзамена2Label.Size = New System.Drawing.Size(95, 13)
        Дата_экзамена2Label.TabIndex = 8
        Дата_экзамена2Label.Text = "Дата экзамена2:"
        '
        'Дата_экзамена2DateTimePicker
        '
        Me.Дата_экзамена2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата экзамена2", True))
        Me.Дата_экзамена2DateTimePicker.Location = New System.Drawing.Point(143, 171)
        Me.Дата_экзамена2DateTimePicker.Name = "Дата_экзамена2DateTimePicker"
        Me.Дата_экзамена2DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена2DateTimePicker.TabIndex = 9
        '
        'Код_предмета2Label
        '
        Код_предмета2Label.AutoSize = True
        Код_предмета2Label.Location = New System.Drawing.Point(51, 211)
        Код_предмета2Label.Name = "Код_предмета2Label"
        Код_предмета2Label.Size = New System.Drawing.Size(86, 13)
        Код_предмета2Label.TabIndex = 10
        Код_предмета2Label.Text = "код предмета2:"
        '
        'Код_предмета2TextBox
        '
        Me.Код_предмета2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "код предмета2", True))
        Me.Код_предмета2TextBox.Location = New System.Drawing.Point(143, 208)
        Me.Код_предмета2TextBox.Name = "Код_предмета2TextBox"
        Me.Код_предмета2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета2TextBox.TabIndex = 11
        '
        'Оценка2Label
        '
        Оценка2Label.AutoSize = True
        Оценка2Label.Location = New System.Drawing.Point(85, 247)
        Оценка2Label.Name = "Оценка2Label"
        Оценка2Label.Size = New System.Drawing.Size(52, 13)
        Оценка2Label.TabIndex = 12
        Оценка2Label.Text = "оценка2:"
        '
        'Оценка2TextBox
        '
        Me.Оценка2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "оценка2", True))
        Me.Оценка2TextBox.Location = New System.Drawing.Point(143, 244)
        Me.Оценка2TextBox.Name = "Оценка2TextBox"
        Me.Оценка2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка2TextBox.TabIndex = 13
        '
        'Дата_экзамена3Label
        '
        Дата_экзамена3Label.AutoSize = True
        Дата_экзамена3Label.Location = New System.Drawing.Point(42, 286)
        Дата_экзамена3Label.Name = "Дата_экзамена3Label"
        Дата_экзамена3Label.Size = New System.Drawing.Size(95, 13)
        Дата_экзамена3Label.TabIndex = 14
        Дата_экзамена3Label.Text = "Дата экзамена3:"
        '
        'Дата_экзамена3DateTimePicker
        '
        Me.Дата_экзамена3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата экзамена3", True))
        Me.Дата_экзамена3DateTimePicker.Location = New System.Drawing.Point(143, 282)
        Me.Дата_экзамена3DateTimePicker.Name = "Дата_экзамена3DateTimePicker"
        Me.Дата_экзамена3DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена3DateTimePicker.TabIndex = 15
        '
        'Код_предмета3Label
        '
        Код_предмета3Label.AutoSize = True
        Код_предмета3Label.Location = New System.Drawing.Point(51, 311)
        Код_предмета3Label.Name = "Код_предмета3Label"
        Код_предмета3Label.Size = New System.Drawing.Size(86, 13)
        Код_предмета3Label.TabIndex = 16
        Код_предмета3Label.Text = "код предмета3:"
        '
        'Код_предмета3TextBox
        '
        Me.Код_предмета3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "код предмета3", True))
        Me.Код_предмета3TextBox.Location = New System.Drawing.Point(143, 308)
        Me.Код_предмета3TextBox.Name = "Код_предмета3TextBox"
        Me.Код_предмета3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета3TextBox.TabIndex = 17
        '
        'Оценка3Label
        '
        Оценка3Label.AutoSize = True
        Оценка3Label.Location = New System.Drawing.Point(85, 337)
        Оценка3Label.Name = "Оценка3Label"
        Оценка3Label.Size = New System.Drawing.Size(52, 13)
        Оценка3Label.TabIndex = 18
        Оценка3Label.Text = "оценка3:"
        '
        'Оценка3TextBox
        '
        Me.Оценка3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "оценка3", True))
        Me.Оценка3TextBox.Location = New System.Drawing.Point(143, 334)
        Me.Оценка3TextBox.Name = "Оценка3TextBox"
        Me.Оценка3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка3TextBox.TabIndex = 19
        '
        'Средний_баллLabel
        '
        Средний_баллLabel.AutoSize = True
        Средний_баллLabel.Location = New System.Drawing.Point(57, 376)
        Средний_баллLabel.Name = "Средний_баллLabel"
        Средний_баллLabel.Size = New System.Drawing.Size(80, 13)
        Средний_баллLabel.TabIndex = 20
        Средний_баллLabel.Text = "Средний балл:"
        '
        'Средний_баллTextBox
        '
        Me.Средний_баллTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Средний балл", True))
        Me.Средний_баллTextBox.Location = New System.Drawing.Point(143, 373)
        Me.Средний_баллTextBox.Name = "Средний_баллTextBox"
        Me.Средний_баллTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Средний_баллTextBox.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Вычислить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Средний_баллLabel)
        Me.Controls.Add(Me.Средний_баллTextBox)
        Me.Controls.Add(Оценка3Label)
        Me.Controls.Add(Me.Оценка3TextBox)
        Me.Controls.Add(Код_предмета3Label)
        Me.Controls.Add(Me.Код_предмета3TextBox)
        Me.Controls.Add(Дата_экзамена3Label)
        Me.Controls.Add(Me.Дата_экзамена3DateTimePicker)
        Me.Controls.Add(Оценка2Label)
        Me.Controls.Add(Me.Оценка2TextBox)
        Me.Controls.Add(Код_предмета2Label)
        Me.Controls.Add(Me.Код_предмета2TextBox)
        Me.Controls.Add(Дата_экзамена2Label)
        Me.Controls.Add(Me.Дата_экзамена2DateTimePicker)
        Me.Controls.Add(Оценка1Label)
        Me.Controls.Add(Me.Оценка1TextBox)
        Me.Controls.Add(Код_предмета1Label)
        Me.Controls.Add(Me.Код_предмета1TextBox)
        Me.Controls.Add(Дата_экзамена1Label)
        Me.Controls.Add(Me.Дата_экзамена1DateTimePicker)
        Me.Controls.Add(Me.ОценкиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Оценки"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОценкиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОценкиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ОценкиBindingNavigator.ResumeLayout(False)
        Me.ОценкиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentsDataSet As Students_db2.StudentsDataSet
    Friend WithEvents ОценкиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ОценкиTableAdapter As Students_db2.StudentsDataSetTableAdapters.ОценкиTableAdapter
    Friend WithEvents TableAdapterManager As Students_db2.StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ОценкиBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ОценкиBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Дата_экзамена1DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Код_предмета1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Оценка1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_экзамена2DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Код_предмета2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Оценка2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_экзамена3DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Код_предмета3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Оценка3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Средний_баллTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
