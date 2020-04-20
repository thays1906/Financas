Imports GFT.Util
Public Class frmReceita
    Dim oform As frmNovaReceita = New frmNovaReceita

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmReceita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmReceita_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Receita)
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        oform = New frmNovaReceita
        oform.Show()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'Buscar na base o registro e setar os campos
        oform = New frmNovaReceita

        oform.Show()
    End Sub

    Private Sub frmReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
    End Sub
End Class