<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _6ReservationsFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_6ReservationsFORM))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CustomerTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Table3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CustomerTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewCustomerDataSet = New Splash_Form.NewCustomerDataSet()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableTableAdapter = New Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter()
        Me.TableAdapterManager3 = New Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.CustomerTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(682, 495)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = " Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 10)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(22, 495)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 25
        Me.BackButton.Text = "Back To Main"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CustomerTableDataGridView
        '
        Me.CustomerTableDataGridView.AutoGenerateColumns = False
        Me.CustomerTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CustomerTableDataGridView.DataSource = Me.CustomerTableBindingSource1
        Me.CustomerTableDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.CustomerTableDataGridView.Name = "CustomerTableDataGridView"
        Me.CustomerTableDataGridView.Size = New System.Drawing.Size(769, 465)
        Me.CustomerTableDataGridView.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Query 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = " .Where Total Payment Gtreater Than 200 $"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "New Customer Form"
        Me.Button2.UseVisualStyleBackColor = True
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
        'CustomerTableBindingSource1
        '
        Me.CustomerTableBindingSource1.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource1.DataSource = Me.NewCustomerDataSet
        '
        'NewCustomerDataSet
        '
        Me.NewCustomerDataSet.DataSetName = "NewCustomerDataSet"
        Me.NewCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.NewCustomerDataSet
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.CustomerTableTableAdapter = Me.CustomerTableTableAdapter
        Me.TableAdapterManager3.UpdateOrder = Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(24, 553)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 32
        Me.SearchButton.Text = " Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 556)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 33
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Names", "Telephone Number", "Payment Method", "e-Mail Address", "Room Number"})
        Me.ComboBox1.Location = New System.Drawing.Point(327, 556)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 34
        '
        '_6ReservationsFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 597)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustomerTableDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "_6ReservationsFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        CType(Me.CustomerTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button

    Friend WithEvents Table3BindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents NewCustomerDataSet As Splash_Form.NewCustomerDataSet
    Friend WithEvents CustomerTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableTableAdapter As Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents TableAdapterManager3 As Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerTableBindingSource1 As System.Windows.Forms.BindingSource
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
