Imports MySql.Data.MySqlClient

Module ContsDedsModule
    Public Sub setContsDedsDetails(ByVal contsDedsID As String, ByVal tbl As String)
        Try
            Dim query As String = "SELECT * FROM `tbl_" & tbl & "` WHERE `id` = '" & contsDedsID & "'"
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    ContsDedsForm.contsDedsNameTextBox.Text = dr.Item("name")
                    If LCase(ContsDedsForm.Text) <> "allowance" Then
                        ContsDedsForm.contsdedsAmountTextBox.Text = dr.Item("rate")
                    Else
                        ContsDedsForm.contsdedsAmountTextBox.Text = dr.Item("amount")
                    End If
                    ContsDedsForm.contsDedsCommentTextBox.Text = dr.Item("comment")
                End While
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
    Public Function createContsDeds(ByVal name As String, ByVal amount As Decimal,
                                    ByVal comment As String, ByVal tbl As String) As Integer
        Try

            Dim query As String = ""
            If LCase(tbl) = "allowance" Then
                query = "INSERT INTO `tbl_" & tbl & "` (`name`, `amount`, `comment`, `added_at`) 
                        VALUES('" & name & "', '" & amount & "', '" & comment & "', CURRENT_TIMESTAMP)"
            Else
                query = "INSERT INTO `tbl_" & tbl & "` (`name`, `rate`, `comment`, `added_at`) 
                        VALUES('" & name & "', '" & amount & "', '" & comment & "', CURRENT_TIMESTAMP)"
            End If

            If runQuery(query) = 1 Then
                If runQuery("ALTER TABLE `tbl_payroll` ADD `" & name & "` DECIMAL(10,2) NOT NULL DEFAULT " & amount & " AFTER `empid`") = 1 Then
                    If runQuery("ALTER TABLE `tbl_applicable` ADD `" & name & "` TINYINT NOT NULL DEFAULT 1 AFTER `empid`;") = 1 Then
                        Return 1
                    End If
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function updateContsDeds(ByVal name As String, ByVal amount As Decimal,
                                    ByVal comment As String, ByVal tbl As String, ByVal tblID As Integer) As Integer
        Try
            Dim query As String = ""
            If LCase(tbl) = "allowance" Then
                query = "UPDATE tbl_" + tbl + " SET `name` ='" & name & "', `amount` = '" & amount & "', 
                                       `comment` = '" & comment & "', `updated_at` = CURRENT_TIMESTAMP
                                        WHERE `id` = '" & tblID & "'"
            Else
                query = "UPDATE tbl_" + tbl + " SET `name` ='" & name & "', `rate` = '" & amount & "', 
                                       `comment` = '" & comment & "', `updated_at` = CURRENT_TIMESTAMP 
                                        WHERE `id` = '" & tblID & "'"
            End If
            Return runQuery(query)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function deleteContsDeds(ByVal name As String, ByVal tbl As String) As Integer
        Try
            If runQuery("DELETE FROM `tbl_" + tbl + "` WHERE `name` = '" & name & "';") = 1 Then
                If runQuery("ALTER TABLE `tbl_payroll` DROP COLUMN " & name & ";") = 1 Then
                    If runQuery("ALTER TABLE `tbl_applicable` DROP COLUMN " & name & ";") = 1 Then
                        Return 1
                    End If
                End If
            End If
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function
End Module
