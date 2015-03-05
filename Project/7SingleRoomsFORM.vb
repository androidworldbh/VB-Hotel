Public Class _7SingleRoomsFORM
    Public price As Decimal = 25
    Public total As Decimal
    Public totalwd As Decimal

    Public nights As Integer

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub _7SingleRoomsFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "Room 101"
        Button2.Text = "Room 102"
        Button3.Text = "Room 103"
        Button4.Text = "Room 104"
        Button5.Text = "Room 105"
        Button6.Text = "Room 106"
        Button7.Text = "Room 107"
        Button8.Text = "Room 108"
        Button9.Text = "Room 109"
        Button10.Text = "Room 110"


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
        _5PringFORM.Label17.Text = "101"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "101"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 101")
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
        _5PringFORM.Label17.Text = "102"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "102"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 102")
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
        _5PringFORM.Label17.Text = "103"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "103"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 103")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
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
        _5PringFORM.Label17.Text = "110"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "110"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 110")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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
        _5PringFORM.Label17.Text = "107"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "107"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 107")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
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
        _5PringFORM.Label17.Text = "108"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "108"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 108")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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
        _5PringFORM.Label17.Text = "109"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "109"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 109")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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
        _5PringFORM.Label17.Text = "106"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "106"
        NCustomerFORM.Room_TypeTextBox.Text = "Single"
        MsgBox("You Chosen Room 106")
        NCustomerFORM.Show()
        Me.Close()
    End Sub
End Class