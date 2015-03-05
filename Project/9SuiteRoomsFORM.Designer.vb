<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _9SuiteRoomsFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_9SuiteRoomsFORM))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(736, 10)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(13, 194)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 26
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(556, 134)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = " Rooms Services:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.Location = New System.Drawing.Point(171, 21)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(6, 144)
        Me.TextBox1.TabIndex = 61
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 27)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 27)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        '_9SuiteRoomsFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 223)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label3)
        Me.Name = "_9SuiteRoomsFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_9SuiteRoomsFORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
