<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayHeadCreationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.payHeadNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.calcGroupPanel = New System.Windows.Forms.Panel()
        Me.calcPeriodPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CalculationPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.whatCalcTypePanel = New System.Windows.Forms.Panel()
        Me.whattypeLabel = New System.Windows.Forms.Label()
        Me.whatTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.periodOfPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.calculationPeriodLabel = New System.Windows.Forms.Label()
        Me.periodOfTextBox = New System.Windows.Forms.TextBox()
        Me.calcBasisPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.calculationBasisComboBox = New System.Windows.Forms.ComboBox()
        Me.calcTypePanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.calculationTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.affectNetSalaryPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.affectsNetSalComboBox = New System.Windows.Forms.ComboBox()
        Me.nameToAppearTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.underAndTaxablePanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.underComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.taxableComboBox = New System.Windows.Forms.ComboBox()
        Me.payTypePanel = New System.Windows.Forms.Panel()
        Me.selectedPaytypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.PayTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.payHeadTypePanel = New System.Windows.Forms.Panel()
        Me.selectedPayHeadIDTextBox = New System.Windows.Forms.TextBox()
        Me.payHeadTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.computeInfoDgvPanel = New System.Windows.Forms.Panel()
        Me.graTaxSlabDataGridView = New System.Windows.Forms.DataGridView()
        Me.computationInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.amount_from = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount_to = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.slab_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.value_basis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formulaPanel = New System.Windows.Forms.Panel()
        Me.specifiedFormulaTextBox = New System.Windows.Forms.TextBox()
        Me.ViewFormulaButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.effectiveFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.computeOnPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.computeTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SavePayHeadButton = New System.Windows.Forms.Button()
        Me.CancelPayHeadButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.calcGroupPanel.SuspendLayout()
        Me.calcPeriodPanel.SuspendLayout()
        Me.whatCalcTypePanel.SuspendLayout()
        Me.periodOfPanel.SuspendLayout()
        Me.calcBasisPanel.SuspendLayout()
        Me.calcTypePanel.SuspendLayout()
        Me.affectNetSalaryPanel.SuspendLayout()
        Me.underAndTaxablePanel.SuspendLayout()
        Me.payTypePanel.SuspendLayout()
        Me.payHeadTypePanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.computeInfoDgvPanel.SuspendLayout()
        CType(Me.graTaxSlabDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computationInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.formulaPanel.SuspendLayout()
        Me.computeOnPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(25, 90)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(42, 13)
        Me.Label65.TabIndex = 59
        Me.Label65.Text = "Name :"
        '
        'payHeadNameTextBox
        '
        Me.payHeadNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.payHeadNameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payHeadNameTextBox.Location = New System.Drawing.Point(74, 88)
        Me.payHeadNameTextBox.Name = "payHeadNameTextBox"
        Me.payHeadNameTextBox.Size = New System.Drawing.Size(347, 15)
        Me.payHeadNameTextBox.TabIndex = 58
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.calcGroupPanel)
        Me.GroupBox1.Controls.Add(Me.calcTypePanel)
        Me.GroupBox1.Controls.Add(Me.affectNetSalaryPanel)
        Me.GroupBox1.Controls.Add(Me.underAndTaxablePanel)
        Me.GroupBox1.Controls.Add(Me.payTypePanel)
        Me.GroupBox1.Controls.Add(Me.payHeadTypePanel)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 400)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pay Head Info"
        '
        'calcGroupPanel
        '
        Me.calcGroupPanel.Controls.Add(Me.calcPeriodPanel)
        Me.calcGroupPanel.Controls.Add(Me.whatCalcTypePanel)
        Me.calcGroupPanel.Controls.Add(Me.periodOfPanel)
        Me.calcGroupPanel.Controls.Add(Me.calcBasisPanel)
        Me.calcGroupPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.calcGroupPanel.Location = New System.Drawing.Point(3, 256)
        Me.calcGroupPanel.Name = "calcGroupPanel"
        Me.calcGroupPanel.Size = New System.Drawing.Size(417, 137)
        Me.calcGroupPanel.TabIndex = 107
        Me.calcGroupPanel.Visible = False
        '
        'calcPeriodPanel
        '
        Me.calcPeriodPanel.Controls.Add(Me.Label7)
        Me.calcPeriodPanel.Controls.Add(Me.CalculationPeriodComboBox)
        Me.calcPeriodPanel.Location = New System.Drawing.Point(3, 32)
        Me.calcPeriodPanel.Name = "calcPeriodPanel"
        Me.calcPeriodPanel.Size = New System.Drawing.Size(411, 26)
        Me.calcPeriodPanel.TabIndex = 104
        Me.calcPeriodPanel.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Calculation Period :"
        '
        'CalculationPeriodComboBox
        '
        Me.CalculationPeriodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculationPeriodComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculationPeriodComboBox.FormattingEnabled = True
        Me.CalculationPeriodComboBox.Items.AddRange(New Object() {"Months", "Weeks"})
        Me.CalculationPeriodComboBox.Location = New System.Drawing.Point(236, 0)
        Me.CalculationPeriodComboBox.Name = "CalculationPeriodComboBox"
        Me.CalculationPeriodComboBox.Size = New System.Drawing.Size(168, 21)
        Me.CalculationPeriodComboBox.TabIndex = 89
        Me.CalculationPeriodComboBox.Text = "Select"
        '
        'whatCalcTypePanel
        '
        Me.whatCalcTypePanel.Controls.Add(Me.whattypeLabel)
        Me.whatCalcTypePanel.Controls.Add(Me.whatTypeComboBox)
        Me.whatCalcTypePanel.Location = New System.Drawing.Point(3, 3)
        Me.whatCalcTypePanel.Name = "whatCalcTypePanel"
        Me.whatCalcTypePanel.Size = New System.Drawing.Size(411, 28)
        Me.whatCalcTypePanel.TabIndex = 103
        Me.whatCalcTypePanel.Visible = False
        '
        'whattypeLabel
        '
        Me.whattypeLabel.AutoSize = True
        Me.whattypeLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whattypeLabel.Location = New System.Drawing.Point(41, 3)
        Me.whattypeLabel.Name = "whattypeLabel"
        Me.whattypeLabel.Size = New System.Drawing.Size(80, 13)
        Me.whattypeLabel.TabIndex = 86
        Me.whattypeLabel.Text = "what calc type"
        '
        'whatTypeComboBox
        '
        Me.whatTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.whatTypeComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whatTypeComboBox.FormattingEnabled = True
        Me.whatTypeComboBox.Location = New System.Drawing.Point(236, 0)
        Me.whatTypeComboBox.Name = "whatTypeComboBox"
        Me.whatTypeComboBox.Size = New System.Drawing.Size(168, 21)
        Me.whatTypeComboBox.TabIndex = 87
        Me.whatTypeComboBox.Text = "Select"
        '
        'periodOfPanel
        '
        Me.periodOfPanel.Controls.Add(Me.Label10)
        Me.periodOfPanel.Controls.Add(Me.calculationPeriodLabel)
        Me.periodOfPanel.Controls.Add(Me.periodOfTextBox)
        Me.periodOfPanel.Location = New System.Drawing.Point(3, 87)
        Me.periodOfPanel.Name = "periodOfPanel"
        Me.periodOfPanel.Size = New System.Drawing.Size(411, 25)
        Me.periodOfPanel.TabIndex = 106
        Me.periodOfPanel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(244, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Period of"
        '
        'calculationPeriodLabel
        '
        Me.calculationPeriodLabel.AutoSize = True
        Me.calculationPeriodLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculationPeriodLabel.Location = New System.Drawing.Point(333, 3)
        Me.calculationPeriodLabel.Name = "calculationPeriodLabel"
        Me.calculationPeriodLabel.Size = New System.Drawing.Size(30, 13)
        Me.calculationPeriodLabel.TabIndex = 96
        Me.calculationPeriodLabel.Text = "days"
        '
        'periodOfTextBox
        '
        Me.periodOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.periodOfTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodOfTextBox.Location = New System.Drawing.Point(304, 3)
        Me.periodOfTextBox.Name = "periodOfTextBox"
        Me.periodOfTextBox.Size = New System.Drawing.Size(23, 15)
        Me.periodOfTextBox.TabIndex = 95
        '
        'calcBasisPanel
        '
        Me.calcBasisPanel.Controls.Add(Me.Label8)
        Me.calcBasisPanel.Controls.Add(Me.calculationBasisComboBox)
        Me.calcBasisPanel.Location = New System.Drawing.Point(3, 59)
        Me.calcBasisPanel.Name = "calcBasisPanel"
        Me.calcBasisPanel.Size = New System.Drawing.Size(411, 27)
        Me.calcBasisPanel.TabIndex = 105
        Me.calcBasisPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Calculation Basis :"
        '
        'calculationBasisComboBox
        '
        Me.calculationBasisComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculationBasisComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculationBasisComboBox.FormattingEnabled = True
        Me.calculationBasisComboBox.Items.AddRange(New Object() {"User Defined"})
        Me.calculationBasisComboBox.Location = New System.Drawing.Point(236, 2)
        Me.calculationBasisComboBox.Name = "calculationBasisComboBox"
        Me.calculationBasisComboBox.Size = New System.Drawing.Size(168, 21)
        Me.calculationBasisComboBox.TabIndex = 91
        Me.calculationBasisComboBox.Text = "Select"
        '
        'calcTypePanel
        '
        Me.calcTypePanel.Controls.Add(Me.Label5)
        Me.calcTypePanel.Controls.Add(Me.calculationTypeComboBox)
        Me.calcTypePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.calcTypePanel.Location = New System.Drawing.Point(3, 228)
        Me.calcTypePanel.Name = "calcTypePanel"
        Me.calcTypePanel.Size = New System.Drawing.Size(417, 28)
        Me.calcTypePanel.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Calculation Type"
        '
        'calculationTypeComboBox
        '
        Me.calculationTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculationTypeComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculationTypeComboBox.FormattingEnabled = True
        Me.calculationTypeComboBox.Items.AddRange(New Object() {"As Computed Value", "As User Defined Value", "Flat Rate", "On Production", "On Attendance"})
        Me.calculationTypeComboBox.Location = New System.Drawing.Point(239, 1)
        Me.calculationTypeComboBox.Name = "calculationTypeComboBox"
        Me.calculationTypeComboBox.Size = New System.Drawing.Size(168, 21)
        Me.calculationTypeComboBox.TabIndex = 85
        Me.calculationTypeComboBox.Text = "Select"
        '
        'affectNetSalaryPanel
        '
        Me.affectNetSalaryPanel.Controls.Add(Me.Label3)
        Me.affectNetSalaryPanel.Controls.Add(Me.affectsNetSalComboBox)
        Me.affectNetSalaryPanel.Controls.Add(Me.nameToAppearTextBox)
        Me.affectNetSalaryPanel.Controls.Add(Me.Label4)
        Me.affectNetSalaryPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.affectNetSalaryPanel.Location = New System.Drawing.Point(3, 156)
        Me.affectNetSalaryPanel.Name = "affectNetSalaryPanel"
        Me.affectNetSalaryPanel.Size = New System.Drawing.Size(417, 72)
        Me.affectNetSalaryPanel.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Affects Net Salary ? : "
        '
        'affectsNetSalComboBox
        '
        Me.affectsNetSalComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.affectsNetSalComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.affectsNetSalComboBox.FormattingEnabled = True
        Me.affectsNetSalComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.affectsNetSalComboBox.Location = New System.Drawing.Point(239, 2)
        Me.affectsNetSalComboBox.Name = "affectsNetSalComboBox"
        Me.affectsNetSalComboBox.Size = New System.Drawing.Size(63, 21)
        Me.affectsNetSalComboBox.TabIndex = 81
        Me.affectsNetSalComboBox.Text = "Yes"
        '
        'nameToAppearTextBox
        '
        Me.nameToAppearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nameToAppearTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameToAppearTextBox.Location = New System.Drawing.Point(239, 31)
        Me.nameToAppearTextBox.Name = "nameToAppearTextBox"
        Me.nameToAppearTextBox.Size = New System.Drawing.Size(168, 15)
        Me.nameToAppearTextBox.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = " Name to appear in Pay Slip : "
        '
        'underAndTaxablePanel
        '
        Me.underAndTaxablePanel.Controls.Add(Me.Label2)
        Me.underAndTaxablePanel.Controls.Add(Me.underComboBox)
        Me.underAndTaxablePanel.Controls.Add(Me.Label9)
        Me.underAndTaxablePanel.Controls.Add(Me.taxableComboBox)
        Me.underAndTaxablePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.underAndTaxablePanel.Location = New System.Drawing.Point(3, 76)
        Me.underAndTaxablePanel.Name = "underAndTaxablePanel"
        Me.underAndTaxablePanel.Size = New System.Drawing.Size(417, 80)
        Me.underAndTaxablePanel.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Under :"
        '
        'underComboBox
        '
        Me.underComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.underComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.underComboBox.FormattingEnabled = True
        Me.underComboBox.Items.AddRange(New Object() {"Direct Expenses", "Indirect Expenses", "Current Liablities"})
        Me.underComboBox.Location = New System.Drawing.Point(239, 1)
        Me.underComboBox.Name = "underComboBox"
        Me.underComboBox.Size = New System.Drawing.Size(168, 21)
        Me.underComboBox.TabIndex = 79
        Me.underComboBox.Text = "Select"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Taxable ? :"
        '
        'taxableComboBox
        '
        Me.taxableComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.taxableComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxableComboBox.FormattingEnabled = True
        Me.taxableComboBox.Items.AddRange(New Object() {"Yes", "No"})
        Me.taxableComboBox.Location = New System.Drawing.Point(239, 30)
        Me.taxableComboBox.Name = "taxableComboBox"
        Me.taxableComboBox.Size = New System.Drawing.Size(62, 21)
        Me.taxableComboBox.TabIndex = 93
        Me.taxableComboBox.Text = "Yes"
        '
        'payTypePanel
        '
        Me.payTypePanel.Controls.Add(Me.selectedPaytypeIDTextBox)
        Me.payTypePanel.Controls.Add(Me.PayTypeComboBox)
        Me.payTypePanel.Controls.Add(Me.Label14)
        Me.payTypePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.payTypePanel.Location = New System.Drawing.Point(3, 47)
        Me.payTypePanel.Name = "payTypePanel"
        Me.payTypePanel.Size = New System.Drawing.Size(417, 29)
        Me.payTypePanel.TabIndex = 99
        Me.payTypePanel.Visible = False
        '
        'selectedPaytypeIDTextBox
        '
        Me.selectedPaytypeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selectedPaytypeIDTextBox.Enabled = False
        Me.selectedPaytypeIDTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedPaytypeIDTextBox.Location = New System.Drawing.Point(200, 6)
        Me.selectedPaytypeIDTextBox.Name = "selectedPaytypeIDTextBox"
        Me.selectedPaytypeIDTextBox.Size = New System.Drawing.Size(33, 15)
        Me.selectedPaytypeIDTextBox.TabIndex = 99
        '
        'PayTypeComboBox
        '
        Me.PayTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PayTypeComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayTypeComboBox.FormattingEnabled = True
        Me.PayTypeComboBox.Location = New System.Drawing.Point(239, 1)
        Me.PayTypeComboBox.Name = "PayTypeComboBox"
        Me.PayTypeComboBox.Size = New System.Drawing.Size(168, 21)
        Me.PayTypeComboBox.TabIndex = 98
        Me.PayTypeComboBox.Text = "Select"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(41, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Pay Type :"
        '
        'payHeadTypePanel
        '
        Me.payHeadTypePanel.Controls.Add(Me.selectedPayHeadIDTextBox)
        Me.payHeadTypePanel.Controls.Add(Me.payHeadTypeComboBox)
        Me.payHeadTypePanel.Controls.Add(Me.Label1)
        Me.payHeadTypePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.payHeadTypePanel.Location = New System.Drawing.Point(3, 18)
        Me.payHeadTypePanel.Name = "payHeadTypePanel"
        Me.payHeadTypePanel.Size = New System.Drawing.Size(417, 29)
        Me.payHeadTypePanel.TabIndex = 87
        '
        'selectedPayHeadIDTextBox
        '
        Me.selectedPayHeadIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selectedPayHeadIDTextBox.Enabled = False
        Me.selectedPayHeadIDTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedPayHeadIDTextBox.Location = New System.Drawing.Point(200, 7)
        Me.selectedPayHeadIDTextBox.Name = "selectedPayHeadIDTextBox"
        Me.selectedPayHeadIDTextBox.Size = New System.Drawing.Size(33, 15)
        Me.selectedPayHeadIDTextBox.TabIndex = 96
        '
        'payHeadTypeComboBox
        '
        Me.payHeadTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payHeadTypeComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payHeadTypeComboBox.FormattingEnabled = True
        Me.payHeadTypeComboBox.Location = New System.Drawing.Point(239, 2)
        Me.payHeadTypeComboBox.Name = "payHeadTypeComboBox"
        Me.payHeadTypeComboBox.Size = New System.Drawing.Size(168, 21)
        Me.payHeadTypeComboBox.TabIndex = 77
        Me.payHeadTypeComboBox.Text = "Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Pay Head Type :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.computeInfoDgvPanel)
        Me.GroupBox2.Controls.Add(Me.formulaPanel)
        Me.GroupBox2.Controls.Add(Me.computeOnPanel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(444, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 400)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Computation Info"
        '
        'computeInfoDgvPanel
        '
        Me.computeInfoDgvPanel.Controls.Add(Me.graTaxSlabDataGridView)
        Me.computeInfoDgvPanel.Controls.Add(Me.computationInfoDataGridView)
        Me.computeInfoDgvPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.computeInfoDgvPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computeInfoDgvPanel.Location = New System.Drawing.Point(3, 107)
        Me.computeInfoDgvPanel.Name = "computeInfoDgvPanel"
        Me.computeInfoDgvPanel.Size = New System.Drawing.Size(426, 286)
        Me.computeInfoDgvPanel.TabIndex = 65
        Me.computeInfoDgvPanel.Visible = False
        '
        'graTaxSlabDataGridView
        '
        Me.graTaxSlabDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.graTaxSlabDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.graTaxSlabDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.graTaxSlabDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.graTaxSlabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.graTaxSlabDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.graTaxSlabDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.graTaxSlabDataGridView.Location = New System.Drawing.Point(13, 184)
        Me.graTaxSlabDataGridView.Name = "graTaxSlabDataGridView"
        Me.graTaxSlabDataGridView.RowHeadersVisible = False
        Me.graTaxSlabDataGridView.Size = New System.Drawing.Size(403, 240)
        Me.graTaxSlabDataGridView.TabIndex = 64
        Me.graTaxSlabDataGridView.Visible = False
        '
        'computationInfoDataGridView
        '
        Me.computationInfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.computationInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.computationInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.computationInfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.computationInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.computationInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.amount_from, Me.amount_to, Me.slab_type, Me.value_basis})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.computationInfoDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.computationInfoDataGridView.GridColor = System.Drawing.SystemColors.Control
        Me.computationInfoDataGridView.Location = New System.Drawing.Point(13, 7)
        Me.computationInfoDataGridView.Name = "computationInfoDataGridView"
        Me.computationInfoDataGridView.RowHeadersVisible = False
        Me.computationInfoDataGridView.Size = New System.Drawing.Size(403, 161)
        Me.computationInfoDataGridView.TabIndex = 63
        '
        'amount_from
        '
        Me.amount_from.HeaderText = "Amount From"
        Me.amount_from.Name = "amount_from"
        '
        'amount_to
        '
        Me.amount_to.HeaderText = "Amount To"
        Me.amount_to.Name = "amount_to"
        '
        'slab_type
        '
        Me.slab_type.HeaderText = "Sab Type"
        Me.slab_type.Items.AddRange(New Object() {"Percentage", "Value"})
        Me.slab_type.Name = "slab_type"
        Me.slab_type.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.slab_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'value_basis
        '
        Me.value_basis.HeaderText = "Value Basis"
        Me.value_basis.Name = "value_basis"
        '
        'formulaPanel
        '
        Me.formulaPanel.Controls.Add(Me.specifiedFormulaTextBox)
        Me.formulaPanel.Controls.Add(Me.ViewFormulaButton)
        Me.formulaPanel.Controls.Add(Me.Label15)
        Me.formulaPanel.Controls.Add(Me.effectiveFromDateTimePicker)
        Me.formulaPanel.Controls.Add(Me.Label13)
        Me.formulaPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.formulaPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formulaPanel.Location = New System.Drawing.Point(3, 47)
        Me.formulaPanel.Name = "formulaPanel"
        Me.formulaPanel.Size = New System.Drawing.Size(426, 60)
        Me.formulaPanel.TabIndex = 64
        Me.formulaPanel.Visible = False
        '
        'specifiedFormulaTextBox
        '
        Me.specifiedFormulaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.specifiedFormulaTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specifiedFormulaTextBox.Location = New System.Drawing.Point(135, 7)
        Me.specifiedFormulaTextBox.Name = "specifiedFormulaTextBox"
        Me.specifiedFormulaTextBox.Size = New System.Drawing.Size(254, 15)
        Me.specifiedFormulaTextBox.TabIndex = 97
        Me.specifiedFormulaTextBox.Text = "="
        '
        'ViewFormulaButton
        '
        Me.ViewFormulaButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewFormulaButton.Location = New System.Drawing.Point(395, 5)
        Me.ViewFormulaButton.Name = "ViewFormulaButton"
        Me.ViewFormulaButton.Size = New System.Drawing.Size(21, 19)
        Me.ViewFormulaButton.TabIndex = 84
        Me.ViewFormulaButton.Text = "::"
        Me.ViewFormulaButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Effective From :"
        '
        'effectiveFromDateTimePicker
        '
        Me.effectiveFromDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.effectiveFromDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.effectiveFromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.effectiveFromDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effectiveFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.effectiveFromDateTimePicker.Location = New System.Drawing.Point(135, 32)
        Me.effectiveFromDateTimePicker.Name = "effectiveFromDateTimePicker"
        Me.effectiveFromDateTimePicker.Size = New System.Drawing.Size(98, 22)
        Me.effectiveFromDateTimePicker.TabIndex = 83
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Specified Formula :"
        '
        'computeOnPanel
        '
        Me.computeOnPanel.Controls.Add(Me.Label12)
        Me.computeOnPanel.Controls.Add(Me.computeTypeComboBox)
        Me.computeOnPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.computeOnPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computeOnPanel.Location = New System.Drawing.Point(3, 16)
        Me.computeOnPanel.Name = "computeOnPanel"
        Me.computeOnPanel.Size = New System.Drawing.Size(426, 31)
        Me.computeOnPanel.TabIndex = 0
        Me.computeOnPanel.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Compute :"
        '
        'computeTypeComboBox
        '
        Me.computeTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.computeTypeComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computeTypeComboBox.FormattingEnabled = True
        Me.computeTypeComboBox.Items.AddRange(New Object() {"On Deductions Total", "On Taxable Pay", "On Earnings Total", "On Net Salary", "On Sub Total", "On Specified Formula"})
        Me.computeTypeComboBox.Location = New System.Drawing.Point(135, 4)
        Me.computeTypeComboBox.Name = "computeTypeComboBox"
        Me.computeTypeComboBox.Size = New System.Drawing.Size(201, 21)
        Me.computeTypeComboBox.TabIndex = 79
        Me.computeTypeComboBox.Text = "Select"
        '
        'SavePayHeadButton
        '
        Me.SavePayHeadButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePayHeadButton.Location = New System.Drawing.Point(11, 12)
        Me.SavePayHeadButton.Name = "SavePayHeadButton"
        Me.SavePayHeadButton.Size = New System.Drawing.Size(72, 23)
        Me.SavePayHeadButton.TabIndex = 85
        Me.SavePayHeadButton.Text = "Save"
        Me.SavePayHeadButton.UseVisualStyleBackColor = True
        '
        'CancelPayHeadButton
        '
        Me.CancelPayHeadButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPayHeadButton.Location = New System.Drawing.Point(89, 12)
        Me.CancelPayHeadButton.Name = "CancelPayHeadButton"
        Me.CancelPayHeadButton.Size = New System.Drawing.Size(49, 23)
        Me.CancelPayHeadButton.TabIndex = 86
        Me.CancelPayHeadButton.Text = "Cancel"
        Me.CancelPayHeadButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.Label65)
        Me.Panel3.Controls.Add(Me.payHeadNameTextBox)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 561)
        Me.Panel3.TabIndex = 87
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SavePayHeadButton)
        Me.GroupBox3.Controls.Add(Me.CancelPayHeadButton)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 42)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.TabStop = False
        '
        'PayHeadCreationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(903, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(460, 600)
        Me.Name = "PayHeadCreationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pay Head Creation"
        Me.GroupBox1.ResumeLayout(False)
        Me.calcGroupPanel.ResumeLayout(False)
        Me.calcPeriodPanel.ResumeLayout(False)
        Me.calcPeriodPanel.PerformLayout()
        Me.whatCalcTypePanel.ResumeLayout(False)
        Me.whatCalcTypePanel.PerformLayout()
        Me.periodOfPanel.ResumeLayout(False)
        Me.periodOfPanel.PerformLayout()
        Me.calcBasisPanel.ResumeLayout(False)
        Me.calcBasisPanel.PerformLayout()
        Me.calcTypePanel.ResumeLayout(False)
        Me.calcTypePanel.PerformLayout()
        Me.affectNetSalaryPanel.ResumeLayout(False)
        Me.affectNetSalaryPanel.PerformLayout()
        Me.underAndTaxablePanel.ResumeLayout(False)
        Me.underAndTaxablePanel.PerformLayout()
        Me.payTypePanel.ResumeLayout(False)
        Me.payTypePanel.PerformLayout()
        Me.payHeadTypePanel.ResumeLayout(False)
        Me.payHeadTypePanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.computeInfoDgvPanel.ResumeLayout(False)
        CType(Me.graTaxSlabDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computationInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.formulaPanel.ResumeLayout(False)
        Me.formulaPanel.PerformLayout()
        Me.computeOnPanel.ResumeLayout(False)
        Me.computeOnPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label65 As Label
    Friend WithEvents payHeadNameTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents taxableComboBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents calculationBasisComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CalculationPeriodComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents whatTypeComboBox As ComboBox
    Friend WithEvents whattypeLabel As Label
    Friend WithEvents calculationTypeComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameToAppearTextBox As TextBox
    Friend WithEvents affectsNetSalComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents underComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents payHeadTypeComboBox As ComboBox
    Friend WithEvents calculationPeriodLabel As Label
    Friend WithEvents periodOfTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents computeTypeComboBox As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents computationInfoDataGridView As DataGridView
    Friend WithEvents computeOnPanel As Panel
    Friend WithEvents PayTypeComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ViewFormulaButton As Button
    Friend WithEvents effectiveFromDateTimePicker As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents formulaPanel As Panel
    Friend WithEvents SavePayHeadButton As Button
    Friend WithEvents CancelPayHeadButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents computeInfoDgvPanel As Panel
    Friend WithEvents amount_from As DataGridViewTextBoxColumn
    Friend WithEvents amount_to As DataGridViewTextBoxColumn
    Friend WithEvents slab_type As DataGridViewComboBoxColumn
    Friend WithEvents value_basis As DataGridViewTextBoxColumn
    Friend WithEvents payHeadTypePanel As Panel
    Friend WithEvents payTypePanel As Panel
    Friend WithEvents calcBasisPanel As Panel
    Friend WithEvents calcPeriodPanel As Panel
    Friend WithEvents whatCalcTypePanel As Panel
    Friend WithEvents calcTypePanel As Panel
    Friend WithEvents affectNetSalaryPanel As Panel
    Friend WithEvents underAndTaxablePanel As Panel
    Friend WithEvents periodOfPanel As Panel
    Friend WithEvents selectedPayHeadIDTextBox As TextBox
    Friend WithEvents selectedPaytypeIDTextBox As TextBox
    Friend WithEvents calcGroupPanel As Panel
    Friend WithEvents specifiedFormulaTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents graTaxSlabDataGridView As DataGridView
End Class
