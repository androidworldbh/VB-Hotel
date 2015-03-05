<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _10GymFORM
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim RegDateLabel As System.Windows.Forms.Label
        Dim ExpiredDateLabel As System.Windows.Forms.Label
        Dim TotalPaymentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_10GymFORM))
        Me.GymDataSet = New Splash_Form.GymDataSet()
        Me.GymBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GymTableAdapter = New Splash_Form.GymDataSetTableAdapters.GymTableAdapter()
        Me.TableAdapterManager = New Splash_Form.GymDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EnableButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Gym2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gym2TableAdapter = New Splash_Form.GymDataSetTableAdapters.Gym2TableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RegDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpiredDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Gym2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        RegDateLabel = New System.Windows.Forms.Label()
        ExpiredDateLabel = New System.Windows.Forms.Label()
        TotalPaymentLabel = New System.Windows.Forms.Label()
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GymBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gym2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gym2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(22, 13)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 35)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(62, 13)
        FirstNameLabel.TabIndex = 21
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 61)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 23
        LastNameLabel.Text = "Last Name:"
        '
        'RegDateLabel
        '
        RegDateLabel.AutoSize = True
        RegDateLabel.Location = New System.Drawing.Point(12, 88)
        RegDateLabel.Name = "RegDateLabel"
        RegDateLabel.Size = New System.Drawing.Size(56, 13)
        RegDateLabel.TabIndex = 25
        RegDateLabel.Text = "Reg Date:"
        '
        'ExpiredDateLabel
        '
        ExpiredDateLabel.AutoSize = True
        ExpiredDateLabel.Location = New System.Drawing.Point(12, 114)
        ExpiredDateLabel.Name = "ExpiredDateLabel"
        ExpiredDateLabel.Size = New System.Drawing.Size(73, 13)
        ExpiredDateLabel.TabIndex = 27
        ExpiredDateLabel.Text = "Expired Date:"
        '
        'TotalPaymentLabel
        '
        TotalPaymentLabel.AutoSize = True
        TotalPaymentLabel.Location = New System.Drawing.Point(12, 139)
        TotalPaymentLabel.Name = "TotalPaymentLabel"
        TotalPaymentLabel.Size = New System.Drawing.Size(80, 13)
        TotalPaymentLabel.TabIndex = 29
        TotalPaymentLabel.Text = "Total Payment:"
        '
        'GymDataSet
        '
        Me.GymDataSet.DataSetName = "GymDataSet"
        Me.GymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GymBindingSource
        '
        Me.GymBindingSource.DataMember = "Gym"
        Me.GymBindingSource.DataSource = Me.GymDataSet
        '
        'GymTableAdapter
        '
        Me.GymTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Gym2TableAdapter = Me.Gym2TableAdapter
        Me.TableAdapterManager.GymTableAdapter = Me.GymTableAdapter
        Me.TableAdapterManager.UpdateOrder = Splash_Form.GymDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = " Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(673, 158)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 22)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EnableButton
        '
        Me.EnableButton.Location = New System.Drawing.Point(511, 158)
        Me.EnableButton.Name = "EnableButton"
        Me.EnableButton.Size = New System.Drawing.Size(75, 22)
        Me.EnableButton.TabIndex = 17
        Me.EnableButton.Text = " Enable"
        Me.EnableButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(673, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(15, 192)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = " Main Menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Gym2BindingSource
        '
        Me.Gym2BindingSource.DataMember = "Gym2"
        Me.Gym2BindingSource.DataSource = Me.GymDataSet
        '
        'Gym2TableAdapter
        '
        Me.Gym2TableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gym2BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(98, 6)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 20
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gym2BindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(98, 32)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 22
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gym2BindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(98, 58)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 24
        '
        'RegDateDateTimePicker
        '
        Me.RegDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Gym2BindingSource, "RegDate", True))
        Me.RegDateDateTimePicker.Location = New System.Drawing.Point(98, 84)
        Me.RegDateDateTimePicker.Name = "RegDateDateTimePicker"
        Me.RegDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.RegDateDateTimePicker.TabIndex = 26
        '
        'ExpiredDateDateTimePicker
        '
        Me.ExpiredDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Gym2BindingSource, "ExpiredDate", True))
        Me.ExpiredDateDateTimePicker.Location = New System.Drawing.Point(98, 110)
        Me.ExpiredDateDateTimePicker.Name = "ExpiredDateDateTimePicker"
        Me.ExpiredDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ExpiredDateDateTimePicker.TabIndex = 28
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gym2BindingSource, "TotalPayment", True))
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(98, 136)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.ReadOnly = True
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalPaymentTextBox.TabIndex = 30
        '
        'Gym2DataGridView
        '
        Me.Gym2DataGridView.AutoGenerateColumns = False
        Me.Gym2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gym2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Gym2DataGridView.DataSource = Me.Gym2BindingSource
        Me.Gym2DataGridView.Location = New System.Drawing.Point(304, 6)
        Me.Gym2DataGridView.Name = "Gym2DataGridView"
        Me.Gym2DataGridView.Size = New System.Drawing.Size(444, 150)
        Me.Gym2DataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RegDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RegDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ExpiredDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ExpiredDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalPayment"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TotalPayment"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(736, 10)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'PeriodTextBox
        '
        Me.PeriodTextBox.Location = New System.Drawing.Point(98, 162)
        Me.PeriodTextBox.Name = "PeriodTextBox"
        Me.PeriodTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PeriodTextBox.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = " Period"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(304, 159)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(120, 23)
        Me.CalcButton.TabIndex = 34
        Me.CalcButton.Text = " Calculate Payment"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        '_10GymFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 223)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PeriodTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Gym2DataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(RegDateLabel)
        Me.Controls.Add(Me.RegDateDateTimePicker)
        Me.Controls.Add(ExpiredDateLabel)
        Me.Controls.Add(Me.ExpiredDateDateTimePicker)
        Me.Controls.Add(TotalPaymentLabel)
        Me.Controls.Add(Me.TotalPaymentTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.EnableButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "_10GymFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_10GymFORM"
        CType(Me.GymDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GymBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gym2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gym2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GymDataSet As Splash_Form.GymDataSet
    Friend WithEvents GymBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GymTableAdapter As Splash_Form.GymDataSetTableAdapters.GymTableAdapter
    Friend WithEvents TableAdapterManager As Splash_Form.GymDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents EnableButton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Gym2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gym2TableAdapter As Splash_Form.GymDataSetTableAdapters.Gym2TableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExpiredDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalPaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gym2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PeriodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button
End Class
