Public Class MainWnd
    Private Sub WindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.Click

        For Each frmClose As Form In Me.MdiChildren.ToArray()
            frmClose.Close()
        Next
        Dim mdi As New CRUDWnd()
        mdi.MdiParent = Me
        mdi.Show()

    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click

        For Each frmClose As Form In Me.MdiChildren.ToArray()
            frmClose.Close()
        Next
        Dim mdi As New InventoryWnd()
        mdi.MdiParent = Me
        mdi.Show()
    End Sub

    Private Sub SeeSellsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeeSellsToolStripMenuItem.Click

        For Each frmClose As Form In Me.MdiChildren.ToArray()
            frmClose.Close()
        Next
        Dim mdi As New SellsWnd()
        mdi.MdiParent = Me
        mdi.Show()
    End Sub
End Class