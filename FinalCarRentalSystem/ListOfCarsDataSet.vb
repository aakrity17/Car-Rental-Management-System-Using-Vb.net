Partial Class ListOfCarsDataSet
    Partial Public Class ListOfCarsDataTable
        Private Sub ListOfCarsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me._Rent_DayColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
