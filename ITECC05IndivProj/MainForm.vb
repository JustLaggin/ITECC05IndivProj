Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbdataset As New DataTable
    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        LoginForm.Show()
        Me.Close()


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
            MessageBox.Show("Data updated")
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
            MessageBox.Show("Data deleted")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btn_load.PerformClick()
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM testdatabase.data"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("firstname")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM testdatabase.data Where firstname= '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtbox_eid.Text = READER.GetInt32("eid")
                txtbox_firstname.Text = READER.GetString("firstname")
                txtbox_lastname.Text = READER.GetString("lastname")
                txtbox_age.Text = READER.GetInt32("age")
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM testdatabase.data Where firstname= '" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtbox_eid.Text = READER.GetInt32("eid")
                txtbox_firstname.Text = READER.GetString("firstname")
                txtbox_lastname.Text = READER.GetString("lastname")
                txtbox_age.Text = READER.GetInt32("age")
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=testdatabase"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM testdatabase.data"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtbox_eid.Text = row.Cells("eid").Value.ToString
            txtbox_firstname.Text = row.Cells("firstname").Value.ToString
            txtbox_lastname.Text = row.Cells("lastname").Value.ToString
            txtbox_age.Text = row.Cells("age").Value.ToString
        End If
    End Sub

    Private Sub txtbox_search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_search.TextChanged
        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("firstname like '%" & txtbox_search.Text & "%'")
        DataGridView1.DataSource = DV
    End Sub
End Class