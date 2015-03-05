Public Class _6ReservationsFORM

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        _3MAIN_FORM.Show()
        Me.Close()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub





    Private Sub _6ReservationsFORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewCustomerDataSet.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.NewCustomerDataSet.CustomerTable)
        'TODO: This line of code loads data into the 'ReservDatabaseDataSet.Table2' table. You can move, or remove it, as needed.
     

    End Sub

    Private Sub Table3DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Table3BindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Table1DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Table2BindingSource.AddNew()

    End Sub

   
    Private Sub FullNameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub FullNameToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.CustomerTableTableAdapter.FullName(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NCustomerFORM.Show()
        Me.Close()

    End Sub

    Private Sub SearchToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Search(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Search1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Search1(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Full_NameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Full_Name(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Full_NameToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TelephoneToolStripTextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click

        If ComboBox1.SelectedIndex = 0 Then
            Try
                Me.CustomerTableTableAdapter.Full_Name1(Me.NewCustomerDataSet.CustomerTable, TextBox1.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Try
                Me.CustomerTableTableAdapter.Telephone(Me.NewCustomerDataSet.CustomerTable, CType(TextBox1.Text, Integer))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        ElseIf ComboBox1.SelectedIndex = 2 Then
            Try
                Me.CustomerTableTableAdapter.FillBy(Me.NewCustomerDataSet.CustomerTable, TextBox1.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Try
                Me.CustomerTableTableAdapter.Email1(Me.NewCustomerDataSet.CustomerTable, TextBox1.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Try
                Me.CustomerTableTableAdapter._Date(Me.NewCustomerDataSet.CustomerTable, TextBox1.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MsgBox("Please Select A Type From The ComboBox")
        Else : MsgBox("Enter A Proper Method To Search")
        End If
        
    End Sub

    Private Sub EmailsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Emails(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TelephoneToolStripLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmailToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Email(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Total1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Total1(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Payment_MethodToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableTableAdapter.Payment_Method(Me.NewCustomerDataSet.CustomerTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Email1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub _DateToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class