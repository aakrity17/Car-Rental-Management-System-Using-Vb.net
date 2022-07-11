Public Class Form2

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)
        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent_Details' table. You can move, or remove it, as needed.
        Me.Rent_DetailsTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent_Details)
        'TODO: This line of code loads data into the 'Rent_DetailsDataSet.Rent' table. You can move, or remove it, as needed.
        Me.RentTableAdapter.Fill(Me.Rent_DetailsDataSet.Rent)

    End Sub

    Private Sub No_of_DaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_of_DaysTextBox.TextChanged
        Total_DueTextBox.Text = Val(Rent_DayTextBox.Text) * Val(No_of_DaysTextBox.Text)
    End Sub

    Private Sub Total_DueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total_DueTextBox.TextChanged

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        BindingNavigatorAddNewItem.PerformClick()


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Rent_DetailsDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Hide()
    End Sub
End Class
