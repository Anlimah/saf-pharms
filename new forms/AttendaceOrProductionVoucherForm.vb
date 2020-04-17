Public Class AttendaceOrProductionVoucherForm

    Private Sub AttendaceOrProductionVoucherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveVoucherDetailsButton_Click(sender As Object, e As EventArgs) Handles SaveVoucherDetailsButton.Click

        attendOrProductUnitTextBox.Text = runQueryAndReturnValue("SELECT `unit` FROM `tbl_attendance_or_production` 
            WHERE `id` = '" & attendOrProdIDTextBox.Text & "'", "unit")

        If LCase(empOrGroupTypeTextBox.Text) = "employee" Then
            LoadDataIntoDatagrid(attendOrProductVoucherDataGridView,
                                 "SELECT `id`, CONCAT(`surname`, ' ', `first_name`) AS 'NAME' FROM `tbl_employee` 
                                    WHERE `id` = '" & empOrGroupIDTextBox.Text & "'")

        ElseIf LCase(empOrGroupTypeTextBox.Text) = "group" Then
            LoadDataIntoDatagrid(attendOrProductVoucherDataGridView,
                                 "SELECT e.`id`, CONCAT(e.`surname`, ' ', e.`first_name`) AS 'NAME' FROM `tbl_employee` AS e 
                                    WHERE e.`category` = '" & empCategoryComboBox.Text & "'")

        ElseIf LCase(empOrGroupTypeTextBox.Text) = "all items" Then
            LoadDataIntoDatagrid(attendOrProductVoucherDataGridView,
                                 "SELECT `id`, CONCAT(`surname`, ' ', `first_name`) AS 'NAME' FROM `tbl_employee`")

        End If

        attendOrProductVoucherSetupPanel.Hide()
        Me.Width = Me.MaximumSize.Width
        Me.Height = Me.MaximumSize.Height
        attendOrProductVoucherDataGridView.Show()


        For index = 0 To attendOrProductVoucherDataGridView.RowCount - 2
            attendOrProductVoucherDataGridView.Rows(index).Cells("type").Value = AttendOrProductComboBox.Text.ToString
            attendOrProductVoucherDataGridView.Rows(index).Cells("value").Value = defaultValueTextBox.Text.ToString
            attendOrProductVoucherDataGridView.Rows(index).Cells("unit").Value = attendOrProductUnitTextBox.Text.ToString
        Next

        attendOrProductVoucherDataGridView.Columns("id").DisplayIndex = 0
        attendOrProductVoucherDataGridView.Columns("NAME").DisplayIndex = 1
        attendOrProductVoucherDataGridView.Columns("id").Visible = False
        attendOrProductVoucherDataGridView.Columns("NAME").Width = 232
        attendOrProductVoucherDataGridView.Columns("NAME").ReadOnly = True


    End Sub

    Private Sub CancelVoucherDetailsButton_Click(sender As Object, e As EventArgs) Handles CancelVoucherDetailsButton.Click
        voucherDateTimePicker.Text = Date.Now
        empCategoryComboBox.Text = "Primary Cost Category"
        empCatIDTextBox.Text = "1"
        empOrGroupNameTextBox.Text = "All Items"
        empOrGroupTypeTextBox.Text = "All Items"
        empOrGroupIDTextBox.Text = "0"
        AttendOrProductComboBox.Text = ""
        attendOrProdIDTextBox.Text = ""
        defaultValueTextBox.Text = "0"
    End Sub

    Private Sub empCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles empCategoryComboBox.SelectedIndexChanged
        empCatIDTextBox.Text = empCategoryComboBox.SelectedValue.ToString
    End Sub

    Private Sub empCategoryComboBox_Click(sender As Object, e As EventArgs) Handles empCategoryComboBox.Click
        FetchComboData(empCategoryComboBox, "SELECT * FROM `tbl_category`", "name")
        empCategoryComboBox.Text = ""
        empCatIDTextBox.Text = ""
    End Sub

    Private Sub empOrGroupNameTextBox_Click(sender As Object, e As EventArgs) Handles empOrGroupNameTextBox.Click
        SelectVoucherTypeForm.Show()
    End Sub

    Private Sub AttendOrProductComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttendOrProductComboBox.SelectedIndexChanged
        attendOrProdIDTextBox.Text = AttendOrProductComboBox.SelectedValue.ToString
    End Sub

    Private Sub AttendOrProductComboBox_Click(sender As Object, e As EventArgs) Handles AttendOrProductComboBox.Click
        FetchComboData(AttendOrProductComboBox, "SELECT * FROM `tbl_attendance_or_production`", "name")
        AttendOrProductComboBox.Text = ""
        attendOrProdIDTextBox.Text = ""
    End Sub

    Private Sub setupAOrPVoucherButton_Click(sender As Object, e As EventArgs) Handles setupAOrPVoucherButton.Click
        attendOrProductVoucherDataGridView.Hide()
        attendOrProductVoucherSetupPanel.Show()
        Me.Width = Me.MinimumSize.Width
        Me.Height = Me.MinimumSize.Height
    End Sub

    Private Sub attendOrProductVoucherDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles attendOrProductVoucherDataGridView.CellContentClick

    End Sub

    Private Sub attendOrProductVoucherDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles attendOrProductVoucherDataGridView.CellEndEdit
        If CInt(attendOrProductVoucherDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) > 27 Then
            MsgBox("Value can't be greater than 27")
            attendOrProductVoucherDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = defaultValueTextBox.Text
        End If
    End Sub

    Private Sub saveAttendOrProductVoucherButton_Click(sender As Object, e As EventArgs) Handles saveAttendOrProductVoucherButton.Click
        Dim pay_id As Integer = 1
        Dim x As Integer = 0

        For index = 0 To attendOrProductVoucherDataGridView.RowCount - 2
            If runQuery("INSERT INTO `tbl_emp_attend_or_product_vouvher`(`pid`,`empid`,`type`,`value`, `unit`, `added_at`) 
                VALUES('" & pay_id & "', 
                        '" & attendOrProductVoucherDataGridView.Rows(index).Cells("id").Value & "', 
                        '" & attendOrProductVoucherDataGridView.Rows(index).Cells("type").Value & "', 
                        '" & attendOrProductVoucherDataGridView.Rows(index).Cells("value").Value & "', 
                        '" & attendOrProductVoucherDataGridView.Rows(index).Cells("unit").Value & "', 
                        CURRENT_TIMESTAMP)") = 1 Then
                x += 1
            End If
        Next

        If x = attendOrProductVoucherDataGridView.RowCount - 1 Then
            MsgBox("Data saved successfully!")
        End If

    End Sub
End Class