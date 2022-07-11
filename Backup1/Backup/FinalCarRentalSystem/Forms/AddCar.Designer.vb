<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCar
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
        Dim Car_IDLabel As System.Windows.Forms.Label
        Dim Plate_NoLabel As System.Windows.Forms.Label
        Dim Car_NameLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Rent_DayLabel As System.Windows.Forms.Label
        Dim PictureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCar))
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.button4 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.ListOfCarsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet
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
        Me.ListOfCarsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Car_IDTextBox = New System.Windows.Forms.TextBox
        Me.Plate_NoTextBox = New System.Windows.Forms.TextBox
        Me.Car_NameTextBox = New System.Windows.Forms.TextBox
        Me.ColorTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.Rent_DayTextBox = New System.Windows.Forms.TextBox
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
        Me.TableAdapterManager = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Car_IDLabel = New System.Windows.Forms.Label
        Plate_NoLabel = New System.Windows.Forms.Label
        Car_NameLabel = New System.Windows.Forms.Label
        ColorLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        Rent_DayLabel = New System.Windows.Forms.Label
        PictureLabel = New System.Windows.Forms.Label
        Me.groupBox2.SuspendLayout()
        CType(Me.ListOfCarsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListOfCarsBindingNavigator.SuspendLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car_IDLabel
        '
        Car_IDLabel.AutoSize = True
        Car_IDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_IDLabel.Location = New System.Drawing.Point(82, 82)
        Car_IDLabel.Name = "Car_IDLabel"
        Car_IDLabel.Size = New System.Drawing.Size(47, 17)
        Car_IDLabel.TabIndex = 85
        Car_IDLabel.Text = "Car ID:"
        '
        'Plate_NoLabel
        '
        Plate_NoLabel.AutoSize = True
        Plate_NoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plate_NoLabel.Location = New System.Drawing.Point(82, 108)
        Plate_NoLabel.Name = "Plate_NoLabel"
        Plate_NoLabel.Size = New System.Drawing.Size(61, 17)
        Plate_NoLabel.TabIndex = 87
        Plate_NoLabel.Text = "Plate No:"
        '
        'Car_NameLabel
        '
        Car_NameLabel.AutoSize = True
        Car_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_NameLabel.Location = New System.Drawing.Point(82, 134)
        Car_NameLabel.Name = "Car_NameLabel"
        Car_NameLabel.Size = New System.Drawing.Size(70, 17)
        Car_NameLabel.TabIndex = 89
        Car_NameLabel.Text = "Car Name:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(82, 160)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(43, 17)
        ColorLabel.TabIndex = 91
        ColorLabel.Text = "Color:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(82, 186)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(59, 17)
        QuantityLabel.TabIndex = 93
        QuantityLabel.Text = "Quantity:"
        '
        'Rent_DayLabel
        '
        Rent_DayLabel.AutoSize = True
        Rent_DayLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_DayLabel.Location = New System.Drawing.Point(82, 212)
        Rent_DayLabel.Name = "Rent_DayLabel"
        Rent_DayLabel.Size = New System.Drawing.Size(64, 17)
        Rent_DayLabel.TabIndex = 95
        Rent_DayLabel.Text = "Rent/Day:"
        '
        'PictureLabel
        '
        PictureLabel.AutoSize = True
        PictureLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PictureLabel.Location = New System.Drawing.Point(82, 247)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New System.Drawing.Size(50, 17)
        PictureLabel.TabIndex = 96
        PictureLabel.Text = "Picture:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Button5)
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Controls.Add(Me.button1)
        Me.groupBox2.Location = New System.Drawing.Point(29, 426)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(401, 57)
        Me.groupBox2.TabIndex = 84
        Me.groupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(10, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 32)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(209, 16)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(82, 32)
        Me.button4.TabIndex = 34
        Me.button4.Text = "CLEAR ALL"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(306, 16)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(82, 32)
        Me.button2.TabIndex = 33
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(109, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(82, 32)
        Me.button1.TabIndex = 32
        Me.button1.Text = "SAVE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'ListOfCarsBindingNavigator
        '
        Me.ListOfCarsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListOfCarsBindingNavigator.BindingSource = Me.ListOfCarsBindingSource
        Me.ListOfCarsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListOfCarsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListOfCarsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListOfCarsBindingNavigatorSaveItem})
        Me.ListOfCarsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListOfCarsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListOfCarsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListOfCarsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListOfCarsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListOfCarsBindingNavigator.Name = "ListOfCarsBindingNavigator"
        Me.ListOfCarsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListOfCarsBindingNavigator.Size = New System.Drawing.Size(463, 25)
        Me.ListOfCarsBindingNavigator.TabIndex = 85
        Me.ListOfCarsBindingNavigator.Text = "BindingNavigator1"
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
        'ListOfCarsBindingNavigatorSaveItem
        '
        Me.ListOfCarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListOfCarsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListOfCarsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListOfCarsBindingNavigatorSaveItem.Name = "ListOfCarsBindingNavigatorSaveItem"
        Me.ListOfCarsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListOfCarsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Car_IDTextBox
        '
        Me.Car_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_ID", True))
        Me.Car_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_IDTextBox.Location = New System.Drawing.Point(154, 79)
        Me.Car_IDTextBox.Name = "Car_IDTextBox"
        Me.Car_IDTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Car_IDTextBox.TabIndex = 86
        '
        'Plate_NoTextBox
        '
        Me.Plate_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Plate_No", True))
        Me.Plate_NoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plate_NoTextBox.Location = New System.Drawing.Point(154, 105)
        Me.Plate_NoTextBox.Name = "Plate_NoTextBox"
        Me.Plate_NoTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Plate_NoTextBox.TabIndex = 88
        '
        'Car_NameTextBox
        '
        Me.Car_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_Name", True))
        Me.Car_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_NameTextBox.Location = New System.Drawing.Point(154, 131)
        Me.Car_NameTextBox.Name = "Car_NameTextBox"
        Me.Car_NameTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Car_NameTextBox.TabIndex = 90
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Color", True))
        Me.ColorTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTextBox.Location = New System.Drawing.Point(154, 157)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(206, 25)
        Me.ColorTextBox.TabIndex = 92
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(154, 183)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(206, 25)
        Me.QuantityTextBox.TabIndex = 94
        '
        'Rent_DayTextBox
        '
        Me.Rent_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Rent/Day", True))
        Me.Rent_DayTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_DayTextBox.Location = New System.Drawing.Point(154, 209)
        Me.Rent_DayTextBox.Name = "Rent_DayTextBox"
        Me.Rent_DayTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Rent_DayTextBox.TabIndex = 96
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ListOfCarsBindingSource, "Picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(154, 247)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(206, 130)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 97
        Me.PicturePictureBox.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(210, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 26)
        Me.Button3.TabIndex = 98
        Me.Button3.Text = "Upload"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(29, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 363)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ListOfCarsTableAdapter = Me.ListOfCarsTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 45)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Add Car"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.PictureBox2.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(463, 53)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'AddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(463, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(PictureLabel)
        Me.Controls.Add(Me.PicturePictureBox)
        Me.Controls.Add(Car_IDLabel)
        Me.Controls.Add(Me.Car_IDTextBox)
        Me.Controls.Add(Plate_NoLabel)
        Me.Controls.Add(Me.Plate_NoTextBox)
        Me.Controls.Add(Car_NameLabel)
        Me.Controls.Add(Me.Car_NameTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Rent_DayLabel)
        Me.Controls.Add(Me.Rent_DayTextBox)
        Me.Controls.Add(Me.ListOfCarsBindingNavigator)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddCar"
        Me.Text = "Add Car"
        Me.groupBox2.ResumeLayout(False)
        CType(Me.ListOfCarsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListOfCarsBindingNavigator.ResumeLayout(False)
        Me.ListOfCarsBindingNavigator.PerformLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListOfCarsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ListOfCarsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Car_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Plate_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Car_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rent_DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
