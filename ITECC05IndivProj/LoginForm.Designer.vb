<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Label1 = New Label()
        btn_login = New Button()
        Label2 = New Label()
        txtbox_username = New TextBox()
        txtbox_password = New TextBox()
        btn_connect = New Button()
        btn_showpass = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        Label1.Location = New Point(68, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 37)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' btn_login
        ' 
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatStyle = FlatStyle.Popup
        btn_login.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btn_login.Location = New Point(361, 248)
        btn_login.Margin = New Padding(3, 2, 3, 2)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(95, 33)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        Label2.Location = New Point(75, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 37)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtbox_username
        ' 
        txtbox_username.Location = New Point(250, 103)
        txtbox_username.Name = "txtbox_username"
        txtbox_username.Size = New Size(332, 23)
        txtbox_username.TabIndex = 3
        ' 
        ' txtbox_password
        ' 
        txtbox_password.Location = New Point(250, 184)
        txtbox_password.Name = "txtbox_password"
        txtbox_password.Size = New Size(332, 23)
        txtbox_password.TabIndex = 4
        txtbox_password.UseSystemPasswordChar = True
        ' 
        ' btn_connect
        ' 
        btn_connect.Cursor = Cursors.Hand
        btn_connect.FlatStyle = FlatStyle.Popup
        btn_connect.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btn_connect.Location = New Point(614, 364)
        btn_connect.Margin = New Padding(3, 2, 3, 2)
        btn_connect.Name = "btn_connect"
        btn_connect.Size = New Size(141, 34)
        btn_connect.TabIndex = 0
        btn_connect.Text = "Connection"
        btn_connect.UseVisualStyleBackColor = True
        ' 
        ' btn_showpass
        ' 
        btn_showpass.Location = New Point(507, 184)
        btn_showpass.Name = "btn_showpass"
        btn_showpass.Size = New Size(75, 23)
        btn_showpass.TabIndex = 6
        btn_showpass.Text = "Show"
        btn_showpass.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_showpass)
        Controls.Add(btn_connect)
        Controls.Add(txtbox_password)
        Controls.Add(txtbox_username)
        Controls.Add(Label2)
        Controls.Add(btn_login)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents btn_connect As Button
    Friend WithEvents btn_showpass As Button

End Class
