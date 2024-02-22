<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUDWnd
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
        txtID = New TextBox()
        txtName = New TextBox()
        txtDesign = New TextBox()
        cmbColor = New ComboBox()
        DTP1 = New DateTimePicker()
        btnInsert = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        radAllowed = New RadioButton()
        radNotAllowed = New RadioButton()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtSearch = New TextBox()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Anchor = AnchorStyles.None
        txtID.Location = New Point(161, 106)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.None
        txtName.Location = New Point(161, 157)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 1
        ' 
        ' txtDesign
        ' 
        txtDesign.Anchor = AnchorStyles.None
        txtDesign.Location = New Point(161, 205)
        txtDesign.Name = "txtDesign"
        txtDesign.Size = New Size(100, 23)
        txtDesign.TabIndex = 2
        ' 
        ' cmbColor
        ' 
        cmbColor.Anchor = AnchorStyles.None
        cmbColor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbColor.FormattingEnabled = True
        cmbColor.ItemHeight = 15
        cmbColor.Items.AddRange(New Object() {"Black", "White", "Gray"})
        cmbColor.Location = New Point(161, 251)
        cmbColor.MaxDropDownItems = 3
        cmbColor.Name = "cmbColor"
        cmbColor.Size = New Size(121, 23)
        cmbColor.TabIndex = 3
        ' 
        ' DTP1
        ' 
        DTP1.Anchor = AnchorStyles.None
        DTP1.CustomFormat = "dd/MM/YY"
        DTP1.Format = DateTimePickerFormat.Short
        DTP1.Location = New Point(161, 295)
        DTP1.Name = "DTP1"
        DTP1.Size = New Size(200, 23)
        DTP1.TabIndex = 4
        ' 
        ' btnInsert
        ' 
        btnInsert.Anchor = AnchorStyles.None
        btnInsert.BackColor = Color.White
        btnInsert.FlatStyle = FlatStyle.Flat
        btnInsert.Location = New Point(158, 367)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(100, 23)
        btnInsert.TabIndex = 5
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.None
        btnUpdate.BackColor = Color.White
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Location = New Point(281, 367)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.BackColor = Color.White
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(404, 367)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 23)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' radAllowed
        ' 
        radAllowed.Anchor = AnchorStyles.None
        radAllowed.AutoSize = True
        radAllowed.Location = New Point(161, 333)
        radAllowed.Name = "radAllowed"
        radAllowed.Size = New Size(68, 19)
        radAllowed.TabIndex = 8
        radAllowed.TabStop = True
        radAllowed.Text = "Allowed"
        radAllowed.UseVisualStyleBackColor = True
        ' 
        ' radNotAllowed
        ' 
        radNotAllowed.Anchor = AnchorStyles.None
        radNotAllowed.AutoSize = True
        radNotAllowed.Location = New Point(279, 333)
        radNotAllowed.Name = "radNotAllowed"
        radNotAllowed.Size = New Size(91, 19)
        radNotAllowed.TabIndex = 9
        radNotAllowed.TabStop = True
        radNotAllowed.Text = "Not Allowed"
        radNotAllowed.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 40F)
        Label1.Location = New Point(161, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 72)
        Label1.TabIndex = 10
        Label1.Text = "CRUD"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(158, 405)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1037, 147)
        DataGridView1.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(82, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 12
        Label2.Text = "Product ID"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(81, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 13
        Label3.Text = "Item name"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(102, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 14
        Label4.Text = "Design"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(104, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 14
        Label5.Text = "Color"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(60, 333)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 14
        Label6.Text = "Warrantly Type"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Location = New Point(81, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 14
        Label7.Text = "Insert Date"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.None
        txtSearch.Location = New Point(544, 106)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Location = New Point(466, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 15)
        Label8.TabIndex = 16
        Label8.Text = "Search by ID"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1311, 618)
        ControlBox = False
        Controls.Add(Label8)
        Controls.Add(txtSearch)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(radNotAllowed)
        Controls.Add(radAllowed)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnInsert)
        Controls.Add(DTP1)
        Controls.Add(cmbColor)
        Controls.Add(txtDesign)
        Controls.Add(txtName)
        Controls.Add(txtID)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDesign As TextBox
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents radAllowed As RadioButton
    Friend WithEvents radNotAllowed As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label

End Class
