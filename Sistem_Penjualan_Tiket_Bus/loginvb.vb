
Public Class login
    Public Shared users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        users = New Users()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim plainUsername As String = txtusername.Text
        Dim plainPassword As String = txtpassword.Text

        'Dim encrypted As String = Users.EncryptionData(plainPassword)
        'MessageBox.Show(encrypted)
        'Dim authstatus As Boolean = Users.checkauth(plainUsername, plainPassword)
        'MessageBox.Show(authstatus)
        'Dim encrypted As String = Users.EncryptMD5(plainPassword)
        'MessageBox.Show(encrypted)
        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.usernameProperty = data_user(1)
            FormMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("password salah")
        End If

        'If authstatus Then
        'Perpustakaan.Show()
        'Else
        'MessageBox.Show("Wrong Password")
        'End If
    End Sub

    Private Sub btnregist_Click(sender As Object, e As EventArgs) Handles btnregist.Click
        Dim regist = New registration()
        regist.Show()
    End Sub
End Class