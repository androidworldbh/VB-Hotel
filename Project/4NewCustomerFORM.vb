Public Class NCustomerFORM
    Public nn As Integer
    Public fname As String

    Private Sub NewCustomerFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewCustomerDataSet.CustomerTable' table. You can move, or remove it, as needed.
        'Me.CustomerTableTableAdapter.Fill(Me.NewCustomerDataSet.CustomerTable)
        Full_NameTextBox.Enabled = False
        TelephoneTextBox.Enabled = False
        E_Mail_AddressMaskedTextBox.Enabled = False
        Arrival_DateDateTimePicker.Enabled = False
        Departure_DateDateTimePicker.Enabled = False
        NightsTextBox.Enabled = False
        Total_PaymentTextBox.Enabled = False
        Room_No_TextBox.Enabled = False
        Room_TypeTextBox.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
       

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub SuitCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuiteCheckBox.CheckedChanged

    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        _3MAIN_FORM.Show()
        Me.Close()

    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        Dim found As Boolean = True
        If MsgBox("Please, Make Sure You Add The Customer To The DataBase Before Making An Invoice And Save", MsgBoxStyle.YesNo, "Continue Confirmation") = MsgBoxResult.Yes Then
            _5PringFORM.Show()
            Me.Hide()

        End If



        If CashRadioButton.Checked = True Then
            _5PringFORM.Label3.Text = " " + "Cash"
        ElseIf MasterCardRadioButton.Checked = True Then
            _5PringFORM.Label3.Text = " " + " MasterCard"
        ElseIf VisaCardRadioButton.Checked = True Then
            _5PringFORM.Label3.Text = " " + "VisaCard"
        End If

        If SingleCheckBox.Checked = True Then
            _5PringFORM.Label6.Text = " " + "Single Room"
        ElseIf DoubleCheckBox.Checked = True Then
            _5PringFORM.Label6.Text = " " + "Double Room"
        ElseIf SuiteCheckBox.Checked = True Then
            _5PringFORM.Label6.Text = " " + "Suite Room"
        End If



    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

        If CashRadioButton.Checked = True Then
            MasterCardRadioButton.Checked = False
            VisaCardRadioButton.Checked = False
        End If

        If MasterCardRadioButton.Checked = True Then
            CashRadioButton.Checked = False
            VisaCardRadioButton.Checked = False
        End If

        If VisaCardRadioButton.Checked = True Then
            MasterCardRadioButton.Checked = False
            CashRadioButton.Checked = False
        End If

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

        If SingleCheckBox.Checked = True Then
            DoubleCheckBox.Checked = False
            SuiteCheckBox.Checked = False
        End If

        If DoubleCheckBox.Checked = True Then
            SingleCheckBox.Checked = False
            SuiteCheckBox.Checked = False
        End If

        If SuiteCheckBox.Checked = True Then
            DoubleCheckBox.Checked = False
            SingleCheckBox.Checked = False
        End If

    End Sub

    Private Sub telephoneTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckForRoomButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForRoomButton.Click
        If SingleCheckBox.Checked = True Then
            _7SingleRoomsFORM.Show()
        ElseIf DoubleCheckBox.Checked = True Then
            _8DoubleRoomsFORM.Show()
        ElseIf SuiteCheckBox.Checked = True Then
            _9SuiteRoomsFORM.Show()
        Else : MsgBox("Please Select The Type Of The Room Please", MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _6ReservationsFORM.Table1BindingSource.AddNew()

    End Sub

    Private Sub Res_TableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _6ReservationsFORM.Show()

    End Sub

    Private Sub Payment_MethodTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Payment_MethodLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            CustomerTableBindingSource.AddNew()
    End Sub

    Private Sub EnableButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableButton.Click
        Me.CustomerTableTableAdapter.Fill(Me.NewCustomerDataSet.CustomerTable)
        Full_NameTextBox.Enabled = True
        TelephoneTextBox.Enabled = True
        E_Mail_AddressMaskedTextBox.Enabled = True
        Arrival_DateDateTimePicker.Enabled = True
        Departure_DateDateTimePicker.Enabled = True
        NightsTextBox.Enabled = True
        Total_PaymentTextBox.Enabled = True
        Room_No_TextBox.Enabled = True
        Room_TypeTextBox.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        Me.CustomerTableBindingSource.AddNew()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Me.CustomerTableBindingSource.RemoveCurrent()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click



        Me.Validate()
        MsgBox("UPDATED")
        Me.TableAdapterManager2.UpdateAll(Me.NewCustomerDataSet)

        Dim row As DataRow
        'Dim column As DataColumn

        'column = NewCustomerDataSet.CustomerTable.Full_NameColumn
        row = NewCustomerDataSet.CustomerTable.NewRow

        'row = NewCustomerDataSet.Table.NewRow
        row("Full Name") = Full_NameTextBox.Text
        'column = Full_NameTextBox.Text
        'column("Telephone") = TelephoneTextBox.Text
        'row("e-Mail address") = E_Mail_AddressMaskedTextBox.Text
        'row("Arrival Date") = Arrival_DateDateTimePicker.Value
        'row("Departure Date") = Departure_DateDateTimePicker.Value
        'row("Nights No_") = NightsTextBox.Text
        'row("Total Payment") = Total_PaymentTextBox.Text


        'row("columnname") = z
        'DataSet.table.Rows.Add(row)

    End Sub

    Private Sub CustomerTableDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustomerTableDataGridView.CellContentClick

    End Sub

    Private Sub TotalToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Total(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class