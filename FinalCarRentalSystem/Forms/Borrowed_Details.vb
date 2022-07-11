Public Class Borrowed_Details

    Private Sub RentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RentDataSet)

    End Sub

    Private Sub Borrowed_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RentDataSet.Rent' table. You can move, or remove it, as needed.
        Me.RentTableAdapter.Fill(Me.RentDataSet.Rent)

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub groupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class