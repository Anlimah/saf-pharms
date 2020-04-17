Public Class SalaryDetailsSetupForm
    Private Sub SetupSalaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub empNameOrGroupTextBox_Click(sender As Object, e As EventArgs) Handles empNameOrGroupTextBox.Click
        AddEmployeeOrGroupForm.Show()
    End Sub

    Private Sub addPayHeadsButton_Click(sender As Object, e As EventArgs) Handles addPayHeadsButton.Click
        If empNameOrGroupTextBox.Text = "" And empOrGroupIDTextBox.Text = "" Then
            empNameOrGroupTextBox.Focus()
        Else
            SalarySetupStartTypeFrom.Show()
            Me.Width = Me.MaximumSize.Width
            Me.Height = Me.MaximumSize.Height

        End If
    End Sub

    Private Sub SavesSalaryDetailsButton_Click(sender As Object, e As EventArgs) Handles SavesSalaryDetailsButton.Click

        If empOrGroupIDTextBox.Text = "" And empOrGroupTypeTextBox.Text = "" And empNameOrGroupTextBox.Text = "" Then
            Exit Sub
        End If

        Dim empOrGroupId As Integer = empOrGroupIDTextBox.Text
        Dim empOrGroupType As String = empOrGroupTypeTextBox.Text

        If seelectedStartTypeTextBox.Text = "1" Then
            Dim x As Integer = 0

            For index = 0 To GroupSalaryDetailsDataGridView.RowCount - 2
                If runQuery("INSERT INTO `tbl_salary_details_setup`(`phid`, `empOrGrID`, `type`, `rate`) 
                VALUES ('" & GroupSalaryDetailsDataGridView.Rows(index).Cells("id").Value & "', '" & empOrGroupId & "', '" & empOrGroupType & "', '" & GroupSalaryDetailsDataGridView.Rows(i).Cells("rate").Value & "')") = 1 Then
                    x += 1
                End If
            Next

            If x = GroupSalaryDetailsDataGridView.RowCount - 1 Then
                MsgBox("Salary details successfully created!")
            End If

        ElseIf seelectedStartTypeTextBox.Text = "2" Then
            Dim x As Integer = 0

            For index = 0 To individualSalaryDetailsDataGridView.RowCount - 2
                If runQuery("INSERT INTO `tbl_salary_details_setup`(`phid`, `empOrGrID`, `type`, `rate`) 
                VALUES ('" & individualSalaryDetailsDataGridView.Rows(index).Cells("id").Value & "', '" & empOrGroupId & "', '" & empOrGroupType & "', '" & If(individualSalaryDetailsDataGridView.Rows(index).Cells("rate").Value = "", 0, individualSalaryDetailsDataGridView.Rows(index).Cells("rate").Value) & "')") = 1 Then
                    x += 1
                End If
            Next

            If x = individualSalaryDetailsDataGridView.RowCount - 1 Then
                MsgBox("Salary details successfully created!")
            End If

        Else
            Exit Sub
        End If

        clearData()

    End Sub

    Private Sub CancelPayHeadButton_Click(sender As Object, e As EventArgs) Handles CancelSalarySetupButton.Click
        clearData()
    End Sub

    Public Sub clearData()
        empOrGroupIDTextBox.Text = ""
        empOrGroupTypeTextBox.Text = ""
        empNameOrGroupTextBox.Text = ""
        underTextBox.Text = ""
        effectiveFromDateTimePicker.Text = Date.Now
        seelectedStartTypeTextBox.Text = ""
        clickedRowIndexTextBox.Text = "0"

        If individualSalaryDetailsDataGridView.Visible = True Then
            If (individualSalaryDetailsDataGridView.RowCount - 1) <> 0 Then
                individualSalaryDetailsDataGridView.Rows.Clear()
            End If

        ElseIf GroupSalaryDetailsDataGridView.Visible = True Then
            If (GroupSalaryDetailsDataGridView.RowCount - 1) <> 0 Then
                GroupSalaryDetailsDataGridView.DataSource = DBNull.Value
            End If
        End If

    End Sub

End Class