Imports System.Runtime.CompilerServices

Public Class LoginWnd
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

        'Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click


        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then

            Dim Wnd As New MainWnd()
            Wnd.Show()
            Me.Hide()

        End If
    End Sub
End Class