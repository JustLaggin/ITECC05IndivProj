<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        LogOut = New Button()
        txtbox_eid = New TextBox()
        txtbox_firstname = New TextBox()
        txtbox_lastname = New TextBox()
        txtbox_age = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btn_Save = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        btn_loadtable = New Button()
        txtbox_search = New TextBox()
        Chart1 = New DataVisualization.Charting.Chart()
        btn_loadchart = New Button()
        radbtn_male = New RadioButton()
        radbtn_female = New RadioButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogOut
        ' 
        LogOut.Location = New Point(23, 12)
        LogOut.Name = "LogOut"
        LogOut.Size = New Size(75, 23)
        LogOut.TabIndex = 0
        LogOut.Text = "Sign Out"
        LogOut.UseVisualStyleBackColor = True
        ' 
        ' txtbox_eid
        ' 
        txtbox_eid.Location = New Point(116, 80)
        txtbox_eid.Name = "txtbox_eid"
        txtbox_eid.Size = New Size(164, 23)
        txtbox_eid.TabIndex = 1
        txtbox_eid.WordWrap = False
        ' 
        ' txtbox_firstname
        ' 
        txtbox_firstname.Location = New Point(116, 109)
        txtbox_firstname.Name = "txtbox_firstname"
        txtbox_firstname.Size = New Size(164, 23)
        txtbox_firstname.TabIndex = 2
        ' 
        ' txtbox_lastname
        ' 
        txtbox_lastname.Location = New Point(116, 138)
        txtbox_lastname.Name = "txtbox_lastname"
        txtbox_lastname.Size = New Size(164, 23)
        txtbox_lastname.TabIndex = 3
        ' 
        ' txtbox_age
        ' 
        txtbox_age.Location = New Point(116, 167)
        txtbox_age.Name = "txtbox_age"
        txtbox_age.Size = New Size(164, 23)
        txtbox_age.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 15)
        Label1.TabIndex = 5
        Label1.Text = "EID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 6
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 7
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 8
        Label4.Text = "Age"
        ' 
        ' btn_Save
        ' 
        btn_Save.Location = New Point(23, 240)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(75, 23)
        btn_Save.TabIndex = 9
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.Location = New Point(104, 240)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(75, 23)
        btn_update.TabIndex = 10
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(185, 240)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(75, 23)
        btn_delete.TabIndex = 11
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(104, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(144, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(254, 16)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(144, 19)
        ListBox1.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(330, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(339, 150)
        DataGridView1.TabIndex = 14
        ' 
        ' btn_loadtable
        ' 
        btn_loadtable.Location = New Point(330, 236)
        btn_loadtable.Name = "btn_loadtable"
        btn_loadtable.Size = New Size(75, 23)
        btn_loadtable.TabIndex = 15
        btn_loadtable.Text = "Load Table"
        btn_loadtable.UseVisualStyleBackColor = True
        ' 
        ' txtbox_search
        ' 
        txtbox_search.Location = New Point(411, 236)
        txtbox_search.Name = "txtbox_search"
        txtbox_search.Size = New Size(258, 23)
        txtbox_search.TabIndex = 16
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(699, 80)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Name_vs_Age"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(339, 150)
        Chart1.TabIndex = 17
        Chart1.Text = "Chart1"
        ' 
        ' btn_loadchart
        ' 
        btn_loadchart.Location = New Point(699, 240)
        btn_loadchart.Name = "btn_loadchart"
        btn_loadchart.Size = New Size(75, 23)
        btn_loadchart.TabIndex = 18
        btn_loadchart.Text = "Load Chart"
        btn_loadchart.UseVisualStyleBackColor = True
        ' 
        ' radbtn_male
        ' 
        radbtn_male.AutoSize = True
        radbtn_male.Location = New Point(23, 211)
        radbtn_male.Name = "radbtn_male"
        radbtn_male.Size = New Size(51, 19)
        radbtn_male.TabIndex = 19
        radbtn_male.TabStop = True
        radbtn_male.Text = "male"
        radbtn_male.UseVisualStyleBackColor = True
        ' 
        ' radbtn_female
        ' 
        radbtn_female.AutoSize = True
        radbtn_female.Location = New Point(183, 211)
        radbtn_female.Name = "radbtn_female"
        radbtn_female.Size = New Size(63, 19)
        radbtn_female.TabIndex = 20
        radbtn_female.TabStop = True
        radbtn_female.Text = "Female"
        radbtn_female.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1081, 277)
        Controls.Add(radbtn_female)
        Controls.Add(radbtn_male)
        Controls.Add(btn_loadchart)
        Controls.Add(Chart1)
        Controls.Add(txtbox_search)
        Controls.Add(btn_loadtable)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_Save)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtbox_age)
        Controls.Add(txtbox_lastname)
        Controls.Add(txtbox_firstname)
        Controls.Add(txtbox_eid)
        Controls.Add(LogOut)
        Name = "MainForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LogOut As Button
    Friend WithEvents txtbox_eid As TextBox
    Friend WithEvents txtbox_firstname As TextBox
    Friend WithEvents txtbox_lastname As TextBox
    Friend WithEvents txtbox_age As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_loadtable As Button
    Friend WithEvents txtbox_search As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btn_loadchart As Button
    Friend WithEvents radbtn_male As RadioButton
    Friend WithEvents radbtn_female As RadioButton
End Class
