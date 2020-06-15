Imports GFT.Util

Public Class frmConsulta
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Dim oDataset As SuperDataSet

            oDataset = pConsulta.Pesquisar()

            lvConsulta.PreencheGridDS(oDataset, True, True, True, True)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        centralizarGrupoTab(tbConsulta)
        centralizarGrupoBotoes(gbBotoes)

    End Sub

    Private Sub frmConsulta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Consulta)
    End Sub

    Private Sub frmConsulta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub
    'Private Sub AtualizaTela()

    '    Try

    '        ''------------------------------------------------------------------
    '        ''  CONSULTA
    '        ''------------------------------------------------------------------
    '        If modotela = enumModoTela.CONSULTA Then

    '            cmbFiltroEtapa.PosicionaRegistroCombo(CDec(0))
    '            cmbFiltroStatus.PosicionaRegistroCombo(CDec(0))

    '            tabContrEnvio.TabPages("tabFiltro").Enabled = True
    '            tabContrEnvio.TabPages("tabDetalhe").Enabled = False
    '            tabContrEnvio.TabPages("tabSGSS").Enabled = False
    '            tabContrEnvio.TabPages("tabMainFr").Enabled = False
    '            tabContrEnvio.TabPages("tabEnvio").Enabled = False

    '            tabContrEnvio.SelectTab("tabFiltro")

    '            '--acerta botoes-------------------
    '            cmdPesquisar.Enabled = True
    '            cmdDetalhes.Enabled = False
    '            cmdVoltar.Enabled = True
    '            sCmdVisualizar.Enabled = False
    '            cmdSGSS.Enabled = True
    '            cmdProcessar.Enabled = True
    '            btnCancelaSGSS.Enabled = False
    '            btnConcluirSE.Enabled = False
    '            btnEnvio.Enabled = True

    '            'aqui que tem que limpar as coisas
    '            'INICIAR VARIAVEIS
    '            lvDetalheFiltro.Items.Clear()
    '            txtInfo.TextoLetreiro = strPronto

    '            cmdVoltar.Text = "Fechar"

    '            ''------------------------------------------------------------------
    '            ''  INCLUSAO
    '            ''------------------------------------------------------------------
    '        ElseIf modotela = enumModoTela.INCLUSAO Then

    '            tabContrEnvio.TabPages("tabFiltro").Enabled = False
    '            tabContrEnvio.TabPages("tabDetalhe").Enabled = False
    '            tabContrEnvio.TabPages("tabSGSS").Enabled = True
    '            tabContrEnvio.TabPages("tabMainFr").Enabled = False
    '            tabContrEnvio.TabPages("tabEnvio").Enabled = False

    '            tabContrEnvio.SelectTab("tabSGSS")

    '            '--acerta botoes--------------
    '            cmdPesquisar.Enabled = False
    '            cmdDetalhes.Enabled = False
    '            sCmdVisualizar.Enabled = False
    '            cmdSGSS.Enabled = False
    '            cmdProcessar.Enabled = False
    '            btnCancelaSGSS.Enabled = False
    '            btnConcluirSE.Enabled = False
    '            cmdObterSGSS.Enabled = True
    '            btnEnvio.Enabled = False

    '        ElseIf modotela = enumModoTela.PROCESSO Then

    '            tabContrEnvio.TabPages("tabFiltro").Enabled = False
    '            tabContrEnvio.TabPages("tabDetalhe").Enabled = False
    '            tabContrEnvio.TabPages("tabSGSS").Enabled = False
    '            tabContrEnvio.TabPages("tabMainFr").Enabled = True
    '            tabContrEnvio.TabPages("tabEnvio").Enabled = False

    '            tabContrEnvio.SelectTab("tabMainFr")

    '            '--acerta botoes--------------
    '            cmdPesquisar.Enabled = False
    '            cmdDetalhes.Enabled = False
    '            sCmdVisualizar.Enabled = False
    '            cmdSGSS.Enabled = False
    '            cmdProcessar.Enabled = False
    '            btnCancelaSGSS.Enabled = False
    '            btnConcluirSE.Enabled = False
    '            btnEnvio.Enabled = False


    '        ElseIf modotela = enumModoTela.DETALHE Then
    '            ''------------------------------------------------------------------
    '            ''  Detalhe
    '            ''------------------------------------------------------------------

    '            dsRPAD = RPAD_pProcessos.Listar(CInt(cProcessoRPAD))
    '            If Not dsRPAD Is Nothing Then
    '                If dsRPAD.TotalRegistros > 0 Then

    '                    tabContrEnvio.TabPages("tabFiltro").Enabled = False
    '                    tabContrEnvio.TabPages("tabDetalhe").Enabled = True
    '                    tabContrEnvio.TabPages("tabSGSS").Enabled = False
    '                    tabContrEnvio.TabPages("tabMainFr").Enabled = False
    '                    tabContrEnvio.TabPages("tabEnvio").Enabled = False

    '                    tabContrEnvio.SelectTab("tabDetalhe")

    '                    '--acerta botoes-------------------
    '                    cmdPesquisar.Enabled = False
    '                    cmdDetalhes.Enabled = False
    '                    sCmdVisualizar.Enabled = False
    '                    cmdSGSS.Enabled = False
    '                    cmdProcessar.Enabled = False
    '                    btnCancelaSGSS.Enabled = False
    '                    btnConcluirSE.Enabled = False
    '                    btnEnvio.Enabled = False

    '                    sCmdVisualizar.Enabled = True

    '                    'Limpa Campos
    '                    limpaCampo()

    '                    'Processo
    '                    sDTP_DTInclusao.Value = CDate(dsRPAD("dtCriacao").ToString())
    '                    sDTP_DTInclusao.Enabled = False
    '                    sTxtSolicitacao.Text = dsRPAD("nSoltc").ToString()
    '                    CbocEtapaProc.PosicionaRegistroCombo(CDec(dsRPAD("EtapaProc")))
    '                    CbocEtapaProc.Enabled = False
    '                    'CbocStatus.PosicionaRegistroCombo(CDec(dsAcorDesc("StatusEtapaProc")))
    '                    CbocStatus.Enabled = False
    '                    txtrStatus.Text = dsRPAD("ErroEtapaProc").ToString()
    '                    'Contrato
    '                    sTXTContrato.Text = dsRPAD("cContrato").ToString()
    '                    sTxtGrupo.Text = dsRPAD("rGrupo").ToString()
    '                    sTxtCota.Text = dsRPAD("rCota").ToString()
    '                    txtcAg.Text = dsRPAD("cAgencia").ToString() + " - " + dsRPAD("rNomeAgencia").ToString()
    '                    txtcConta.Text = dsRPAD("cConta").ToString()
    '                    sTxtCliente.Text = dsRPAD("rCli").ToString()
    '                    txtrCPFCliente.Text = dsRPAD("cCli_CPFCNPJ").ToString()
    '                    sTxtEmailCliente.Text = dsRPAD("rCliEmail").ToString()
    '                    txtsTpBem.Text = dsRPAD("rTpBem").ToString()
    '                    txtsSolicitante.Text = dsRPAD("rSolicitante").ToString()
    '                    txtsTelAg.Text = dsRPAD("rTelAg").ToString

    '                Else
    '                    S_MsgBox("Pesquisa não retornou registros", eBotoes.Ok, , , eImagens.Cancel)
    '                End If
    '            Else
    '                S_MsgBox("Erro Banco", eBotoes.Ok, , , eImagens.Cancel)
    '            End If

    '        ElseIf modotela = enumModoTela.ENVIOEMAIL Then

    '            tabContrEnvio.TabPages("tabFiltro").Enabled = False
    '            tabContrEnvio.TabPages("tabDetalhe").Enabled = False
    '            tabContrEnvio.TabPages("tabSGSS").Enabled = False
    '            tabContrEnvio.TabPages("tabMainFr").Enabled = False
    '            tabContrEnvio.TabPages("tabEnvio").Enabled = True

    '            tabContrEnvio.SelectTab("tabEnvio")

    '            cmdPesquisar.Enabled = True
    '            cmdDetalhes.Enabled = False
    '            cmdSGSS.Enabled = False
    '            cmdProcessar.Enabled = False
    '            btnEnvio.Enabled = False

    '            lvEnvioEmail.Clear()

    '        ElseIf tabContrEnvio.TabPages("tabSGSS").Enabled = True Then
    '            cmdSGSS.Enabled = False
    '        End If


    '        If modotela = enumModoTela.INCLUSAO Or
    '           modotela = enumModoTela.ALTERACAO Or
    '           modotela = enumModoTela.DETALHE Or
    '           modotela = enumModoTela.PROCESSO Or
    '           modotela = enumModoTela.VISUALIZACAO Then

    '            cmdVoltar.Text = "Voltar"

    '        End If

    '    Catch ex As Exception
    '        LogaErro("Erro em " & NomeMetodo(Me) & ": " & ex.Message)
    '    End Try

    'End Sub

End Class