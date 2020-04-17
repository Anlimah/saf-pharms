Imports MySql.Data.MySqlClient

Module DBModule
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public dr As MySqlDataReader
    Public NewData As Boolean
    Public i, o As Integer

    'Public servername As String = readfile("serverName.txt")
    Public servername As String = "local"

    Public Function connect() As Integer
        Try
            If String.IsNullOrEmpty(servername) Or servername = "no" Then
                Return 0
            Else
                conn.ConnectionString = "server=localhost;userid=root;password=fast;database=db_fast_pharms"
                If conn.ConnectionString.Any = True Then
                    'MsgBox("Connected to Server!")
                    Return 1
                Else
                    MsgBox("Unable to Connect Server!")
                    Return 0
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        Finally
            conn.Close()
        End Try
    End Function

    Function runQuery(query As String) As Integer
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            i = cmd.ExecuteNonQuery
            conn.Close()
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
            Return -1
        Finally
            conn.Close()
        End Try
    End Function

    Public Function runQueryAndReturnValue(ByVal query As String, ByVal value As String) As String
        Try
            Dim returnValue As String = ""
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    returnValue = dr.Item(value)
                End While
            End If
            conn.Close()
            Return returnValue
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            Return -1
        Finally
            conn.Close()
        End Try

    End Function

End Module
