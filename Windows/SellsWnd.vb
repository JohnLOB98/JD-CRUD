
Public Class SellsWnd
    Private Sub SellsWnd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ProcedureName As String = "SeeSells"
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
End Class