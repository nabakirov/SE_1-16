<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim РодителиLabel1 As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim КурсLabel1 As System.Windows.Forms.Label
        Dim Очная_форма_обученияLabel As System.Windows.Forms.Label
        Dim Код_специальностиLabel As System.Windows.Forms.Label
        Dim ГруппаLabel As System.Windows.Forms.Label
        Dim Дата_поступленияLabel As System.Windows.Forms.Label
        Dim Номер_зачеткиLabel As System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New Students_db2.StudentsDataSet()
        Me.СтудентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СтудентыTableAdapter = New Students_db2.StudentsDataSetTableAdapters.СтудентыTableAdapter()
        Me.TableAdapterManager = New Students_db2.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.СтудентыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.СтудентыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Дата_рожденияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.КурсNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Очная_форма_обученияCheckBox = New System.Windows.Forms.CheckBox()
        Me.ГруппаTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_поступленияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.СпециальностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностиTableAdapter = New Students_db2.StudentsDataSetTableAdapters.СпециальностиTableAdapter()
        ФИОLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        РодителиLabel1 = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        КурсLabel1 = New System.Windows.Forms.Label()
        Очная_форма_обученияLabel = New System.Windows.Forms.Label()
        Код_специальностиLabel = New System.Windows.Forms.Label()
        ГруппаLabel = New System.Windows.Forms.Label()
        Дата_поступленияLabel = New System.Windows.Forms.Label()
        Номер_зачеткиLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтудентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтудентыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СтудентыBindingNavigator.SuspendLayout()
        CType(Me.КурсNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(276, 581)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 52
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(70, 581)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(176, 581)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(276, 552)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(176, 552)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(70, 552)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(276, 515)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Предидущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(74, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Таблица ""Студенты"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СтудентыBindingSource
        '
        Me.СтудентыBindingSource.DataMember = "Студенты"
        Me.СтудентыBindingSource.DataSource = Me.StudentsDataSet
        '
        'СтудентыTableAdapter
        '
        Me.СтудентыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Students_db2.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностиTableAdapter = Me.СпециальностиTableAdapter
        Me.TableAdapterManager.СтудентыTableAdapter = Me.СтудентыTableAdapter
        '
        'СтудентыBindingNavigator
        '
        Me.СтудентыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СтудентыBindingNavigator.BindingSource = Me.СтудентыBindingSource
        Me.СтудентыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СтудентыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СтудентыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СтудентыBindingNavigatorSaveItem})
        Me.СтудентыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СтудентыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СтудентыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СтудентыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СтудентыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СтудентыBindingNavigator.Name = "СтудентыBindingNavigator"
        Me.СтудентыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СтудентыBindingNavigator.Size = New System.Drawing.Size(429, 25)
        Me.СтудентыBindingNavigator.TabIndex = 54
        Me.СтудентыBindingNavigator.Text = "BindingNavigator1"
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
        'СтудентыBindingNavigatorSaveItem
        '
        Me.СтудентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СтудентыBindingNavigatorSaveItem.Image = CType(resources.GetObject("СтудентыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СтудентыBindingNavigatorSaveItem.Name = "СтудентыBindingNavigatorSaveItem"
        Me.СтудентыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.СтудентыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Location = New System.Drawing.Point(88, 84)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(37, 13)
        ФИОLabel.TabIndex = 54
        ФИОLabel.Text = "ФИО:"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "ФИО", True))
        Me.ФИОTextBox.Location = New System.Drawing.Point(131, 81)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ФИОTextBox.TabIndex = 55
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Пол", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.ComboBox1.Location = New System.Drawing.Point(131, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 56
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(88, 117)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(30, 13)
        Label2.TabIndex = 57
        Label2.Text = "Пол:"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Location = New System.Drawing.Point(36, 154)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(89, 13)
        Дата_рожденияLabel.TabIndex = 57
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'Дата_рожденияDateTimePicker
        '
        Me.Дата_рожденияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Дата_рождения", True))
        Me.Дата_рожденияDateTimePicker.Location = New System.Drawing.Point(131, 150)
        Me.Дата_рожденияDateTimePicker.Name = "Дата_рожденияDateTimePicker"
        Me.Дата_рожденияDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.Дата_рожденияDateTimePicker.TabIndex = 58
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Родители", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Отец,Мать", "Отец", "Мать", "Нет"})
        Me.ComboBox2.Location = New System.Drawing.Point(131, 183)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 59
        '
        'РодителиLabel1
        '
        РодителиLabel1.AutoSize = True
        РодителиLabel1.Location = New System.Drawing.Point(67, 186)
        РодителиLabel1.Name = "РодителиLabel1"
        РодителиLabel1.Size = New System.Drawing.Size(58, 13)
        РодителиLabel1.TabIndex = 60
        РодителиLabel1.Text = "Родители:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(84, 219)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 60
        АдресLabel.Text = "Адрес:"
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(131, 216)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 61
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Телефон", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(130, 252)
        Me.MaskedTextBox1.Mask = "+7(999)000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(127, 20)
        Me.MaskedTextBox1.TabIndex = 63
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.Location = New System.Drawing.Point(69, 255)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 62
        ТелефонLabel.Text = "Телефон:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Паспортные_данные", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(131, 287)
        Me.MaskedTextBox2.Mask = "0000-000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(116, 20)
        Me.MaskedTextBox2.TabIndex = 65
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Location = New System.Drawing.Point(11, 289)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        Паспортные_данныеLabel.TabIndex = 64
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Код_специальности", True))
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СтудентыBindingSource, "Код_специальности", True))
        Me.ComboBox3.DataSource = Me.СпециальностиBindingSource
        Me.ComboBox3.DisplayMember = "Наименование_специальности"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(126, 426)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 89
        Me.ComboBox3.ValueMember = "Описание_специальности"
        '
        'КурсLabel1
        '
        КурсLabel1.AutoSize = True
        КурсLabel1.Location = New System.Drawing.Point(89, 404)
        КурсLabel1.Name = "КурсLabel1"
        КурсLabel1.Size = New System.Drawing.Size(34, 13)
        КурсLabel1.TabIndex = 86
        КурсLabel1.Text = "Курс:"
        '
        'КурсNumericUpDown
        '
        Me.КурсNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Курс", True))
        Me.КурсNumericUpDown.Location = New System.Drawing.Point(129, 400)
        Me.КурсNumericUpDown.Name = "КурсNumericUpDown"
        Me.КурсNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.КурсNumericUpDown.TabIndex = 88
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Номер_зачетки", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(135, 318)
        Me.MaskedTextBox3.Mask = "00000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(184, 20)
        Me.MaskedTextBox3.TabIndex = 87
        Me.MaskedTextBox3.ValidatingType = GetType(Integer)
        '
        'Очная_форма_обученияLabel
        '
        Очная_форма_обученияLabel.AutoSize = True
        Очная_форма_обученияLabel.Location = New System.Drawing.Point(12, 454)
        Очная_форма_обученияLabel.Name = "Очная_форма_обученияLabel"
        Очная_форма_обученияLabel.Size = New System.Drawing.Size(127, 13)
        Очная_форма_обученияLabel.TabIndex = 84
        Очная_форма_обученияLabel.Text = "Очная форма обучения:"
        '
        'Очная_форма_обученияCheckBox
        '
        Me.Очная_форма_обученияCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.СтудентыBindingSource, "Очная_форма_обучения", True))
        Me.Очная_форма_обученияCheckBox.Location = New System.Drawing.Point(145, 449)
        Me.Очная_форма_обученияCheckBox.Name = "Очная_форма_обученияCheckBox"
        Me.Очная_форма_обученияCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.Очная_форма_обученияCheckBox.TabIndex = 85
        Me.Очная_форма_обученияCheckBox.Text = "CheckBox1"
        Me.Очная_форма_обученияCheckBox.UseVisualStyleBackColor = True
        '
        'Код_специальностиLabel
        '
        Код_специальностиLabel.AutoSize = True
        Код_специальностиLabel.Location = New System.Drawing.Point(20, 426)
        Код_специальностиLabel.Name = "Код_специальностиLabel"
        Код_специальностиLabel.Size = New System.Drawing.Size(109, 13)
        Код_специальностиLabel.TabIndex = 83
        Код_специальностиLabel.Text = "Код специальности:"
        '
        'ГруппаLabel
        '
        ГруппаLabel.AutoSize = True
        ГруппаLabel.Location = New System.Drawing.Point(84, 374)
        ГруппаLabel.Name = "ГруппаLabel"
        ГруппаLabel.Size = New System.Drawing.Size(45, 13)
        ГруппаLabel.TabIndex = 81
        ГруппаLabel.Text = "Группа:"
        '
        'ГруппаTextBox
        '
        Me.ГруппаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Группа", True))
        Me.ГруппаTextBox.Location = New System.Drawing.Point(135, 374)
        Me.ГруппаTextBox.Name = "ГруппаTextBox"
        Me.ГруппаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ГруппаTextBox.TabIndex = 82
        '
        'Дата_поступленияLabel
        '
        Дата_поступленияLabel.AutoSize = True
        Дата_поступленияLabel.Location = New System.Drawing.Point(26, 352)
        Дата_поступленияLabel.Name = "Дата_поступленияLabel"
        Дата_поступленияLabel.Size = New System.Drawing.Size(103, 13)
        Дата_поступленияLabel.TabIndex = 79
        Дата_поступленияLabel.Text = "Дата поступления:"
        '
        'Дата_поступленияDateTimePicker
        '
        Me.Дата_поступленияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Дата_поступления", True))
        Me.Дата_поступленияDateTimePicker.Location = New System.Drawing.Point(135, 348)
        Me.Дата_поступленияDateTimePicker.Name = "Дата_поступленияDateTimePicker"
        Me.Дата_поступленияDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_поступленияDateTimePicker.TabIndex = 80
        '
        'Номер_зачеткиLabel
        '
        Номер_зачеткиLabel.AutoSize = True
        Номер_зачеткиLabel.Location = New System.Drawing.Point(42, 321)
        Номер_зачеткиLabel.Name = "Номер_зачеткиLabel"
        Номер_зачеткиLabel.Size = New System.Drawing.Size(87, 13)
        Номер_зачеткиLabel.TabIndex = 78
        Номер_зачеткиLabel.Text = "Номер зачетки:"
        '
        'СпециальностиBindingSource
        '
        Me.СпециальностиBindingSource.DataMember = "Специальности"
        Me.СпециальностиBindingSource.DataSource = Me.StudentsDataSet
        '
        'СпециальностиTableAdapter
        '
        Me.СпециальностиTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 627)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(КурсLabel1)
        Me.Controls.Add(Me.КурсNumericUpDown)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Очная_форма_обученияLabel)
        Me.Controls.Add(Me.Очная_форма_обученияCheckBox)
        Me.Controls.Add(Код_специальностиLabel)
        Me.Controls.Add(ГруппаLabel)
        Me.Controls.Add(Me.ГруппаTextBox)
        Me.Controls.Add(Дата_поступленияLabel)
        Me.Controls.Add(Me.Дата_поступленияDateTimePicker)
        Me.Controls.Add(Номер_зачеткиLabel)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Паспортные_данныеLabel)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(ТелефонLabel)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(РодителиLabel1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Дата_рожденияLabel)
        Me.Controls.Add(Me.Дата_рожденияDateTimePicker)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
        Me.Controls.Add(Me.СтудентыBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form4"
        Me.Text = "Студенты"
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтудентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтудентыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СтудентыBindingNavigator.ResumeLayout(False)
        Me.СтудентыBindingNavigator.PerformLayout()
        CType(Me.КурсNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentsDataSet As Students_db2.StudentsDataSet
    Friend WithEvents СтудентыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents СтудентыTableAdapter As Students_db2.StudentsDataSetTableAdapters.СтудентыTableAdapter
    Friend WithEvents TableAdapterManager As Students_db2.StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СтудентыBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents СтудентыBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ФИОTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Дата_рожденияDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents АдресTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents КурсNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Очная_форма_обученияCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ГруппаTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Дата_поступленияDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents СпециальностиTableAdapter As Students_db2.StudentsDataSetTableAdapters.СпециальностиTableAdapter
    Friend WithEvents СпециальностиBindingSource As System.Windows.Forms.BindingSource
End Class
