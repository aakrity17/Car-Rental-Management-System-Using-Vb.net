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
        Dim ColorLabel As System.Windows.Forms.Label
        Dim Rent_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Cellphone_NoLabel As System.Windows.Forms.Label
        Dim Telephone_NoLabel As System.Windows.Forms.Label
        Dim Street_AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim Car_IDLabel As System.Windows.Forms.Label
        Dim Car_NameLabel As System.Windows.Forms.Label
        Dim Plate_NoLabel As System.Windows.Forms.Label
        Dim ColorLabel1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Rent_DayLabel As System.Windows.Forms.Label
        Dim No_of_DaysLabel As System.Windows.Forms.Label
        Dim Total_DueLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Rent_DetailsDataSet = New FinalCarRentalSystem.Rent_DetailsDataSet()
        Me.Rent_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rent_DetailsTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter()
        Me.TableAdapterManager = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager()
        Me.RentTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter()
        Me.Rent_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Rent_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Rent_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColorComboBox = New System.Windows.Forms.ComboBox()
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter()
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rent_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Cellphone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Street_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.City_TownTextBox = New System.Windows.Forms.TextBox()
        Me.Car_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Car_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Plate_NoTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Rent_DayTextBox = New System.Windows.Forms.TextBox()
        Me.No_of_DaysTextBox = New System.Windows.Forms.TextBox()
        Me.Total_DueTextBox = New System.Windows.Forms.TextBox()
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox()
        ColorLabel = New System.Windows.Forms.Label()
        Rent_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Cellphone_NoLabel = New System.Windows.Forms.Label()
        Telephone_NoLabel = New System.Windows.Forms.Label()
        Street_AddressLabel = New System.Windows.Forms.Label()
        City_TownLabel = New System.Windows.Forms.Label()
        Car_IDLabel = New System.Windows.Forms.Label()
        Car_NameLabel = New System.Windows.Forms.Label()
        Plate_NoLabel = New System.Windows.Forms.Label()
        ColorLabel1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Rent_DayLabel = New System.Windows.Forms.Label()
        No_of_DaysLabel = New System.Windows.Forms.Label()
        Total_DueLabel = New System.Windows.Forms.Label()
        Processed_ByLabel = New System.Windows.Forms.Label()
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rent_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Rent_DetailsBindingNavigator.SuspendLayout()
        CType(Me.Rent_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(441, 453)
        ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(42, 16)
        ColorLabel.TabIndex = 2
        ColorLabel.Text = "Color:"
        '
        'Rent_IDLabel
        '
        Rent_IDLabel.AutoSize = True
        Rent_IDLabel.Location = New System.Drawing.Point(60, 97)
        Rent_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rent_IDLabel.Name = "Rent_IDLabel"
        Rent_IDLabel.Size = New System.Drawing.Size(54, 16)
        Rent_IDLabel.TabIndex = 4
        Rent_IDLabel.Text = "Rent ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(60, 129)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(75, 16)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(60, 161)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(75, 16)
        Last_NameLabel.TabIndex = 8
        Last_NameLabel.Text = "Last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(60, 193)
        AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(35, 16)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age:"
        '
        'Cellphone_NoLabel
        '
        Cellphone_NoLabel.AutoSize = True
        Cellphone_NoLabel.Location = New System.Drawing.Point(60, 225)
        Cellphone_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cellphone_NoLabel.Name = "Cellphone_NoLabel"
        Cellphone_NoLabel.Size = New System.Drawing.Size(92, 16)
        Cellphone_NoLabel.TabIndex = 12
        Cellphone_NoLabel.Text = "Cellphone No:"
        '
        'Telephone_NoLabel
        '
        Telephone_NoLabel.AutoSize = True
        Telephone_NoLabel.Location = New System.Drawing.Point(60, 257)
        Telephone_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Telephone_NoLabel.Name = "Telephone_NoLabel"
        Telephone_NoLabel.Size = New System.Drawing.Size(97, 16)
        Telephone_NoLabel.TabIndex = 14
        Telephone_NoLabel.Text = "Telephone No:"
        '
        'Street_AddressLabel
        '
        Street_AddressLabel.AutoSize = True
        Street_AddressLabel.Location = New System.Drawing.Point(60, 289)
        Street_AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Street_AddressLabel.Name = "Street_AddressLabel"
        Street_AddressLabel.Size = New System.Drawing.Size(99, 16)
        Street_AddressLabel.TabIndex = 16
        Street_AddressLabel.Text = "Street Address:"
        '
        'City_TownLabel
        '
        City_TownLabel.AutoSize = True
        City_TownLabel.Location = New System.Drawing.Point(60, 321)
        City_TownLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(69, 16)
        City_TownLabel.TabIndex = 18
        City_TownLabel.Text = "City/Town:"
        '
        'Car_IDLabel
        '
        Car_IDLabel.AutoSize = True
        Car_IDLabel.Location = New System.Drawing.Point(60, 353)
        Car_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Car_IDLabel.Name = "Car_IDLabel"
        Car_IDLabel.Size = New System.Drawing.Size(47, 16)
        Car_IDLabel.TabIndex = 20
        Car_IDLabel.Text = "Car ID:"
        '
        'Car_NameLabel
        '
        Car_NameLabel.AutoSize = True
        Car_NameLabel.Location = New System.Drawing.Point(60, 385)
        Car_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Car_NameLabel.Name = "Car_NameLabel"
        Car_NameLabel.Size = New System.Drawing.Size(71, 16)
        Car_NameLabel.TabIndex = 22
        Car_NameLabel.Text = "Car Name:"
        '
        'Plate_NoLabel
        '
        Plate_NoLabel.AutoSize = True
        Plate_NoLabel.Location = New System.Drawing.Point(60, 417)
        Plate_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Plate_NoLabel.Name = "Plate_NoLabel"
        Plate_NoLabel.Size = New System.Drawing.Size(62, 16)
        Plate_NoLabel.TabIndex = 24
        Plate_NoLabel.Text = "Plate No:"
        '
        'ColorLabel1
        '
        ColorLabel1.AutoSize = True
        ColorLabel1.Location = New System.Drawing.Point(60, 449)
        ColorLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel1.Name = "ColorLabel1"
        ColorLabel1.Size = New System.Drawing.Size(42, 16)
        ColorLabel1.TabIndex = 26
        ColorLabel1.Text = "Color:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(60, 482)
        DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(39, 16)
        DateLabel.TabIndex = 28
        DateLabel.Text = "Date:"
        '
        'Rent_DayLabel
        '
        Rent_DayLabel.AutoSize = True
        Rent_DayLabel.Location = New System.Drawing.Point(60, 513)
        Rent_DayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rent_DayLabel.Name = "Rent_DayLabel"
        Rent_DayLabel.Size = New System.Drawing.Size(67, 16)
        Rent_DayLabel.TabIndex = 30
        Rent_DayLabel.Text = "Rent/Day:"
        '
        'No_of_DaysLabel
        '
        No_of_DaysLabel.AutoSize = True
        No_of_DaysLabel.Location = New System.Drawing.Point(60, 545)
        No_of_DaysLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        No_of_DaysLabel.Name = "No_of_DaysLabel"
        No_of_DaysLabel.Size = New System.Drawing.Size(77, 16)
        No_of_DaysLabel.TabIndex = 32
        No_of_DaysLabel.Text = "No of Days:"
        '
        'Total_DueLabel
        '
        Total_DueLabel.AutoSize = True
        Total_DueLabel.Location = New System.Drawing.Point(60, 577)
        Total_DueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Total_DueLabel.Name = "Total_DueLabel"
        Total_DueLabel.Size = New System.Drawing.Size(69, 16)
        Total_DueLabel.TabIndex = 34
        Total_DueLabel.Text = "Total Due:"
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Location = New System.Drawing.Point(60, 609)
        Processed_ByLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(95, 16)
        Processed_ByLabel.TabIndex = 36
        Processed_ByLabel.Text = "Processed By:"
        '
        'Rent_DetailsDataSet
        '
        Me.Rent_DetailsDataSet.DataSetName = "Rent_DetailsDataSet"
        Me.Rent_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rent_DetailsBindingSource
        '
        Me.Rent_DetailsBindingSource.DataMember = "Rent_Details"
        Me.Rent_DetailsBindingSource.DataSource = Me.Rent_DetailsDataSet
        '
        'Rent_DetailsTableAdapter
        '
        Me.Rent_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Rent_DetailsTableAdapter = Me.Rent_DetailsTableAdapter
        Me.TableAdapterManager.RentTableAdapter = Me.RentTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentTableAdapter
        '
        Me.RentTableAdapter.ClearBeforeFill = True
        '
        'Rent_DetailsBindingNavigator
        '
        Me.Rent_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Rent_DetailsBindingNavigator.BindingSource = Me.Rent_DetailsBindingSource
        Me.Rent_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Rent_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Rent_DetailsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Rent_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Rent_DetailsBindingNavigatorSaveItem})
        Me.Rent_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Rent_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Rent_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Rent_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Rent_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Rent_DetailsBindingNavigator.Name = "Rent_DetailsBindingNavigator"
        Me.Rent_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Rent_DetailsBindingNavigator.Size = New System.Drawing.Size(1304, 27)
        Me.Rent_DetailsBindingNavigator.TabIndex = 0
        Me.Rent_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Rent_DetailsBindingNavigatorSaveItem
        '
        Me.Rent_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rent_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Rent_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Rent_DetailsBindingNavigatorSaveItem.Name = "Rent_DetailsBindingNavigatorSaveItem"
        Me.Rent_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Rent_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Rent_DetailsDataGridView
        '
        Me.Rent_DetailsDataGridView.AutoGenerateColumns = False
        Me.Rent_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rent_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.Rent_DetailsDataGridView.DataSource = Me.Rent_DetailsBindingSource
        Me.Rent_DetailsDataGridView.Location = New System.Drawing.Point(624, 151)
        Me.Rent_DetailsDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rent_DetailsDataGridView.Name = "Rent_DetailsDataGridView"
        Me.Rent_DetailsDataGridView.RowHeadersWidth = 51
        Me.Rent_DetailsDataGridView.Size = New System.Drawing.Size(617, 271)
        Me.Rent_DetailsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RentDetails_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RentDetails_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Rent_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rent_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Car_ID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ListOfCarsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Car_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Car_ID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Car_Name"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'ListOfCarsBindingSource
        '
        Me.ListOfCarsBindingSource.DataMember = "ListOfCars"
        Me.ListOfCarsBindingSource.DataSource = Me.ListOfCarsDataSet
        '
        'ListOfCarsDataSet
        '
        Me.ListOfCarsDataSet.DataSetName = "ListOfCarsDataSet"
        Me.ListOfCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Plate_No"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ListOfCarsBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Plate_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Plate_No"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "Plate_No"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Car_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Car_Name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Rent/Day"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rent/Day"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'ColorComboBox
        '
        Me.ColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rent_DetailsBindingSource, "Color", True))
        Me.ColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Rent_DetailsBindingSource, "Color", True))
        Me.ColorComboBox.DataSource = Me.ListOfCarsBindingSource
        Me.ColorComboBox.DisplayMember = "Color"
        Me.ColorComboBox.FormattingEnabled = True
        Me.ColorComboBox.Location = New System.Drawing.Point(799, 506)
        Me.ColorComboBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ColorComboBox.Name = "ColorComboBox"
        Me.ColorComboBox.Size = New System.Drawing.Size(160, 24)
        Me.ColorComboBox.TabIndex = 3
        Me.ColorComboBox.ValueMember = "Color"
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'RentBindingSource
        '
        Me.RentBindingSource.DataMember = "Rent"
        Me.RentBindingSource.DataSource = Me.Rent_DetailsDataSet
        '
        'Rent_IDTextBox
        '
        Me.Rent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent_ID", True))
        Me.Rent_IDTextBox.Location = New System.Drawing.Point(173, 94)
        Me.Rent_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rent_IDTextBox.Name = "Rent_IDTextBox"
        Me.Rent_IDTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Rent_IDTextBox.TabIndex = 5
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(173, 126)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.First_NameTextBox.TabIndex = 7
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(173, 158)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Last_NameTextBox.TabIndex = 9
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(173, 190)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(265, 22)
        Me.AgeTextBox.TabIndex = 11
        '
        'Cellphone_NoTextBox
        '
        Me.Cellphone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Cellphone_No", True))
        Me.Cellphone_NoTextBox.Location = New System.Drawing.Point(173, 222)
        Me.Cellphone_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cellphone_NoTextBox.Name = "Cellphone_NoTextBox"
        Me.Cellphone_NoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Cellphone_NoTextBox.TabIndex = 13
        '
        'Telephone_NoTextBox
        '
        Me.Telephone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Telephone_No", True))
        Me.Telephone_NoTextBox.Location = New System.Drawing.Point(173, 254)
        Me.Telephone_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Telephone_NoTextBox.Name = "Telephone_NoTextBox"
        Me.Telephone_NoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Telephone_NoTextBox.TabIndex = 15
        '
        'Street_AddressTextBox
        '
        Me.Street_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Street_Address", True))
        Me.Street_AddressTextBox.Location = New System.Drawing.Point(173, 286)
        Me.Street_AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Street_AddressTextBox.Name = "Street_AddressTextBox"
        Me.Street_AddressTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Street_AddressTextBox.TabIndex = 17
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "City/Town", True))
        Me.City_TownTextBox.Location = New System.Drawing.Point(173, 318)
        Me.City_TownTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(265, 22)
        Me.City_TownTextBox.TabIndex = 19
        '
        'Car_IDTextBox
        '
        Me.Car_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Car_ID", True))
        Me.Car_IDTextBox.Location = New System.Drawing.Point(173, 350)
        Me.Car_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Car_IDTextBox.Name = "Car_IDTextBox"
        Me.Car_IDTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Car_IDTextBox.TabIndex = 21
        '
        'Car_NameTextBox
        '
        Me.Car_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Car_Name", True))
        Me.Car_NameTextBox.Location = New System.Drawing.Point(173, 382)
        Me.Car_NameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Car_NameTextBox.Name = "Car_NameTextBox"
        Me.Car_NameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Car_NameTextBox.TabIndex = 23
        '
        'Plate_NoTextBox
        '
        Me.Plate_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Plate_No", True))
        Me.Plate_NoTextBox.Location = New System.Drawing.Point(173, 414)
        Me.Plate_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Plate_NoTextBox.Name = "Plate_NoTextBox"
        Me.Plate_NoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Plate_NoTextBox.TabIndex = 25
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(173, 446)
        Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ColorTextBox.TabIndex = 27
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(173, 478)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateDateTimePicker.TabIndex = 29
        '
        'Rent_DayTextBox
        '
        Me.Rent_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent/Day", True))
        Me.Rent_DayTextBox.Location = New System.Drawing.Point(173, 510)
        Me.Rent_DayTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rent_DayTextBox.Name = "Rent_DayTextBox"
        Me.Rent_DayTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Rent_DayTextBox.TabIndex = 31
        '
        'No_of_DaysTextBox
        '
        Me.No_of_DaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "No_of_Days", True))
        Me.No_of_DaysTextBox.Location = New System.Drawing.Point(173, 542)
        Me.No_of_DaysTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.No_of_DaysTextBox.Name = "No_of_DaysTextBox"
        Me.No_of_DaysTextBox.Size = New System.Drawing.Size(265, 22)
        Me.No_of_DaysTextBox.TabIndex = 33
        '
        'Total_DueTextBox
        '
        Me.Total_DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Total_Due", True))
        Me.Total_DueTextBox.Location = New System.Drawing.Point(173, 574)
        Me.Total_DueTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Total_DueTextBox.Name = "Total_DueTextBox"
        Me.Total_DueTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Total_DueTextBox.TabIndex = 35
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(173, 606)
        Me.Processed_ByTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Processed_ByTextBox.TabIndex = 37
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 655)
        Me.Controls.Add(Rent_IDLabel)
        Me.Controls.Add(Me.Rent_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Cellphone_NoLabel)
        Me.Controls.Add(Me.Cellphone_NoTextBox)
        Me.Controls.Add(Telephone_NoLabel)
        Me.Controls.Add(Me.Telephone_NoTextBox)
        Me.Controls.Add(Street_AddressLabel)
        Me.Controls.Add(Me.Street_AddressTextBox)
        Me.Controls.Add(City_TownLabel)
        Me.Controls.Add(Me.City_TownTextBox)
        Me.Controls.Add(Car_IDLabel)
        Me.Controls.Add(Me.Car_IDTextBox)
        Me.Controls.Add(Car_NameLabel)
        Me.Controls.Add(Me.Car_NameTextBox)
        Me.Controls.Add(Plate_NoLabel)
        Me.Controls.Add(Me.Plate_NoTextBox)
        Me.Controls.Add(ColorLabel1)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Rent_DayLabel)
        Me.Controls.Add(Me.Rent_DayTextBox)
        Me.Controls.Add(No_of_DaysLabel)
        Me.Controls.Add(Me.No_of_DaysTextBox)
        Me.Controls.Add(Total_DueLabel)
        Me.Controls.Add(Me.Total_DueTextBox)
        Me.Controls.Add(Processed_ByLabel)
        Me.Controls.Add(Me.Processed_ByTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorComboBox)
        Me.Controls.Add(Me.Rent_DetailsDataGridView)
        Me.Controls.Add(Me.Rent_DetailsBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rent_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Rent_DetailsBindingNavigator.ResumeLayout(False)
        Me.Rent_DetailsBindingNavigator.PerformLayout()
        CType(Me.Rent_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rent_DetailsDataSet As FinalCarRentalSystem.Rent_DetailsDataSet
    Friend WithEvents Rent_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rent_DetailsTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Rent_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Rent_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rent_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents RentTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents RentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rent_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cellphone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telephone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents City_TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Car_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Car_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plate_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rent_DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_of_DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_DueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Processed_ByTextBox As System.Windows.Forms.TextBox
End Class
