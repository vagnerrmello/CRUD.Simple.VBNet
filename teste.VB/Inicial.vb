Imports System.Windows.Forms

Public Class Inicial

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        '' Create a new instance of the child form.
        'Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber

        'ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CorretoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorretoraToolStripMenuItem.Click

        Dim frmCorretora As New frmCorretora
        frmCorretora.MdiParent = Me
        frmCorretora.Show()

    End Sub

    Private Sub ConveniadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConveniadoToolStripMenuItem.Click

        Dim frmConveniado As New frmConveniado
        frmConveniado.MdiParent = Me
        frmConveniado.Show()

    End Sub

    Private Sub ParcelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParcelaToolStripMenuItem.Click

        Dim frmParcela As New frmParcela
        frmParcela.MdiParent = Me
        frmParcela.Show()

    End Sub

    Private Sub ParcelaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParcelaToolStripMenuItem1.Click

        Dim frmBaixa As New frmBaixa
        frmBaixa.MdiParent = Me
        frmBaixa.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
