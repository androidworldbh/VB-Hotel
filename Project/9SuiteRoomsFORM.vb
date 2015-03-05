Public Class _9SuiteRoomsFORM
    Public price As Decimal = 500
    Public total As Decimal
    Public nights As Integer
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub _9SuiteRoomsFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "Suite 01"
        Button2.Text = "Suite 02"
        Button3.Text = "Suite 03"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NCustomerFORM.CashRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "CASH"
        ElseIf NCustomerFORM.MasterCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "MasterCard"
        ElseIf NCustomerFORM.VisaCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "VisaCard"
        Else : MsgBox("Please Choose A Payment Method", MsgBoxStyle.OkOnly)

        End If


        nights = Integer.Parse(NCustomerFORM.NightsTextBox.Text)
        total = price * nights

        _5PringFORM.Label19.Text = total.ToString("C2")
        _5PringFORM.Label17.Text = "Suite 01"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "01"
        NCustomerFORM.Room_TypeTextBox.Text = "Suite"
        MsgBox("You Chosen Room Suite 1")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If NCustomerFORM.CashRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "CASH"
        ElseIf NCustomerFORM.MasterCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "MasterCard"
        ElseIf NCustomerFORM.VisaCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "VisaCard"
        Else : MsgBox("Please Choose A Payment Method", MsgBoxStyle.OkOnly)

        End If


        nights = Integer.Parse(NCustomerFORM.NightsTextBox.Text)
        total = price * nights

        _5PringFORM.Label19.Text = total.ToString("C2")
        _5PringFORM.Label17.Text = "Suite 02"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "02"
        NCustomerFORM.Room_TypeTextBox.Text = "Suite"
        MsgBox("You Chosen Room Suite 2")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If NCustomerFORM.CashRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "CASH"
        ElseIf NCustomerFORM.MasterCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "MasterCard"
        ElseIf NCustomerFORM.VisaCardRadioButton.Checked = True Then
            NCustomerFORM.Payment_MethodTextBox.Text = "VisaCard"
        Else : MsgBox("Please Choose A Payment Method", MsgBoxStyle.OkOnly)

        End If


        nights = Integer.Parse(NCustomerFORM.NightsTextBox.Text)
        total = price * nights

        _5PringFORM.Label19.Text = total.ToString("C2")
        _5PringFORM.Label17.Text = "Suite 03"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "03"
        NCustomerFORM.Room_TypeTextBox.Text = "Suite"
        MsgBox("You Chosen Room Suite 3")
        NCustomerFORM.Show()
        Me.Close()
    End Sub
End Class