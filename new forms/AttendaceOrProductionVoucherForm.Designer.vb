<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendaceOrProductionVoucherForm
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
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.attendOrProductVoucherDataGridView = New System.Windows.Forms.DataGridView()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.setupAOrPVoucherButton = New System.Windows.Forms.Button()
        Me.attendOrProductVoucherSetupPanel = New System.Windows.Forms.Panel()
        Me.attendOrProductUnitTextBox = New System.Windows.Forms.TextBox()
        Me.empOrGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.empOrGroupTypeTextBox = New System.Windows.Forms.TextBox()
        Me.empCatIDTextBox = New System.Windows.Forms.TextBox()
        Me.attendOrProdIDTextBox = New System.Windows.Forms.TextBox()
        Me.empOrGroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveVoucherDetailsButton = New System.Windows.Forms.Button()
        Me.CancelVoucherDetailsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.defaultValueTextBox = New System.Windows.Forms.TextBox()
        Me.AttendOrProductComboBox = New System.Windows.Forms.ComboBox()
        Me.voucherDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.empCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.saveAttendOrProductVoucherButton = New System.Windows.Forms.Button()
        CType(Me.attendOrProductVoucherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.attendOrProductVoucherSetupPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'attendOrProductVoucherDataGridView
        '
        DataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control
        Me.attendOrProductVoucherDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle43
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.attendOrProductVoucherDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.attendOrProductVoucherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.attendOrProductVoucherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.type, Me.value, Me.unit})
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.attendOrProductVoucherDataGridView.DefaultCellStyle = DataGridViewCellStyle48
        Me.attendOrProductVoucherDataGridView.GridColor = System.Drawing.Color.White
        Me.attendOrProductVoucherDataGridView.Location = New System.Drawing.Point(12, 40)
        Me.attendOrProductVoucherDataGridView.Name = "attendOrProductVoucherDataGridView"
        Me.attendOrProductVoucherDataGridView.RowHeadersVisible = False
        Me.attendOrProductVoucherDataGridView.Size = New System.Drawing.Size(684, 299)
        Me.attendOrProductVoucherDataGridView.TabIndex = 0
        Me.attendOrProductVoucherDataGridView.Visible = False
        '
        'type
        '
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.type.DefaultCellStyle = DataGridViewCellStyle45
        Me.type.HeaderText = "ATTENDANCE/PRODUCTION TYPE"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Width = 250
        '
        'value
        '
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.value.DefaultCellStyle = DataGridViewCellStyle46
        Me.value.HeaderText = "VALUE"
        Me.value.Name = "value"
        '
        'unit
        '
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.unit.DefaultCellStyle = DataGridViewCellStyle47
        Me.unit.HeaderText = "UNIT"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'setupAOrPVoucherButton
        '
        Me.setupAOrPVoucherButton.Location = New System.Drawing.Point(12, 11)
        Me.setupAOrPVoucherButton.Name = "setupAOrPVoucherButton"
        Me.setupAOrPVoucherButton.Size = New System.Drawing.Size(27, 23)
        Me.setupAOrPVoucherButton.TabIndex = 1
        Me.setupAOrPVoucherButton.Text = "+"
        Me.setupAOrPVoucherButton.UseVisualStyleBackColor = True
        '
        'attendOrProductVoucherSetupPanel
        '
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.attendOrProductUnitTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.empOrGroupIDTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.empOrGroupTypeTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.empCatIDTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.attendOrProdIDTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.empOrGroupNameTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Panel1)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label1)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label5)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label13)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label12)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label11)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label10)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label9)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label8)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.defaultValueTextBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.AttendOrProductComboBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.voucherDateTimePicker)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.empCategoryComboBox)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label7)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label6)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label4)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label3)
        Me.attendOrProductVoucherSetupPanel.Controls.Add(Me.Label2)
        Me.attendOrProductVoucherSetupPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendOrProductVoucherSetupPanel.Location = New System.Drawing.Point(0, 0)
        Me.attendOrProductVoucherSetupPanel.Name = "attendOrProductVoucherSetupPanel"
        Me.attendOrProductVoucherSetupPanel.Size = New System.Drawing.Size(432, 339)
        Me.attendOrProductVoucherSetupPanel.TabIndex = 3
        '
        'attendOrProductUnitTextBox
        '
        Me.attendOrProductUnitTextBox.BackColor = System.Drawing.Color.Snow
        Me.attendOrProductUnitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.attendOrProductUnitTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attendOrProductUnitTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendOrProductUnitTextBox.Location = New System.Drawing.Point(334, 218)
        Me.attendOrProductUnitTextBox.Name = "attendOrProductUnitTextBox"
        Me.attendOrProductUnitTextBox.ReadOnly = True
        Me.attendOrProductUnitTextBox.Size = New System.Drawing.Size(48, 15)
        Me.attendOrProductUnitTextBox.TabIndex = 110
        Me.attendOrProductUnitTextBox.Visible = False
        '
        'empOrGroupIDTextBox
        '
        Me.empOrGroupIDTextBox.BackColor = System.Drawing.Color.Snow
        Me.empOrGroupIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empOrGroupIDTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empOrGroupIDTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empOrGroupIDTextBox.Location = New System.Drawing.Point(334, 169)
        Me.empOrGroupIDTextBox.Name = "empOrGroupIDTextBox"
        Me.empOrGroupIDTextBox.ReadOnly = True
        Me.empOrGroupIDTextBox.Size = New System.Drawing.Size(48, 15)
        Me.empOrGroupIDTextBox.TabIndex = 109
        Me.empOrGroupIDTextBox.Text = "0"
        Me.empOrGroupIDTextBox.Visible = False
        '
        'empOrGroupTypeTextBox
        '
        Me.empOrGroupTypeTextBox.BackColor = System.Drawing.Color.Snow
        Me.empOrGroupTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empOrGroupTypeTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empOrGroupTypeTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empOrGroupTypeTextBox.Location = New System.Drawing.Point(217, 169)
        Me.empOrGroupTypeTextBox.Name = "empOrGroupTypeTextBox"
        Me.empOrGroupTypeTextBox.ReadOnly = True
        Me.empOrGroupTypeTextBox.Size = New System.Drawing.Size(105, 15)
        Me.empOrGroupTypeTextBox.TabIndex = 108
        Me.empOrGroupTypeTextBox.Text = "All Items"
        Me.empOrGroupTypeTextBox.Visible = False
        '
        'empCatIDTextBox
        '
        Me.empCatIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.empCatIDTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empCatIDTextBox.Location = New System.Drawing.Point(402, 120)
        Me.empCatIDTextBox.Name = "empCatIDTextBox"
        Me.empCatIDTextBox.ReadOnly = True
        Me.empCatIDTextBox.Size = New System.Drawing.Size(25, 22)
        Me.empCatIDTextBox.TabIndex = 107
        Me.empCatIDTextBox.Text = "1"
        Me.empCatIDTextBox.Visible = False
        '
        'attendOrProdIDTextBox
        '
        Me.attendOrProdIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.attendOrProdIDTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendOrProdIDTextBox.Location = New System.Drawing.Point(401, 239)
        Me.attendOrProdIDTextBox.Name = "attendOrProdIDTextBox"
        Me.attendOrProdIDTextBox.ReadOnly = True
        Me.attendOrProdIDTextBox.Size = New System.Drawing.Size(25, 22)
        Me.attendOrProdIDTextBox.TabIndex = 106
        Me.attendOrProdIDTextBox.Visible = False
        '
        'empOrGroupNameTextBox
        '
        Me.empOrGroupNameTextBox.BackColor = System.Drawing.Color.Snow
        Me.empOrGroupNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.empOrGroupNameTextBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empOrGroupNameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empOrGroupNameTextBox.Location = New System.Drawing.Point(217, 148)
        Me.empOrGroupNameTextBox.Name = "empOrGroupNameTextBox"
        Me.empOrGroupNameTextBox.ReadOnly = True
        Me.empOrGroupNameTextBox.Size = New System.Drawing.Size(165, 15)
        Me.empOrGroupNameTextBox.TabIndex = 105
        Me.empOrGroupNameTextBox.Text = "All Items"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.SaveVoucherDetailsButton)
        Me.Panel1.Controls.Add(Me.CancelVoucherDetailsButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 34)
        Me.Panel1.TabIndex = 104
        '
        'SaveVoucherDetailsButton
        '
        Me.SaveVoucherDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveVoucherDetailsButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveVoucherDetailsButton.Location = New System.Drawing.Point(17, 7)
        Me.SaveVoucherDetailsButton.Name = "SaveVoucherDetailsButton"
        Me.SaveVoucherDetailsButton.Size = New System.Drawing.Size(72, 20)
        Me.SaveVoucherDetailsButton.TabIndex = 87
        Me.SaveVoucherDetailsButton.Text = "Save"
        Me.SaveVoucherDetailsButton.UseVisualStyleBackColor = True
        '
        'CancelVoucherDetailsButton
        '
        Me.CancelVoucherDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelVoucherDetailsButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelVoucherDetailsButton.Location = New System.Drawing.Point(95, 7)
        Me.CancelVoucherDetailsButton.Name = "CancelVoucherDetailsButton"
        Me.CancelVoucherDetailsButton.Size = New System.Drawing.Size(49, 20)
        Me.CancelVoucherDetailsButton.TabIndex = 88
        Me.CancelVoucherDetailsButton.Text = "Cancel"
        Me.CancelVoucherDetailsButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Attendance Auto Fill"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Auto Fill Values"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(200, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 15)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(200, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 15)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(201, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 15)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(201, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 15)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(201, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 15)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 15)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "(Value entered above will be prefilled for all employees)"
        '
        'defaultValueTextBox
        '
        Me.defaultValueTextBox.BackColor = System.Drawing.Color.Snow
        Me.defaultValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.defaultValueTextBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaultValueTextBox.Location = New System.Drawing.Point(216, 266)
        Me.defaultValueTextBox.Name = "defaultValueTextBox"
        Me.defaultValueTextBox.Size = New System.Drawing.Size(34, 15)
        Me.defaultValueTextBox.TabIndex = 93
        Me.defaultValueTextBox.Text = "0"
        '
        'AttendOrProductComboBox
        '
        Me.AttendOrProductComboBox.BackColor = System.Drawing.Color.Snow
        Me.AttendOrProductComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendOrProductComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendOrProductComboBox.FormattingEnabled = True
        Me.AttendOrProductComboBox.Location = New System.Drawing.Point(216, 239)
        Me.AttendOrProductComboBox.Name = "AttendOrProductComboBox"
        Me.AttendOrProductComboBox.Size = New System.Drawing.Size(182, 21)
        Me.AttendOrProductComboBox.TabIndex = 92
        '
        'voucherDateTimePicker
        '
        Me.voucherDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.voucherDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.voucherDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voucherDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.voucherDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voucherDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.voucherDateTimePicker.Location = New System.Drawing.Point(217, 93)
        Me.voucherDateTimePicker.Name = "voucherDateTimePicker"
        Me.voucherDateTimePicker.Size = New System.Drawing.Size(105, 22)
        Me.voucherDateTimePicker.TabIndex = 91
        '
        'empCategoryComboBox
        '
        Me.empCategoryComboBox.BackColor = System.Drawing.Color.Snow
        Me.empCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empCategoryComboBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empCategoryComboBox.FormattingEnabled = True
        Me.empCategoryComboBox.Location = New System.Drawing.Point(217, 121)
        Me.empCategoryComboBox.Name = "empCategoryComboBox"
        Me.empCategoryComboBox.Size = New System.Drawing.Size(182, 21)
        Me.empCategoryComboBox.TabIndex = 10
        Me.empCategoryComboBox.Text = "Primary Cost Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Default Value to Fill"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Attendance/Production Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Employee/Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Employee Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Voucher Date"
        '
        'saveAttendOrProductVoucherButton
        '
        Me.saveAttendOrProductVoucherButton.Location = New System.Drawing.Point(642, 11)
        Me.saveAttendOrProductVoucherButton.Name = "saveAttendOrProductVoucherButton"
        Me.saveAttendOrProductVoucherButton.Size = New System.Drawing.Size(54, 23)
        Me.saveAttendOrProductVoucherButton.TabIndex = 4
        Me.saveAttendOrProductVoucherButton.Text = "Save"
        Me.saveAttendOrProductVoucherButton.UseVisualStyleBackColor = True
        '
        'AttendaceOrProductionVoucherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 340)
        Me.Controls.Add(Me.saveAttendOrProductVoucherButton)
        Me.Controls.Add(Me.attendOrProductVoucherSetupPanel)
        Me.Controls.Add(Me.setupAOrPVoucherButton)
        Me.Controls.Add(Me.attendOrProductVoucherDataGridView)
        Me.MaximumSize = New System.Drawing.Size(724, 392)
        Me.MinimumSize = New System.Drawing.Size(447, 379)
        Me.Name = "AttendaceOrProductionVoucherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AttendaceOrProductionVoucherForm"
        CType(Me.attendOrProductVoucherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.attendOrProductVoucherSetupPanel.ResumeLayout(False)
        Me.attendOrProductVoucherSetupPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents attendOrProductVoucherDataGridView As DataGridView
    Friend WithEvents setupAOrPVoucherButton As Button
    Friend WithEvents attendOrProductVoucherSetupPanel As Panel
    Friend WithEvents empCategoryComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents voucherDateTimePicker As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents defaultValueTextBox As TextBox
    Friend WithEvents AttendOrProductComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveVoucherDetailsButton As Button
    Friend WithEvents CancelVoucherDetailsButton As Button
    Friend WithEvents empOrGroupNameTextBox As TextBox
    Friend WithEvents empCatIDTextBox As TextBox
    Friend WithEvents attendOrProdIDTextBox As TextBox
    Friend WithEvents empOrGroupTypeTextBox As TextBox
    Friend WithEvents empOrGroupIDTextBox As TextBox
    Friend WithEvents attendOrProductUnitTextBox As TextBox
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents value As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents saveAttendOrProductVoucherButton As Button
End Class
