<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking1
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
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rent_DetailsDataSet = New FinalCarRentalSystem.Rent_DetailsDataSet
        Me.RentTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
        Me.TableAdapterManager = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
        Me.Rent_DetailsTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
        Me.Rent_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListOfCarsDataSet
        '
        Me.ListOfCarsDataSet.DataSetName = "ListOfCarsDataSet"
        Me.ListOfCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListOfCarsBindingSource
        '
        Me.ListOfCarsBindingSource.DataMember = "ListOfCars"
        Me.ListOfCarsBindingSource.DataSource = Me.ListOfCarsDataSet
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
        'Rent_DetailsDataSet
        '
        Me.Rent_DetailsDataSet.DataSetName = "Rent_DetailsDataSet"
        Me.Rent_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Rent_DetailsBindingSource
        '
        Me.Rent_DetailsBindingSource.DataMember = "Rent_Rent_Details"
        Me.Rent_DetailsBindingSource.DataSource = Me.RentBindingSource
        '
        'Booking1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 523)
        Me.Name = "Booking1"
        Me.Text = "Booking1"
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rent_DetailsDataSet As FinalCarRentalSystem.Rent_DetailsDataSet
    Friend WithEvents RentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Rent_DetailsTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents Rent_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
End Class
