Imports System.Data.SqlClient

Module Module1
    Public Function SelectSqlSrvRows(ByVal query As String, ByVal Optional sqlconstr As String = "") As DataSet

        Dim myConnectionString As String = sqlconstr, contentofError = ""
        'If sqlconstr = "" Then myConnectionString = contentOfdbODBC

        Dim conn As New SqlConnection(myConnectionString)
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        Try
            adapter.SelectCommand = New SqlCommand(query, conn)
            adapter.SelectCommand.CommandTimeout = 0
            adapter.Fill(dataSet)

        Catch ex As SqlException
            contentofError = query & ex.Message & "<br>"
        Catch ex As Exception
            contentofError = query & ex.Message & "<br>"
        Finally
            conn.Close()

        End Try
        adapter = Nothing
        Return dataSet

    End Function
    Public Function runSQLwithResult(ByVal sqlstr As String, Optional ByVal sqlconstr As String = "") As String
        Dim result As String, contentofError As String

        ' If the connection string is null, usse a default.
        Dim myConnectionString As String = sqlconstr
        'If sqlconstr = "" Then myConnectionString = contentOfdbODBC
        If myConnectionString = "" And sqlconstr = "" Then
            'SignOff()
            Return ""
            Exit Function
        End If

        Dim myConnection As New SqlConnection(myConnectionString)
        Dim myInsertQuery As String = sqlstr
        Dim myCommand As New SqlCommand(myInsertQuery)
        Try
            Dim Reader As SqlClient.SqlDataReader

            myCommand.Connection = myConnection
            myConnection.Open()

            Reader = myCommand.ExecuteReader()

            Reader.Read()
            If Reader.HasRows Then
                result = Reader.GetValue(0).ToString
            Else
                result = ""
            End If

        Catch ex As SqlException
            contentofError = ex.Message & "<br>"
            Return ""
        Catch ex As Exception

            contentofError = ex.Message & "<br>"
            Return ""
        Finally
            myCommand.Connection.Close()
            myConnection.Close()
        End Try
        Return result
    End Function

End Module
