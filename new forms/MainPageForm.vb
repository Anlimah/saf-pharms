Public Class MainPageForm

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        Dim mmpWidth As Integer = mainMenuPanel.Width
        Dim mmpHeight As Integer = mainMenuPanel.Height

        mainMenuPanel.Location = New Point(((formWidth - mmpWidth) / 2), ((formHeight - mmpHeight) / 2))

        Me.Focus()
    End Sub
    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        EmployeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub PayrollButton_Click(sender As Object, e As EventArgs) Handles PayrollButton.Click
        PayrollForm.Show()
        Me.Hide()
    End Sub
End Class