Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ClassPenumpang
    Private NIK As Integer
    Private nama_penumpang As String
    Private alamat_penumpang As String
    Private jenis_kelamin As String

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "formbus"


    Public Property NIKProperty() As String
        Get
            Return NIK
        End Get
        Set(ByVal value As String)
            NIK = value
        End Set
    End Property

    Public Property nama_penumpangProperty() As String
        Get
            Return nama_penumpang
        End Get
        Set(ByVal value As String)
            nama_penumpang = value
        End Set
    End Property

    Public Property alamat_penumpangProperty() As String
        Get
            Return alamat_penumpang
        End Get
        Set(ByVal value As String)
            alamat_penumpang = value
        End Set
    End Property

    Public Property jenis_kelaminProperty() As String
        Get
            Return jenis_kelamin
        End Get
        Set(ByVal value As String)
            jenis_kelamin = value
        End Set
    End Property

    Public Function ConvertBusToString(vals As List(Of String))
            Dim builder As StringBuilder = New StringBuilder()
            For Each val As String In vals
                builder.Append(val).Append(" | ")
            Next

            'convert to string 
            Dim res = builder.ToString()
            Return res
        End Function

        Public Function ConvertStringToBus(value As String)
            Dim arr() As String = value.Split(" | ")

            'convert to list 
            Dim vals As List(Of String) = arr.ToList()
            Return vals
        End Function

    Public Function GetDataPenumpangDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT NIK as 'NIK', 
                                 nama_penumpang as 'nama_penumpang',
                                 alamat_penumpang as 'alamat_penumpang', 
                                 jenis_kelamin as 'jenis_kelamin'
                                 FROM penumpang"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataPenumpangDatabase(NIK As Integer,
                                             nama_penumpang As String,
                                             alamat_penumpang As String,
                                             jenis_kelamin As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO penumpang( NIK, nama_penumpang , alamat_penumpang , jenis_kelamin) VALUE('" _
                        & NIK & "' , '" _
                        & nama_penumpang & "' , '" _
                        & alamat_penumpang & "' , '" _
                        & jenis_kelamin & "' )"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataPenumpangByNIKDatabase(NIK As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT NIK, nama_penumpang, alamat_penumpang, jenis_kelamin
                                  FROM penumpang WHERE NIK='" & NIK & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataPenumpangByNIKDatabase(NIK As Integer,
                                                     nama_penumpang As String,
                                                     alamat_penumpang As String,
                                                     jenis_kelamin As String)


        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE penumpang SET " &
                   "nama_penumpang = '" & nama_penumpang & "' , " &
                   "alamat_penumpang = '" & alamat_penumpang & "' , " &
                   "jenis_kelamin ='" & jenis_kelamin & "'  " &
                   "WHERE NIK = '" & NIK & "'"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataPenumpangByNIKDatabase(NIK As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM penumpang " &
                       "WHERE NIK = '" & NIK & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
