Option Explicit On
Option Strict On

Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Imports GFT.Correio
Imports GFT.Correio.clsCorreio
Imports GFT.Correio.clsCorreioExchange
Imports System
Imports System.IO
Imports System.Text
Imports RPAD
Imports RPAD.RPAD_pProdutoDocto
Imports RPAD.cls3270
Imports RPAD.clsComum
Imports Newtonsoft.Json
Imports System.Drawing.Printing

#Const ATRIBUI_SE = True

Public Class frmProc

    Private cListaContr As Decimal = 0
    Public modotela As eTela


    Public cProcessoRPAD As Decimal
    Public rsTSoltc As SuperDataSet
    Public Property cProcMovLPCL7 As Boolean = False
    Public dsRPAD As SuperDataSet = Nothing
    Public RetString As String = ""
    Private TextoParaImpr As String
    Dim PATH_DESTINO As String = ""

    Dim ErroMPI As Boolean

    Private Sub frmCadUsuario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'alterarCaptionFormPrincipal(eTela.proc_Processos)
    End Sub

    Private Sub frm_CadUsuario_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        'restaurarMDI()
    End Sub

    Private Sub frmProcRural_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            centralizarGrupoTab(tabContrEnvio)
            centralizarGrupoBotoes(grp_Botoes)
            'CarregaCombos()
            modotela = eTela.Consulta
            AtualizaTela()

        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo(Me) & ": " & ex.Message)
        End Try
    End Sub

    'Private Sub CarregaCombos()

    '    'Carrega cmbcEtapaProc com os valores do enum: eEtapaPcote

    '    Dim colEtapa As New Collection
    '    'colEtapa.Add(DuplaCombo.Coll(eEtapa.BUSCA_CONTRATO))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.ObeterSGSS))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.Processar))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.EnviadoEmpresa))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.RetornoEmpresa))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.EnviadoAgencia))
    '    colEtapa.Add(DuplaCombo.Coll(eEtapaProc.FimProcessamento))
    '    cmbFiltroEtapa.PreencheComboColl(colEtapa, PrimeiroValor.Todos)
    '    CbocEtapaProc.PreencheComboColl(colEtapa, PrimeiroValor.Todos)

    '    'Carrega cmbcStatus com os valores do enum: eStatus
    '    Dim colStatus As New Collection
    '    colStatus.Add(DuplaCombo.Coll(eStatusEtapaProc.OK))
    '    colStatus.Add(DuplaCombo.Coll(eStatusEtapaProc.ERRO))
    '    colStatus.Add(DuplaCombo.Coll(eStatusEtapaProc.CANCELADO))
    '    colStatus.Add(DuplaCombo.Coll(eStatusEtapaProc.SEMIMAGENS))
    '    cmbFiltroStatus.PreencheComboColl(colStatus, PrimeiroValor.Todos)
    '    CbocStatus.PreencheComboColl(colStatus, PrimeiroValor.Todos)

    'End Sub

    Private Sub AtualizaTela()

        Try

            ''------------------------------------------------------------------
            ''  CONSULTA
            ''------------------------------------------------------------------
            If modotela = eTela.Consulta Then

                cmbFiltroEtapa.PosicionaRegistroCombo(CDec(0))
                cmbFiltroStatus.PosicionaRegistroCombo(CDec(0))

                tabContrEnvio.TabPages("tabFiltro").Enabled = True
                tabContrEnvio.TabPages("tabDetalhe").Enabled = False
                tabContrEnvio.TabPages("tabSGSS").Enabled = False
                tabContrEnvio.TabPages("tabMainFr").Enabled = False
                tabContrEnvio.TabPages("tabEnvio").Enabled = False

                tabContrEnvio.SelectTab("tabFiltro")

                '--acerta botoes-------------------
                cmdPesquisar.Enabled = True
                cmdDetalhes.Enabled = False
                cmdVoltar.Enabled = True
                sCmdVisualizar.Enabled = False
                cmdSGSS.Enabled = True
                cmdProcessar.Enabled = True
                btnCancelaSGSS.Enabled = False
                btnConcluirSE.Enabled = False
                btnEnvio.Enabled = True

                'aqui que tem que limpar as coisas
                'INICIAR VARIAVEIS
                lvDetalheFiltro.Items.Clear()
                'txtInfo.TextoLetreiro = strPronto

                cmdVoltar.Text = "Fechar"

                ''------------------------------------------------------------------
                ''  INCLUSAO
                ''------------------------------------------------------------------
            End If

        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo(Me) & ": " & ex.Message)
        End Try

    End Sub

    Private Sub cmdPesquisar_Click_1(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
        Pesquisar(False)
    End Sub
    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Pesquisar(True)
    End Sub

    Private Sub Pesquisar(imrpimir As Boolean)

        Dim oDataSet As SuperDataSet
        'Dim oXLS As SuperXLS
        Dim Contrato As Decimal
        Dim Agencia As Decimal
        Dim Conta As Decimal

        Try
        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo(Me) & ": " & ex.Message)
        End Try

    End Sub

    Public Sub limpaCampo()

        Try

            'Processo
            sDTP_DTInclusao.Value = Nothing
            sTxtSolicitacao.Text = ""
            CbocEtapaProc.PosicionaRegistroCombo(0)
            CbocStatus.PosicionaRegistroCombo(0)
            txtrStatus.Text = ""

            'Contrato
            sTXTContrato.Text = ""
            sTxtGrupo.Text = ""
            txtcAg.Text = ""
            txtcConta.Text = ""

            sTxtCliente.Text = ""
            txtrCPFCliente.Text = ""
            sTxtEmailCliente.Text = ""

        Catch ex As Exception
            LogaErro("Erro em " & NomeMetodo(Me) & ": " & ex.Message)
        End Try

    End Sub

End Class