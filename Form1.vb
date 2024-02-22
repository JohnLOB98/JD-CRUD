﻿
'Rerefence https://www.youtube.com/watch?v=n7SRRnN-geU
Imports System.Data.SqlClient

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Reference https://www.youtube.com/watch?v=e2ovoOWObiM
        Dim query As String = $"SELECT * FROM TableProduct"
        LoadDataGridView(query)


        cmbColor.SelectedIndex = 0
        radAllowed.Checked = True

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

        Dim pid As Integer = txtID.Text
        Dim name As String = txtName.Text
        Dim design As String = txtDesign.Text
        Dim color As String = cmbColor.Text
        Dim daTime As String = DTP1.Value.ToString("yyyy/MM/dd")
        Dim wtype As String = If((radAllowed.Checked), "Allowed", "Not Allowed")

        'If radAllowed.Checked Then
        '    wtype = "Allowed"
        'Else
        '    wtype = "Not Allowed"
        'End If


        Dim query As String = $"INSERT INTO TableProduct values ({pid}, '{name}', '{design}', '{color}', '{daTime}' , '{wtype}')"
        ExecuteTransaction(query)
        MessageBox.Show("Succesfully INSERT")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim pid As Integer = txtID.Text
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


        Dim query As String = $"UPDATE TableProduct SET ItemName = '{name}', Design = '{design}', Color = '{color}', ItemDate = {daTime}, WarrantlyType = '{wtype}' 
                                WHERE Product_ID = {pid}"
        ExecuteTransaction(query)
        query = "SELECT * FROM TableProduct"
        LoadDataGridView(query)
        MessageBox.Show("Successfully UPDATED")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim pid As String = txtID.Text

        Dim r As DialogResult = MessageBox.Show($"Do you really want to delete the product {pid}", "caption", MessageBoxButtons.YesNo)
        If r = DialogResult.Yes Then
            Dim query As String = $"DELETE TableProduct WHERE Product_ID = {pid}"
            ExecuteTransaction(query)

            query = $"SELECT * FROM TableProduct"
            LoadDataGridView(query)
            MessageBox.Show("Successfully DELETED")

        End If

    End Sub


    'EVENTS TEXT CHANGED
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim id As String = txtSearch.Text
        Dim query As String = If((id = ""), $"SELECT * FROM TableProduct", $"SELECT * FROM TableProduct WHERE Product_ID LIKE {id}")
        LoadDataGridView(query)

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

    'CUSTOM EVENTS
    Public Sub ExecuteTransaction(query As String)

        Dim con As New SqlConnection(connection)
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub


    Public Sub LoadDataGridView(query As String)

        Dim con As New SqlConnection(connection)
        con.Open()
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        con.Close()
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Public connection As String = "Data Source=DESKTOP-CNSF48P\TEW_SQLEXPRESS;Initial Catalog=CRUD_JD;User ID=sa;Password=y6dreqbc;"

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


End Class
