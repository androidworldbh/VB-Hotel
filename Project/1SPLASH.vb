Public Class SPLASH

    Private Sub SPLASH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        LOGIN_FORM.Show()
        Me.Hide()

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        LOGIN_FORM.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomerTableBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SPLASH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewCustomerDataSet.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.NewCustomerDataSet.CustomerTable)

    End Sub
End Class
