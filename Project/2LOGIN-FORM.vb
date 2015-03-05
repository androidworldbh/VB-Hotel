Public Class LOGIN_FORM

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click

        Dim counter As Integer


            usernameTextBox.Text = StrConv(usernameTextBox.Text, VbStrConv.Uppercase)


            If usernameTextBox.Text = "" And passwordTextBox.Text = "" Then
                _3MAIN_FORM.Show()
                Me.Close()

            Else
                MsgBox("Invalid Username or Password", MessageBoxIcon.Error)
                With passwordTextBox
                    .SelectAll()
                    .Focus()
                End With

                With usernameTextBox
                    .SelectAll()
                    .Focus()
                End With

            End If

    Private Sub passwordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordTextBox.TextChanged
        passwordTextBox.PasswordChar = CChar("*")
    End Sub

    Private Sub LOGIN_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class