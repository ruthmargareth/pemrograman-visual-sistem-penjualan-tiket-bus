
Public Class registration
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        If txtuname.Text.Length > 0 And txtemail.Text.Length > 0 And txtpass.Text.Length > 0 Then

            'Login.Users.AddDataUsers(TxtUserRegist.Text, TxtPasswordregist.Text)
            login.users.AddUsersDatabase(txtuname.Text, txtemail.Text, txtpass.Text)
            Me.Close()
        Else
            MessageBox.Show("lengkapi Data")
        End If
    End Sub
End Class
