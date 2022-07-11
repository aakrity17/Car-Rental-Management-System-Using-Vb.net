<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Dim Rent_IDLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Cellphone_NoLabel As System.Windows.Forms.Label
        Dim Telephone_NoLabel As System.Windows.Forms.Label
        Dim Street_AddressLabel As System.Windows.Forms.Label
        Dim City_TownLabel As System.Windows.Forms.Label
        Dim Car_IDLabel As System.Windows.Forms.Label
        Dim Car_NameLabel As System.Windows.Forms.Label
        Dim Plate_NoLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Rent_DayLabel As System.Windows.Forms.Label
        Dim No_of_DaysLabel As System.Windows.Forms.Label
        Dim Total_DueLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Car_NameLabel1 As System.Windows.Forms.Label
        Dim Rent_DayLabel1 As System.Windows.Forms.Label
        Dim ColorLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Rent_DetailsDataSet = New FinalCarRentalSystem.Rent_DetailsDataSet
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
        Me.TableAdapterManager = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
        Me.Rent_DetailsTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
        Me.RentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Rent_IDTextBox = New System.Windows.Forms.TextBox
        Me.AgeTextBox = New System.Windows.Forms.TextBox
        Me.Cellphone_NoTextBox = New System.Windows.Forms.TextBox
        Me.Telephone_NoTextBox = New System.Windows.Forms.TextBox
        Me.Street_AddressTextBox = New System.Windows.Forms.TextBox
        Me.City_TownTextBox = New System.Windows.Forms.TextBox
        Me.Car_IDTextBox = New System.Windows.Forms.TextBox
        Me.Car_NameTextBox = New System.Windows.Forms.TextBox
        Me.Plate_NoTextBox = New System.Windows.Forms.TextBox
        Me.ColorTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Rent_DayTextBox = New System.Windows.Forms.TextBox
        Me.No_of_DaysTextBox = New System.Windows.Forms.TextBox
        Me.Total_DueTextBox = New System.Windows.Forms.TextBox
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox
        Me.Rent_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rent_DetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox
        Me.First_NameComboBox = New System.Windows.Forms.ComboBox
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New FinalCarRentalSystem.CustomerDataSet
        Me.CustomerTableAdapter = New FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.Car_NameComboBox = New System.Windows.Forms.ComboBox
        Me.Rent_DayComboBox = New System.Windows.Forms.ComboBox
        Me.ColorComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Rent_IDLabel = New System.Windows.Forms.Label
        AgeLabel = New System.Windows.Forms.Label
        Cellphone_NoLabel = New System.Windows.Forms.Label
        Telephone_NoLabel = New System.Windows.Forms.Label
        Street_AddressLabel = New System.Windows.Forms.Label
        City_TownLabel = New System.Windows.Forms.Label
        Car_IDLabel = New System.Windows.Forms.Label
        Car_NameLabel = New System.Windows.Forms.Label
        Plate_NoLabel = New System.Windows.Forms.Label
        ColorLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        Rent_DayLabel = New System.Windows.Forms.Label
        No_of_DaysLabel = New System.Windows.Forms.Label
        Total_DueLabel = New System.Windows.Forms.Label
        Processed_ByLabel = New System.Windows.Forms.Label
        Last_NameLabel = New System.Windows.Forms.Label
        First_NameLabel = New System.Windows.Forms.Label
        Car_NameLabel1 = New System.Windows.Forms.Label
        Rent_DayLabel1 = New System.Windows.Forms.Label
        ColorLabel1 = New System.Windows.Forms.Label
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentBindingNavigator.SuspendLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rent_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rent_IDLabel
        '
        Rent_IDLabel.AutoSize = True
        Rent_IDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_IDLabel.Location = New System.Drawing.Point(29, 106)
        Rent_IDLabel.Name = "Rent_IDLabel"
        Rent_IDLabel.Size = New System.Drawing.Size(53, 17)
        Rent_IDLabel.TabIndex = 1
        Rent_IDLabel.Text = "Rent ID:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(413, 139)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        AgeLabel.Visible = False
        '
        'Cellphone_NoLabel
        '
        Cellphone_NoLabel.AutoSize = True
        Cellphone_NoLabel.Location = New System.Drawing.Point(413, 165)
        Cellphone_NoLabel.Name = "Cellphone_NoLabel"
        Cellphone_NoLabel.Size = New System.Drawing.Size(74, 13)
        Cellphone_NoLabel.TabIndex = 9
        Cellphone_NoLabel.Text = "Cellphone No:"
        Cellphone_NoLabel.Visible = False
        '
        'Telephone_NoLabel
        '
        Telephone_NoLabel.AutoSize = True
        Telephone_NoLabel.Location = New System.Drawing.Point(413, 191)
        Telephone_NoLabel.Name = "Telephone_NoLabel"
        Telephone_NoLabel.Size = New System.Drawing.Size(78, 13)
        Telephone_NoLabel.TabIndex = 11
        Telephone_NoLabel.Text = "Telephone No:"
        Telephone_NoLabel.Visible = False
        '
        'Street_AddressLabel
        '
        Street_AddressLabel.AutoSize = True
        Street_AddressLabel.Location = New System.Drawing.Point(413, 217)
        Street_AddressLabel.Name = "Street_AddressLabel"
        Street_AddressLabel.Size = New System.Drawing.Size(79, 13)
        Street_AddressLabel.TabIndex = 13
        Street_AddressLabel.Text = "Street Address:"
        Street_AddressLabel.Visible = False
        '
        'City_TownLabel
        '
        City_TownLabel.AutoSize = True
        City_TownLabel.Location = New System.Drawing.Point(413, 243)
        City_TownLabel.Name = "City_TownLabel"
        City_TownLabel.Size = New System.Drawing.Size(59, 13)
        City_TownLabel.TabIndex = 15
        City_TownLabel.Text = "City/Town:"
        City_TownLabel.Visible = False
        '
        'Car_IDLabel
        '
        Car_IDLabel.AutoSize = True
        Car_IDLabel.Location = New System.Drawing.Point(397, 187)
        Car_IDLabel.Name = "Car_IDLabel"
        Car_IDLabel.Size = New System.Drawing.Size(40, 13)
        Car_IDLabel.TabIndex = 17
        Car_IDLabel.Text = "Car ID:"
        Car_IDLabel.Visible = False
        '
        'Car_NameLabel
        '
        Car_NameLabel.AutoSize = True
        Car_NameLabel.Location = New System.Drawing.Point(397, 213)
        Car_NameLabel.Name = "Car_NameLabel"
        Car_NameLabel.Size = New System.Drawing.Size(57, 13)
        Car_NameLabel.TabIndex = 19
        Car_NameLabel.Text = "Car Name:"
        Car_NameLabel.Visible = False
        '
        'Plate_NoLabel
        '
        Plate_NoLabel.AutoSize = True
        Plate_NoLabel.Location = New System.Drawing.Point(397, 239)
        Plate_NoLabel.Name = "Plate_NoLabel"
        Plate_NoLabel.Size = New System.Drawing.Size(51, 13)
        Plate_NoLabel.TabIndex = 21
        Plate_NoLabel.Text = "Plate No:"
        Plate_NoLabel.Visible = False
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(397, 265)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 23
        ColorLabel.Text = "Color:"
        ColorLabel.Visible = False
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(29, 167)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(38, 17)
        DateLabel.TabIndex = 25
        DateLabel.Text = "Date:"
        '
        'Rent_DayLabel
        '
        Rent_DayLabel.AutoSize = True
        Rent_DayLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_DayLabel.Location = New System.Drawing.Point(29, 200)
        Rent_DayLabel.Name = "Rent_DayLabel"
        Rent_DayLabel.Size = New System.Drawing.Size(64, 17)
        Rent_DayLabel.TabIndex = 27
        Rent_DayLabel.Text = "Rent/Day:"
        '
        'No_of_DaysLabel
        '
        No_of_DaysLabel.AutoSize = True
        No_of_DaysLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        No_of_DaysLabel.Location = New System.Drawing.Point(29, 226)
        No_of_DaysLabel.Name = "No_of_DaysLabel"
        No_of_DaysLabel.Size = New System.Drawing.Size(77, 17)
        No_of_DaysLabel.TabIndex = 29
        No_of_DaysLabel.Text = "No of Days:"
        '
        'Total_DueLabel
        '
        Total_DueLabel.AutoSize = True
        Total_DueLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_DueLabel.Location = New System.Drawing.Point(29, 256)
        Total_DueLabel.Name = "Total_DueLabel"
        Total_DueLabel.Size = New System.Drawing.Size(67, 17)
        Total_DueLabel.TabIndex = 31
        Total_DueLabel.Text = "Total Due:"
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Processed_ByLabel.Location = New System.Drawing.Point(29, 286)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(88, 17)
        Processed_ByLabel.TabIndex = 33
        Processed_ByLabel.Text = "Processed By:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(382, 210)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(30, 139)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(69, 17)
        First_NameLabel.TabIndex = 39
        First_NameLabel.Text = "Full Name:"
        '
        'Car_NameLabel1
        '
        Car_NameLabel1.AutoSize = True
        Car_NameLabel1.Location = New System.Drawing.Point(764, 102)
        Car_NameLabel1.Name = "Car_NameLabel1"
        Car_NameLabel1.Size = New System.Drawing.Size(57, 13)
        Car_NameLabel1.TabIndex = 104
        Car_NameLabel1.Text = "Car Name:"
        '
        'Rent_DayLabel1
        '
        Rent_DayLabel1.AutoSize = True
        Rent_DayLabel1.Location = New System.Drawing.Point(778, 209)
        Rent_DayLabel1.Name = "Rent_DayLabel1"
        Rent_DayLabel1.Size = New System.Drawing.Size(57, 13)
        Rent_DayLabel1.TabIndex = 106
        Rent_DayLabel1.Text = "Rent/Day:"
        '
        'ColorLabel1
        '
        ColorLabel1.AutoSize = True
        ColorLabel1.Location = New System.Drawing.Point(768, 152)
        ColorLabel1.Name = "ColorLabel1"
        ColorLabel1.Size = New System.Drawing.Size(34, 13)
        ColorLabel1.TabIndex = 105
        ColorLabel1.Text = "Color:"
        '
        'Rent_DetailsDataSet
        '
        Me.Rent_DetailsDataSet.DataSetName = "Rent_DetailsDataSet"
        Me.Rent_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentBindingSource
        '
        Me.RentBindingSource.DataMember = "Rent"
        Me.RentBindingSource.DataSource = Me.Rent_DetailsDataSet
        '
        'RentTableAdapter
        '
        Me.RentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Rent_DetailsTableAdapter = Me.Rent_DetailsTableAdapter
        Me.TableAdapterManager.RentTableAdapter = Me.RentTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Rent_DetailsTableAdapter
        '
        Me.Rent_DetailsTableAdapter.ClearBeforeFill = True
        '
        'RentBindingNavigator
        '
        Me.RentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RentBindingNavigator.BindingSource = Me.RentBindingSource
        Me.RentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RentBindingNavigatorSaveItem})
        Me.RentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RentBindingNavigator.Name = "RentBindingNavigator"
        Me.RentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RentBindingNavigator.Size = New System.Drawing.Size(929, 25)
        Me.RentBindingNavigator.TabIndex = 0
        Me.RentBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RentBindingNavigatorSaveItem
        '
        Me.RentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RentBindingNavigatorSaveItem.Image = CType(resources.GetObject("RentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RentBindingNavigatorSaveItem.Name = "RentBindingNavigatorSaveItem"
        Me.RentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Rent_IDTextBox
        '
        Me.Rent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent_ID", True))
        Me.Rent_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_IDTextBox.Location = New System.Drawing.Point(124, 103)
        Me.Rent_IDTextBox.Name = "Rent_IDTextBox"
        Me.Rent_IDTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Rent_IDTextBox.TabIndex = 2
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(516, 125)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AgeTextBox.TabIndex = 8
        Me.AgeTextBox.Visible = False
        '
        'Cellphone_NoTextBox
        '
        Me.Cellphone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Cellphone_No", True))
        Me.Cellphone_NoTextBox.Location = New System.Drawing.Point(516, 151)
        Me.Cellphone_NoTextBox.Name = "Cellphone_NoTextBox"
        Me.Cellphone_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cellphone_NoTextBox.TabIndex = 10
        Me.Cellphone_NoTextBox.Visible = False
        '
        'Telephone_NoTextBox
        '
        Me.Telephone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Telephone_No", True))
        Me.Telephone_NoTextBox.Location = New System.Drawing.Point(516, 177)
        Me.Telephone_NoTextBox.Name = "Telephone_NoTextBox"
        Me.Telephone_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Telephone_NoTextBox.TabIndex = 12
        Me.Telephone_NoTextBox.Visible = False
        '
        'Street_AddressTextBox
        '
        Me.Street_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Street_Address", True))
        Me.Street_AddressTextBox.Location = New System.Drawing.Point(516, 203)
        Me.Street_AddressTextBox.Name = "Street_AddressTextBox"
        Me.Street_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Street_AddressTextBox.TabIndex = 14
        Me.Street_AddressTextBox.Visible = False
        '
        'City_TownTextBox
        '
        Me.City_TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "City/Town", True))
        Me.City_TownTextBox.Location = New System.Drawing.Point(516, 229)
        Me.City_TownTextBox.Name = "City_TownTextBox"
        Me.City_TownTextBox.Size = New System.Drawing.Size(200, 20)
        Me.City_TownTextBox.TabIndex = 16
        Me.City_TownTextBox.Visible = False
        '
        'Car_IDTextBox
        '
        Me.Car_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Car_ID", True))
        Me.Car_IDTextBox.Location = New System.Drawing.Point(500, 173)
        Me.Car_IDTextBox.Name = "Car_IDTextBox"
        Me.Car_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Car_IDTextBox.TabIndex = 18
        Me.Car_IDTextBox.Visible = False
        '
        'Car_NameTextBox
        '
        Me.Car_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Car_Name", True))
        Me.Car_NameTextBox.Location = New System.Drawing.Point(500, 199)
        Me.Car_NameTextBox.Name = "Car_NameTextBox"
        Me.Car_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Car_NameTextBox.TabIndex = 20
        Me.Car_NameTextBox.Visible = False
        '
        'Plate_NoTextBox
        '
        Me.Plate_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Plate_No", True))
        Me.Plate_NoTextBox.Location = New System.Drawing.Point(500, 225)
        Me.Plate_NoTextBox.Name = "Plate_NoTextBox"
        Me.Plate_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Plate_NoTextBox.TabIndex = 22
        Me.Plate_NoTextBox.Visible = False
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(500, 251)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ColorTextBox.TabIndex = 24
        Me.ColorTextBox.Visible = False
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(124, 163)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.DateDateTimePicker.TabIndex = 26
        '
        'Rent_DayTextBox
        '
        Me.Rent_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent/Day", True))
        Me.Rent_DayTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_DayTextBox.Location = New System.Drawing.Point(124, 193)
        Me.Rent_DayTextBox.Name = "Rent_DayTextBox"
        Me.Rent_DayTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Rent_DayTextBox.TabIndex = 28
        '
        'No_of_DaysTextBox
        '
        Me.No_of_DaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "No_of_Days", True))
        Me.No_of_DaysTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_of_DaysTextBox.Location = New System.Drawing.Point(124, 223)
        Me.No_of_DaysTextBox.Name = "No_of_DaysTextBox"
        Me.No_of_DaysTextBox.Size = New System.Drawing.Size(200, 25)
        Me.No_of_DaysTextBox.TabIndex = 30
        '
        'Total_DueTextBox
        '
        Me.Total_DueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Total_Due", True))
        Me.Total_DueTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_DueTextBox.Location = New System.Drawing.Point(124, 253)
        Me.Total_DueTextBox.Name = "Total_DueTextBox"
        Me.Total_DueTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Total_DueTextBox.TabIndex = 32
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(124, 283)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Processed_ByTextBox.TabIndex = 34
        '
        'Rent_DetailsBindingSource
        '
        Me.Rent_DetailsBindingSource.DataMember = "Rent_Rent_Details"
        Me.Rent_DetailsBindingSource.DataSource = Me.RentBindingSource
        '
        'Rent_DetailsDataGridView
        '
        Me.Rent_DetailsDataGridView.AutoGenerateColumns = False
        Me.Rent_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rent_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewImageColumn1})
        Me.Rent_DetailsDataGridView.DataSource = Me.Rent_DetailsBindingSource
        Me.Rent_DetailsDataGridView.Location = New System.Drawing.Point(363, 95)
        Me.Rent_DetailsDataGridView.Name = "Rent_DetailsDataGridView"
        Me.Rent_DetailsDataGridView.Size = New System.Drawing.Size(534, 220)
        Me.Rent_DetailsDataGridView.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RentDetails_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RentDetails_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Rent_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rent_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Car_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Car_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Plate_No"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ListOfCarsBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Plate_No"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Plate_No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "Plate_No"
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Car_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Car_Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Rent/Day"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Rent/Day"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Picture"
        Me.DataGridViewImageColumn1.HeaderText = "Picture"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(477, 207)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'First_NameComboBox
        '
        Me.First_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "First_Name", True))
        Me.First_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RentBindingSource, "First_Name", True))
        Me.First_NameComboBox.DataSource = Me.CustomerBindingSource
        Me.First_NameComboBox.DisplayMember = "First_Name"
        Me.First_NameComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameComboBox.FormattingEnabled = True
        Me.First_NameComboBox.Location = New System.Drawing.Point(124, 133)
        Me.First_NameComboBox.Name = "First_NameComboBox"
        Me.First_NameComboBox.Size = New System.Drawing.Size(200, 25)
        Me.First_NameComboBox.TabIndex = 40
        Me.First_NameComboBox.ValueMember = "First_Name"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 45)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Booking"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(936, 53)
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.button1)
        Me.groupBox3.Controls.Add(Me.button3)
        Me.groupBox3.Controls.Add(Me.button2)
        Me.groupBox3.Location = New System.Drawing.Point(518, 335)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(379, 57)
        Me.groupBox3.TabIndex = 104
        Me.groupBox3.TabStop = False
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(146, 15)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 32)
        Me.button1.TabIndex = 18
        Me.button1.Text = "SAVE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(31, 15)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(96, 32)
        Me.button3.TabIndex = 22
        Me.button3.Text = "ADD"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(254, 15)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(96, 32)
        Me.button2.TabIndex = 19
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'Car_NameComboBox
        '
        Me.Car_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rent_DetailsBindingSource, "Car_Name", True))
        Me.Car_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Rent_DetailsBindingSource, "Car_Name", True))
        Me.Car_NameComboBox.DataSource = Me.ListOfCarsBindingSource
        Me.Car_NameComboBox.DisplayMember = "Car_Name"
        Me.Car_NameComboBox.FormattingEnabled = True
        Me.Car_NameComboBox.Location = New System.Drawing.Point(762, 99)
        Me.Car_NameComboBox.Name = "Car_NameComboBox"
        Me.Car_NameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Car_NameComboBox.TabIndex = 105
        Me.Car_NameComboBox.ValueMember = "Car_Name"
        '
        'Rent_DayComboBox
        '
        Me.Rent_DayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rent_DetailsBindingSource, "Rent/Day", True))
        Me.Rent_DayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Rent_DetailsBindingSource, "Rent/Day", True))
        Me.Rent_DayComboBox.DataSource = Me.ListOfCarsBindingSource
        Me.Rent_DayComboBox.DisplayMember = "Rent/Day"
        Me.Rent_DayComboBox.FormattingEnabled = True
        Me.Rent_DayComboBox.Location = New System.Drawing.Point(776, 206)
        Me.Rent_DayComboBox.Name = "Rent_DayComboBox"
        Me.Rent_DayComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Rent_DayComboBox.TabIndex = 107
        Me.Rent_DayComboBox.ValueMember = "Rent/Day"
        '
        'ColorComboBox
        '
        Me.ColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Rent_DetailsBindingSource, "Color", True))
        Me.ColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Rent_DetailsBindingSource, "Color", True))
        Me.ColorComboBox.DataSource = Me.ListOfCarsBindingSource
        Me.ColorComboBox.DisplayMember = "Color"
        Me.ColorComboBox.FormattingEnabled = True
        Me.ColorComboBox.Location = New System.Drawing.Point(743, 149)
        Me.ColorComboBox.Name = "ColorComboBox"
        Me.ColorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ColorComboBox.TabIndex = 106
        Me.ColorComboBox.ValueMember = "Color"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(346, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 253)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 253)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(929, 404)
        Me.Controls.Add(Me.Rent_DetailsDataGridView)
        Me.Controls.Add(Rent_DayLabel1)
        Me.Controls.Add(Me.Rent_DayComboBox)
        Me.Controls.Add(ColorLabel1)
        Me.Controls.Add(Me.ColorComboBox)
        Me.Controls.Add(Car_NameLabel1)
        Me.Controls.Add(Me.Car_NameComboBox)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameComboBox)
        Me.Controls.Add(Rent_IDLabel)
        Me.Controls.Add(Me.Rent_IDTextBox)
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
        Me.Controls.Add(ColorLabel)
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
        Me.Controls.Add(Me.RentBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentBindingNavigator.ResumeLayout(False)
        Me.RentBindingNavigator.PerformLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rent_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rent_DetailsDataSet As FinalCarRentalSystem.Rent_DetailsDataSet
    Friend WithEvents RentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rent_IDTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Rent_DetailsTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents Rent_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rent_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerDataSet As FinalCarRentalSystem.CustomerDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents Car_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Rent_DayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
