Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllDefaultAndRequiredDataIntoDgv()
    End Sub

    Private Sub PayEarningsButton_Click(sender As Object, e As EventArgs) Handles PayEarningsButton.Click
        'PayDeductionsPanel.Hide()
        'PayContributionsPanel.Hide()
        'PayAllowancesPanel.Hide()
        'PayProcessPayrollPanel.Hide()
        'PayEmployeesNamePanel.Show()
        'PayEarningsPanel.Show()
    End Sub

    Private Sub PayDeductionsButton_Click(sender As Object, e As EventArgs) Handles PayDeductionsButton.Click

    End Sub

    Private Sub PayContributionsButton_Click(sender As Object, e As EventArgs) Handles PayContributionsButton.Click

    End Sub

    Private Sub PayProcessPayrollButton_Click(sender As Object, e As EventArgs) Handles PayProcessPayrollButton.Click
        Label1.Visible = True
        PayEmployeesNameDataGridView.Enabled = False
        PayEarningsDataGridView.Enabled = False
        PayDeductionsDataGridView.Enabled = False
        PayContributionsDataGridView.Enabled = False
        If RunAll() = 1 Then
            Label1.Text = "Done Processing"
        End If
    End Sub

    Public Sub LoadAllDefaultAndRequiredDataIntoDgv()

        'load allowances, deductions and contribution
        LoadDataIntoDatagrid(allowancesNamesDataGridView, "SELECT `name` AS 'allowance', `amount` FROM tbl_allowance")
        LoadDataIntoDatagrid(DeductionNamesDataGridView, "SELECT `name` AS 'deduction', `rate` FROM tbl_deduction")
        LoadDataIntoDatagrid(ContributionNamesDataGridView, "SELECT `name` AS 'contribution', `rate` FROM tbl_contribution")

        'Load Employee names
        LoadDataIntoDatagrid(PayEmployeesNameDataGridView,
                         "CALL proc_disp_employee_names ('" & PayProcessIDTextBox.Text & "');")
        PayEmployeesNameDataGridView.Columns(0).Visible = False

        'Load earnings: basic salary  and all the allowances as (checkboxes)
        LoadDataIntoDatagrid(PayEarningsDataGridView,
                         "CALL proc_disp_employee_basic_salary ('" & PayProcessIDTextBox.Text & "');")
        PayEarningsDataGridView.Columns(0).Visible = False

        'Load earnings: basic salary  and all the allowances as (checkboxes)
        LoadDataIntoDatagrid(PayDeductionsDataGridView,
                         "CALL proc_disp_employee_id_in_payroll ('" & PayProcessIDTextBox.Text & "');")
        PayDeductionsDataGridView.Columns(0).Visible = False

        'Load earnings: basic salary  and all the allowances as (checkboxes)
        LoadDataIntoDatagrid(PayContributionsDataGridView,
                         "CALL proc_disp_employee_id_in_payroll ('" & PayProcessIDTextBox.Text & "');")
        PayContributionsDataGridView.Columns(0).Visible = False

        'allowances
        Dim total_allwows As Integer = allowancesNamesDataGridView.RowCount - 1 'total allowance in database
        If total_allwows > 0 Then
            For index = 0 To total_allwows - 1
                'Create a new checkbox in datagridview
                PayEarningsDataGridView.Columns.Add(New DataGridViewTextBoxColumn())
                'rename the new added check column  
                PayEarningsDataGridView.Columns(PayEarningsDataGridView.ColumnCount - 1).Name = allowancesNamesDataGridView.Rows(index).Cells("allowance").Value
                'rename the column's header 
                PayEarningsDataGridView.Columns(PayEarningsDataGridView.ColumnCount - 1).HeaderText = UCase(allowancesNamesDataGridView.Rows(index).Cells("allowance").Value) & " ALLOWANCE"
                'go through all the rows in the datagrid and check all the rows new added column to true
                For i = 0 To PayEarningsDataGridView.RowCount - 2
                    PayEarningsDataGridView.Rows(i).Cells(allowancesNamesDataGridView.Rows(index).Cells(0).Value).Value = allowancesNamesDataGridView.Rows(index).Cells("amount").Value
                Next
            Next
        End If

        'deductions
        Dim total_deds As Integer = DeductionNamesDataGridView.RowCount - 1 'total allowance in database
        If total_deds > 0 Then
            For index = 0 To total_deds - 1
                'Create a new checkbox in datagridview
                PayDeductionsDataGridView.Columns.Add(New DataGridViewCheckBoxColumn())
                'rename the new added check column  
                PayDeductionsDataGridView.Columns(PayDeductionsDataGridView.ColumnCount - 1).Name = DeductionNamesDataGridView.Rows(index).Cells("deduction").Value
                If LCase(DeductionNamesDataGridView.Rows(index).Cells("deduction").Value) = "income tax" Then
                    'rename the column's header 
                    PayDeductionsDataGridView.Columns(PayDeductionsDataGridView.ColumnCount - 1).HeaderText = UCase(DeductionNamesDataGridView.Rows(index).Cells("deduction").Value)
                Else
                    'rename the column's header 
                    PayDeductionsDataGridView.Columns(PayDeductionsDataGridView.ColumnCount - 1).HeaderText = UCase(DeductionNamesDataGridView.Rows(index).Cells("deduction").Value) & " [" & DeductionNamesDataGridView.Rows(index).Cells("rate").Value & "%]"
                End If
                'go through all the rows in the datagrid and check all the rows new added column to true
                For i = 0 To PayDeductionsDataGridView.RowCount - 2
                    PayDeductionsDataGridView.Rows(i).Cells(DeductionNamesDataGridView.Rows(index).Cells(0).Value).Value = True
                Next
            Next
        End If

        'contribution
        Dim total_conts As Integer = ContributionNamesDataGridView.RowCount - 1 'total allowance in database
        If total_conts > 0 Then
            For index = 0 To total_conts - 1
                'Create a new checkbox in datagridview
                PayContributionsDataGridView.Columns.Add(New DataGridViewCheckBoxColumn())
                'rename the new added check column  
                PayContributionsDataGridView.Columns(PayContributionsDataGridView.ColumnCount - 1).Name = ContributionNamesDataGridView.Rows(index).Cells("contribution").Value
                'rename the column's header 
                PayContributionsDataGridView.Columns(PayContributionsDataGridView.ColumnCount - 1).HeaderText = UCase(ContributionNamesDataGridView.Rows(index).Cells("contribution").Value) & " [" & ContributionNamesDataGridView.Rows(index).Cells("rate").Value & "%]"
                'go through all the rows in the datagrid and check all the rows new added column to true
                For i = 0 To PayContributionsDataGridView.RowCount - 2
                    PayContributionsDataGridView.Rows(i).Cells(ContributionNamesDataGridView.Rows(index).Cells(0).Value).Value = True
                Next
            Next
        End If

    End Sub

    Private Sub PaySelectEmpButton_Click(sender As Object, e As EventArgs) Handles PaySelectEmpButton.Click
        AddEmpToProcessPayrollForm.Show()
        Me.Hide()
    End Sub

    'Remember to add the else stmts
    Private Sub PayEarningsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayEarningsDataGridView.CellContentClick
        If (PayEarningsDataGridView.RowCount - 2) > 0 And e.ColumnIndex > 0 Then
            If PayEarningsDataGridView.Columns(e.ColumnIndex).Name <> UCase("basic salary") Then
                If PayEarningsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                    If runQuery("UPDATE `tbl_applicable` SET `" & PayEarningsDataGridView.Columns(e.ColumnIndex).Name & "` = 0 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayEarningsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                        If runQuery("UPDATE tbl_payroll SET `" & PayEarningsDataGridView.Columns(e.ColumnIndex).Name & "` = 0, `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayEarningsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                        End If
                    End If
                ElseIf PayEarningsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                    If runQuery("UPDATE `tbl_applicable` SET `" & PayEarningsDataGridView.Columns(e.ColumnIndex).Name & "` = 1 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayEarningsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                        If runQuery("UPDATE tbl_payroll SET `" & PayEarningsDataGridView.Columns(e.ColumnIndex).Name & "` = " & allowancesNamesDataGridView.Rows(e.ColumnIndex - 2).Cells(1).Value & ", `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayEarningsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PayDeductionsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayDeductionsDataGridView.CellContentClick
        If (PayDeductionsDataGridView.RowCount - 2) > 0 And e.ColumnIndex > 0 Then
            If PayDeductionsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                If runQuery("UPDATE `tbl_applicable` SET `" & PayDeductionsDataGridView.Columns(e.ColumnIndex).Name & "` = 0 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayDeductionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    If runQuery("UPDATE tbl_payroll SET `" & PayDeductionsDataGridView.Columns(e.ColumnIndex).Name & "` = 0, `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayDeductionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    End If
                End If
            ElseIf PayDeductionsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                If runQuery("UPDATE `tbl_applicable` SET `" & PayDeductionsDataGridView.Columns(e.ColumnIndex).Name & "` = 1 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayDeductionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    If runQuery("UPDATE tbl_payroll SET `" & PayDeductionsDataGridView.Columns(e.ColumnIndex).Name & "` = " & ((DeductionNamesDataGridView.Rows(e.ColumnIndex - 1).Cells(1).Value / 100) * PayEarningsDataGridView.Rows(e.RowIndex).Cells("BASIC SALARY").Value) & ", `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayDeductionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PayContributionsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayContributionsDataGridView.CellContentClick
        If (PayContributionsDataGridView.RowCount - 2) > 0 And e.ColumnIndex > 0 Then
            If PayContributionsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                If runQuery("UPDATE `tbl_applicable` SET `" & PayContributionsDataGridView.Columns(e.ColumnIndex).Name & "` = 0 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayContributionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    If runQuery("UPDATE tbl_payroll SET `" & PayContributionsDataGridView.Columns(e.ColumnIndex).Name & "` = 0, `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayContributionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    End If
                End If
            ElseIf PayContributionsDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                If runQuery("UPDATE `tbl_applicable` SET `" & PayContributionsDataGridView.Columns(e.ColumnIndex).Name & "` = 1 
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayContributionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    If runQuery("UPDATE tbl_payroll SET `" & PayContributionsDataGridView.Columns(e.ColumnIndex).Name & "` = " & ((ContributionNamesDataGridView.Rows(e.ColumnIndex - 1).Cells(1).Value / 100) * PayEarningsDataGridView.Rows(e.RowIndex).Cells("BASIC SALARY").Value) & ", `updated_at` = CURRENT_TIMESTAMP  
                            WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                            AND `empid` = '" & PayContributionsDataGridView.Rows(e.RowIndex).Cells(0).Value & "'") = 1 Then
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PayEarningsDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PayEarningsDataGridView.CellEndEdit
        If PayEarningsDataGridView.Columns(e.ColumnIndex).Name = UCase("basic salary") Then
            If runQuery("UPDATE tbl_payroll SET `basic_salary` = " & PayEarningsDataGridView.Rows(e.RowIndex).Cells("BASIC SALARY").Value & ", `updated_at` = CURRENT_TIMESTAMP  
                        WHERE `pid` = '" & PayProcessIDTextBox.Text & "' 
                        AND `empid` = '" & PayEarningsDataGridView.Rows(e.RowIndex).Cells("empid").Value & "'") = 1 Then
            Else
                MsgBox("COULDN'T update basic salary")
            End If
        End If
    End Sub

    Function RunAll() As Integer
        Dim pid As Integer = PayProcessIDTextBox.Text
        Dim checker As Integer = 0
        For index = 0 To PayEarningsDataGridView.RowCount - 2
            Dim empid As Integer = PayEarningsDataGridView.Rows(index).Cells("empid").Value
            Dim allow As Decimal = 0
            Dim deduct As Decimal = 0

            Dim basic_salary As Decimal = runQueryAndReturnValue("SELECT `basic_salary` FROM `tbl_payroll` WHERE `pid` = '" & pid & "' AND `empid` = '" & empid & "'", "basic_salary")

            For j = 0 To allowancesNamesDataGridView.RowCount - 2
                allow += runQueryAndReturnValue("SELECT DISTINCT p.`" & allowancesNamesDataGridView.Rows(j).Cells(0).Value & "` AS 'allow' FROM `tbl_payroll` AS p, `tbl_allowance` AS a WHERE p.`pid` = '" & pid & "' AND p.`empid` = '" & empid & "' AND a.`taxable` = 1", "allow")
            Next

            For k = 0 To DeductionNamesDataGridView.RowCount - 2
                deduct += runQueryAndReturnValue("SELECT `" & DeductionNamesDataGridView.Rows(k).Cells(0).Value & "` FROM `tbl_payroll` WHERE `pid` = '" & pid & "' AND `empid` = '" & empid & "'", DeductionNamesDataGridView.Rows(k).Cells(0).Value)
            Next

            Dim taxable_pay As Decimal = (basic_salary - deduct) + allow
            Dim income_tax As Decimal = calculateIncomeTax(taxable_pay)
            Dim employee_ssnit As Decimal = runQueryAndReturnValue("SELECT `Employee SSNIT` AS 'emp_ssnit' FROM `tbl_payroll` WHERE `pid` = '" & pid & "' AND `empid` = '" & empid & "'", "emp_ssnit")
            Dim net_salary As Decimal = basic_salary - employee_ssnit - income_tax

            If runQuery("UPDATE `tbl_payroll` SET `taxable_pay` = " & taxable_pay & ", `Income Tax` = " & income_tax & ", `net_salary` = " & net_salary & " WHERE  `pid` = '" & pid & "' AND `empid` = '" & empid & "'") = 1 Then
                checker += 1
                Label1.Text = "Processing..."
            End If
        Next
        If checker = PayEarningsDataGridView.RowCount - 1 Then
            Return 1
        End If
        Return 0
    End Function

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainPage.Show()
    End Sub
End Class