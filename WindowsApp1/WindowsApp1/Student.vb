Public Class Student
    Private Sub Student1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Student1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Student1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDBDataSet.Student1' table. You can move, or remove it, as needed.
        Me.Student1TableAdapter.Fill(Me.LMSDBDataSet.Student1)

    End Sub
End Class