Imports System.Data.Common
Imports System.Data.Odbc


Module Module1
    Public sql As String
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public connection As OdbcConnection

    Public Sub MyConnection()
        connection = New OdbcConnection("DSN=beautysalon_db")
        If connection.State = ConnectionState.Closed Then
            connection.Open()



        End If
    End Sub
End Module

