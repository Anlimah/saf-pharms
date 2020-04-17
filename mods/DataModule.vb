Imports MySql.Data.MySqlClient

Module DataModule

    Public Sub FetchComboData(combo, sql, disp)
        Try
            conn.Open()
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            combo.DataSource = dt
            combo.DisplayMember = disp
            combo.ValueMember = "id"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub LoadDataIntoDatagrid(datagrid, query)
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            datagrid.DataSource = dt
            datagrid.Enabled = True
            conn.Close()
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Module
