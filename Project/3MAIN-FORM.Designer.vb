<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3MAIN_FORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_3MAIN_FORM))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newCustomerButton = New System.Windows.Forms.Button()
        Me.ReservationsButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewCustomerToolStripMenuItem.Text = " &New Customer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(153, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HelpToolStripMenuItem.Text = " &Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 10)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'newCustomerButton
        '
        Me.newCustomerButton.Location = New System.Drawing.Point(15, 56)
        Me.newCustomerButton.Name = "newCustomerButton"
        Me.newCustomerButton.Size = New System.Drawing.Size(121, 23)
        Me.newCustomerButton.TabIndex = 4
        Me.newCustomerButton.Text = " New Customer"
        Me.newCustomerButton.UseVisualStyleBackColor = True
        '
        'ReservationsButton
        '
        Me.ReservationsButton.Location = New System.Drawing.Point(15, 85)
        Me.ReservationsButton.Name = "ReservationsButton"
        Me.ReservationsButton.Size = New System.Drawing.Size(121, 23)
        Me.ReservationsButton.TabIndex = 5
        Me.ReservationsButton.Text = "Reservations"
        Me.ReservationsButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(15, 114)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(121, 23)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = " Gym"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(15, 143)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(121, 23)
        Me.EditButton.TabIndex = 7
        Me.EditButton.Text = "Edit Reservation"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(673, 194)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = " Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Register A New Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Show All Reservations And Residents"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To Sign Up For GYM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(378, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Edit The Current Resedents Reservations Or To Change Any Pre Reservarion"
        '
        '_3MAIN_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(760, 223)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ReservationsButton)
        Me.Controls.Add(Me.newCustomerButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "_3MAIN_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newCustomerButton As System.Windows.Forms.Button
    Friend WithEvents ReservationsButton As System.Windows.Forms.Button
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
