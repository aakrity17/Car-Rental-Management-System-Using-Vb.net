Public Class Form1

    Private Sub Rent_DetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rent_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Rent_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent' table. You can move, or remove it, as needed.

        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent_Details' table. You can move, or remove it, as needed.

        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)
    End Sub

    Private Sub Rent_DetailsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rent_DetailsBindingNavigator.RefreshItems

    End Sub
End Class