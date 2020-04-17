Imports System.ComponentModel

Public Class PayrollForm

    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PayrollSetupButton_Click(sender As Object, e As EventArgs) Handles PayrollSetupButton.Click
        titleHeaderLabel.Text = PayrollSetupButton.Text
        titleHeaderLabel.Visible = True
        setupPanel.Visible = True
        setupPanel.Location = New Point(14, 80)
        setupPanel.Width = 621
        setupPanel.Height = 1002
        CreatePayHeadPanel.Visible = False
        salarySetupPanel.Visible = False
    End Sub

    Private Sub CreatePayHeadButton_Click(sender As Object, e As EventArgs) Handles CreatePayHeadButton.Click
        PayHeadCreationForm.Show()
        titleHeaderLabel.Text = CreatePayHeadButton.Text
        titleHeaderLabel.Visible = True
        CreatePayHeadPanel.Visible = True
        CreatePayHeadPanel.Location = New Point(14, 80)
        CreatePayHeadPanel.Width = 621
        CreatePayHeadPanel.Height = 1002
        setupPanel.Visible = False
        salarySetupPanel.Visible = False
    End Sub

    Private Sub ProcessPayrollButton_Click(sender As Object, e As EventArgs) Handles ProcessPayrollButton.Click
        titleHeaderLabel.Text = ProcessPayrollButton.Text
        titleHeaderLabel.Visible = True
    End Sub

    Private Sub PayrollForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainPageForm.Show()
    End Sub

    Private Sub SalarySetupButton_Click(sender As Object, e As EventArgs) Handles SalarySetupButton.Click
        SalaryDetailsSetupForm.Show()
        titleHeaderLabel.Text = SalarySetupButton.Text
        titleHeaderLabel.Visible = True
        salarySetupPanel.Visible = True
        salarySetupPanel.Location = New Point(14, 80)
        salarySetupPanel.Width = 621
        salarySetupPanel.Height = 1002
        setupPanel.Visible = False
        CreatePayHeadPanel.Visible = False
    End Sub

    Private Sub AttendanceButton_Click(sender As Object, e As EventArgs) Handles AttendanceButton.Click
        AttendaceOrProductionVoucherForm.Show()
    End Sub

    Private Sub AttendanceVoucherButton_Click(sender As Object, e As EventArgs) Handles AttendanceVoucherButton.Click

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class