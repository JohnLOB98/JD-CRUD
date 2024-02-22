Imports JD_CRUD.CRUDWnd

Public Class InventoryWnd

    Public connection As String = "Data Source=DESKTOP-CNSF48P\TEW_SQLEXPRESS;Initial Catalog=CRUD_JD;User ID=sa;Password=y6dreqbc;"

    Public SelectProductID As Integer = -1

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ProcedureName As String = "GetAllProducts"
        DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.MultiSelect = False
        DataGridView1.ReadOnly = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim pid As String = TextBox1.Text
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click

        'Dim rowIndex = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
        'DataGridView1.Row

        If SelectProductID > -1 Then
            Dim pid As String = SelectProductID
            Dim daTime As String = DateTime.Now.ToString("yyyy/MM/dd")

            'REFERENCE STORED PROCEDURES GENERATION https://www.youtube.com/watch?v=2OuhVHJGuS0
            'METHOD 2
            Dim ProcedureName As String = $"AddSell"
            Dim ListParameters As New List(Of ParameterProduct) From {
                New ParameterProduct("@ProductID", SqlDbType.Int, pid),
                New ParameterProduct("@SellDate", SqlDbType.DateTime, daTime)
            }

            UtilityProcedures.ExecuteProcedureTransaction(ProcedureName, ListParameters)
            'MessageBox.Show("INSERT Sell Successfuly")

            'ProcedureName = "GetAllProducts"
            'DataGridView1.DataSource = UtilityProcedures.ExecuteProcedureQuery(ProcedureName)
        End If

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick

        Dim Index As Integer = e.RowIndex
        SelectProductID = DataGridView1.Rows(Index).Cells(0).Value

    End Sub
End Class