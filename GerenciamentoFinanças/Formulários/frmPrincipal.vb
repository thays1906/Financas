Imports GFT.Util

Public Class frmPrincipal
    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

        Dim oform As Form
        oform = frmConsulta
        oform.Show()
        controleFormulario(Me, oform, eTela.Consulta)
    End Sub

    Private Sub ReceitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceitasToolStripMenuItem.Click
        Dim oform As Form
        oform = frmReceita
        controleFormulario(Me, oform, eTela.Receita)
    End Sub

    Private Sub DespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesasToolStripMenuItem.Click
        Dim oform As Form
        oform = frmDespesa
        controleFormulario(Me, oform, eTela.Despesa)
    End Sub
End Class