Public Class Booking

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentDataSet)

    End Sub

    Private Sub Booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        'TODO: This line of code loads data into the 'ListOfCarsDataSet.ListOfCars' table. You can move, or remove it, as needed.
        Me.ListOfCarsTableAdapter.Fill(Me.ListOfCarsDataSet.ListOfCars)
        'TODO: This line of code loads data into the 'RentDataSet.Rent' table. You can move, or remove it, as needed.
        Me.RentTableAdapter.Fill(Me.RentDataSet.Rent)

       


    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

    End Sub

    Private Sub No_of_DaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Total_DueTextBox.Text = Val(No_of_DaysTextBox.Text) * Val(Rent_DayTextBox.Text)
    End Sub

    Private Sub Total_DueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rent_DayTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Car_NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Car_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Plate_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  If Plate_NoTextBox.Text = "" Then
        'Return
        'Else
        'Me.ListOfCarsTableAdapter.FillBy(Me.ListOfCarsDataSet.ListOfCars, Plate_NoTextBox.Text)
        'End If
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BindingNavigatorAddNewItem.PerformClick()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.RentTableAdapter.FillBy(Me.RentDataSet.Rent)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class