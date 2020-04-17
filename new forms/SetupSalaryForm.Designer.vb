<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalaryDetailsSetupForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.individualSalaryDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_head = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_head_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calculation_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compute_on = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.empNameOrGroupTextBox = New System.Windows.Forms.TextBox()
        Me.underTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SavesSalaryDetailsButton = New System.Windows.Forms.Button()
        Me.CancelSalarySetupButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.effectiveFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.empOrGroupTypeTextBox = New System.Windows.Forms.TextBox()
        Me.clickedRowIndexTextBox = New System.Windows.Forms.TextBox()
        Me.empOrGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.seelectedStartTypeTextBox = New System.Windows.Forms.TextBox()
        Me.addPayHeadsButton = New System.Windows.Forms.Button()
        Me.GroupSalaryDetailsDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.individualSalaryDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GroupSalaryDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'individualSalaryDetailsDataGridView
        '
        Me.individualSalaryDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.individualSalaryDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.individualSalaryDetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.individualSalaryDetailsDataGridView.ColumnHeadersHeight = 50
        Me.individualSalaryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.individualSalaryDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.pay_head, Me.rate, Me.period, Me.pay_head_type, Me.calculation_type, Me.compute_on})
        Me.individualSalaryDetailsDataGridView.Location = New System.Drawing.Point(12, 241)
        Me.individualSalaryDetailsDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.individualSalaryDetailsDataGridView.Name = "individualSalaryDetailsDataGridView"
        Me.individualSalaryDetailsDataGridView.RowHeadersVisible = False
        Me.individualSalaryDetailsDataGridView.Size = New System.Drawing.Size(386, 251)
        Me.individualSalaryDetailsDataGridView.TabIndex = 0
        Me.individualSalaryDetailsDataGridView.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "SNo."
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'pay_head
        '
        Me.pay_head.HeaderText = "Pay Head"
        Me.pay_head.Name = "pay_head"
        Me.pay_head.ReadOnly = True
        Me.pay_head.Width = 250
        '
        'rate
        '
        Me.rate.HeaderText = "Rate"
        Me.rate.Name = "rate"
        '
        'period
        '
        Me.period.HeaderText = "Period"
        Me.period.Name = "period"
        '
        'pay_head_type
        '
        Me.pay_head_type.HeaderText = "Pay Head Type"
        Me.pay_head_type.Name = "pay_head_type"
        Me.pay_head_type.ReadOnly = True
        Me.pay_head_type.Width = 150
        '
        'calculation_type
        '
        Me.calculation_type.HeaderText = "Calculation Type"
        Me.calculation_type.Name = "calculation_type"
        Me.calculation_type.ReadOnly = True
        Me.calculation_type.Width = 150
        '
        'compute_on
        '
        Me.compute_on.HeaderText = "Compute On"
        Me.compute_on.Name = "compute_on"
        Me.compute_on.ReadOnly = True
        Me.compute_on.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Under :"
        '
        'empNameOrGroupTextBox
        '
        Me.empNameOrGroupTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.empNameOrGroupTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empNameOrGroupTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empNameOrGroupTextBox.Location = New System.Drawing.Point(75, 64)
        Me.empNameOrGroupTextBox.Name = "empNameOrGroupTextBox"
        Me.empNameOrGroupTextBox.ReadOnly = True
        Me.empNameOrGroupTextBox.Size = New System.Drawing.Size(313, 23)
        Me.empNameOrGroupTextBox.TabIndex = 3
        '
        'underTextBox
        '
        Me.underTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.underTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.underTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.underTextBox.Location = New System.Drawing.Point(75, 94)
        Me.underTextBox.Name = "underTextBox"
        Me.underTextBox.ReadOnly = True
        Me.underTextBox.Size = New System.Drawing.Size(313, 23)
        Me.underTextBox.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SavesSalaryDetailsButton)
        Me.GroupBox3.Controls.Add(Me.CancelSalarySetupButton)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 37)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        '
        'SavesSalaryDetailsButton
        '
        Me.SavesSalaryDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SavesSalaryDetailsButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavesSalaryDetailsButton.Location = New System.Drawing.Point(12, 11)
        Me.SavesSalaryDetailsButton.Name = "SavesSalaryDetailsButton"
        Me.SavesSalaryDetailsButton.Size = New System.Drawing.Size(72, 20)
        Me.SavesSalaryDetailsButton.TabIndex = 85
        Me.SavesSalaryDetailsButton.Text = "Save"
        Me.SavesSalaryDetailsButton.UseVisualStyleBackColor = True
        '
        'CancelSalarySetupButton
        '
        Me.CancelSalarySetupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelSalarySetupButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelSalarySetupButton.Location = New System.Drawing.Point(90, 11)
        Me.CancelSalarySetupButton.Name = "CancelSalarySetupButton"
        Me.CancelSalarySetupButton.Size = New System.Drawing.Size(49, 20)
        Me.CancelSalarySetupButton.TabIndex = 86
        Me.CancelSalarySetupButton.Text = "Cancel"
        Me.CancelSalarySetupButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Effective From :"
        '
        'effectiveFromDateTimePicker
        '
        Me.effectiveFromDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.effectiveFromDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.effectiveFromDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.effectiveFromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.effectiveFromDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effectiveFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.effectiveFromDateTimePicker.Location = New System.Drawing.Point(122, 124)
        Me.effectiveFromDateTimePicker.Name = "effectiveFromDateTimePicker"
        Me.effectiveFromDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.effectiveFromDateTimePicker.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Salary Details"
        '
        'empOrGroupTypeTextBox
        '
        Me.empOrGroupTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empOrGroupTypeTextBox.Enabled = False
        Me.empOrGroupTypeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empOrGroupTypeTextBox.Location = New System.Drawing.Point(297, 42)
        Me.empOrGroupTypeTextBox.Name = "empOrGroupTypeTextBox"
        Me.empOrGroupTypeTextBox.Size = New System.Drawing.Size(91, 16)
        Me.empOrGroupTypeTextBox.TabIndex = 92
        '
        'clickedRowIndexTextBox
        '
        Me.clickedRowIndexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clickedRowIndexTextBox.Enabled = False
        Me.clickedRowIndexTextBox.Location = New System.Drawing.Point(22, 221)
        Me.clickedRowIndexTextBox.Name = "clickedRowIndexTextBox"
        Me.clickedRowIndexTextBox.Size = New System.Drawing.Size(40, 16)
        Me.clickedRowIndexTextBox.TabIndex = 93
        Me.clickedRowIndexTextBox.Text = "0"
        '
        'empOrGroupIDTextBox
        '
        Me.empOrGroupIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empOrGroupIDTextBox.Enabled = False
        Me.empOrGroupIDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empOrGroupIDTextBox.Location = New System.Drawing.Point(246, 42)
        Me.empOrGroupIDTextBox.Name = "empOrGroupIDTextBox"
        Me.empOrGroupIDTextBox.Size = New System.Drawing.Size(45, 16)
        Me.empOrGroupIDTextBox.TabIndex = 94
        '
        'seelectedStartTypeTextBox
        '
        Me.seelectedStartTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.seelectedStartTypeTextBox.Enabled = False
        Me.seelectedStartTypeTextBox.Location = New System.Drawing.Point(71, 221)
        Me.seelectedStartTypeTextBox.Name = "seelectedStartTypeTextBox"
        Me.seelectedStartTypeTextBox.Size = New System.Drawing.Size(45, 16)
        Me.seelectedStartTypeTextBox.TabIndex = 95
        '
        'addPayHeadsButton
        '
        Me.addPayHeadsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addPayHeadsButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPayHeadsButton.Location = New System.Drawing.Point(12, 173)
        Me.addPayHeadsButton.Name = "addPayHeadsButton"
        Me.addPayHeadsButton.Size = New System.Drawing.Size(96, 23)
        Me.addPayHeadsButton.TabIndex = 96
        Me.addPayHeadsButton.Text = "Add Pay Heads"
        Me.addPayHeadsButton.UseVisualStyleBackColor = True
        '
        'GroupSalaryDetailsDataGridView
        '
        Me.GroupSalaryDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GroupSalaryDetailsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GroupSalaryDetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GroupSalaryDetailsDataGridView.ColumnHeadersHeight = 50
        Me.GroupSalaryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GroupSalaryDetailsDataGridView.Location = New System.Drawing.Point(12, 260)
        Me.GroupSalaryDetailsDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupSalaryDetailsDataGridView.Name = "GroupSalaryDetailsDataGridView"
        Me.GroupSalaryDetailsDataGridView.RowHeadersVisible = False
        Me.GroupSalaryDetailsDataGridView.Size = New System.Drawing.Size(386, 232)
        Me.GroupSalaryDetailsDataGridView.TabIndex = 97
        Me.GroupSalaryDetailsDataGridView.Visible = False
        '
        'SalaryDetailsSetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 212)
        Me.Controls.Add(Me.GroupSalaryDetailsDataGridView)
        Me.Controls.Add(Me.addPayHeadsButton)
        Me.Controls.Add(Me.seelectedStartTypeTextBox)
        Me.Controls.Add(Me.empOrGroupIDTextBox)
        Me.Controls.Add(Me.clickedRowIndexTextBox)
        Me.Controls.Add(Me.empOrGroupTypeTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.effectiveFromDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.underTextBox)
        Me.Controls.Add(Me.empNameOrGroupTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.individualSalaryDetailsDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(426, 542)
        Me.MinimumSize = New System.Drawing.Size(426, 251)
        Me.Name = "SalaryDetailsSetupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SetupSalaryForm"
        CType(Me.individualSalaryDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GroupSalaryDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents individualSalaryDetailsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents empNameOrGroupTextBox As TextBox
    Friend WithEvents underTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SavesSalaryDetailsButton As Button
    Friend WithEvents CancelSalarySetupButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents effectiveFromDateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents empOrGroupTypeTextBox As TextBox
    Friend WithEvents clickedRowIndexTextBox As TextBox
    Friend WithEvents empOrGroupIDTextBox As TextBox
    Friend WithEvents seelectedStartTypeTextBox As TextBox
    Friend WithEvents addPayHeadsButton As Button
    Friend WithEvents GroupSalaryDetailsDataGridView As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents pay_head As DataGridViewTextBoxColumn
    Friend WithEvents rate As DataGridViewTextBoxColumn
    Friend WithEvents period As DataGridViewTextBoxColumn
    Friend WithEvents pay_head_type As DataGridViewTextBoxColumn
    Friend WithEvents calculation_type As DataGridViewTextBoxColumn
    Friend WithEvents compute_on As DataGridViewTextBoxColumn
End Class
