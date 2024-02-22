Imports JD_CRUD.CRUDWnd
Imports System.Data.SqlClient

Public Class UtilityProcedures


    Public Shared connection As String = "Data Source=DESKTOP-CNSF48P\TEW_SQLEXPRESS;Initial Catalog=CRUD_JD;User ID=sa;Password=y6dreqbc;"

    Public Shared Function ExecuteProcedureQuery(ProcedureName As String) As DataTable


        Try
            Dim con As New SqlConnection(connection)
            Dim cmd As New SqlCommand(ProcedureName, con)
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            con.Close()
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            'MessageBox.Show("Error ExecuteProcedureTransaction 1.00" & vbCrLf & ex.Message)
            MessageBox.Show("Error ExecuteProcedureQuery 1.00" & vbCrLf & ex.Message)
            Return New DataTable
        End Try



    End Function

    Public Shared Function ExecuteProcedureQuery(ProcedureName As String, ListParameters As List(Of ParameterProduct)) As DataTable

        Try
            Dim parameters(ListParameters.Count - 1) As SqlParameter
            Dim i As Integer = 0

            For Each p As ParameterProduct In ListParameters
                parameters(i) = New SqlParameter(p.parameterName, p.dbType)
                parameters(i).Value = p.value
                i += 1
            Next

            Dim con As New SqlConnection(connection)
            Dim cmd As New SqlCommand(ProcedureName, con)
            cmd.Parameters.AddRange(parameters)
            cmd.CommandType = CommandType.StoredProcedure

            con.Open()
            Dim da As New SqlDataAdapter(cmd)
            con.Close()
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show("Error ExecuteProcedureQuery 1.01" & vbCrLf & ex.Message)
            Return New DataTable
        End Try

    End Function

    Public Shared Sub ExecuteProcedureTransaction(ProcedureName As String, ListParameters As List(Of ParameterProduct))

        Try
            Dim parameters(ListParameters.Count - 1) As SqlParameter

            Dim i As Integer = 0
            For Each p As ParameterProduct In ListParameters
                parameters(i) = New SqlParameter(p.parameterName, p.dbType)
                parameters(i).Value = p.value
                i += 1
            Next

            Dim con As New SqlConnection(connection)
            Dim cmd As New SqlCommand()
            cmd.Parameters.AddRange(parameters)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.CommandText = ProcedureName

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error ExecuteProcedureTransaction 1.00" & vbCrLf & ex.Message)
        End Try

    End Sub

End Class
