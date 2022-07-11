<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturn
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
        Dim Return_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Car_IDLabel As System.Windows.Forms.Label
        Dim Car_NameLabel As System.Windows.Forms.Label
        Dim Plate_NoLabel As System.Windows.Forms.Label
        Dim Date_BorrowedLabel As System.Windows.Forms.Label
        Dim Date_ReturnedLabel As System.Windows.Forms.Label
        Dim Processed_ByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturn))
        Me.ReturnBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnDataSet = New FinalCarRentalSystem.ReturnDataSet
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
        Me.ReturnBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Return_IDTextBox = New System.Windows.Forms.TextBox
        Me.First_NameTextBox = New System.Windows.Forms.TextBox
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox
        Me.Car_IDTextBox = New System.Windows.Forms.TextBox
        Me.Car_NameTextBox = New System.Windows.Forms.TextBox
        Me.Plate_NoTextBox = New System.Windows.Forms.TextBox
        Me.Date_BorrowedDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Date_ReturnedDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Processed_ByTextBox = New System.Windows.Forms.TextBox
        Me.ReturnTableAdapter = New FinalCarRentalSystem.ReturnDataSetTableAdapters.ReturnTableAdapter
        Me.TableAdapterManager = New FinalCarRentalSystem.ReturnDataSetTableAdapters.TableAdapterManager
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.button1 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Return_IDLabel = New System.Windows.Forms.Label
        First_NameLabel = New System.Windows.Forms.Label
        Last_NameLabel = New System.Windows.Forms.Label
        Car_IDLabel = New System.Windows.Forms.Label
        Car_NameLabel = New System.Windows.Forms.Label
        Plate_NoLabel = New System.Windows.Forms.Label
        Date_BorrowedLabel = New System.Windows.Forms.Label
        Date_ReturnedLabel = New System.Windows.Forms.Label
        Processed_ByLabel = New System.Windows.Forms.Label
        CType(Me.ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReturnBindingNavigator.SuspendLayout()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Return_IDLabel
        '
        Return_IDLabel.AutoSize = True
        Return_IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Return_IDLabel.Location = New System.Drawing.Point(60, 74)
        Return_IDLabel.Name = "Return_IDLabel"
        Return_IDLabel.Size = New System.Drawing.Size(79, 21)
        Return_IDLabel.TabIndex = 1
        Return_IDLabel.Text = "Return ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(60, 104)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(89, 21)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(60, 137)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(87, 21)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Car_IDLabel
        '
        Car_IDLabel.AutoSize = True
        Car_IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_IDLabel.Location = New System.Drawing.Point(60, 170)
        Car_IDLabel.Name = "Car_IDLabel"
        Car_IDLabel.Size = New System.Drawing.Size(56, 21)
        Car_IDLabel.TabIndex = 7
        Car_IDLabel.Text = "Car ID:"
        '
        'Car_NameLabel
        '
        Car_NameLabel.AutoSize = True
        Car_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_NameLabel.Location = New System.Drawing.Point(60, 203)
        Car_NameLabel.Name = "Car_NameLabel"
        Car_NameLabel.Size = New System.Drawing.Size(83, 21)
        Car_NameLabel.TabIndex = 9
        Car_NameLabel.Text = "Car Name:"
        '
        'Plate_NoLabel
        '
        Plate_NoLabel.AutoSize = True
        Plate_NoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plate_NoLabel.Location = New System.Drawing.Point(60, 236)
        Plate_NoLabel.Name = "Plate_NoLabel"
        Plate_NoLabel.Size = New System.Drawing.Size(72, 21)
        Plate_NoLabel.TabIndex = 11
        Plate_NoLabel.Text = "Plate No:"
        '
        'Date_BorrowedLabel
        '
        Date_BorrowedLabel.AutoSize = True
        Date_BorrowedLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_BorrowedLabel.Location = New System.Drawing.Point(60, 270)
        Date_BorrowedLabel.Name = "Date_BorrowedLabel"
        Date_BorrowedLabel.Size = New System.Drawing.Size(117, 21)
        Date_BorrowedLabel.TabIndex = 13
        Date_BorrowedLabel.Text = "Date Borrowed:"
        '
        'Date_ReturnedLabel
        '
        Date_ReturnedLabel.AutoSize = True
        Date_ReturnedLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_ReturnedLabel.Location = New System.Drawing.Point(60, 303)
        Date_ReturnedLabel.Name = "Date_ReturnedLabel"
        Date_ReturnedLabel.Size = New System.Drawing.Size(113, 21)
        Date_ReturnedLabel.TabIndex = 15
        Date_ReturnedLabel.Text = "Date Returned:"
        '
        'Processed_ByLabel
        '
        Processed_ByLabel.AutoSize = True
        Processed_ByLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Processed_ByLabel.Location = New System.Drawing.Point(60, 335)
        Processed_ByLabel.Name = "Processed_ByLabel"
        Processed_ByLabel.Size = New System.Drawing.Size(104, 21)
        Processed_ByLabel.TabIndex = 17
        Processed_ByLabel.Text = "Processed By:"
        '
        'ReturnBindingNavigator
        '
        Me.ReturnBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReturnBindingNavigator.BindingSource = Me.ReturnBindingSource
        Me.ReturnBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReturnBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReturnBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReturnBindingNavigatorSaveItem})
        Me.ReturnBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReturnBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReturnBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReturnBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReturnBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReturnBindingNavigator.Name = "ReturnBindingNavigator"
        Me.ReturnBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReturnBindingNavigator.Size = New System.Drawing.Size(450, 25)
        Me.ReturnBindingNavigator.TabIndex = 0
        Me.ReturnBindingNavigator.Text = "BindingNavigator1"
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
        'ReturnBindingSource
        '
        Me.ReturnBindingSource.DataMember = "Return"
        Me.ReturnBindingSource.DataSource = Me.ReturnDataSet
        '
        'ReturnDataSet
        '
        Me.ReturnDataSet.DataSetName = "ReturnDataSet"
        Me.ReturnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ReturnBindingNavigatorSaveItem
        '
        Me.ReturnBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReturnBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReturnBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReturnBindingNavigatorSaveItem.Name = "ReturnBindingNavigatorSaveItem"
        Me.ReturnBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReturnBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Return_IDTextBox
        '
        Me.Return_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Return_ID", True))
        Me.Return_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Return_IDTextBox.Location = New System.Drawing.Point(182, 70)
        Me.Return_IDTextBox.Name = "Return_IDTextBox"
        Me.Return_IDTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Return_IDTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(182, 104)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(182, 137)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Car_IDTextBox
        '
        Me.Car_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Car_ID", True))
        Me.Car_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_IDTextBox.Location = New System.Drawing.Point(182, 170)
        Me.Car_IDTextBox.Name = "Car_IDTextBox"
        Me.Car_IDTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Car_IDTextBox.TabIndex = 8
        '
        'Car_NameTextBox
        '
        Me.Car_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Car_Name", True))
        Me.Car_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_NameTextBox.Location = New System.Drawing.Point(182, 203)
        Me.Car_NameTextBox.Name = "Car_NameTextBox"
        Me.Car_NameTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Car_NameTextBox.TabIndex = 10
        '
        'Plate_NoTextBox
        '
        Me.Plate_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Plate_No", True))
        Me.Plate_NoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plate_NoTextBox.Location = New System.Drawing.Point(182, 236)
        Me.Plate_NoTextBox.Name = "Plate_NoTextBox"
        Me.Plate_NoTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Plate_NoTextBox.TabIndex = 12
        '
        'Date_BorrowedDateTimePicker
        '
        Me.Date_BorrowedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReturnBindingSource, "Date_Borrowed", True))
        Me.Date_BorrowedDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_BorrowedDateTimePicker.Location = New System.Drawing.Point(182, 269)
        Me.Date_BorrowedDateTimePicker.Name = "Date_BorrowedDateTimePicker"
        Me.Date_BorrowedDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Date_BorrowedDateTimePicker.TabIndex = 14
        '
        'Date_ReturnedDateTimePicker
        '
        Me.Date_ReturnedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReturnBindingSource, "Date_Returned", True))
        Me.Date_ReturnedDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_ReturnedDateTimePicker.Location = New System.Drawing.Point(182, 302)
        Me.Date_ReturnedDateTimePicker.Name = "Date_ReturnedDateTimePicker"
        Me.Date_ReturnedDateTimePicker.Size = New System.Drawing.Size(200, 29)
        Me.Date_ReturnedDateTimePicker.TabIndex = 16
        '
        'Processed_ByTextBox
        '
        Me.Processed_ByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReturnBindingSource, "Processed_By", True))
        Me.Processed_ByTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processed_ByTextBox.Location = New System.Drawing.Point(182, 335)
        Me.Processed_ByTextBox.Name = "Processed_ByTextBox"
        Me.Processed_ByTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Processed_ByTextBox.TabIndex = 18
        '
        'ReturnTableAdapter
        '
        Me.ReturnTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ReturnTableAdapter = Me.ReturnTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.ReturnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.button1)
        Me.groupBox3.Controls.Add(Me.button3)
        Me.groupBox3.Controls.Add(Me.button2)
        Me.groupBox3.Location = New System.Drawing.Point(40, 386)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(379, 57)
        Me.groupBox3.TabIndex = 84
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(450, 53)
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 45)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Returning"
        '
        'frmReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 469)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Return_IDLabel)
        Me.Controls.Add(Me.Return_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Car_IDLabel)
        Me.Controls.Add(Me.Car_IDTextBox)
        Me.Controls.Add(Car_NameLabel)
        Me.Controls.Add(Me.Car_NameTextBox)
        Me.Controls.Add(Plate_NoLabel)
        Me.Controls.Add(Me.Plate_NoTextBox)
        Me.Controls.Add(Date_BorrowedLabel)
        Me.Controls.Add(Me.Date_BorrowedDateTimePicker)
        Me.Controls.Add(Date_ReturnedLabel)
        Me.Controls.Add(Me.Date_ReturnedDateTimePicker)
        Me.Controls.Add(Processed_ByLabel)
        Me.Controls.Add(Me.Processed_ByTextBox)
        Me.Controls.Add(Me.ReturnBindingNavigator)
        Me.Name = "frmReturn"
        Me.Text = "frmReturn"
        CType(Me.ReturnBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReturnBindingNavigator.ResumeLayout(False)
        Me.ReturnBindingNavigator.PerformLayout()
        CType(Me.ReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReturnDataSet As FinalCarRentalSystem.ReturnDataSet
    Friend WithEvents ReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnTableAdapter As FinalCarRentalSystem.ReturnDataSetTableAdapters.ReturnTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.ReturnDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReturnBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReturnBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Return_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Car_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Car_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plate_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_BorrowedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_ReturnedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Processed_ByTextBox As System.Windows.Forms.TextBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
