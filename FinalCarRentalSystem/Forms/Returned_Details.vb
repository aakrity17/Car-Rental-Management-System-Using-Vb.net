Public Class Returned_Details

    Private Sub ReturnBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)

    End Sub

    Private Sub Returned_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReturnDataSet._Return' table. You can move, or remove it, as needed.
        Me.ReturnTableAdapter.Fill(Me.ReturnDataSet._Return)

    End Sub

    Private Sub button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReturn.Show()

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Street_AddressLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Rent_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rent_IDTextBox.TextChanged

    End Sub

    Private Sub button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click
        Me.Validate()
        Me.ReturnBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnDataSet)
        MessageBox.Show("Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class