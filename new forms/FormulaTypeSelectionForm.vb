Public Class FormulaTypeSelectionForm
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        FormulaForm.userSpecifiedFunctionDataGridView.Rows(FormulaForm.rowIndexTextBox.Text).Cells("thefunction").Value = ListBox1.SelectedItem
        Me.Close()
    End Sub
End Class