Public Class _5PringFORM

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub _5PringFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label2.Text = " " + NCustomerFORM.Full_NameTextBox.Text
        Label4.Text = " " + NCustomerFORM.TelephoneTextBox.Text
        Label5.Text = " " + NCustomerFORM.E_Mail_AddressMaskedTextBox.Text
        Label7.Text = " " + NCustomerFORM.Arrival_DateDateTimePicker.Value
        Label8.Text = " " + NCustomerFORM.Departure_DateDateTimePicker.Value
        Label23.Text = " " + NCustomerFORM.NightsTextBox.Text
        Label19.Text = " " + NCustomerFORM.Total_PaymentTextBox.Text
        Label17.Text = " " + NCustomerFORM.Room_No_TextBox.Text



    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.Print()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        NCustomerFORM.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label17.Text = ""
        Label19.Text = ""
        Label23.Text = ""
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Res_TableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Res_TableButton.Click
        _6ReservationsFORM.Show()

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _6ReservationsFORM.Table2BindingSource.AddNew()
        '  _6ReservationsFORM.Full_NameTextBox.Text = Label2.Text
        ' _6ReservationsFORM.Payment_MethodTextBox.Text = Label3.Text
        '_6ReservationsFORM.TelephoneTextBox.Text = Label4.Text

    End Sub
End Class