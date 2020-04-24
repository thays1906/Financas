Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmDespesa
    Public oDataset As SuperDataSet

    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmDespesa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmDespesa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Despesa)
    End Sub

    Private Sub btnAddDespesa_Click(sender As Object, e As EventArgs) Handles btnAddDespesa.Click
        Dim novaDespesa As frmNovaDespesa
        novaDespesa = New frmNovaDespesa
        novaDespesa.Show()
    End Sub

    Private Sub frmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim newDespesa As frmNovaDespesa
        Try
            newDespesa = New frmNovaDespesa

            If lvConsulta.SelectedItems.Count > 0 Then
                newDespesa.Show()

                oDataset = pDespesa.ObterDespesa(lvConsulta.ObterChave())
                If oDataset.TotalRegistros > 0 Then
                    newDespesa.PreencheCampo(oDataset)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cDespesa As Decimal
        Try
            If lvConsulta.SelectedItems.Count > 0 Then

                cDespesa = lvConsulta.ObterChave()

                If cDespesa <> 0 Then

                    pDespesa.DeletarDespesa(cDespesa)

                    S_MsgBox("Despesa excluída com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)
                    Pesquisar()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Pesquisar()
        Try
            oDataset = pDespesa.PesquisarDespesa()

            If oDataset.TotalRegistros > 0 Then

                lvConsulta.PreencheGridDS(oDataset, True, True, False, True)
            Else
                S_MsgBox("Não foi possível localizar dados ao realizar a pesquisa.",
                         eBotoes.Ok,
                         "Consulta de Dados", 1,
                         eImagens.Atencao)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class