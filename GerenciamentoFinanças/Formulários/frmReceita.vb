﻿Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmReceita
    Dim oform As frmNovaReceita = New frmNovaReceita
    Public Shared cReceita As Decimal
    Public Shared oDataset As SuperDataSet

    Private Sub frmReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
    End Sub
    Private Sub frmReceita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmReceita_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Receita)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim novaRec As frmNovaReceita
        Try
            novaRec = New frmNovaReceita


            If lvConsulta.Items.Count > 0 Then

                novaRec.Show()

                oDataset = pReceita.ObterReceita(lvConsulta.ObterChave())

                If oDataset.TotalRegistros > 0 Then
                    novaRec.PreencheCampo(oDataset)
                Else
                    S_MsgBox("Não foram encontrado dados.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)
                End If
            Else
                S_MsgBox("Selecione o registro que deseja alterar.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub Pesquisar()
        Try
            oDataset = pReceita.PesquisarReceita()

            frmReceita.lvConsulta.PreencheGridDS2(oDataset, True, True, False, True)
            frmReceita.lvConsulta.GridLines = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        oform = New frmNovaReceita
        oform.Show()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If lvConsulta.SelectedItems.Count > 0 Then

                cReceita = lvConsulta.ObterChave()

                If cReceita <> 0 Then
                    pReceita.DeletarReceita(cReceita)
                    S_MsgBox("Registro excluído com sucesso.", eBotoes.Ok,,, eImagens.Ok)
                    Pesquisar()
                End If
            Else
                S_MsgBox("Selecione o registro que deseja excluir.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
    End Sub
End Class