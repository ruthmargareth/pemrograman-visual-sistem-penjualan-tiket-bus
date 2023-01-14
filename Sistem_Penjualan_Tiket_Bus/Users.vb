Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Username As String
    Private Password As String
    Private Users As New ArrayList()

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "formbus"

    Public Property usernameProperty() As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            Username = value
        End Set
    End Property

    Public Property passwordProperty() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    'Public Function EncryptionData(ByVal plaintext As String) As String

    'Dim plaintextBytes() As Byte =
    'System.Text.Encoding.Unicode.GetBytes(plaintext)

    'Dim ms As New System.IO.MemoryStream
    'Dim encStream As New CryptoStream(ms,
    'TripleDes.CreateEncryptor(),
    'System.Security.Cryptography.CryptoStreamMode.Write)

    'encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
    'encStream.FlushFinalBlock()

    'Return Convert.ToBase64String(ms.ToArray)
    'End Function

    'Public Function checkauth(username As String, ByVal plainpassword As String) As String

    'Dim realpassword As String = EncryptionData("12345")
    'Dim realusername As String = ("ruth")
    'If String.Compare(username, realusername) = 0 And String.Compare(EncryptionData(plainpassword), realpassword) = 0 Then
    'Return True
    'Else
    'Return False
    'End If
    'End Function

    'Public Function checkauthmultiple(username As String, ByVal plainpassword As String) As String
    'For Each barisuser In GetDataUsers()
    'If String.Compare(username, barisuser(0)) = 0 Then
    'If String.Compare(username, barisuser(0)) = 0 And String.Compare(EncryptionData(plainpassword), barisuser(1)) = 0 Then
    'Return True
    'Else
    'Return False
    'End If
    'End If
    'Next
    'End Function

    'Public Function adddatausers(username As String, password As String)
    'Users.Add({username, EncryptionData(password)})
    'End Function

    Public ReadOnly Property GetDataUsers() As ArrayList
        Get
            Return Users
        End Get
    End Property

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function
    Public Function AddUsersDatabase(username_regist As String, email_regist As String, password_regist As String)
        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
          + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO USERS( username, email, password) VALUE('" _
                       & username_regist & "', '" _
                       & email_regist & "', '" _
                       & EncryptMD5(password_regist) & " ')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message

        End Try
        dbConn.Dispose()
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
                + "password=" + password_db + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            Dim queryAuth = "SELECT id, username FROM users
                             WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            Debug.WriteLine(ex.Message)

        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
