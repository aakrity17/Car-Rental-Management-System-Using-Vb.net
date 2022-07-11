Public Class Booking1

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Booking1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent_Details' table. You can move, or remove it, as needed.
        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent' table. You can move, or remove it, as needed.
        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)

    End Sub


End Class