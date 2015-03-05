Public Class _10GymFORM

    Private Sub GymBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GymBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GymDataSet)

    End Sub

    Private Sub _10GymFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GymDataSet.Gym2' table. You can move, or remove it, as needed.
        'Me.Gym2TableAdapter.Fill(Me.GymDataSet.Gym2)
        'TODO: This line of code loads data into the 'GymDataSet.Gym' table. You can move, or remove it, as needed.
        'Me.GymTableAdapter.Fill(Me.GymDataSet.Gym)
        
        IDTextBox.Enabled = False
        FirstNameTextBox.Enabled = False
        LastNameTextBox.Enabled = False
        RegDateDateTimePicker.Enabled = False
        ExpiredDateDateTimePicker.Enabled = False
        TotalPaymentTextBox.Enabled = False

       



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Me.Validate()
        MsgBox("UPDATED")
        Me.TableAdapterManager.UpdateAll(Me.GymDataSet)
        Dim row As DataRow
        row = GymDataSet.Gym2.NewRow
        row("FirstName") = FirstNameTextBox.Text


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Gym2BindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Gym2BindingSource.RemoveCurrent()

    End Sub

    Private Sub EnableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableButton.Click
        Me.Gym2TableAdapter.Fill(Me.GymDataSet.Gym2)
        Gym2BindingSource.AddNew()

        IDTextBox.Enabled = True
        FirstNameTextBox.Enabled = True
        LastNameTextBox.Enabled = True
        RegDateDateTimePicker.Enabled = True
        ExpiredDateDateTimePicker.Enabled = True
        TotalPaymentTextBox.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        

        _3MAIN_FORM.Show()
        Me.Hide()


    End Sub

    Private Sub CalcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        Dim x As Integer
        Dim total As Decimal
        Dim price As Decimal = 1.6

        x = Integer.Parse(PeriodTextBox.Text)
        total = x * price
        TotalPaymentTextBox.Text = total
    End Sub
End Class