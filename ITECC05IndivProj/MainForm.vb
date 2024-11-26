Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        LoginForm.txtbox_username.Clear()
        LoginForm.txtbox_password.Clear()
        LoginForm.Show()

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "INSERT INTO testdatabase.Data (EID,firstname,lastname,age) Values ('" & txtbox_eid.Text & "' ,'" & txtbox_firstname.Text & "' ,'" & txtbox_lastname.Text & "' ,'" & txtbox_age.Text & "' )"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "Update testdatabase.Data SET EID= '" & txtbox_eid.Text & "' ,firstname='" & txtbox_firstname.Text & "' ,lastname='" & txtbox_lastname.Text & "' ,age='" & txtbox_age.Text & "' where eid='" & txtbox_eid.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "Update testdatabase.Data SET EID= '" & txtbox_eid.Text & "' ,firstname='" & txtbox_firstname.Text & "' ,lastname='" & txtbox_lastname.Text & "' ,age='" & txtbox_age.Text & "' where eid='" & txtbox_eid.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class