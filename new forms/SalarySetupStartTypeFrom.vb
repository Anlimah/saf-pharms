Public Class SalarySetupStartTypeFrom
    Private Sub SalarySetupStartTypeFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub startTypeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles startTypeListBox.SelectedIndexChanged

        If startTypeListBox.SelectedItem = "Copy From Parent Value" Then

            LoadDataIntoDatagrid(SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView,
                                 "SELECT DISTINCT p.`id`, p.`name`, s.`rate`, p.`calculation_period`, p.`pay_head_type`, p.`calculation_type`, c.`compute_on`, c.`specified_formula` 
                                 FROM `tbl_pay_head` AS p, `tbl_computation_info` AS c, `tbl_salary_details_setup` AS s 
                                 WHERE s.`phid` = p.`id` AND s.`empOrGrID` = (SELECT g.`id` FROM `tbl_group` AS g, `tbl_employee` AS e WHERE e.`group` = g.`name` AND e.`id` = '" & SalaryDetailsSetupForm.empOrGroupIDTextBox.Text & "')")
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns(0).Visible = False
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("name").HeaderText = "PAY HEAD"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("rate").HeaderText = "RATE"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("calculation_period").HeaderText = "PERIOD"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("pay_head_type").HeaderText = "PAY HEAD TYPE"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("calculation_type").HeaderText = "CALCULATION TYPE"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("compute_on").HeaderText = "COMPUTE ON"
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Columns("specified_formula").HeaderText = "SPECIFIED FORMULA"
            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Visible = False
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Visible = True
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Location = New Point(12, 273)

            SalaryDetailsSetupForm.seelectedStartTypeTextBox.Text = 1
            Me.Close()

        ElseIf startTypeListBox.SelectedItem = "Start Afresh" Then
            SalaryDetailsSetupForm.individualSalaryDetailsDataGridView.Visible = True
            SalaryDetailsSetupForm.GroupSalaryDetailsDataGridView.Visible = False

            SalaryDetailsSetupForm.seelectedStartTypeTextBox.Text = 2
            Me.Close()
            PayHeadsForm.Show()

        End If

    End Sub
End Class