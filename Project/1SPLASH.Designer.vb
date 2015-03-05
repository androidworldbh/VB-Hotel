<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPLASH
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewCustomerDataSet = New Splash_Form.NewCustomerDataSet()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableTableAdapter = New Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter()
        Me.TableAdapterManager = New Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager()
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 205)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO VB HOTEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableTableAdapter = Me.CustomerTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPLASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(760, 223)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SPLASH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To VB Hotel"
        CType(Me.NewCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewCustomerDataSet As Splash_Form.NewCustomerDataSet
    Friend WithEvents CustomerTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableTableAdapter As Splash_Form.NewCustomerDataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents TableAdapterManager As Splash_Form.NewCustomerDataSetTableAdapters.TableAdapterManager

End Class
