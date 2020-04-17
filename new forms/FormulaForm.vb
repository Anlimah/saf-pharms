Public Class FormulaForm
    Private Sub FormulaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveFunctionButton_Click(sender As Object, e As EventArgs) Handles SaveFunctionButton.Click

        PayHeadCreationForm.specifiedFormulaTextBox.Text = "="
        For i = 0 To userSpecifiedFunctionDataGridView.RowCount - 1

            If userSpecifiedFunctionDataGridView.Rows(i).Cells("symbol").Value = "(" Or userSpecifiedFunctionDataGridView.Rows(i).Cells("symbol").Value = ")" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += userSpecifiedFunctionDataGridView.Rows(i).Cells("symbol").Value
            End If

            If userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value = "Add Pay Head" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += " + "
            ElseIf userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value = "Substract Pay Head" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += " - "
            ElseIf userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value = "Divide by Attendance" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += " / "
            ElseIf userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value = "Multiply by Attendance" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += " * "
            End If

            If userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value <> "Divide by Attendance" And
                userSpecifiedFunctionDataGridView.Rows(i).Cells("thefunction").Value <> "Multiply by Attendance" Then
                PayHeadCreationForm.specifiedFormulaTextBox.Text += userSpecifiedFunctionDataGridView.Rows(i).Cells("pay_head").Value
            Else
                PayHeadCreationForm.specifiedFormulaTextBox.Text += "attendance"
            End If

        Next

        MsgBox("Saved successfully!")

    End Sub

    Private Sub userSpecifiedFunctionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userSpecifiedFunctionDataGridView.CellClick
        If e.ColumnIndex = 1 Then
            rowIndexTextBox.Text = e.RowIndex
            FormulaTypeSelectionForm.Show()
        ElseIf e.ColumnIndex = 2 Then
            If userSpecifiedFunctionDataGridView.Rows(e.RowIndex).Cells("thefunction").Value <> "" Then
                If userSpecifiedFunctionDataGridView.Rows(e.RowIndex).Cells("thefunction").Value = "Divide by Attendance" Then
                    userSpecifiedFunctionDataGridView.Rows(e.RowIndex).Cells("pay_head").Value =
                    runQueryAndReturnValue("SELECT `name` FROM `tbl_attendance_or_production` 
                    WHERE `type` LIKE 'Attendance%' AND `name` LIKE 'Present%'", "name")
                ElseIf userSpecifiedFunctionDataGridView.Rows(e.RowIndex).Cells("thefunction").Value = "Multiply by Attendance" Then
                    userSpecifiedFunctionDataGridView.Rows(e.RowIndex).Cells("pay_head").Value =
                    runQueryAndReturnValue("SELECT `name` FROM `tbl_attendance_or_production` 
                    WHERE `type` LIKE 'Attendance%' AND `name` LIKE 'Present%'", "name")
                Else
                    AddPayHeadForm.Show()
                End If
            End If
        End If
    End Sub

    Private Sub HideFormButton_Click(sender As Object, e As EventArgs) Handles HideFormButton.Click
        Me.Hide()
    End Sub

    Private Sub CancelPayHeadButton_Click(sender As Object, e As EventArgs) Handles CancelPayHeadButton.Click
        userSpecifiedFunctionDataGridView.Rows.Clear()
    End Sub
End Class