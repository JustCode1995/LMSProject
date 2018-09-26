Public Class Form1
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDataSet)

    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.LMSDataSet.Student)
        Me.StudentTableAdapter.GetDataBy1()

    End Sub


End Class