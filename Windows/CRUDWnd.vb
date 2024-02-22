
'Rerefence https://www.youtube.com/watch?v=n7SRRnN-geU
Imports System.Data.SqlClient

Public Class CRUDWnd

    Public connection As String = "Data Source=DESKTOP-CNSF48P\TEW_SQLEXPRESS;Initial Catalog=CRUD_JD;User ID=sa;Password=y6dreqbc;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Reference https://www.youtube.com/watch?v=e2ovoOWObiM
        Dim ProcedureName As String = "GetAllProducts"
        DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)

        cmbColor.SelectedIndex = 0
        radAllowed.Checked = True
        txtName.MaxLength = 50
        txtDesign.MaxLength = 150
        'DataGridView1.Columns(1).Width = 100

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.MultiSelect = False
        DataGridView1.ReadOnly = True

    End Sub






    'EVENTS ON CLICK
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim pid As String = txtID.Text
        Dim name As String = txtName.Text
        Dim design As String = txtDesign.Text
        Dim color As String = cmbColor.Text
        Dim daTime As String = DTP1.Value.ToString("yyyy/MM/dd")
        Dim wtype As String = If((radAllowed.Checked), "Allowed", "Not Allowed")

        'METHOD 1
        'Dim query As String = $"INSERT INTO TableProduct values ({pid}, '{name}', '{design}', '{color}', '{daTime}' , '{wtype}')"
        'ExecuteTransaction(query)


        'REFERENCE STORED PROCEDURES GENERATION https://www.youtube.com/watch?v=2OuhVHJGuS0
        'METHOD 2
        Dim ProcedureName As String = $"AddProduct"
        Dim ListParameters As New List(Of ParameterProduct) From {
                New ParameterProduct("@Product_ID", SqlDbType.Int, pid),
                New ParameterProduct("@ItemName", SqlDbType.NVarChar, name),
                New ParameterProduct("@Design", SqlDbType.NVarChar, design),
                New ParameterProduct("@Color", SqlDbType.NVarChar, color),
                New ParameterProduct("@ItemDate", SqlDbType.DateTime, daTime),
                New ParameterProduct("@WarrantlyType", SqlDbType.NVarChar, wtype)
        }

        UtilityProcedures.ExecuteProcedureTransaction(ProcedureName, ListParameters)

        ProcedureName = "GetAllProducts"
        DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)
        'ExecuteProcedureQuery(ProcedureName)

        'Dim parameters(ListParameters.Count - 1) As SqlParameter

        'METHOD 2.01
        'Dim i As Integer = 0
        'For Each p As ParameterProduct In ListParameters
        '    parameters(i) = New SqlParameter(p.parameterName, p.dbType)
        '    parameters(i).Value = p.value
        '    i += 1
        'Next

        'METHOD 2.02
        'parameters(0) = New SqlParameter("@Product_ID", SqlDbType.Int)
        'parameters(0).Value = pid
        'parameters(1) = New SqlParameter("@ItemName", SqlDbType.NVarChar)
        'parameters(1).Value = name
        'parameters(2) = New SqlParameter("@Design", SqlDbType.NVarChar)
        'parameters(2).Value = design
        'parameters(3) = New SqlParameter("@Color", SqlDbType.NVarChar)
        'parameters(3).Value = color
        'parameters(4) = New SqlParameter("@ItemDate", SqlDbType.DateTime)
        'parameters(4).Value = daTime
        'parameters(5) = New SqlParameter("@WarrantlyType", SqlDbType.NVarChar)
        'parameters(5).Value = wtype


        'cmd.Parameters.AddRange(parameters)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.CommandText = "AddProduct"


        '    con.Open()
        '    cmd.ExecuteNonQuery()
        '    con.Close()

        'MessageBox.Show("Succesfully INSERT")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim pid As String = txtID.Text
        Dim name As String = txtName.Text
        Dim design As String = txtDesign.Text
        Dim color As String = cmbColor.Text
        Dim daTime As String = DTP1.Value.ToString("yyyy/MM/dd")
        Dim wtype As String = ""
        If radAllowed.Checked Then
            wtype = "Allowed"
        Else
            wtype = "Not Allowed"
        End If


        Dim ProcedureName As String = $"UpdateProduct"
        Dim ListParameters As New List(Of ParameterProduct) From {
                New ParameterProduct("@Product_ID", SqlDbType.Int, pid),
                New ParameterProduct("@ItemName", SqlDbType.NVarChar, name),
                New ParameterProduct("@Design", SqlDbType.NVarChar, design),
                New ParameterProduct("@Color", SqlDbType.NVarChar, color),
                New ParameterProduct("@ItemDate", SqlDbType.DateTime, daTime),
                New ParameterProduct("@WarrantlyType", SqlDbType.NVarChar, wtype)
        }


        UtilityProcedures.ExecuteProcedureTransaction(ProcedureName, ListParameters)

        ProcedureName = "GetAllProducts"
        DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)

        'MessageBox.Show("Successfully UPDATED")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim pid As String = txtID.Text

        Dim r As DialogResult = MessageBox.Show($"Do you really want to delete the product {pid}", "caption", MessageBoxButtons.YesNo)
        If r = DialogResult.Yes Then

            Dim ProcedureName As String = "DeleteProduct"
            Dim ListParameters As New List(Of ParameterProduct) From {
                New ParameterProduct("@Product_ID", SqlDbType.Int, pid)
            }

            UtilityProcedures.ExecuteProcedureTransaction(ProcedureName, ListParameters)

            ProcedureName = "GetAllProducts"
            DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)

            'MessageBox.Show("Successfully DELETED")

        End If

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

        Dim i As Integer = e.RowIndex

        txtID.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
        txtName.Text = DataGridView1.Rows(i).Cells(1).Value.ToString()
        txtDesign.Text = DataGridView1.Rows(i).Cells(2).Value.ToString()
        cmbColor.Text = DataGridView1.Rows(i).Cells(3).Value.ToString()
        DTP1.Value = DataGridView1.Rows(i).Cells(4).Value
        Dim wtype As String = DataGridView1.Rows(i).Cells(5).Value


        If wtype = "Allowed" Then
            radAllowed.Checked = True
            radNotAllowed.Checked = False
        Else
            radAllowed.Checked = True
            radNotAllowed.Checked = False
        End If


    End Sub






    'EVENTS TEXT CHANGED
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim pid As String = txtSearch.Text
        'Dim query As String = If((id = ""), $"SELECT * FROM TableProduct", $"SELECT * FROM TableProduct WHERE Product_ID LIKE {pid}")
        'LoadDataGridView(query)

        If pid = "" Then

            DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery("GetAllProducts")
        Else

            Dim ListParameters As New List(Of ParameterProduct) From {
                New ParameterProduct("@Product_ID", SqlDbType.Int, pid)
            }

            DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery("SearchProduct", ListParameters)
        End If


    End Sub






    'EVENTS KEYPRESSED
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Public Sub LoadDataGridView(query As String)

    '    Dim con As New SqlConnection(connection)
    '    con.Open()
    '    Dim cmd As New SqlCommand(query, con)
    '    Dim da As New SqlDataAdapter(cmd)
    '    con.Close()
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    DataGridView1.DataSource = dt

    'End Sub




    'CUSTOM CLASSES
    Public Class ParameterProduct
        Public Property parameterName As String
        Public Property dbType As Integer
        Public Property value As String

        'CONSTRUCTORS
        Public Sub New(aparameterName As String, adbType As String, avalue As String)

            parameterName = aparameterName
            dbType = adbType
            value = avalue

        End Sub

    End Class

    Public Class Product

        Public Property Product_ID As Integer
        Public Property ItemName As String
        Public Property Design As String
        Public Property Color As String
        Public Property ItemDate As DateTime
        Public Property WarrantlyType As String
        'CONSTRUCTORS

        Public Sub New(aProduct_ID As Integer, aItemName As String, aDesign As String, aColor As String, aItemDate As DateTime, aWarrantlyType As String)

            Product_ID = aProduct_ID
            ItemName = aItemName
            Design = aDesign
            Color = aColor
            ItemDate = aItemDate
            WarrantlyType = aWarrantlyType

        End Sub

    End Class

End Class
