Public Class _3MAIN_FORM

    Private Sub _3MAIN_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub newCustomerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newCustomerButton.Click
        NCustomerFORM.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Abdulla Hassan 20095591" & vbNewLine & "Ali Thamer" & vbNewLine & "Hussain Football" & vbNewLine & "Section: 04", MessageBoxIcon.Information)

    End Sub

    Private Sub ReservationsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationsButton.Click
        _6ReservationsFORM.Show()
        Me.Close()
    End Sub

    Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
        _10GymFORM.Show()
        Me.Close()

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        _6ReservationsFORM.Show()
        Me.Close()

    End Sub
End Class