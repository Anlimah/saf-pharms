﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormulaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.formulaDisplayTextBox = New System.Windows.Forms.TextBox()
        Me.userSpecifiedFunctionDataGridView = New System.Windows.Forms.DataGridView()
        Me.symbol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.thefunction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFunctionButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HideFormButton = New System.Windows.Forms.Button()
        Me.rowIndexTextBox = New System.Windows.Forms.TextBox()
        Me.CancelPayHeadButton = New System.Windows.Forms.Button()
        CType(Me.userSpecifiedFunctionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'formulaDisplayTextBox
        '
        Me.formulaDisplayTextBox.Enabled = False
        Me.formulaDisplayTextBox.Location = New System.Drawing.Point(219, 16)
        Me.formulaDisplayTextBox.Multiline = True
        Me.formulaDisplayTextBox.Name = "formulaDisplayTextBox"
        Me.formulaDisplayTextBox.Size = New System.Drawing.Size(22, 20)
        Me.formulaDisplayTextBox.TabIndex = 0
        '
        'userSpecifiedFunctionDataGridView
        '
        Me.userSpecifiedFunctionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.userSpecifiedFunctionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userSpecifiedFunctionDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.userSpecifiedFunctionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userSpecifiedFunctionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.symbol, Me.thefunction, Me.pay_head})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.userSpecifiedFunctionDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.userSpecifiedFunctionDataGridView.Location = New System.Drawing.Point(9, 48)
        Me.userSpecifiedFunctionDataGridView.Name = "userSpecifiedFunctionDataGridView"
        Me.userSpecifiedFunctionDataGridView.RowHeadersVisible = False
        Me.userSpecifiedFunctionDataGridView.Size = New System.Drawing.Size(403, 212)
        Me.userSpecifiedFunctionDataGridView.TabIndex = 2
        '
        'symbol
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        Me.symbol.DefaultCellStyle = DataGridViewCellStyle2
        Me.symbol.HeaderText = "Symbol"
        Me.symbol.Items.AddRange(New Object() {"new row", "(", ")"})
        Me.symbol.Name = "symbol"
        Me.symbol.Width = 50
        '
        'thefunction
        '
        Me.thefunction.HeaderText = "Function"
        Me.thefunction.Name = "thefunction"
        Me.thefunction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.thefunction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.thefunction.Width = 150
        '
        'pay_head
        '
        Me.pay_head.HeaderText = "Pay Head"
        Me.pay_head.Name = "pay_head"
        Me.pay_head.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pay_head.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pay_head.Width = 200
        '
        'SaveFunctionButton
        '
        Me.SaveFunctionButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveFunctionButton.Location = New System.Drawing.Point(9, 12)
        Me.SaveFunctionButton.Name = "SaveFunctionButton"
        Me.SaveFunctionButton.Size = New System.Drawing.Size(61, 23)
        Me.SaveFunctionButton.TabIndex = 3
        Me.SaveFunctionButton.Text = "Save"
        Me.SaveFunctionButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HideFormButton)
        Me.GroupBox3.Controls.Add(Me.rowIndexTextBox)
        Me.GroupBox3.Controls.Add(Me.SaveFunctionButton)
        Me.GroupBox3.Controls.Add(Me.CancelPayHeadButton)
        Me.GroupBox3.Controls.Add(Me.formulaDisplayTextBox)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(417, 42)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        '
        'HideFormButton
        '
        Me.HideFormButton.BackColor = System.Drawing.Color.Red
        Me.HideFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideFormButton.ForeColor = System.Drawing.Color.White
        Me.HideFormButton.Location = New System.Drawing.Point(394, 12)
        Me.HideFormButton.Name = "HideFormButton"
        Me.HideFormButton.Size = New System.Drawing.Size(21, 22)
        Me.HideFormButton.TabIndex = 89
        Me.HideFormButton.Text = "X"
        Me.HideFormButton.UseVisualStyleBackColor = False
        '
        'rowIndexTextBox
        '
        Me.rowIndexTextBox.Enabled = False
        Me.rowIndexTextBox.Location = New System.Drawing.Point(191, 16)
        Me.rowIndexTextBox.Multiline = True
        Me.rowIndexTextBox.Name = "rowIndexTextBox"
        Me.rowIndexTextBox.Size = New System.Drawing.Size(22, 20)
        Me.rowIndexTextBox.TabIndex = 87
        '
        'CancelPayHeadButton
        '
        Me.CancelPayHeadButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPayHeadButton.Location = New System.Drawing.Point(76, 12)
        Me.CancelPayHeadButton.Name = "CancelPayHeadButton"
        Me.CancelPayHeadButton.Size = New System.Drawing.Size(49, 23)
        Me.CancelPayHeadButton.TabIndex = 86
        Me.CancelPayHeadButton.Text = "Cancel"
        Me.CancelPayHeadButton.UseVisualStyleBackColor = True
        '
        'FormulaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.userSpecifiedFunctionDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormulaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compute: On Specified Formula"
        CType(Me.userSpecifiedFunctionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formulaDisplayTextBox As TextBox
    Friend WithEvents userSpecifiedFunctionDataGridView As DataGridView
    Friend WithEvents SaveFunctionButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CancelPayHeadButton As Button
    Friend WithEvents rowIndexTextBox As TextBox
    Friend WithEvents HideFormButton As Button
    Friend WithEvents symbol As DataGridViewComboBoxColumn
    Friend WithEvents thefunction As DataGridViewTextBoxColumn
    Friend WithEvents pay_head As DataGridViewTextBoxColumn
End Class
