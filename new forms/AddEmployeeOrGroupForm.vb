﻿Public Class AddEmployeeOrGroupForm

    Private Sub AddEmployeeOrGroupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EmpOrGroupComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EmpOrGroupComboBox.SelectedIndexChanged
        If LCase(EmpOrGroupComboBox.SelectedItem) = "employee" Then
            LoadDataIntoDatagrid(EmpOrGroupNameDataGridView, "SELECT `id`, CONCAT(`surname`, ' ', `first_name`) AS 'employee', `category` FROM `tbl_employee`;")
            EmpOrGroupNameDataGridView.Columns(1).HeaderText = "EMPLOYEE"

        ElseIf LCase(EmpOrGroupComboBox.SelectedItem) = "group" Then
            LoadDataIntoDatagrid(EmpOrGroupNameDataGridView, "SELECT g.`id`, g.`name` AS 'group', c.`name` AS 'category' FROM `tbl_group` AS g , `tbl_category` AS c WHERE c.`id` = g.`catId`;")
            EmpOrGroupNameDataGridView.Columns(1).HeaderText = "GROUP"
        End If

        EmpOrGroupNameDataGridView.Columns("id").Visible = False
        EmpOrGroupNameDataGridView.Columns("category").Visible = False
        EmpOrGroupNameDataGridView.Columns(1).Width = 195
    End Sub

    Private Sub EmpOrGroupNameDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpOrGroupNameDataGridView.CellClick
        If e.RowIndex >= 0 And e.RowIndex <= EmpOrGroupNameDataGridView.RowCount - 2 Then
            empOrGroupTypeTextBox.Text = EmpOrGroupComboBox.Text
            SalaryDetailsSetupForm.empOrGroupTypeTextBox.Text = empOrGroupTypeTextBox.Text
            SalaryDetailsSetupForm.empOrGroupIDTextBox.Text = EmpOrGroupNameDataGridView.Rows(e.RowIndex).Cells("id").Value
            SalaryDetailsSetupForm.empNameOrGroupTextBox.Text = EmpOrGroupNameDataGridView.Rows(e.RowIndex).Cells(1).Value
            SalaryDetailsSetupForm.underTextBox.Text = EmpOrGroupNameDataGridView.Rows(e.RowIndex).Cells("category").Value
            Me.Close()
        End If
    End Sub

End Class