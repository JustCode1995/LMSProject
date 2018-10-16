Public Class Admin
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDBDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.StudentTableAdapter.Insert(txtStudentID.Text, txtFname.Text, txtLname.Text, dateDOB.Value.ToString)
        MsgBox("Success")
        txtStudentID.Clear()
        txtFname.Clear()
        txtLname.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.StudentTableAdapter.Fill(Me.LMSDBDataSet.Student) 'Fills Student Table

    End Sub
End Class