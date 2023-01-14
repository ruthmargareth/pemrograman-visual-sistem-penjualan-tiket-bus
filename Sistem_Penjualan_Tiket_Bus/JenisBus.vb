Imports System.Text
Imports MySql.Data.MySqlClient

Public Class JenisBus
    'Private id_bus As String
    Private nama_bus As String
    Private kapasitas_bus As Integer
    Private Jenis_bus As String
    Private tahun_pembuatan As String

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "formbus"

    Public Property nama_busProperty() As String
        Get
            Return nama_bus
        End Get
        Set(ByVal value As String)
            nama_bus = value
        End Set
    End Property

    Public Property kapasitas_busProperty() As String
        Get
            Return kapasitas_bus
        End Get
        Set(ByVal value As String)
            kapasitas_bus = value
        End Set
    End Property

    Public Property jenis_busProperty() As String
        Get
            Return Jenis_bus
        End Get
        Set(ByVal value As String)
            Jenis_bus = value
        End Set
    End Property

    Public Property tahun_pembuatanProperty() As String
        Get
            Return tahun_pembuatan
        End Get
        Set(ByVal value As String)
            tahun_pembuatan = value
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

    Public Function GetDataBusDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_bus as 'ID', 
                                 nama_bus as 'nama_bus',
                                 kapasitas_bus as 'kapasitas_bus', 
                                 jenis_bus as 'jenis_bus',
                                 tahun_pembuatan as 'tahun_pembuatan'
                                 FROM jenisbus"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataBusDatabase(nama_bus As String,
                                      kapasitas_bus As Integer,
                                           jenis_bus As String,
                                           tahun_pembuatan As String)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenisbus( nama_bus , kapasitas_bus , jenis_bus, tahun_pembuatan) VALUE('" _
                        & nama_bus & "' , '" _
                        & kapasitas_bus & "' , '" _
                        & jenis_bus & "' , '" _
                        & tahun_pembuatan & "' )"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataBusByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_bus, nama_bus, kapasitas_bus, jenis_bus, tahun_pembuatan
                                  FROM jenisbus WHERE id_bus='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataBusByIDDatabase(ID As Integer,
                                              nama_bus As String,
                                              kapasitas_bus As Integer,
                                              jenis_bus As String,
                                              tahun_pembuatan As String)


        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE jenisbus SET " &
                   "nama_bus= '" & nama_bus & "' , " &
                   "kapasitas_bus= '" & kapasitas_bus & "' , " &
                   "jenis_bus= '" & jenis_bus & "' , " &
                   "tahun_pembuatan='" & tahun_pembuatan & "'  " &
                   "WHERE id_bus= '" & ID & "'"

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

    Public Function DeleteDataBusByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM jenisbus " &
                       "WHERE id_bus= '" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function
End Class
