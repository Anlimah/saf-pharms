Imports MySql.Data.MySqlClient

Module ProcessPayrollModule

    Private WORKING_DAYS As Integer = 0


    'For gra tax slab
    Dim AMT_FROM As Decimal = 0
    Dim AMT_TO As Decimal = 0
    Dim CHRG_AMT As Decimal = 0
    Dim PERCENT As Decimal = 0
    Dim AMT_CRH As Decimal = 0
    Dim FREE_AMT As Decimal = 0

    'taxaable pay
    Private BASIC_SALARY As Decimal = 0
    Private EMPLOYEE_SSNIT As Decimal = 0
    Private EMPLOYEE_PF As Decimal = 0


    Private Function setupVars(ByVal id As Integer) As Integer

        Try
            Dim query As String = "SELECT * FROM `tbl_gra_refera` WHERE `id` ='" & id & "'"
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    AMT_FROM = CType(dr.Item("amt_from"), Decimal)
                    AMT_TO = CType(dr.Item("amt_to"), Decimal)
                    CHRG_AMT = CType(dr.Item("chrg_amt"), Decimal)
                    PERCENT = CType(dr.Item("percentage"), Decimal)
                    AMT_CRH = CType(dr.Item("amt_crh"), Decimal)
                End While
            End If
            conn.Close()
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        Finally
            conn.Close()
        End Try

        Return 0
    End Function


    Public Function setupAdecimalVal(ByVal query As String, ByVal rtrn As String) As Decimal

        Try
            Dim value As Decimal = 0
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            da = New MySqlDataAdapter(cmd)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    value = CType(dr.Item(rtrn), Decimal)
                End While
            End If
            conn.Close()
            Return value
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        Finally
            conn.Close()
        End Try

        Return 0
    End Function

    Public Function calculateIncomeTax(ByVal taxable_pay As Decimal) As Decimal

        setupVars(1)

        For i = 1 To runQueryAndReturnValue("SELECT COUNT(*) AS 'total' FROM `tbl_gra_refera`", "total")
            If taxable_pay > AMT_TO Then
                setupVars(i + 1)
            Else
                If i > 1 Then
                    FREE_AMT = CType(runQueryAndReturnValue("SELECT `free_amt` FROM `tbl_gra_refera` WHERE `id` = '" & (i - 1) & "'", "free_amt"), Decimal)
                Else
                    FREE_AMT = CType(runQueryAndReturnValue("SELECT `free_amt` FROM `tbl_gra_refera` WHERE `id` = '" & i & "'", "free_amt"), Decimal)
                End If
                Exit For
            End If
        Next

        Dim income_tax As Decimal = (taxable_pay - AMT_FROM) * PERCENT / 100 + FREE_AMT

        Return income_tax
    End Function


    Public Function CalcEmpTaxableAllowance(ByVal empId As Integer, ByVal pId As Integer) As Decimal
        Dim totalTaxableAllowance As Decimal = 0
        For a = 0 To MainForm.allowancesNamesDataGridView.RowCount - 2
            totalTaxableAllowance += CType(runQueryAndReturnValue("SELECT DISTINCT 
                p.`" & MainForm.allowancesNamesDataGridView.Rows(a).Cells(0).Value & "` AS 'allow' 
                FROM `tbl_payroll` AS p, `tbl_allowance` AS a
                WHERE `pid` = '" & pId & "' AND `empid` = '" & empId & "' AND a.`taxable` = 1;", "allow"), Decimal)
        Next
        Return totalTaxableAllowance
    End Function


    Public Function CalcEmpDeduction(ByVal empId As Integer, ByVal pId As Integer) As Decimal
        Dim totalDeduction As Decimal = 0
        For d = 0 To MainForm.DeductionNamesDataGridView.RowCount - 2
            totalDeduction += CType(runQueryAndReturnValue("SELECT  
            `" & MainForm.DeductionNamesDataGridView.Rows(d).Cells(0).Value & "` AS 'deduct' 
            FROM `tbl_payroll` WHERE `pid` = '" & pId & "' AND `empid` = '" & empId & "';", "deduct"), Decimal)
        Next
        Return totalDeduction
    End Function

    Public Function calcEmpTaxablePay(ByVal pId As Integer, ByVal empId As Integer) As Integer


        Return 0
    End Function

    Public Function calculateNetSalary() As Integer

        Return 0
    End Function

    Public Function setupProcessPayroll() As Integer

        Return 0
    End Function

    Public Function checkColumn(ByVal table_name As String, ByVal column_name As String) As String
        Dim sql As String = "SELECT IF(count(*) = 1, 'Exist','Not Exist') AS result 
                            FROM information_schema.columns 
                            WHERE table_schema = 'db_fast_pharms' 
                            AND table_name = '" & table_name & "' 
                            AND column_name = '" & column_name & "';"
        MsgBox(runQueryAndReturnValue(sql, "result"))
        Return 0
    End Function

End Module
