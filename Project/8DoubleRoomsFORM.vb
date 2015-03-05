Public Class _8DoubleRoomsFORM
    Public price As Decimal = 50
    Public total As Decimal
    Public nights As Integer
    Private Sub _8DoubleRoomsFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Text = "Room 111"
        Button2.Text = "Room 112"
    
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        NCustomerFORM.Show()
        Me.Close()
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
        _5PringFORM.Label17.Text = "111"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "111"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 111")
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
        _5PringFORM.Label17.Text = "112"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "112"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 112")
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
        _5PringFORM.Label17.Text = "113"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "113"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 113")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
        _5PringFORM.Label17.Text = "114"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "114"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 114")
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
        _5PringFORM.Label17.Text = "115"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "115"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 115")
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
        _5PringFORM.Label17.Text = "116"
        NCustomerFORM.Total_PaymentTextBox.Text = total.ToString("C2")
        NCustomerFORM.Room_No_TextBox.Text = "116"
        NCustomerFORM.Room_TypeTextBox.Text = "Double"
        MsgBox("You Chosen Room 116")
        NCustomerFORM.Show()
        Me.Close()
    End Sub
End Class