Public Class PayHeadsForm
    Private Sub PayHeadsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If SalaryDetailsSetupForm.seelectedStartTypeTextBox.Text = "2" Then
            LoadDataIntoDatagrid(payHeadsDataGridView, "SELECT * FROM `tbl_pay_head`;")
            payHeadsDataGridView.Columns(0).Visible = False
            payHeadsDataGridView.Columns(2).Visible = False
            payHeadsDataGridView.Columns(3).Visible = False
            payHeadsDataGridView.Columns(4).Visible = False
            payHeadsDataGridView.Columns(5).Visible = False
            payHeadsDataGridView.Columns(6).Visible = False
            payHeadsDataGridView.Columns(7).Visible = False
            payHeadsDataGridView.Columns(8).Visible = False
            payHeadsDataGridView.Columns(9).Visible = False
            payHeadsDataGridView.Columns(10).Visible = False
            payHeadsDataGridView.Columns(11).Visible = False
            payHeadsDataGridView.Columns(12).Visible = False
            payHeadsDataGridView.Columns(13).Visible = False
            payHeadsDataGridView.Columns(14).Visible = False
            payHeadsDataGridView.Columns(1).Width = 184
            payHeadsDataGridView.Columns(1).HeaderText = "PAY HEADS"

        End If
    End Sub

    Private Sub payHeadsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles payHeadsDataGridView.CellClick

        If e.RowIndex >= 0 And e.RowIndex <= payHeadsDataGridView.RowCount - 2 Then

            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows.Add()

            Dim rowInd As Integer = SalaryDetailsSetupForm.clickedRowIndexTextBox.Text

            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("id").Value = payHeadsDataGridView.Rows(e.RowIndex).Cells("id").Value
            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("pay_head").Value = payHeadsDataGridView.Rows(e.RowIndex).Cells("name").Value
            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("pay_head_type").Value = payHeadsDataGridView.Rows(e.RowIndex).Cells("pay_head_type").Value
            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("calculation_type").Value = payHeadsDataGridView.Rows(e.RowIndex).Cells("calculation_type").Value

            If LCase(payHeadsDataGridView.Rows(e.RowIndex).Cells("calculation_type").Value) = "as computed value" Then
                Dim computeOn As String = runQueryAndReturnValue("SELECT `compute_on` FROM `tbl_computation_info` WHERE `phid` = '" & payHeadsDataGridView.Rows(e.RowIndex).Cells("id").Value & "'", "compute_on")

                If LCase(computeOn) = "on specified formula" Then
                    SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("compute_on").Value = runQueryAndReturnValue("SELECT `specified_formula` FROM `tbl_computation_info` WHERE `phid` = '" & payHeadsDataGridView.Rows(e.RowIndex).Cells("id").Value & "'", "specified_formula")
                Else
                    SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("compute_on").Value = computeOn
                End If

            ElseIf LCase(payHeadsDataGridView.Rows(e.RowIndex).Cells("calculation_type").Value) = "on production" Then
                SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("period").Value = runQueryAndReturnValue("SELECT a.`unit` FROM `tbl_pay_head` AS p, `tbl_attendance_or_production` AS a WHERE p.`attend_or_prod_type` = a.`name` AND p.`id` = '" & payHeadsDataGridView.Rows(e.RowIndex).Cells("id").Value & "';", "unit")

            ElseIf LCase(payHeadsDataGridView.Rows(e.RowIndex).Cells("calculation_period").Value) <> "" Then
                SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Rows(rowInd).Cells("period").Value = payHeadsDataGridView.Rows(e.RowIndex).Cells("calculation_period").Value
            End If

            SalaryDetailsSetupForm.clickedRowIndexTextBox.Text = rowInd + 1

            For Each row As DataGridViewRow In payHeadsDataGridView.SelectedRows
                payHeadsDataGridView.Rows.Remove(row)
            Next

        End If

    End Sub

    Private Sub payHeadsDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles payHeadsDataGridView.CellMouseDoubleClick

    End Sub

    Private Sub payHeadsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles payHeadsDataGridView.CellContentClick

    End Sub
End Class