<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN_FORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN_FORM))
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(81, 59)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usernameTextBox.TabIndex = 0
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(81, 85)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passwordTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = " User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Password"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(81, 111)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(100, 23)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(5, 194)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(198, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = " Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-249, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(736, 10)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'LOGIN_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(206, 223)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Name = "LOGIN_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN_FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
