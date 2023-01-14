Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ClassRute
    Private asal_rute As String
    Private destinasi_rute As String
    Private tarif_rute As String
    Private jadwal_keberangkatan As String
    Private jadwal_kedatangan As String

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "127.0.0.1"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "formbus"


    Public Property asal_ruteProperty() As String
        Get
            Return asal_rute
        End Get
        Set(ByVal value As String)
            asal_rute = value
        End Set
    End Property

    Public Property destinasi_ruteProperty() As String
        Get
            Return destinasi_rute
        End Get
        Set(ByVal value As String)
            destinasi_rute = value
        End Set
    End Property

    Public Property tarif_ruteProperty() As String
        Get
            Return tarif_rute
        End Get
        Set(ByVal value As String)
            tarif_rute = value
        End Set
    End Property

    Public Property jadwal_keberangkatanProperty() As String
        Get
            Return jadwal_keberangkatan
        End Get
        Set(ByVal value As String)
            jadwal_keberangkatan = value
        End Set
    End Property

    Public Property jadwal_kedatanganProperty() As String
        Get
            Return jadwal_kedatangan
        End Get
        Set(ByVal value As String)
            jadwal_kedatangan = value
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

    Public Function GetDataRuteDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_rute as 'ID', 
                                 asal_rute as 'asal_rute',
                                 destinasi_rute as 'destinasi_rute', 
                                 tarif_rute as 'tarif_bus',
                                 jadwal_keberangkatan as 'jadwal_keberangkatan',
                                 jadwal_kedatangan as 'jadwal_kedatangan'
                                 FROM rute"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataRuteDatabase(asal_rute As String,
                                       destinasi_rute As String,
                                       tarif_rute As String,
                                       jadwal_keberangkatan As DateTime,
                                       jadwal_kedatangan As DateTime)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" _
        + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO rute( asal_rute , destinasi_rute , tarif_rute, jadwal_keberangkatan, jadwal_kedatangan) VALUE('" _
                        & asal_rute & "' , '" _
                        & destinasi_rute & "' , '" _
                        & tarif_rute & "' , '" _
                        & jadwal_keberangkatan & "' , '" _
                        & jadwal_kedatangan & "' )"

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

    Public Function GetDataRuteByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_rute, asal_rute, destinasi_rute, tarif_rute, jadwal_keberangkatan, jadwal_kedatangan
                                  FROM rute WHERE id_rute='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataRuteByIDDatabase(ID As Integer,
                                              asal_rute As String,
                                              destinasi_rute As String,
                                              tarif_rute As String,
                                              jadwal_keberangkatan As DateTime,
                                              jadwal_kedatangan As DateTime)


        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE rute SET " &
                   "asal_rute = '" & asal_rute & "' , " &
                   "destinasi_rute = '" & destinasi_rute & "' , " &
                   "tarif_rute = '" & tarif_rute & "' , " &
                   "jadwal_keberangkatan ='" & jadwal_keberangkatan & "' , " &
                   "jadwal_kedatangan ='" & jadwal_kedatangan & "'  " &
                   "WHERE id_rute = '" & ID & "'"

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

    Public Function DeleteDataRuteByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" _
            + "password =" + password + ";" + "database =" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM rute " &
                       "WHERE id_rute= '" & ID & "'"

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
