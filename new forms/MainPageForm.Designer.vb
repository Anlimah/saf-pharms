<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPageForm
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
        Me.LoansButton = New System.Windows.Forms.Button()
        Me.LeavesButton = New System.Windows.Forms.Button()
        Me.SetupButton = New System.Windows.Forms.Button()
        Me.PayrollButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.mainMenuPanel = New System.Windows.Forms.Panel()
        Me.mainMenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoansButton
        '
        Me.LoansButton.Location = New System.Drawing.Point(114, 77)
        Me.LoansButton.Name = "LoansButton"
        Me.LoansButton.Size = New System.Drawing.Size(75, 55)
        Me.LoansButton.TabIndex = 18
        Me.LoansButton.Text = "Loans"
        Me.LoansButton.UseVisualStyleBackColor = True
        '
        'LeavesButton
        '
        Me.LeavesButton.Location = New System.Drawing.Point(195, 16)
        Me.LeavesButton.Name = "LeavesButton"
        Me.LeavesButton.Size = New System.Drawing.Size(75, 55)
        Me.LeavesButton.TabIndex = 17
        Me.LeavesButton.Text = "Leaves"
        Me.LeavesButton.UseVisualStyleBackColor = True
        '
        'SetupButton
        '
        Me.SetupButton.Location = New System.Drawing.Point(114, 138)
        Me.SetupButton.Name = "SetupButton"
        Me.SetupButton.Size = New System.Drawing.Size(75, 55)
        Me.SetupButton.TabIndex = 16
        Me.SetupButton.Text = "SetUp"
        Me.SetupButton.UseVisualStyleBackColor = True
        '
        'PayrollButton
        '
        Me.PayrollButton.Location = New System.Drawing.Point(114, 16)
        Me.PayrollButton.Name = "PayrollButton"
        Me.PayrollButton.Size = New System.Drawing.Size(75, 55)
        Me.PayrollButton.TabIndex = 13
        Me.PayrollButton.Text = "Payroll"
        Me.PayrollButton.UseVisualStyleBackColor = True
        '
        'EmployeeButton
        '
        Me.EmployeeButton.Location = New System.Drawing.Point(33, 16)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(75, 55)
        Me.EmployeeButton.TabIndex = 12
        Me.EmployeeButton.Text = "Employee"
        Me.EmployeeButton.UseVisualStyleBackColor = True
        '
        'mainMenuPanel
        '
        Me.mainMenuPanel.Controls.Add(Me.SetupButton)
        Me.mainMenuPanel.Controls.Add(Me.LoansButton)
        Me.mainMenuPanel.Controls.Add(Me.EmployeeButton)
        Me.mainMenuPanel.Controls.Add(Me.LeavesButton)
        Me.mainMenuPanel.Controls.Add(Me.PayrollButton)
        Me.mainMenuPanel.Location = New System.Drawing.Point(259, 112)
        Me.mainMenuPanel.Name = "mainMenuPanel"
        Me.mainMenuPanel.Size = New System.Drawing.Size(305, 210)
        Me.mainMenuPanel.TabIndex = 19
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 427)
        Me.Controls.Add(Me.mainMenuPanel)
        Me.Name = "MainPageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainPageForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainMenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoansButton As Button
    Friend WithEvents LeavesButton As Button
    Friend WithEvents SetupButton As Button
    Friend WithEvents PayrollButton As Button
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents mainMenuPanel As Panel
End Class
