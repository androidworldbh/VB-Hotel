<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCustomerFORM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim E_Mail_AddressLabel As System.Windows.Forms.Label
        Dim Arrival_DateLabel As System.Windows.Forms.Label
        Dim Departure_DateLabel As System.Windows.Forms.Label
        Dim Nights_No_Label As System.Windows.Forms.Label
        Dim Total_PaymentLabel As System.Windows.Forms.Label
        Dim Payment_MethodLabel As System.Windows.Forms.Label
        Dim Room_No_Label As System.Windows.Forms.Label
        Dim Room_TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NCustomerFORM))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuiteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DoubleCheckBox = New System.Windows.Forms.CheckBox()
        Me.SingleCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CashRadioButton = New System.Windows.Forms.RadioButton()
        Me.MasterCardRadioButton = New System.Windows.Forms.RadioButton()
        Me.VisaCardRadioButton = New System.Windows.Forms.RadioButton()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CheckForRoomButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EnableButton = New System.Windows.Forms.Button()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Arrival_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Departure_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NightsTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_MethodTextBox = New System.Windows.Forms.TextBox()
        Me.Room_No_TextBox = New System.Windows.Forms.TextBox()
        Me.Room_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustomerTableTableAdapter = New Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter()
        Me.TableAdapterManager2 = New Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager()
        Me.E_Mail_AddressMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewCustomerDataSet = New Splash_Form.NewCustomerDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Full_NameLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        E_Mail_AddressLabel = New System.Windows.Forms.Label()
        Arrival_DateLabel = New System.Windows.Forms.Label()
        Departure_DateLabel = New System.Windows.Forms.Label()
        Nights_No_Label = New System.Windows.Forms.Label()
        Total_PaymentLabel = New System.Windows.Forms.Label()
        Payment_MethodLabel = New System.Windows.Forms.Label()
        Room_No_Label = New System.Windows.Forms.Label()
        Room_TypeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomerTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.Location = New System.Drawing.Point(30, 28)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(57, 13)
        Full_NameLabel.TabIndex = 63
        Full_NameLabel.Text = "Full Name:"
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(30, 54)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 65
        TelephoneLabel.Text = "Telephone:"
        '
        'E_Mail_AddressLabel
        '
        E_Mail_AddressLabel.AutoSize = True
        E_Mail_AddressLabel.Location = New System.Drawing.Point(30, 80)
        E_Mail_AddressLabel.Name = "E_Mail_AddressLabel"
        E_Mail_AddressLabel.Size = New System.Drawing.Size(81, 13)
        E_Mail_AddressLabel.TabIndex = 67
        E_Mail_AddressLabel.Text = "e-Mail Address:"
        '
        'Arrival_DateLabel
        '
        Arrival_DateLabel.AutoSize = True
        Arrival_DateLabel.Location = New System.Drawing.Point(30, 107)
        Arrival_DateLabel.Name = "Arrival_DateLabel"
        Arrival_DateLabel.Size = New System.Drawing.Size(68, 13)
        Arrival_DateLabel.TabIndex = 69
        Arrival_DateLabel.Text = "Arrival Date:"
        '
        'Departure_DateLabel
        '
        Departure_DateLabel.AutoSize = True
        Departure_DateLabel.Location = New System.Drawing.Point(30, 133)
        Departure_DateLabel.Name = "Departure_DateLabel"
        Departure_DateLabel.Size = New System.Drawing.Size(86, 13)
        Departure_DateLabel.TabIndex = 71
        Departure_DateLabel.Text = "Departure Date:"
        '
        'Nights_No_Label
        '
        Nights_No_Label.AutoSize = True
        Nights_No_Label.Location = New System.Drawing.Point(30, 158)
        Nights_No_Label.Name = "Nights_No_Label"
        Nights_No_Label.Size = New System.Drawing.Size(60, 13)
        Nights_No_Label.TabIndex = 73
        Nights_No_Label.Text = "Nights No :"
        '
        'Total_PaymentLabel
        '
        Total_PaymentLabel.AutoSize = True
        Total_PaymentLabel.Location = New System.Drawing.Point(30, 184)
        Total_PaymentLabel.Name = "Total_PaymentLabel"
        Total_PaymentLabel.Size = New System.Drawing.Size(80, 13)
        Total_PaymentLabel.TabIndex = 75
        Total_PaymentLabel.Text = "Total Payment:"
        '
        'Payment_MethodLabel
        '
        Payment_MethodLabel.AutoSize = True
        Payment_MethodLabel.Location = New System.Drawing.Point(30, 621)
        Payment_MethodLabel.Name = "Payment_MethodLabel"
        Payment_MethodLabel.Size = New System.Drawing.Size(92, 13)
        Payment_MethodLabel.TabIndex = 77
        Payment_MethodLabel.Text = "Payment Method:"
        '
        'Room_No_Label
        '
        Room_No_Label.AutoSize = True
        Room_No_Label.Location = New System.Drawing.Point(332, 27)
        Room_No_Label.Name = "Room_No_Label"
        Room_No_Label.Size = New System.Drawing.Size(57, 13)
        Room_No_Label.TabIndex = 79
        Room_No_Label.Text = "Room No :"
        '
        'Room_TypeLabel
        '
        Room_TypeLabel.AutoSize = True
        Room_TypeLabel.Location = New System.Drawing.Point(47, 647)
        Room_TypeLabel.Name = "Room_TypeLabel"
        Room_TypeLabel.Size = New System.Drawing.Size(65, 13)
        Room_TypeLabel.TabIndex = 81
        Room_TypeLabel.Text = "Room Type:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(736, 10)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(673, 241)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = " Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SuiteCheckBox)
        Me.GroupBox1.Controls.Add(Me.DoubleCheckBox)
        Me.GroupBox1.Controls.Add(Me.SingleCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(95, 100)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Type Of Room"
        '
        'SuiteCheckBox
        '
        Me.SuiteCheckBox.AutoSize = True
        Me.SuiteCheckBox.Location = New System.Drawing.Point(14, 73)
        Me.SuiteCheckBox.Name = "SuiteCheckBox"
        Me.SuiteCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.SuiteCheckBox.TabIndex = 18
        Me.SuiteCheckBox.Text = " Suite"
        Me.SuiteCheckBox.UseVisualStyleBackColor = True
        '
        'DoubleCheckBox
        '
        Me.DoubleCheckBox.AutoSize = True
        Me.DoubleCheckBox.Location = New System.Drawing.Point(14, 51)
        Me.DoubleCheckBox.Name = "DoubleCheckBox"
        Me.DoubleCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.DoubleCheckBox.TabIndex = 19
        Me.DoubleCheckBox.Text = "Double"
        Me.DoubleCheckBox.UseVisualStyleBackColor = True
        '
        'SingleCheckBox
        '
        Me.SingleCheckBox.AutoSize = True
        Me.SingleCheckBox.Location = New System.Drawing.Point(14, 25)
        Me.SingleCheckBox.Name = "SingleCheckBox"
        Me.SingleCheckBox.Size = New System.Drawing.Size(54, 17)
        Me.SingleCheckBox.TabIndex = 20
        Me.SingleCheckBox.Text = "Single"
        Me.SingleCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CashRadioButton)
        Me.GroupBox2.Controls.Add(Me.MasterCardRadioButton)
        Me.GroupBox2.Controls.Add(Me.VisaCardRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(436, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(106, 100)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Method"
        '
        'CashRadioButton
        '
        Me.CashRadioButton.AutoSize = True
        Me.CashRadioButton.Location = New System.Drawing.Point(8, 24)
        Me.CashRadioButton.Name = "CashRadioButton"
        Me.CashRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.CashRadioButton.TabIndex = 22
        Me.CashRadioButton.TabStop = True
        Me.CashRadioButton.Text = " Cash"
        Me.CashRadioButton.UseVisualStyleBackColor = True
        '
        'MasterCardRadioButton
        '
        Me.MasterCardRadioButton.AutoSize = True
        Me.MasterCardRadioButton.Location = New System.Drawing.Point(8, 49)
        Me.MasterCardRadioButton.Name = "MasterCardRadioButton"
        Me.MasterCardRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.MasterCardRadioButton.TabIndex = 23
        Me.MasterCardRadioButton.TabStop = True
        Me.MasterCardRadioButton.Text = "MasterCard"
        Me.MasterCardRadioButton.UseVisualStyleBackColor = True
        '
        'VisaCardRadioButton
        '
        Me.VisaCardRadioButton.AutoSize = True
        Me.VisaCardRadioButton.Location = New System.Drawing.Point(8, 72)
        Me.VisaCardRadioButton.Name = "VisaCardRadioButton"
        Me.VisaCardRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.VisaCardRadioButton.TabIndex = 24
        Me.VisaCardRadioButton.TabStop = True
        Me.VisaCardRadioButton.Text = "VisaCard"
        Me.VisaCardRadioButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(418, 241)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 22
        Me.NextButton.Text = "Invoice"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(13, 241)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 23
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CheckForRoomButton
        '
        Me.CheckForRoomButton.Location = New System.Drawing.Point(335, 66)
        Me.CheckForRoomButton.Name = "CheckForRoomButton"
        Me.CheckForRoomButton.Size = New System.Drawing.Size(207, 25)
        Me.CheckForRoomButton.TabIndex = 28
        Me.CheckForRoomButton.Text = "Check For Room"
        Me.CheckForRoomButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = " Add Customer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EnableButton
        '
        Me.EnableButton.Location = New System.Drawing.Point(94, 241)
        Me.EnableButton.Name = "EnableButton"
        Me.EnableButton.Size = New System.Drawing.Size(75, 23)
        Me.EnableButton.TabIndex = 63
        Me.EnableButton.Text = "Enable"
        Me.EnableButton.UseVisualStyleBackColor = True
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(128, 25)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Full_NameTextBox.TabIndex = 64
        '
        'Arrival_DateDateTimePicker
        '
        Me.Arrival_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerTableBindingSource, "Arrival Date", True))
        Me.Arrival_DateDateTimePicker.Location = New System.Drawing.Point(128, 103)
        Me.Arrival_DateDateTimePicker.Name = "Arrival_DateDateTimePicker"
        Me.Arrival_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Arrival_DateDateTimePicker.TabIndex = 70
        '
        'Departure_DateDateTimePicker
        '
        Me.Departure_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerTableBindingSource, "Departure Date", True))
        Me.Departure_DateDateTimePicker.Location = New System.Drawing.Point(128, 129)
        Me.Departure_DateDateTimePicker.Name = "Departure_DateDateTimePicker"
        Me.Departure_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Departure_DateDateTimePicker.TabIndex = 72
        '
        'NightsTextBox
        '
        Me.NightsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Nights No_", True))
        Me.NightsTextBox.Location = New System.Drawing.Point(128, 155)
        Me.NightsTextBox.Name = "NightsTextBox"
        Me.NightsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NightsTextBox.TabIndex = 74
        '
        'Total_PaymentTextBox
        '
        Me.Total_PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Total Payment", True))
        Me.Total_PaymentTextBox.Location = New System.Drawing.Point(128, 181)
        Me.Total_PaymentTextBox.Name = "Total_PaymentTextBox"
        Me.Total_PaymentTextBox.ReadOnly = True
        Me.Total_PaymentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_PaymentTextBox.TabIndex = 76
        '
        'Payment_MethodTextBox
        '
        Me.Payment_MethodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Payment Method", True))
        Me.Payment_MethodTextBox.Location = New System.Drawing.Point(128, 618)
        Me.Payment_MethodTextBox.Name = "Payment_MethodTextBox"
        Me.Payment_MethodTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Payment_MethodTextBox.TabIndex = 78
        '
        'Room_No_TextBox
        '
        Me.Room_No_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Room No_", True))
        Me.Room_No_TextBox.Location = New System.Drawing.Point(413, 24)
        Me.Room_No_TextBox.Name = "Room_No_TextBox"
        Me.Room_No_TextBox.ReadOnly = True
        Me.Room_No_TextBox.Size = New System.Drawing.Size(129, 20)
        Me.Room_No_TextBox.TabIndex = 80
        '
        'Room_TypeTextBox
        '
        Me.Room_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Room Type", True))
        Me.Room_TypeTextBox.Location = New System.Drawing.Point(128, 644)
        Me.Room_TypeTextBox.Name = "Room_TypeTextBox"
        Me.Room_TypeTextBox.Size = New System.Drawing.Size(137, 20)
        Me.Room_TypeTextBox.TabIndex = 82
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(256, 241)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 83
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(337, 241)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 84
        Me.SaveButton.Text = " Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 493)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 10)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'CustomerTableDataGridView
        '
        Me.CustomerTableDataGridView.AutoGenerateColumns = False
        Me.CustomerTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CustomerTableDataGridView.DataSource = Me.CustomerTableBindingSource
        Me.CustomerTableDataGridView.Location = New System.Drawing.Point(13, 270)
        Me.CustomerTableDataGridView.Name = "CustomerTableDataGridView"
        Me.CustomerTableDataGridView.Size = New System.Drawing.Size(735, 220)
        Me.CustomerTableDataGridView.TabIndex = 84
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CustomerTableTableAdapter = Me.CustomerTableTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'E_Mail_AddressMaskedTextBox
        '
        Me.E_Mail_AddressMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "e-Mail Address", True))
        Me.E_Mail_AddressMaskedTextBox.Location = New System.Drawing.Point(128, 77)
        Me.E_Mail_AddressMaskedTextBox.Name = "E_Mail_AddressMaskedTextBox"
        Me.E_Mail_AddressMaskedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.E_Mail_AddressMaskedTextBox.TabIndex = 86
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTableBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(128, 51)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelephoneTextBox.TabIndex = 87
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.NewCustomerDataSet
        '
        'NewCustomerDataSet
        '
        Me.NewCustomerDataSet.DataSetName = "NewCustomerDataSet"
        Me.NewCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Full Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Telephone"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Telephone"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "e-Mail Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "e-Mail Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Arrival Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Arrival Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Departure Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Departure Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nights No_"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nights No_"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total Payment"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Payment"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Payment Method"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Payment Method"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Room No_"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Room No_"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Room Type"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Room Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'NCustomerFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 511)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(Me.E_Mail_AddressMaskedTextBox)
        Me.Controls.Add(Me.CustomerTableDataGridView)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(E_Mail_AddressLabel)
        Me.Controls.Add(Arrival_DateLabel)
        Me.Controls.Add(Me.Arrival_DateDateTimePicker)
        Me.Controls.Add(Departure_DateLabel)
        Me.Controls.Add(Me.Departure_DateDateTimePicker)
        Me.Controls.Add(Nights_No_Label)
        Me.Controls.Add(Me.NightsTextBox)
        Me.Controls.Add(Total_PaymentLabel)
        Me.Controls.Add(Me.Total_PaymentTextBox)
        Me.Controls.Add(Payment_MethodLabel)
        Me.Controls.Add(Me.Payment_MethodTextBox)
        Me.Controls.Add(Room_No_Label)
        Me.Controls.Add(Me.Room_No_TextBox)
        Me.Controls.Add(Room_TypeLabel)
        Me.Controls.Add(Me.Room_TypeTextBox)
        Me.Controls.Add(Me.EnableButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckForRoomButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NCustomerFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CustomerTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SuiteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DoubleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SingleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CashRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MasterCardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents VisaCardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents CheckForRoomButton As System.Windows.Forms.Button




    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EnableButton As System.Windows.Forms.Button
    Friend WithEvents NewCustomerDataSet As Splash_Form.NewCustomerDataSet
    Friend WithEvents CustomerTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableTableAdapter As Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents TableAdapterManager2 As Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Arrival_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Departure_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NightsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_PaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_MethodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_No_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Room_TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents E_Mail_AddressMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
End Class
