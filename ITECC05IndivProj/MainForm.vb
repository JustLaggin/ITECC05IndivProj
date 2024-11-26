Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Hide()
        LoginForm.txtbox_username.Clear()
        LoginForm.txtbox_password.Clear()
        LoginForm.Show()

    End Sub
End Class