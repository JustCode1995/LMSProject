Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.StudentTableAdapter.Insert(txtStudentID.Text, txtFname.Text, txtLname.Text, "12/12/12")
        MsgBox("Success")
        txtStudentID.Clear()
        txtFname.Clear()
        txtLname.Clear()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.StudentTableAdapter.Fill(Me.LMSDataSet.Student) 'Fills Student Table
        Me.StudentTableAdapter.GetDataBy1()


    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        'Me.StudentTableAdapter.Fill(Me.LMSDataSet.Student)

    End Sub
End Class
