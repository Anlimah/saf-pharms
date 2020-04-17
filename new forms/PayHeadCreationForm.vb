Public Class PayHeadCreationForm
    Private Sub ViewFormulaButton_Click(sender As Object, e As EventArgs) Handles ViewFormulaButton.Click
        FormulaForm.Show()
    End Sub

    Private Sub computeTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles computeTypeComboBox.SelectedIndexChanged
        If computeTypeComboBox.SelectedItem = "On Specified Formula" Then
            formulaPanel.Show()
        Else
            formulaPanel.Hide()
        End If
    End Sub


    ' When name of pay head is entered, this will cause it to appear in the name to appear on pay slip textbox
    Private Sub payHeadNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles payHeadNameTextBox.LostFocus
        nameToAppearTextBox.Text = payHeadNameTextBox.Text
    End Sub

    Private Sub payHeadTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles payHeadTypeComboBox.SelectedIndexChanged
        selectedPayHeadIDTextBox.Text = payHeadTypeComboBox.SelectedValue.ToString
        If selectedPayHeadIDTextBox.Text <> "1" And selectedPayHeadIDTextBox.Text <> "System.Data.DataRowView" And selectedPayHeadIDTextBox.Text <> "" Then
            payTypePanel.Visible = True
        Else
            payTypePanel.Visible = False
        End If
    End Sub

    Private Sub payHeadTypeComboBox_Click(sender As Object, e As EventArgs) Handles payHeadTypeComboBox.Click
        FetchComboData(payHeadTypeComboBox, "SELECT * FROM `tbl_pay_head_type`", "name")
        payHeadTypeComboBox.Text = ""
    End Sub

    Private Sub PayTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PayTypeComboBox.SelectedIndexChanged
        selectedPaytypeIDTextBox.Text = PayTypeComboBox.SelectedValue.ToString
    End Sub

    Private Sub PayTypeComboBox_Click(sender As Object, e As EventArgs) Handles PayTypeComboBox.Click
        If Not String.IsNullOrEmpty(selectedPayHeadIDTextBox.Text) Then
            FetchComboData(PayTypeComboBox, "SELECT * FROM `tbl_pay_type` WHERE `ph_type` = '" & selectedPayHeadIDTextBox.Text & "'", "name")
            PayTypeComboBox.Text = ""
        End If
    End Sub

    Private Sub calculationTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles calculationTypeComboBox.SelectedIndexChanged
        If LCase(calculationTypeComboBox.SelectedItem) = "as computed value" Then

            calcGroupPanel.Visible = True
            whatCalcTypePanel.Visible = False
            calcPeriodPanel.Visible = True
            calcBasisPanel.Visible = False
            periodOfPanel.Visible = False

            Me.Width = Me.MaximumSize.Width

            If PayTypeComboBox.Text = "Income Tax" Then
                computationInfoDataGridView.Visible = False
                graTaxSlabDataGridView.Visible = True
                graTaxSlabDataGridView.Location = New Point(13, 7)
                LoadDataIntoDatagrid(graTaxSlabDataGridView, "SELECT `amt_from`, `amt_to`, `chrg_amt`, `percentage`, `amt_crh`,`free_amt` FROM `tbl_gra_refera`")
            Else
                computationInfoDataGridView.Visible = True
                graTaxSlabDataGridView.Visible = False
            End If

            computeOnPanel.Visible = True
            formulaPanel.Visible = False
            computeInfoDgvPanel.Visible = True

        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "as user defined value" Then

            calcGroupPanel.Visible = True
            whatCalcTypePanel.Visible = False
            calcPeriodPanel.Visible = False
            calcBasisPanel.Visible = False
            periodOfPanel.Visible = False

            Me.Width = Me.MinimumSize.Width

            computeOnPanel.Visible = False
            formulaPanel.Visible = False
            computeInfoDgvPanel.Visible = False

        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "flat rate" Then

            calcGroupPanel.Visible = True
            whatCalcTypePanel.Visible = False
            calcPeriodPanel.Visible = True
            calcBasisPanel.Visible = False
            periodOfPanel.Visible = False

            Me.Width = Me.MinimumSize.Width

            computeOnPanel.Visible = False
            formulaPanel.Visible = False
            computeInfoDgvPanel.Visible = False

        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on attendance" Then

            calcGroupPanel.Visible = True
            whattypeLabel.Text = "Present/Leave With Pay :"
            whatCalcTypePanel.Visible = True
            calcPeriodPanel.Visible = True
            calcBasisPanel.Visible = True
            periodOfPanel.Visible = True

            Me.Width = Me.MinimumSize.Width

            computeOnPanel.Visible = False
            formulaPanel.Visible = False
            computeInfoDgvPanel.Visible = False

        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on production" Then

            calcGroupPanel.Visible = True
            whattypeLabel.Text = "Production Type :"
            whatCalcTypePanel.Visible = True
            calcPeriodPanel.Visible = False
            calcBasisPanel.Visible = False
            periodOfPanel.Visible = False

            Me.Width = Me.MinimumSize.Width

            computeOnPanel.Visible = False
            formulaPanel.Visible = False
            computeInfoDgvPanel.Visible = False

        End If

        whatTypeComboBox.Text = "Select"
        CalculationPeriodComboBox.Text = "Select"
        calculationBasisComboBox.Text = "Select"
        computeTypeComboBox.Text = "Select"
        effectiveFromDateTimePicker.Text = Date.Now

    End Sub

    Private Sub whatTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles whatTypeComboBox.SelectedIndexChanged

    End Sub

    Private Sub whatTypeComboBox_Click(sender As Object, e As EventArgs) Handles whatTypeComboBox.Click
        whatTypeComboBox.Text = ""
        If LCase(calculationTypeComboBox.Text) = "on attendance" Then
            FetchComboData(whatTypeComboBox, "SELECT * FROM `tbl_attendance_or_production` WHERE `type` LIKE 'Attendance%' AND `name` LIKE 'Present%'", "name")
        ElseIf LCase(calculationTypeComboBox.Text) = "on production" Then
            FetchComboData(whatTypeComboBox, "SELECT * FROM `tbl_attendance_or_production` WHERE `type` = 'Production'", "name")
        End If
        whatTypeComboBox.Text = ""
    End Sub

    Private Sub SavePayHeadButton_Click(sender As Object, e As EventArgs) Handles SavePayHeadButton.Click
        If validatePayHead() = 1 Then
            Exit Sub
        Else

            If LCase(calculationTypeComboBox.SelectedItem) = "as computed value" Then

                Dim x As Integer = runQuery("INSERT INTO `tbl_pay_head` (`name`, `pay_head_type`, `pay_type`, 
                                            `under`, `taxable`, `affect_net_salary`, `name_to_appear`, 
                                            `calculation_type`, `calculation_period`, `added_at`) 
                            VALUES ('" & payHeadNameTextBox.Text & "', '" & payHeadTypeComboBox.Text & "', 
                                    '" & PayTypeComboBox.Text & "', '" & underComboBox.Text & "', 
                                    '" & taxableComboBox.Text & "', '" & affectsNetSalComboBox.Text & "',
                                    '" & nameToAppearTextBox.Text & "', '" & calculationTypeComboBox.Text & "', 
                                    '" & CalculationPeriodComboBox.Text & "', CURRENT_TIMESTAMP)")

                If x = 1 Then

                    Dim pay_head_id As Integer = runQueryAndReturnValue("SELECT `id` FROM `tbl_pay_head` 
                                WHERE `name` = '" & payHeadNameTextBox.Text & "' 
                                AND `name_to_appear` = '" & nameToAppearTextBox.Text & "'", "id")

                    If pay_head_id > 0 Then

                        Dim amtfrom As Decimal = 0
                        Dim amtto As Decimal = 0
                        Dim slabtype As String = ""
                        Dim value As Decimal = 0

                        Dim computeType As String = computeTypeComboBox.Text
                        Dim specifiedFormula As String = specifiedFormulaTextBox.Text
                        Dim effectiveFrom As String = effectiveFromDateTimePicker.Text
                        Dim z As Integer = 0

                        If PayTypeComboBox.Text <> "Income Tax" Then

                            For i = 0 To computationInfoDataGridView.RowCount - 2

                                amtfrom = If(computationInfoDataGridView.Rows(i).Cells("amount_from").Value = "", 0, computationInfoDataGridView.Rows(i).Cells("amount_from").Value)
                                amtto = If(computationInfoDataGridView.Rows(i).Cells("amount_to").Value = "", 0, computationInfoDataGridView.Rows(i).Cells("amount_to").Value)
                                slabtype = computationInfoDataGridView.Rows(i).Cells("slab_type").Value
                                value = If(computationInfoDataGridView.Rows(i).Cells("value_basis").Value = "", 0, computationInfoDataGridView.Rows(i).Cells("value_basis").Value)

                                If runQuery("INSERT INTO `tbl_computation_info` (`phid`,`compute_on`, 
                                    `specified_formula`, `effective_from`, `amount_from`, `amount_to`, 
                                    `slab_type`, `value_basis`, `added_at`) 
                                VALUES ('" & pay_head_id & "', '" & computeType & "', 
                                    '" & specifiedFormula & "', '" & effectiveFrom & "', 
                                    '" & amtfrom & "', '" & amtto & "', '" & slabtype & "', '" & value & "', CURRENT_TIMESTAMP)") = 1 Then
                                    z += 1
                                End If

                            Next
                        Else
                            If runQuery("INSERT INTO `tbl_computation_info` (`phid`,`compute_on`, 
                                    `specified_formula`, `effective_from`,  `amount_from`, `amount_to`, 
                                    `slab_type`, `value_basis`, `added_at`)  
                                VALUES ('" & pay_head_id & "', '" & computeType & "', 
                                    '" & specifiedFormula & "', '" & effectiveFrom & "', 
                                    '" & amtfrom & "', '" & amtto & "', 'graTaxSlab', '" & value & "', CURRENT_TIMESTAMP)") = 1 Then
                                z += 1
                            End If

                        End If

                        If z = computationInfoDataGridView.RowCount - 1 Then

                            If LCase(computeTypeComboBox.Text) = "on specified formula" Then
                                Dim y As Integer = 0

                                For index = 0 To FormulaForm.userSpecifiedFunctionDataGridView.RowCount - 1

                                    If FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("thefunction").Value <> "" And
                                      FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("pay_head").Value <> "" Then

                                        If FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("symbol").Value = "" Or
                                     FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("symbol").Value = "new row" Then

                                            If runQuery("INSERT INTO `tbl_specified_formula` (`phid`, `symbol`, `function`, `pay_head`) 
                                    VALUES ('" & pay_head_id & "', '',
                                    '" & FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("thefunction").Value & "',
                                    '" & FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("pay_head").Value & "')") = 1 Then
                                                y += 1
                                            End If

                                        Else

                                            If runQuery("INSERT INTO `tbl_specified_formula` (`phid`, `symbol`, `function`, `pay_head`) 
                                    VALUES ('" & pay_head_id & "', 
                                    '" & FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("symbol").Value & "',
                                    '" & FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("thefunction").Value & "',
                                    '" & FormulaForm.userSpecifiedFunctionDataGridView.Rows(index).Cells("pay_head").Value & "')") = 1 Then
                                                y += 1
                                            End If

                                        End If

                                    End If

                                Next

                                If y = FormulaForm.userSpecifiedFunctionDataGridView.RowCount Then
                                    MsgBox("Pay head successfully added!")
                                End If

                            Else
                                MsgBox("Pay head successfully added!")

                            End If

                        End If

                    End If
                End If


            ElseIf LCase(calculationTypeComboBox.SelectedItem) = "as user defined value" Then

                Dim x As Integer = runQuery("INSERT INTO `tbl_pay_head` 
                    (`name`, `pay_head_type`, `under`, `taxable`, `affect_net_salary`, 
                    `name_to_appear`, `calculation_type`, `added_at`) 
                    VALUES ('" & payHeadNameTextBox.Text & "', '" & payHeadTypeComboBox.Text & "', 
                            '" & underComboBox.Text & "', '" & taxableComboBox.Text & "', 
                            '" & affectsNetSalComboBox.Text & "', '" & nameToAppearTextBox.Text & "', 
                            '" & calculationTypeComboBox.Text & "', CURRENT_TIMESTAMP)")

                If x = 1 Then
                    MsgBox("Pay head successfully added!")
                End If

            ElseIf LCase(calculationTypeComboBox.SelectedItem) = "flat rate" Then

                Dim x As Integer = runQuery("INSERT INTO `tbl_pay_head` 
                    (`name`, `pay_head_type`, `under`, `taxable`, `affect_net_salary`, 
                    `name_to_appear`, `calculation_type`, `calculation_period`, `added_at`) 
                    VALUES ('" & payHeadNameTextBox.Text & "', '" & payHeadTypeComboBox.Text & "', 
                            '" & underComboBox.Text & "', '" & taxableComboBox.Text & "', 
                            '" & affectsNetSalComboBox.Text & "', '" & nameToAppearTextBox.Text & "', 
                            '" & calculationTypeComboBox.Text & "', '" & CalculationPeriodComboBox.Text & "', 
                            CURRENT_TIMESTAMP)")

                If x = 1 Then
                    MsgBox("Pay head successfully added!")
                End If

            ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on attendance" Then

                Dim x As Integer = runQuery("INSERT INTO `tbl_pay_head` 
                    (`name`, `pay_head_type`, `under`, `taxable`, `affect_net_salary`, 
                    `name_to_appear`, `calculation_type`, `calculation_period`, `attend_or_prod_type`, 
                    `calculation_basis`, `period_of`, `added_at`) 
                    VALUES ('" & payHeadNameTextBox.Text & "', '" & payHeadTypeComboBox.Text & "', 
                            '" & underComboBox.Text & "', '" & taxableComboBox.Text & "', 
                            '" & affectsNetSalComboBox.Text & "', '" & nameToAppearTextBox.Text & "', 
                            '" & calculationTypeComboBox.Text & "', '" & CalculationPeriodComboBox.Text & "', 
                            '" & whatTypeComboBox.Text & "', '" & calculationBasisComboBox.Text & "',
                            '" & periodOfTextBox.Text & "', CURRENT_TIMESTAMP)")

                If x = 1 Then
                    MsgBox("Pay head successfully added!")
                End If

            ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on production" Then

                Dim x As Integer = runQuery("INSERT INTO `tbl_pay_head` (`name`, `pay_head_type`, `under`, 
                                        `taxable`, `affect_net_salary`, `name_to_appear`, `calculation_type`, 
                                        `attend_or_prod_type`, `added_at`) 
                             VALUES ('" & payHeadNameTextBox.Text & "', '" & payHeadTypeComboBox.Text & "', 
                                    '" & underComboBox.Text & "', '" & taxableComboBox.Text & "', 
                                    '" & affectsNetSalComboBox.Text & "', '" & nameToAppearTextBox.Text & "', 
                                    '" & calculationTypeComboBox.Text & "', '" & whatTypeComboBox.Text & "', 
                                    CURRENT_TIMESTAMP)")

                If x = 1 Then
                    MsgBox("Pay head successfully added!")
                End If

            End If

            clearAll()

        End If

    End Sub

    Public Function validatePayHead() As Integer
        If payHeadNameTextBox.Text = "" Then
            MsgBox("This field can't be left empty!")
            payHeadNameTextBox.Focus()
            Return 1
        ElseIf payHeadTypeComboBox.Text <> "Earnings for Employees" And PayTypeComboBox.Text = "Select" Then
            MsgBox("Some fields can't be left empty or unselected!")
            PayTypeComboBox.Focus()
            Return 1
        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "as computed value" Then
            If CalculationPeriodComboBox.Text = "Select" Or (computeTypeComboBox.Text = "on specified formula" And specifiedFormulaTextBox.Text = "") Then
                MsgBox("This field can't be left empty or unselected!")
                specifiedFormulaTextBox.Focus()
                Return 1
            End If
        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on attendance" Then
            If CalculationPeriodComboBox.Text = "Select" Or whatTypeComboBox.Text = "Select" Or calculationBasisComboBox.Text = "Select" Or periodOfTextBox.Text = "" Then
                MsgBox("You have some unselected field! or unselected")
                Return 1
            End If
        ElseIf LCase(calculationTypeComboBox.SelectedItem) = "on production" Then
            If whatTypeComboBox.Text = "Select" Then
                MsgBox("You have some unselected field! or unselected")
                whatTypeComboBox.Focus()
                Return 1
            End If
        End If
        Return 0
    End Function

    Private Sub CancelPayHeadButton_Click(sender As Object, e As EventArgs) Handles CancelPayHeadButton.Click
        clearAll()
    End Sub

    Private Sub clearAll()
        selectedPayHeadIDTextBox.Text = ""
        payHeadNameTextBox.Text = ""
        payHeadTypeComboBox.Text = "Select"
        PayTypeComboBox.Text = ""
        underComboBox.Text = "Select"
        taxableComboBox.Text = "Yes"
        affectsNetSalComboBox.Text = "Yes"
        nameToAppearTextBox.Text = ""
        calculationTypeComboBox.Text = "Select"
        CalculationPeriodComboBox.Text = "Select"
        whatTypeComboBox.Text = "Select"
        calculationBasisComboBox.Text = "Select"
        periodOfTextBox.Text = ""

        payTypePanel.Visible = False
        calcGroupPanel.Visible = False

        computeTypeComboBox.Text = "Select"
        specifiedFormulaTextBox.Text = "="
        effectiveFromDateTimePicker.Text = Date.Now
        graTaxSlabDataGridView.Visible = False
        formulaPanel.Visible = False
        computationInfoDataGridView.Rows.Clear()

        Me.Width = Me.MinimumSize.Width
        FormulaForm.Close()
        payHeadNameTextBox.Focus()
    End Sub
End Class