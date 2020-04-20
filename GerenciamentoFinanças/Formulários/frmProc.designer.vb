Option Explicit On
Option Strict On

Imports System.IO
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProc
    Inherits System.Windows.Forms.Form

    Sub New()
        InitializeComponent()
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProc))
		Me.grp_Botoes = New System.Windows.Forms.GroupBox()
		Me.btnEnvio = New GFT.Util.SuperButton()
		Me.cmdImprimir = New GFT.Util.SuperButton()
		Me.cmdProcessar = New GFT.Util.SuperButton()
		Me.cmdVoltar = New GFT.Util.SuperButton()
		Me.cmdPesquisar = New GFT.Util.SuperButton()
		Me.cmdSGSS = New GFT.Util.SuperButton()
		Me.cmdDetalhes = New GFT.Util.SuperButton()
		Me.tabContrEnvio = New GFT.Util.SuperTabControl()
		Me.tabFiltro = New System.Windows.Forms.TabPage()
		Me.btnCancelaSGSS = New GFT.Util.SuperButton()
		Me.btnConcluirSE = New GFT.Util.SuperButton()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.lblFunCaf = New System.Windows.Forms.Label()
		Me.Label44 = New System.Windows.Forms.Label()
		Me.lblVerificar = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.lblCaceladoSGSS = New System.Windows.Forms.Label()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.lblReprocessado = New System.Windows.Forms.Label()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.lblProcessoOK = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.lblProcessar = New System.Windows.Forms.Label()
		Me.txtInfo = New GFT.Util.SuperLetreiro()
		Me.grpFiltro = New System.Windows.Forms.GroupBox()
		Me.Label53 = New System.Windows.Forms.Label()
		Me.txbConta = New GFT.Util.SuperTextBox()
		Me.txbContrato = New GFT.Util.SuperTextBox()
		Me.Label54 = New System.Windows.Forms.Label()
		Me.Label55 = New System.Windows.Forms.Label()
		Me.txbAg = New GFT.Util.SuperTextBox()
		Me.Label56 = New System.Windows.Forms.Label()
		Me.txbSE = New GFT.Util.SuperTextBox()
		Me.cmbFiltroStatus = New GFT.Util.SuperComboBox()
		Me.cmbFiltroEtapa = New GFT.Util.SuperComboBox()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.DtInicial = New GFT.Util.SuperDatePicker()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.DtFinal = New GFT.Util.SuperDatePicker()
		Me.lvDetalheFiltro = New GFT.Util.SuperLV()
		Me.tabDetalhe = New System.Windows.Forms.TabPage()
		Me.btnVerificarImagens = New GFT.Util.SuperButton()
		Me.btnIncImg = New GFT.Util.SuperButton()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtsSolicitante = New GFT.Util.SuperTextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.txtsTelAg = New GFT.Util.SuperTextBox()
		Me.Posicionamento = New System.Windows.Forms.GroupBox()
		Me.sDTP_DTInclusao = New GFT.Util.SuperDatePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.sTxtSolicitacao = New GFT.Util.SuperTextBox()
		Me.txtrStatus = New GFT.Util.SuperTextBox()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.CbocStatus = New GFT.Util.SuperComboBox()
		Me.CbocEtapaProc = New GFT.Util.SuperComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.grpBoxContrato = New System.Windows.Forms.GroupBox()
		Me.txtsTpBem = New GFT.Util.SuperTextBox()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.sTxtCota = New GFT.Util.SuperTextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.sTxtGrupo = New GFT.Util.SuperTextBox()
		Me.sTXTContrato = New GFT.Util.SuperTextBox()
		Me.sTxtCliente = New GFT.Util.SuperTextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.sTxtEmailCliente = New GFT.Util.SuperTextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.sCmdVisualizar = New GFT.Util.SuperButton()
		Me.sCmdAnexo = New GFT.Util.SuperButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.txtcConta = New GFT.Util.SuperTextBox()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.txtcAg = New GFT.Util.SuperTextBox()
		Me.txtrCPFCliente = New GFT.Util.SuperTextBox()
		Me.tabSGSS = New System.Windows.Forms.TabPage()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.SuperComboBox1 = New GFT.Util.SuperComboBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.txbnSoltc = New GFT.Util.SuperTextBox()
		Me.lblTipoObtencao = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lbltVal = New System.Windows.Forms.Label()
		Me.lbltInv = New System.Windows.Forms.Label()
		Me.lbltIg = New System.Windows.Forms.Label()
		Me.lbltLido = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtQuantidade = New GFT.Util.SuperTextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtListaSE = New GFT.Util.SuperTextBox()
		Me.cmdObterSGSS = New GFT.Util.SuperButton()
		Me.tabMainFr = New System.Windows.Forms.TabPage()
		Me.sLetreiro_Processo = New GFT.Util.SuperLetreiro()
		Me.txtProcessamento = New GFT.Util.SuperTextBox()
		Me.lbProcesso = New System.Windows.Forms.Label()
		Me.txtTerminal = New System.Windows.Forms.TextBox()
		Me.tabEnvio = New System.Windows.Forms.TabPage()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label40 = New System.Windows.Forms.Label()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.Label45 = New System.Windows.Forms.Label()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.btnCobranca = New GFT.Util.SuperButton()
		Me.btnEnviaResumo = New GFT.Util.SuperButton()
		Me.btnProcAnali = New GFT.Util.SuperButton()
		Me.btnImpRet = New GFT.Util.SuperButton()
		Me.btnEnvAnali = New GFT.Util.SuperButton()
		Me.lvEnvioEmail = New GFT.Util.SuperLV()
		Me.grp_Botoes.SuspendLayout()
		Me.tabContrEnvio.SuspendLayout()
		Me.tabFiltro.SuspendLayout()
		Me.grpFiltro.SuspendLayout()
		Me.tabDetalhe.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.Posicionamento.SuspendLayout()
		Me.grpBoxContrato.SuspendLayout()
		Me.tabSGSS.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.tabMainFr.SuspendLayout()
		Me.tabEnvio.SuspendLayout()
		Me.SuspendLayout()
		'
		'grp_Botoes
		'
		Me.grp_Botoes.BackColor = System.Drawing.Color.Transparent
		Me.grp_Botoes.Controls.Add(Me.btnEnvio)
		Me.grp_Botoes.Controls.Add(Me.cmdImprimir)
		Me.grp_Botoes.Controls.Add(Me.cmdProcessar)
		Me.grp_Botoes.Controls.Add(Me.cmdVoltar)
		Me.grp_Botoes.Controls.Add(Me.cmdPesquisar)
		Me.grp_Botoes.Controls.Add(Me.cmdSGSS)
		Me.grp_Botoes.Controls.Add(Me.cmdDetalhes)
		Me.grp_Botoes.ImeMode = System.Windows.Forms.ImeMode.[On]
		Me.grp_Botoes.Location = New System.Drawing.Point(161, 571)
		Me.grp_Botoes.Name = "grp_Botoes"
		Me.grp_Botoes.Size = New System.Drawing.Size(909, 56)
		Me.grp_Botoes.TabIndex = 2
		Me.grp_Botoes.TabStop = False
		'
		'btnEnvio
		'
		Me.btnEnvio.BackColor = System.Drawing.Color.Transparent
		Me.btnEnvio.BackgroundImage = CType(resources.GetObject("btnEnvio.BackgroundImage"), System.Drawing.Image)
		Me.btnEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnEnvio.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnEnvio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEnvio.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnEnvio.ForeColor = System.Drawing.Color.Black
		Me.btnEnvio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEnvio.Location = New System.Drawing.Point(522, 12)
		Me.btnEnvio.Name = "btnEnvio"
		Me.btnEnvio.Size = New System.Drawing.Size(115, 38)
		Me.btnEnvio.TabIndex = 938
		Me.btnEnvio.Text = "Tratamento Retorno"
		Me.btnEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnEnvio.UseVisualStyleBackColor = False
		'
		'cmdImprimir
		'
		Me.cmdImprimir.BackColor = System.Drawing.Color.Transparent
		Me.cmdImprimir.BackgroundImage = CType(resources.GetObject("cmdImprimir.BackgroundImage"), System.Drawing.Image)
		Me.cmdImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdImprimir.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdImprimir.ForeColor = System.Drawing.Color.Black
		Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdImprimir.Location = New System.Drawing.Point(643, 12)
		Me.cmdImprimir.Name = "cmdImprimir"
		Me.cmdImprimir.Size = New System.Drawing.Size(124, 38)
		Me.cmdImprimir.TabIndex = 937
		Me.cmdImprimir.Text = "&ExportarXLS"
		Me.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdImprimir.UseVisualStyleBackColor = False
		'
		'cmdProcessar
		'
		Me.cmdProcessar.BackColor = System.Drawing.Color.Transparent
		Me.cmdProcessar.BackgroundImage = CType(resources.GetObject("cmdProcessar.BackgroundImage"), System.Drawing.Image)
		Me.cmdProcessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdProcessar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdProcessar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdProcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdProcessar.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdProcessar.ForeColor = System.Drawing.Color.Black
		Me.cmdProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdProcessar.Location = New System.Drawing.Point(358, 12)
		Me.cmdProcessar.Name = "cmdProcessar"
		Me.cmdProcessar.Size = New System.Drawing.Size(119, 38)
		Me.cmdProcessar.TabIndex = 937
		Me.cmdProcessar.Text = "&Processar"
		Me.cmdProcessar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdProcessar.UseVisualStyleBackColor = False
		'
		'cmdVoltar
		'
		Me.cmdVoltar.BackColor = System.Drawing.Color.Transparent
		Me.cmdVoltar.BackgroundImage = CType(resources.GetObject("cmdVoltar.BackgroundImage"), System.Drawing.Image)
		Me.cmdVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdVoltar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdVoltar.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdVoltar.ForeColor = System.Drawing.Color.Black
		Me.cmdVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdVoltar.Location = New System.Drawing.Point(804, 12)
		Me.cmdVoltar.Name = "cmdVoltar"
		Me.cmdVoltar.Size = New System.Drawing.Size(100, 38)
		Me.cmdVoltar.TabIndex = 936
		Me.cmdVoltar.Text = "&Voltar"
		Me.cmdVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdVoltar.UseVisualStyleBackColor = False
		'
		'cmdPesquisar
		'
		Me.cmdPesquisar.BackColor = System.Drawing.Color.Transparent
		Me.cmdPesquisar.BackgroundImage = CType(resources.GetObject("cmdPesquisar.BackgroundImage"), System.Drawing.Image)
		Me.cmdPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdPesquisar.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdPesquisar.ForeColor = System.Drawing.Color.Black
		Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPesquisar.Location = New System.Drawing.Point(4, 12)
		Me.cmdPesquisar.Name = "cmdPesquisar"
		Me.cmdPesquisar.Size = New System.Drawing.Size(100, 38)
		Me.cmdPesquisar.TabIndex = 934
		Me.cmdPesquisar.Text = "&Pesquisar"
		Me.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdPesquisar.UseVisualStyleBackColor = False
		'
		'cmdSGSS
		'
		Me.cmdSGSS.BackColor = System.Drawing.Color.Transparent
		Me.cmdSGSS.BackgroundImage = CType(resources.GetObject("cmdSGSS.BackgroundImage"), System.Drawing.Image)
		Me.cmdSGSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdSGSS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdSGSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdSGSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdSGSS.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdSGSS.ForeColor = System.Drawing.Color.Black
		Me.cmdSGSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdSGSS.Location = New System.Drawing.Point(249, 12)
		Me.cmdSGSS.Name = "cmdSGSS"
		Me.cmdSGSS.Size = New System.Drawing.Size(103, 38)
		Me.cmdSGSS.TabIndex = 108
		Me.cmdSGSS.Text = "&Importar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SGSS"
		Me.cmdSGSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdSGSS.UseVisualStyleBackColor = False
		'
		'cmdDetalhes
		'
		Me.cmdDetalhes.BackColor = System.Drawing.Color.Transparent
		Me.cmdDetalhes.BackgroundImage = CType(resources.GetObject("cmdDetalhes.BackgroundImage"), System.Drawing.Image)
		Me.cmdDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdDetalhes.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDetalhes.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdDetalhes.ForeColor = System.Drawing.Color.Black
		Me.cmdDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdDetalhes.Location = New System.Drawing.Point(110, 12)
		Me.cmdDetalhes.Name = "cmdDetalhes"
		Me.cmdDetalhes.Size = New System.Drawing.Size(100, 38)
		Me.cmdDetalhes.TabIndex = 127
		Me.cmdDetalhes.Text = "&Detalhes"
		Me.cmdDetalhes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdDetalhes.UseVisualStyleBackColor = False
		'
		'tabContrEnvio
		'
		Me.tabContrEnvio.Controls.Add(Me.tabFiltro)
		Me.tabContrEnvio.Controls.Add(Me.tabDetalhe)
		Me.tabContrEnvio.Controls.Add(Me.tabSGSS)
		Me.tabContrEnvio.Controls.Add(Me.tabMainFr)
		Me.tabContrEnvio.Controls.Add(Me.tabEnvio)
		Me.tabContrEnvio.Location = New System.Drawing.Point(13, 13)
		Me.tabContrEnvio.Name = "tabContrEnvio"
		Me.tabContrEnvio.SelectedIndex = 0
		Me.tabContrEnvio.Size = New System.Drawing.Size(1321, 556)
		Me.tabContrEnvio.TabIndex = 3
		'
		'tabFiltro
		'
		Me.tabFiltro.Controls.Add(Me.btnCancelaSGSS)
		Me.tabFiltro.Controls.Add(Me.btnConcluirSE)
		Me.tabFiltro.Controls.Add(Me.Label16)
		Me.tabFiltro.Controls.Add(Me.lblFunCaf)
		Me.tabFiltro.Controls.Add(Me.Label44)
		Me.tabFiltro.Controls.Add(Me.lblVerificar)
		Me.tabFiltro.Controls.Add(Me.Label35)
		Me.tabFiltro.Controls.Add(Me.lblCaceladoSGSS)
		Me.tabFiltro.Controls.Add(Me.Label39)
		Me.tabFiltro.Controls.Add(Me.lblReprocessado)
		Me.tabFiltro.Controls.Add(Me.Label41)
		Me.tabFiltro.Controls.Add(Me.lblProcessoOK)
		Me.tabFiltro.Controls.Add(Me.Label30)
		Me.tabFiltro.Controls.Add(Me.lblProcessar)
		Me.tabFiltro.Controls.Add(Me.txtInfo)
		Me.tabFiltro.Controls.Add(Me.grpFiltro)
		Me.tabFiltro.Controls.Add(Me.lvDetalheFiltro)
		Me.tabFiltro.Location = New System.Drawing.Point(4, 23)
		Me.tabFiltro.Name = "tabFiltro"
		Me.tabFiltro.Padding = New System.Windows.Forms.Padding(3)
		Me.tabFiltro.Size = New System.Drawing.Size(1313, 529)
		Me.tabFiltro.TabIndex = 0
		Me.tabFiltro.Text = "Pesquisa"
		Me.tabFiltro.UseVisualStyleBackColor = True
		'
		'btnCancelaSGSS
		'
		Me.btnCancelaSGSS.BackColor = System.Drawing.Color.Transparent
		Me.btnCancelaSGSS.BackgroundImage = CType(resources.GetObject("btnCancelaSGSS.BackgroundImage"), System.Drawing.Image)
		Me.btnCancelaSGSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnCancelaSGSS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnCancelaSGSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnCancelaSGSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCancelaSGSS.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnCancelaSGSS.ForeColor = System.Drawing.Color.Black
		Me.btnCancelaSGSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnCancelaSGSS.Location = New System.Drawing.Point(720, 483)
		Me.btnCancelaSGSS.Name = "btnCancelaSGSS"
		Me.btnCancelaSGSS.Size = New System.Drawing.Size(118, 30)
		Me.btnCancelaSGSS.TabIndex = 211
		Me.btnCancelaSGSS.Text = "&Cancelar SE"
		Me.btnCancelaSGSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnCancelaSGSS.UseVisualStyleBackColor = False
		'
		'btnConcluirSE
		'
		Me.btnConcluirSE.BackColor = System.Drawing.Color.Transparent
		Me.btnConcluirSE.BackgroundImage = CType(resources.GetObject("btnConcluirSE.BackgroundImage"), System.Drawing.Image)
		Me.btnConcluirSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnConcluirSE.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnConcluirSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnConcluirSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnConcluirSE.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnConcluirSE.ForeColor = System.Drawing.Color.Black
		Me.btnConcluirSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnConcluirSE.Location = New System.Drawing.Point(600, 483)
		Me.btnConcluirSE.Name = "btnConcluirSE"
		Me.btnConcluirSE.Size = New System.Drawing.Size(114, 30)
		Me.btnConcluirSE.TabIndex = 210
		Me.btnConcluirSE.Text = "Co&ncluir SE"
		Me.btnConcluirSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnConcluirSE.UseVisualStyleBackColor = False
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(1152, 480)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(116, 14)
		Me.Label16.TabIndex = 158
		Me.Label16.Text = "Enviado Imagens"
		'
		'lblFunCaf
		'
		Me.lblFunCaf.AutoSize = True
		Me.lblFunCaf.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.lblFunCaf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblFunCaf.Location = New System.Drawing.Point(1133, 478)
		Me.lblFunCaf.Name = "lblFunCaf"
		Me.lblFunCaf.Size = New System.Drawing.Size(13, 16)
		Me.lblFunCaf.TabIndex = 157
		Me.lblFunCaf.Text = " "
		'
		'Label44
		'
		Me.Label44.AutoSize = True
		Me.Label44.Location = New System.Drawing.Point(994, 505)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(133, 14)
		Me.Label44.TabIndex = 152
		Me.Label44.Text = "Enviado Pendências"
		'
		'lblVerificar
		'
		Me.lblVerificar.AutoSize = True
		Me.lblVerificar.BackColor = System.Drawing.Color.LightSteelBlue
		Me.lblVerificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblVerificar.Location = New System.Drawing.Point(975, 503)
		Me.lblVerificar.Name = "lblVerificar"
		Me.lblVerificar.Size = New System.Drawing.Size(13, 16)
		Me.lblVerificar.TabIndex = 151
		Me.lblVerificar.Text = " "
		'
		'Label35
		'
		Me.Label35.AutoSize = True
		Me.Label35.Location = New System.Drawing.Point(1152, 505)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(130, 14)
		Me.Label35.TabIndex = 150
		Me.Label35.Text = "Cancelado no SGSS"
		'
		'lblCaceladoSGSS
		'
		Me.lblCaceladoSGSS.AutoSize = True
		Me.lblCaceladoSGSS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.lblCaceladoSGSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblCaceladoSGSS.Location = New System.Drawing.Point(1133, 503)
		Me.lblCaceladoSGSS.Name = "lblCaceladoSGSS"
		Me.lblCaceladoSGSS.Size = New System.Drawing.Size(13, 16)
		Me.lblCaceladoSGSS.TabIndex = 149
		Me.lblCaceladoSGSS.Text = " "
		'
		'Label39
		'
		Me.Label39.AutoSize = True
		Me.Label39.Location = New System.Drawing.Point(994, 480)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(81, 14)
		Me.Label39.TabIndex = 146
		Me.Label39.Text = "Respondido"
		'
		'lblReprocessado
		'
		Me.lblReprocessado.AutoSize = True
		Me.lblReprocessado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.lblReprocessado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblReprocessado.Location = New System.Drawing.Point(975, 478)
		Me.lblReprocessado.Name = "lblReprocessado"
		Me.lblReprocessado.Size = New System.Drawing.Size(13, 16)
		Me.lblReprocessado.TabIndex = 145
		Me.lblReprocessado.Text = " "
		'
		'Label41
		'
		Me.Label41.AutoSize = True
		Me.Label41.Location = New System.Drawing.Point(888, 505)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(85, 14)
		Me.Label41.TabIndex = 144
		Me.Label41.Text = "Processo Ok"
		'
		'lblProcessoOK
		'
		Me.lblProcessoOK.AutoSize = True
		Me.lblProcessoOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.lblProcessoOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProcessoOK.Location = New System.Drawing.Point(869, 503)
		Me.lblProcessoOK.Name = "lblProcessoOK"
		Me.lblProcessoOK.Size = New System.Drawing.Size(13, 16)
		Me.lblProcessoOK.TabIndex = 143
		Me.lblProcessoOK.Text = " "
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Location = New System.Drawing.Point(888, 480)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(81, 14)
		Me.Label30.TabIndex = 142
		Me.Label30.Text = "A Processar"
		'
		'lblProcessar
		'
		Me.lblProcessar.AutoSize = True
		Me.lblProcessar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lblProcessar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProcessar.Location = New System.Drawing.Point(869, 478)
		Me.lblProcessar.Name = "lblProcessar"
		Me.lblProcessar.Size = New System.Drawing.Size(13, 16)
		Me.lblProcessar.TabIndex = 141
		Me.lblProcessar.Text = " "
		'
		'txtInfo
		'
		Me.txtInfo.CorSombraTexto = System.Drawing.Color.White
		Me.txtInfo.Location = New System.Drawing.Point(9, 478)
		Me.txtInfo.Name = "txtInfo"
		Me.txtInfo.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
		Me.txtInfo.Size = New System.Drawing.Size(415, 30)
		Me.txtInfo.TabIndex = 126
		Me.txtInfo.TextoLetreiro = "Pronto!"
		Me.txtInfo.VelocidadeRolagem = 2
		'
		'grpFiltro
		'
		Me.grpFiltro.Controls.Add(Me.Label53)
		Me.grpFiltro.Controls.Add(Me.txbConta)
		Me.grpFiltro.Controls.Add(Me.txbContrato)
		Me.grpFiltro.Controls.Add(Me.Label54)
		Me.grpFiltro.Controls.Add(Me.Label55)
		Me.grpFiltro.Controls.Add(Me.txbAg)
		Me.grpFiltro.Controls.Add(Me.Label56)
		Me.grpFiltro.Controls.Add(Me.txbSE)
		Me.grpFiltro.Controls.Add(Me.cmbFiltroStatus)
		Me.grpFiltro.Controls.Add(Me.cmbFiltroEtapa)
		Me.grpFiltro.Controls.Add(Me.Label33)
		Me.grpFiltro.Controls.Add(Me.Label34)
		Me.grpFiltro.Controls.Add(Me.Label17)
		Me.grpFiltro.Controls.Add(Me.DtInicial)
		Me.grpFiltro.Controls.Add(Me.Label18)
		Me.grpFiltro.Controls.Add(Me.DtFinal)
		Me.grpFiltro.Location = New System.Drawing.Point(6, 6)
		Me.grpFiltro.Name = "grpFiltro"
		Me.grpFiltro.Size = New System.Drawing.Size(1301, 113)
		Me.grpFiltro.TabIndex = 125
		Me.grpFiltro.TabStop = False
		Me.grpFiltro.Text = "Filtro"
		'
		'Label53
		'
		Me.Label53.AutoSize = True
		Me.Label53.Location = New System.Drawing.Point(871, 19)
		Me.Label53.Name = "Label53"
		Me.Label53.Size = New System.Drawing.Size(45, 14)
		Me.Label53.TabIndex = 962
		Me.Label53.Text = "Conta"
		'
		'txbConta
		'
		Me.txbConta.Alterado = False
		Me.txbConta.BackColor = System.Drawing.Color.White
		Me.txbConta.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txbConta.Location = New System.Drawing.Point(874, 36)
		Me.txbConta.MaxLength = 7
		Me.txbConta.Name = "txbConta"
		Me.txbConta.Size = New System.Drawing.Size(116, 22)
		Me.txbConta.SuperMascara = ""
		Me.txbConta.SuperObrigatorio = False
		Me.txbConta.SuperTravaErrors = False
		Me.txbConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txbConta.SuperTxtObrigatorio = ""
		Me.txbConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
		Me.txbConta.TabIndex = 128
		'
		'txbContrato
		'
		Me.txbContrato.Alterado = False
		Me.txbContrato.BackColor = System.Drawing.Color.White
		Me.txbContrato.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txbContrato.Location = New System.Drawing.Point(580, 36)
		Me.txbContrato.MaxLength = 12
		Me.txbContrato.Name = "txbContrato"
		Me.txbContrato.Size = New System.Drawing.Size(166, 22)
		Me.txbContrato.SuperMascara = ""
		Me.txbContrato.SuperObrigatorio = False
		Me.txbContrato.SuperTravaErrors = False
		Me.txbContrato.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txbContrato.SuperTxtObrigatorio = ""
		Me.txbContrato.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
		Me.txbContrato.TabIndex = 126
		'
		'Label54
		'
		Me.Label54.AutoSize = True
		Me.Label54.Location = New System.Drawing.Point(577, 19)
		Me.Label54.Name = "Label54"
		Me.Label54.Size = New System.Drawing.Size(63, 14)
		Me.Label54.TabIndex = 959
		Me.Label54.Text = "Contrato"
		'
		'Label55
		'
		Me.Label55.AutoSize = True
		Me.Label55.Location = New System.Drawing.Point(749, 19)
		Me.Label55.Name = "Label55"
		Me.Label55.Size = New System.Drawing.Size(56, 14)
		Me.Label55.TabIndex = 958
		Me.Label55.Text = "Agência"
		'
		'txbAg
		'
		Me.txbAg.Alterado = False
		Me.txbAg.BackColor = System.Drawing.Color.White
		Me.txbAg.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txbAg.Location = New System.Drawing.Point(752, 36)
		Me.txbAg.MaxLength = 4
		Me.txbAg.Name = "txbAg"
		Me.txbAg.Size = New System.Drawing.Size(116, 22)
		Me.txbAg.SuperMascara = ""
		Me.txbAg.SuperObrigatorio = False
		Me.txbAg.SuperTravaErrors = False
		Me.txbAg.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txbAg.SuperTxtObrigatorio = ""
		Me.txbAg.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
		Me.txbAg.TabIndex = 127
		'
		'Label56
		'
		Me.Label56.AutoSize = True
		Me.Label56.Location = New System.Drawing.Point(325, 19)
		Me.Label56.Name = "Label56"
		Me.Label56.Size = New System.Drawing.Size(73, 14)
		Me.Label56.TabIndex = 956
		Me.Label56.Text = "Solicitação"
		'
		'txbSE
		'
		Me.txbSE.Alterado = False
		Me.txbSE.BackColor = System.Drawing.Color.White
		Me.txbSE.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txbSE.Location = New System.Drawing.Point(328, 36)
		Me.txbSE.MaxLength = 21
		Me.txbSE.Name = "txbSE"
		Me.txbSE.Size = New System.Drawing.Size(246, 22)
		Me.txbSE.SuperMascara = ""
		Me.txbSE.SuperObrigatorio = False
		Me.txbSE.SuperTravaErrors = False
		Me.txbSE.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txbSE.SuperTxtObrigatorio = ""
		Me.txbSE.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txbSE.TabIndex = 125
		'
		'cmbFiltroStatus
		'
		Me.cmbFiltroStatus.Alterado = False
		Me.cmbFiltroStatus.FormattingEnabled = True
		Me.cmbFiltroStatus.Location = New System.Drawing.Point(327, 79)
		Me.cmbFiltroStatus.Name = "cmbFiltroStatus"
		Me.cmbFiltroStatus.Size = New System.Drawing.Size(301, 22)
		Me.cmbFiltroStatus.SuperObrigatorio = False
		Me.cmbFiltroStatus.SuperTxtObrigatorio = ""
		Me.cmbFiltroStatus.TabIndex = 933
		'
		'cmbFiltroEtapa
		'
		Me.cmbFiltroEtapa.Alterado = False
		Me.cmbFiltroEtapa.FormattingEnabled = True
		Me.cmbFiltroEtapa.Location = New System.Drawing.Point(9, 79)
		Me.cmbFiltroEtapa.Name = "cmbFiltroEtapa"
		Me.cmbFiltroEtapa.Size = New System.Drawing.Size(301, 22)
		Me.cmbFiltroEtapa.SuperObrigatorio = False
		Me.cmbFiltroEtapa.SuperTxtObrigatorio = ""
		Me.cmbFiltroEtapa.TabIndex = 932
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Location = New System.Drawing.Point(6, 61)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(44, 14)
		Me.Label33.TabIndex = 931
		Me.Label33.Text = "Etapa"
		'
		'Label34
		'
		Me.Label34.AutoSize = True
		Me.Label34.Location = New System.Drawing.Point(324, 61)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(48, 14)
		Me.Label34.TabIndex = 930
		Me.Label34.Text = "Status"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(170, 18)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(143, 14)
		Me.Label17.TabIndex = 927
		Me.Label17.Text = "Data final Importação"
		'
		'DtInicial
		'
		Me.DtInicial.Alterado = False
		Me.DtInicial.BackColor = System.Drawing.Color.White
		Me.DtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DtInicial.Location = New System.Drawing.Point(9, 36)
		Me.DtInicial.Name = "DtInicial"
		Me.DtInicial.Size = New System.Drawing.Size(149, 22)
		Me.DtInicial.TabIndex = 123
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(6, 18)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(151, 14)
		Me.Label18.TabIndex = 928
		Me.Label18.Text = "Data inicial Importação"
		'
		'DtFinal
		'
		Me.DtFinal.Alterado = False
		Me.DtFinal.BackColor = System.Drawing.Color.White
		Me.DtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DtFinal.Location = New System.Drawing.Point(173, 36)
		Me.DtFinal.Name = "DtFinal"
		Me.DtFinal.Size = New System.Drawing.Size(149, 22)
		Me.DtFinal.TabIndex = 124
		'
		'lvDetalheFiltro
		'
		Me.lvDetalheFiltro.HabilitaOrdem = True
		Me.lvDetalheFiltro.HideSelection = False
		Me.lvDetalheFiltro.Location = New System.Drawing.Point(7, 125)
		Me.lvDetalheFiltro.Name = "lvDetalheFiltro"
		Me.lvDetalheFiltro.SelecionaVarios = True
		Me.lvDetalheFiltro.Size = New System.Drawing.Size(1300, 335)
		Me.lvDetalheFiltro.TabIndex = 17
		Me.lvDetalheFiltro.UseCompatibleStateImageBehavior = False
		'
		'tabDetalhe
		'
		Me.tabDetalhe.Controls.Add(Me.btnVerificarImagens)
		Me.tabDetalhe.Controls.Add(Me.btnIncImg)
		Me.tabDetalhe.Controls.Add(Me.GroupBox1)
		Me.tabDetalhe.Controls.Add(Me.Posicionamento)
		Me.tabDetalhe.Controls.Add(Me.grpBoxContrato)
		Me.tabDetalhe.Location = New System.Drawing.Point(4, 22)
		Me.tabDetalhe.Name = "tabDetalhe"
		Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(3)
		Me.tabDetalhe.Size = New System.Drawing.Size(1313, 530)
		Me.tabDetalhe.TabIndex = 1
		Me.tabDetalhe.Text = "Detalhes"
		Me.tabDetalhe.UseVisualStyleBackColor = True
		'
		'btnVerificarImagens
		'
		Me.btnVerificarImagens.BackColor = System.Drawing.Color.Transparent
		Me.btnVerificarImagens.BackgroundImage = CType(resources.GetObject("btnVerificarImagens.BackgroundImage"), System.Drawing.Image)
		Me.btnVerificarImagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnVerificarImagens.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnVerificarImagens.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnVerificarImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVerificarImagens.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnVerificarImagens.ForeColor = System.Drawing.Color.Black
		Me.btnVerificarImagens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVerificarImagens.Location = New System.Drawing.Point(1006, 492)
		Me.btnVerificarImagens.Name = "btnVerificarImagens"
		Me.btnVerificarImagens.Size = New System.Drawing.Size(150, 31)
		Me.btnVerificarImagens.TabIndex = 918
		Me.btnVerificarImagens.Text = "&Verificar Imagens"
		Me.btnVerificarImagens.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnVerificarImagens.UseVisualStyleBackColor = False
		'
		'btnIncImg
		'
		Me.btnIncImg.BackColor = System.Drawing.Color.Transparent
		Me.btnIncImg.BackgroundImage = CType(resources.GetObject("btnIncImg.BackgroundImage"), System.Drawing.Image)
		Me.btnIncImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnIncImg.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnIncImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnIncImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnIncImg.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnIncImg.ForeColor = System.Drawing.Color.Black
		Me.btnIncImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnIncImg.Location = New System.Drawing.Point(1162, 492)
		Me.btnIncImg.Name = "btnIncImg"
		Me.btnIncImg.Size = New System.Drawing.Size(145, 31)
		Me.btnIncImg.TabIndex = 917
		Me.btnIncImg.Text = "&Incluir Imagens"
		Me.btnIncImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnIncImg.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtsSolicitante)
		Me.GroupBox1.Controls.Add(Me.Label9)
		Me.GroupBox1.Controls.Add(Me.Label27)
		Me.GroupBox1.Controls.Add(Me.txtsTelAg)
		Me.GroupBox1.Location = New System.Drawing.Point(119, 343)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1055, 79)
		Me.GroupBox1.TabIndex = 123
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Dados Solicitante"
		'
		'txtsSolicitante
		'
		Me.txtsSolicitante.Alterado = False
		Me.txtsSolicitante.BackColor = System.Drawing.Color.White
		Me.txtsSolicitante.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtsSolicitante.Location = New System.Drawing.Point(210, 35)
		Me.txtsSolicitante.Name = "txtsSolicitante"
		Me.txtsSolicitante.ReadOnly = True
		Me.txtsSolicitante.Size = New System.Drawing.Size(674, 22)
		Me.txtsSolicitante.SuperMascara = ""
		Me.txtsSolicitante.SuperObrigatorio = False
		Me.txtsSolicitante.SuperTravaErrors = False
		Me.txtsSolicitante.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtsSolicitante.SuperTxtObrigatorio = ""
		Me.txtsSolicitante.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtsSolicitante.TabIndex = 115
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(207, 18)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(112, 14)
		Me.Label9.TabIndex = 114
		Me.Label9.Text = "Nome Solicitante"
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(18, 18)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(113, 14)
		Me.Label27.TabIndex = 21
		Me.Label27.Text = "Telefone Agência"
		'
		'txtsTelAg
		'
		Me.txtsTelAg.Alterado = False
		Me.txtsTelAg.BackColor = System.Drawing.Color.White
		Me.txtsTelAg.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtsTelAg.Location = New System.Drawing.Point(19, 35)
		Me.txtsTelAg.Name = "txtsTelAg"
		Me.txtsTelAg.ReadOnly = True
		Me.txtsTelAg.Size = New System.Drawing.Size(170, 22)
		Me.txtsTelAg.SuperMascara = ""
		Me.txtsTelAg.SuperObrigatorio = False
		Me.txtsTelAg.SuperTravaErrors = False
		Me.txtsTelAg.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtsTelAg.SuperTxtObrigatorio = ""
		Me.txtsTelAg.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtsTelAg.TabIndex = 28
		'
		'Posicionamento
		'
		Me.Posicionamento.Controls.Add(Me.sDTP_DTInclusao)
		Me.Posicionamento.Controls.Add(Me.Label5)
		Me.Posicionamento.Controls.Add(Me.Label4)
		Me.Posicionamento.Controls.Add(Me.sTxtSolicitacao)
		Me.Posicionamento.Controls.Add(Me.txtrStatus)
		Me.Posicionamento.Controls.Add(Me.Label29)
		Me.Posicionamento.Controls.Add(Me.CbocStatus)
		Me.Posicionamento.Controls.Add(Me.CbocEtapaProc)
		Me.Posicionamento.Controls.Add(Me.Label10)
		Me.Posicionamento.Controls.Add(Me.Label32)
		Me.Posicionamento.Location = New System.Drawing.Point(117, 31)
		Me.Posicionamento.Name = "Posicionamento"
		Me.Posicionamento.Size = New System.Drawing.Size(1057, 126)
		Me.Posicionamento.TabIndex = 25
		Me.Posicionamento.TabStop = False
		Me.Posicionamento.Text = "Processo"
		'
		'sDTP_DTInclusao
		'
		Me.sDTP_DTInclusao.Alterado = False
		Me.sDTP_DTInclusao.BackColor = System.Drawing.Color.White
		Me.sDTP_DTInclusao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.sDTP_DTInclusao.Location = New System.Drawing.Point(9, 47)
		Me.sDTP_DTInclusao.Name = "sDTP_DTInclusao"
		Me.sDTP_DTInclusao.Size = New System.Drawing.Size(129, 22)
		Me.sDTP_DTInclusao.TabIndex = 38
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(6, 30)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(82, 14)
		Me.Label5.TabIndex = 37
		Me.Label5.Text = "Dt. Inclusão"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(182, 31)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 14)
		Me.Label4.TabIndex = 28
		Me.Label4.Text = "Solicitação"
		'
		'sTxtSolicitacao
		'
		Me.sTxtSolicitacao.Alterado = False
		Me.sTxtSolicitacao.BackColor = System.Drawing.Color.White
		Me.sTxtSolicitacao.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTxtSolicitacao.Location = New System.Drawing.Point(185, 48)
		Me.sTxtSolicitacao.Name = "sTxtSolicitacao"
		Me.sTxtSolicitacao.ReadOnly = True
		Me.sTxtSolicitacao.Size = New System.Drawing.Size(194, 22)
		Me.sTxtSolicitacao.SuperMascara = ""
		Me.sTxtSolicitacao.SuperObrigatorio = True
		Me.sTxtSolicitacao.SuperTravaErrors = False
		Me.sTxtSolicitacao.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTxtSolicitacao.SuperTxtObrigatorio = "x_Vlr Confessado_x"
		Me.sTxtSolicitacao.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTxtSolicitacao.TabIndex = 29
		'
		'txtrStatus
		'
		Me.txtrStatus.Alterado = False
		Me.txtrStatus.BackColor = System.Drawing.Color.White
		Me.txtrStatus.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtrStatus.Location = New System.Drawing.Point(9, 89)
		Me.txtrStatus.Name = "txtrStatus"
		Me.txtrStatus.ReadOnly = True
		Me.txtrStatus.Size = New System.Drawing.Size(686, 22)
		Me.txtrStatus.SuperMascara = ""
		Me.txtrStatus.SuperObrigatorio = False
		Me.txtrStatus.SuperTravaErrors = False
		Me.txtrStatus.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtrStatus.SuperTxtObrigatorio = ""
		Me.txtrStatus.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtrStatus.TabIndex = 27
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(6, 72)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(32, 14)
		Me.Label29.TabIndex = 26
		Me.Label29.Text = "Info"
		'
		'CbocStatus
		'
		Me.CbocStatus.Alterado = False
		Me.CbocStatus.FormattingEnabled = True
		Me.CbocStatus.Location = New System.Drawing.Point(731, 48)
		Me.CbocStatus.Name = "CbocStatus"
		Me.CbocStatus.Size = New System.Drawing.Size(262, 22)
		Me.CbocStatus.SuperObrigatorio = False
		Me.CbocStatus.SuperTxtObrigatorio = ""
		Me.CbocStatus.TabIndex = 25
		'
		'CbocEtapaProc
		'
		Me.CbocEtapaProc.Alterado = False
		Me.CbocEtapaProc.FormattingEnabled = True
		Me.CbocEtapaProc.Location = New System.Drawing.Point(423, 48)
		Me.CbocEtapaProc.Name = "CbocEtapaProc"
		Me.CbocEtapaProc.Size = New System.Drawing.Size(262, 22)
		Me.CbocEtapaProc.SuperObrigatorio = False
		Me.CbocEtapaProc.SuperTxtObrigatorio = ""
		Me.CbocEtapaProc.TabIndex = 24
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(420, 30)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(44, 14)
		Me.Label10.TabIndex = 23
		Me.Label10.Text = "Etapa"
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Location = New System.Drawing.Point(728, 31)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(48, 14)
		Me.Label32.TabIndex = 21
		Me.Label32.Text = "Status"
		'
		'grpBoxContrato
		'
		Me.grpBoxContrato.Controls.Add(Me.txtsTpBem)
		Me.grpBoxContrato.Controls.Add(Me.Label47)
		Me.grpBoxContrato.Controls.Add(Me.sTxtCota)
		Me.grpBoxContrato.Controls.Add(Me.Label12)
		Me.grpBoxContrato.Controls.Add(Me.sTxtGrupo)
		Me.grpBoxContrato.Controls.Add(Me.sTXTContrato)
		Me.grpBoxContrato.Controls.Add(Me.sTxtCliente)
		Me.grpBoxContrato.Controls.Add(Me.Label15)
		Me.grpBoxContrato.Controls.Add(Me.sTxtEmailCliente)
		Me.grpBoxContrato.Controls.Add(Me.Label14)
		Me.grpBoxContrato.Controls.Add(Me.Label11)
		Me.grpBoxContrato.Controls.Add(Me.sCmdVisualizar)
		Me.grpBoxContrato.Controls.Add(Me.sCmdAnexo)
		Me.grpBoxContrato.Controls.Add(Me.Label1)
		Me.grpBoxContrato.Controls.Add(Me.Label21)
		Me.grpBoxContrato.Controls.Add(Me.txtcConta)
		Me.grpBoxContrato.Controls.Add(Me.Label22)
		Me.grpBoxContrato.Controls.Add(Me.Label23)
		Me.grpBoxContrato.Controls.Add(Me.txtcAg)
		Me.grpBoxContrato.Controls.Add(Me.txtrCPFCliente)
		Me.grpBoxContrato.Location = New System.Drawing.Point(119, 160)
		Me.grpBoxContrato.Name = "grpBoxContrato"
		Me.grpBoxContrato.Size = New System.Drawing.Size(1055, 177)
		Me.grpBoxContrato.TabIndex = 0
		Me.grpBoxContrato.TabStop = False
		Me.grpBoxContrato.Text = "Contrato"
		'
		'txtsTpBem
		'
		Me.txtsTpBem.Alterado = False
		Me.txtsTpBem.BackColor = System.Drawing.Color.White
		Me.txtsTpBem.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtsTpBem.Location = New System.Drawing.Point(803, 35)
		Me.txtsTpBem.Name = "txtsTpBem"
		Me.txtsTpBem.ReadOnly = True
		Me.txtsTpBem.Size = New System.Drawing.Size(81, 22)
		Me.txtsTpBem.SuperMascara = ""
		Me.txtsTpBem.SuperObrigatorio = False
		Me.txtsTpBem.SuperTravaErrors = False
		Me.txtsTpBem.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtsTpBem.SuperTxtObrigatorio = ""
		Me.txtsTpBem.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtsTpBem.TabIndex = 122
		'
		'Label47
		'
		Me.Label47.AutoSize = True
		Me.Label47.Location = New System.Drawing.Point(800, 18)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(84, 14)
		Me.Label47.TabIndex = 121
		Me.Label47.Text = "Tipo do Bem"
		'
		'sTxtCota
		'
		Me.sTxtCota.Alterado = False
		Me.sTxtCota.BackColor = System.Drawing.Color.White
		Me.sTxtCota.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTxtCota.Location = New System.Drawing.Point(742, 35)
		Me.sTxtCota.Name = "sTxtCota"
		Me.sTxtCota.ReadOnly = True
		Me.sTxtCota.Size = New System.Drawing.Size(55, 22)
		Me.sTxtCota.SuperMascara = ""
		Me.sTxtCota.SuperObrigatorio = False
		Me.sTxtCota.SuperTravaErrors = False
		Me.sTxtCota.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTxtCota.SuperTxtObrigatorio = ""
		Me.sTxtCota.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTxtCota.TabIndex = 120
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(739, 18)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(37, 14)
		Me.Label12.TabIndex = 119
		Me.Label12.Text = "Cota"
		'
		'sTxtGrupo
		'
		Me.sTxtGrupo.Alterado = False
		Me.sTxtGrupo.BackColor = System.Drawing.Color.White
		Me.sTxtGrupo.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTxtGrupo.Location = New System.Drawing.Point(668, 34)
		Me.sTxtGrupo.Name = "sTxtGrupo"
		Me.sTxtGrupo.ReadOnly = True
		Me.sTxtGrupo.Size = New System.Drawing.Size(68, 22)
		Me.sTxtGrupo.SuperMascara = ""
		Me.sTxtGrupo.SuperObrigatorio = False
		Me.sTxtGrupo.SuperTravaErrors = False
		Me.sTxtGrupo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTxtGrupo.SuperTxtObrigatorio = ""
		Me.sTxtGrupo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTxtGrupo.TabIndex = 118
		'
		'sTXTContrato
		'
		Me.sTXTContrato.Alterado = False
		Me.sTXTContrato.BackColor = System.Drawing.Color.White
		Me.sTXTContrato.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTXTContrato.Location = New System.Drawing.Point(18, 35)
		Me.sTXTContrato.Name = "sTXTContrato"
		Me.sTXTContrato.ReadOnly = True
		Me.sTXTContrato.Size = New System.Drawing.Size(194, 22)
		Me.sTXTContrato.SuperMascara = ""
		Me.sTXTContrato.SuperObrigatorio = True
		Me.sTXTContrato.SuperTravaErrors = False
		Me.sTXTContrato.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTXTContrato.SuperTxtObrigatorio = "x_Vlr Confessado_x"
		Me.sTXTContrato.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTXTContrato.TabIndex = 39
		'
		'sTxtCliente
		'
		Me.sTxtCliente.Alterado = False
		Me.sTxtCliente.BackColor = System.Drawing.Color.White
		Me.sTxtCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTxtCliente.Location = New System.Drawing.Point(210, 83)
		Me.sTxtCliente.Name = "sTxtCliente"
		Me.sTxtCliente.ReadOnly = True
		Me.sTxtCliente.Size = New System.Drawing.Size(674, 22)
		Me.sTxtCliente.SuperMascara = ""
		Me.sTxtCliente.SuperObrigatorio = False
		Me.sTxtCliente.SuperTravaErrors = False
		Me.sTxtCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTxtCliente.SuperTxtObrigatorio = ""
		Me.sTxtCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTxtCliente.TabIndex = 115
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(207, 66)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(51, 14)
		Me.Label15.TabIndex = 114
		Me.Label15.Text = "Cliente"
		'
		'sTxtEmailCliente
		'
		Me.sTxtEmailCliente.Alterado = False
		Me.sTxtEmailCliente.BackColor = System.Drawing.Color.White
		Me.sTxtEmailCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.sTxtEmailCliente.Location = New System.Drawing.Point(21, 131)
		Me.sTxtEmailCliente.Name = "sTxtEmailCliente"
		Me.sTxtEmailCliente.ReadOnly = True
		Me.sTxtEmailCliente.Size = New System.Drawing.Size(863, 22)
		Me.sTxtEmailCliente.SuperMascara = ""
		Me.sTxtEmailCliente.SuperObrigatorio = False
		Me.sTxtEmailCliente.SuperTravaErrors = False
		Me.sTxtEmailCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.sTxtEmailCliente.SuperTxtObrigatorio = ""
		Me.sTxtEmailCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.sTxtEmailCliente.TabIndex = 113
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(17, 114)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(93, 14)
		Me.Label14.TabIndex = 112
		Me.Label14.Text = "E-mail Cliente"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(665, 17)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(45, 14)
		Me.Label11.TabIndex = 108
		Me.Label11.Text = "Grupo"
		'
		'sCmdVisualizar
		'
		Me.sCmdVisualizar.BackColor = System.Drawing.Color.Transparent
		Me.sCmdVisualizar.BackgroundImage = CType(resources.GetObject("sCmdVisualizar.BackgroundImage"), System.Drawing.Image)
		Me.sCmdVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.sCmdVisualizar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.sCmdVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.sCmdVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sCmdVisualizar.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.sCmdVisualizar.ForeColor = System.Drawing.Color.Black
		Me.sCmdVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sCmdVisualizar.Location = New System.Drawing.Point(906, 97)
		Me.sCmdVisualizar.Name = "sCmdVisualizar"
		Me.sCmdVisualizar.Size = New System.Drawing.Size(118, 39)
		Me.sCmdVisualizar.TabIndex = 107
		Me.sCmdVisualizar.Text = "    &Visualizar Evidência"
		Me.sCmdVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.sCmdVisualizar.UseVisualStyleBackColor = False
		'
		'sCmdAnexo
		'
		Me.sCmdAnexo.BackColor = System.Drawing.Color.Transparent
		Me.sCmdAnexo.BackgroundImage = CType(resources.GetObject("sCmdAnexo.BackgroundImage"), System.Drawing.Image)
		Me.sCmdAnexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.sCmdAnexo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.sCmdAnexo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.sCmdAnexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.sCmdAnexo.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.sCmdAnexo.ForeColor = System.Drawing.Color.Black
		Me.sCmdAnexo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.sCmdAnexo.Location = New System.Drawing.Point(906, 44)
		Me.sCmdAnexo.Name = "sCmdAnexo"
		Me.sCmdAnexo.Size = New System.Drawing.Size(119, 36)
		Me.sCmdAnexo.TabIndex = 101
		Me.sCmdAnexo.Text = "&Anexo MPI"
		Me.sCmdAnexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.sCmdAnexo.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(16, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 14)
		Me.Label1.TabIndex = 37
		Me.Label1.Text = "Contrato"
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(18, 66)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(67, 14)
		Me.Label21.TabIndex = 21
		Me.Label21.Text = "CPF/CNPJ"
		'
		'txtcConta
		'
		Me.txtcConta.Alterado = False
		Me.txtcConta.BackColor = System.Drawing.Color.White
		Me.txtcConta.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtcConta.Location = New System.Drawing.Point(225, 34)
		Me.txtcConta.Name = "txtcConta"
		Me.txtcConta.ReadOnly = True
		Me.txtcConta.Size = New System.Drawing.Size(121, 22)
		Me.txtcConta.SuperMascara = ""
		Me.txtcConta.SuperObrigatorio = False
		Me.txtcConta.SuperTravaErrors = False
		Me.txtcConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtcConta.SuperTxtObrigatorio = ""
		Me.txtcConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtcConta.TabIndex = 26
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(223, 17)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(45, 14)
		Me.Label22.TabIndex = 22
		Me.Label22.Text = "Conta"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(361, 17)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(56, 14)
		Me.Label23.TabIndex = 23
		Me.Label23.Text = "Agência"
		'
		'txtcAg
		'
		Me.txtcAg.Alterado = False
		Me.txtcAg.BackColor = System.Drawing.Color.White
		Me.txtcAg.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtcAg.Location = New System.Drawing.Point(360, 34)
		Me.txtcAg.Name = "txtcAg"
		Me.txtcAg.ReadOnly = True
		Me.txtcAg.Size = New System.Drawing.Size(302, 22)
		Me.txtcAg.SuperMascara = ""
		Me.txtcAg.SuperObrigatorio = False
		Me.txtcAg.SuperTravaErrors = False
		Me.txtcAg.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtcAg.SuperTxtObrigatorio = ""
		Me.txtcAg.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtcAg.TabIndex = 27
		'
		'txtrCPFCliente
		'
		Me.txtrCPFCliente.Alterado = False
		Me.txtrCPFCliente.BackColor = System.Drawing.Color.White
		Me.txtrCPFCliente.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtrCPFCliente.Location = New System.Drawing.Point(19, 83)
		Me.txtrCPFCliente.Name = "txtrCPFCliente"
		Me.txtrCPFCliente.ReadOnly = True
		Me.txtrCPFCliente.Size = New System.Drawing.Size(170, 22)
		Me.txtrCPFCliente.SuperMascara = ""
		Me.txtrCPFCliente.SuperObrigatorio = False
		Me.txtrCPFCliente.SuperTravaErrors = False
		Me.txtrCPFCliente.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtrCPFCliente.SuperTxtObrigatorio = ""
		Me.txtrCPFCliente.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtrCPFCliente.TabIndex = 28
		'
		'tabSGSS
		'
		Me.tabSGSS.Controls.Add(Me.Label7)
		Me.tabSGSS.Controls.Add(Me.SuperComboBox1)
		Me.tabSGSS.Controls.Add(Me.Label20)
		Me.tabSGSS.Controls.Add(Me.txbnSoltc)
		Me.tabSGSS.Controls.Add(Me.lblTipoObtencao)
		Me.tabSGSS.Controls.Add(Me.GroupBox3)
		Me.tabSGSS.Controls.Add(Me.Label3)
		Me.tabSGSS.Controls.Add(Me.Label2)
		Me.tabSGSS.Controls.Add(Me.txtQuantidade)
		Me.tabSGSS.Controls.Add(Me.Label6)
		Me.tabSGSS.Controls.Add(Me.txtListaSE)
		Me.tabSGSS.Controls.Add(Me.cmdObterSGSS)
		Me.tabSGSS.Location = New System.Drawing.Point(4, 22)
		Me.tabSGSS.Name = "tabSGSS"
		Me.tabSGSS.Size = New System.Drawing.Size(1313, 530)
		Me.tabSGSS.TabIndex = 6
		Me.tabSGSS.Text = "Obter SGSS"
		Me.tabSGSS.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(390, 12)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(58, 14)
		Me.Label7.TabIndex = 430
		Me.Label7.Text = "Assunto"
		'
		'SuperComboBox1
		'
		Me.SuperComboBox1.Alterado = False
		Me.SuperComboBox1.FormattingEnabled = True
		Me.SuperComboBox1.Location = New System.Drawing.Point(393, 31)
		Me.SuperComboBox1.Name = "SuperComboBox1"
		Me.SuperComboBox1.Size = New System.Drawing.Size(121, 22)
		Me.SuperComboBox1.SuperObrigatorio = False
		Me.SuperComboBox1.SuperTxtObrigatorio = ""
		Me.SuperComboBox1.TabIndex = 429
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(93, 12)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(45, 14)
		Me.Label20.TabIndex = 428
		Me.Label20.Text = "E-mail"
		'
		'txbnSoltc
		'
		Me.txbnSoltc.Alterado = False
		Me.txbnSoltc.BackColor = System.Drawing.Color.White
		Me.txbnSoltc.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txbnSoltc.Location = New System.Drawing.Point(96, 31)
		Me.txbnSoltc.MaxLength = 21
		Me.txbnSoltc.Name = "txbnSoltc"
		Me.txbnSoltc.Size = New System.Drawing.Size(258, 22)
		Me.txbnSoltc.SuperMascara = ""
		Me.txbnSoltc.SuperObrigatorio = False
		Me.txbnSoltc.SuperTravaErrors = False
		Me.txbnSoltc.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txbnSoltc.SuperTxtObrigatorio = ""
		Me.txbnSoltc.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txbnSoltc.TabIndex = 427
		'
		'lblTipoObtencao
		'
		Me.lblTipoObtencao.AutoSize = True
		Me.lblTipoObtencao.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
		Me.lblTipoObtencao.Location = New System.Drawing.Point(936, 475)
		Me.lblTipoObtencao.Name = "lblTipoObtencao"
		Me.lblTipoObtencao.Size = New System.Drawing.Size(136, 18)
		Me.lblTipoObtencao.TabIndex = 426
		Me.lblTipoObtencao.Text = "Tipo Obtenção"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lbltVal)
		Me.GroupBox3.Controls.Add(Me.lbltInv)
		Me.GroupBox3.Controls.Add(Me.lbltIg)
		Me.GroupBox3.Controls.Add(Me.lbltLido)
		Me.GroupBox3.Location = New System.Drawing.Point(929, 85)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(340, 355)
		Me.GroupBox3.TabIndex = 422
		Me.GroupBox3.TabStop = False
		'
		'lbltVal
		'
		Me.lbltVal.AutoSize = True
		Me.lbltVal.Location = New System.Drawing.Point(26, 224)
		Me.lbltVal.Name = "lbltVal"
		Me.lbltVal.Size = New System.Drawing.Size(52, 14)
		Me.lbltVal.TabIndex = 422
		Me.lbltVal.Text = "Válidos"
		'
		'lbltInv
		'
		Me.lbltInv.AutoSize = True
		Me.lbltInv.Location = New System.Drawing.Point(26, 141)
		Me.lbltInv.Name = "lbltInv"
		Me.lbltInv.Size = New System.Drawing.Size(64, 14)
		Me.lbltInv.TabIndex = 421
		Me.lbltInv.Text = "Inválidos"
		'
		'lbltIg
		'
		Me.lbltIg.AutoSize = True
		Me.lbltIg.Location = New System.Drawing.Point(26, 182)
		Me.lbltIg.Name = "lbltIg"
		Me.lbltIg.Size = New System.Drawing.Size(72, 14)
		Me.lbltIg.TabIndex = 420
		Me.lbltIg.Text = "Ignorados"
		'
		'lbltLido
		'
		Me.lbltLido.AutoSize = True
		Me.lbltLido.Location = New System.Drawing.Point(26, 96)
		Me.lbltLido.Name = "lbltLido"
		Me.lbltLido.Size = New System.Drawing.Size(40, 14)
		Me.lbltLido.TabIndex = 419
		Me.lbltLido.Text = "Lidos"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(108, 68)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(323, 14)
		Me.Label3.TabIndex = 421
		Me.Label3.Text = "Deixar em branco para obter todas as solicitações"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(10, 12)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(81, 14)
		Me.Label2.TabIndex = 420
		Me.Label2.Text = "Quantidade"
		'
		'txtQuantidade
		'
		Me.txtQuantidade.Alterado = False
		Me.txtQuantidade.BackColor = System.Drawing.Color.White
		Me.txtQuantidade.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtQuantidade.Location = New System.Drawing.Point(13, 31)
		Me.txtQuantidade.Name = "txtQuantidade"
		Me.txtQuantidade.Size = New System.Drawing.Size(77, 22)
		Me.txtQuantidade.SuperMascara = ""
		Me.txtQuantidade.SuperObrigatorio = False
		Me.txtQuantidade.SuperTravaErrors = False
		Me.txtQuantidade.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtQuantidade.SuperTxtObrigatorio = ""
		Me.txtQuantidade.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtQuantidade.TabIndex = 419
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(11, 67)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(80, 14)
		Me.Label6.TabIndex = 413
		Me.Label6.Text = "Solicitações"
		'
		'txtListaSE
		'
		Me.txtListaSE.AcceptsReturn = True
		Me.txtListaSE.Alterado = False
		Me.txtListaSE.BackColor = System.Drawing.Color.White
		Me.txtListaSE.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtListaSE.Location = New System.Drawing.Point(12, 85)
		Me.txtListaSE.Multiline = True
		Me.txtListaSE.Name = "txtListaSE"
		Me.txtListaSE.ReadOnly = True
		Me.txtListaSE.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtListaSE.Size = New System.Drawing.Size(882, 441)
		Me.txtListaSE.SuperMascara = ""
		Me.txtListaSE.SuperObrigatorio = False
		Me.txtListaSE.SuperTravaErrors = False
		Me.txtListaSE.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtListaSE.SuperTxtObrigatorio = ""
		Me.txtListaSE.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtListaSE.TabIndex = 414
		Me.txtListaSE.TabStop = False
		'
		'cmdObterSGSS
		'
		Me.cmdObterSGSS.BackColor = System.Drawing.Color.Transparent
		Me.cmdObterSGSS.BackgroundImage = CType(resources.GetObject("cmdObterSGSS.BackgroundImage"), System.Drawing.Image)
		Me.cmdObterSGSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.cmdObterSGSS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.cmdObterSGSS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.cmdObterSGSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdObterSGSS.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.cmdObterSGSS.ForeColor = System.Drawing.Color.Black
		Me.cmdObterSGSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdObterSGSS.Location = New System.Drawing.Point(790, 31)
		Me.cmdObterSGSS.Name = "cmdObterSGSS"
		Me.cmdObterSGSS.Size = New System.Drawing.Size(104, 32)
		Me.cmdObterSGSS.TabIndex = 109
		Me.cmdObterSGSS.Text = "O&bter SE"
		Me.cmdObterSGSS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdObterSGSS.UseVisualStyleBackColor = False
		'
		'tabMainFr
		'
		Me.tabMainFr.Controls.Add(Me.sLetreiro_Processo)
		Me.tabMainFr.Controls.Add(Me.txtProcessamento)
		Me.tabMainFr.Controls.Add(Me.lbProcesso)
		Me.tabMainFr.Controls.Add(Me.txtTerminal)
		Me.tabMainFr.Location = New System.Drawing.Point(4, 23)
		Me.tabMainFr.Name = "tabMainFr"
		Me.tabMainFr.Size = New System.Drawing.Size(1313, 529)
		Me.tabMainFr.TabIndex = 5
		Me.tabMainFr.Text = "Processar"
		Me.tabMainFr.UseVisualStyleBackColor = True
		'
		'sLetreiro_Processo
		'
		Me.sLetreiro_Processo.CorSombraTexto = System.Drawing.Color.White
		Me.sLetreiro_Processo.Location = New System.Drawing.Point(91, 471)
		Me.sLetreiro_Processo.Name = "sLetreiro_Processo"
		Me.sLetreiro_Processo.RolagemLetreiro = GFT.Util.SuperLetreiro.Direcao.Esquerda
		Me.sLetreiro_Processo.Size = New System.Drawing.Size(415, 30)
		Me.sLetreiro_Processo.TabIndex = 942
		Me.sLetreiro_Processo.TextoLetreiro = "Pronto!"
		Me.sLetreiro_Processo.VelocidadeRolagem = 2
		'
		'txtProcessamento
		'
		Me.txtProcessamento.Alterado = False
		Me.txtProcessamento.BackColor = System.Drawing.Color.White
		Me.txtProcessamento.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
		Me.txtProcessamento.Location = New System.Drawing.Point(685, 3)
		Me.txtProcessamento.Multiline = True
		Me.txtProcessamento.Name = "txtProcessamento"
		Me.txtProcessamento.Size = New System.Drawing.Size(625, 445)
		Me.txtProcessamento.SuperMascara = ""
		Me.txtProcessamento.SuperObrigatorio = False
		Me.txtProcessamento.SuperTravaErrors = False
		Me.txtProcessamento.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
		Me.txtProcessamento.SuperTxtObrigatorio = ""
		Me.txtProcessamento.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
		Me.txtProcessamento.TabIndex = 17
		Me.txtProcessamento.WordWrap = False
		'
		'lbProcesso
		'
		Me.lbProcesso.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbProcesso.Location = New System.Drawing.Point(8, 485)
		Me.lbProcesso.Name = "lbProcesso"
		Me.lbProcesso.Size = New System.Drawing.Size(670, 26)
		Me.lbProcesso.TabIndex = 16
		Me.lbProcesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtTerminal
		'
		Me.txtTerminal.BackColor = System.Drawing.Color.Black
		Me.txtTerminal.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTerminal.ForeColor = System.Drawing.Color.Lime
		Me.txtTerminal.Location = New System.Drawing.Point(3, 3)
		Me.txtTerminal.Multiline = True
		Me.txtTerminal.Name = "txtTerminal"
		Me.txtTerminal.Size = New System.Drawing.Size(675, 445)
		Me.txtTerminal.TabIndex = 14
		'
		'tabEnvio
		'
		Me.tabEnvio.Controls.Add(Me.Label24)
		Me.tabEnvio.Controls.Add(Me.Label25)
		Me.tabEnvio.Controls.Add(Me.Label28)
		Me.tabEnvio.Controls.Add(Me.Label31)
		Me.tabEnvio.Controls.Add(Me.Label36)
		Me.tabEnvio.Controls.Add(Me.Label37)
		Me.tabEnvio.Controls.Add(Me.Label38)
		Me.tabEnvio.Controls.Add(Me.Label40)
		Me.tabEnvio.Controls.Add(Me.Label42)
		Me.tabEnvio.Controls.Add(Me.Label43)
		Me.tabEnvio.Controls.Add(Me.Label45)
		Me.tabEnvio.Controls.Add(Me.Label46)
		Me.tabEnvio.Controls.Add(Me.btnCobranca)
		Me.tabEnvio.Controls.Add(Me.btnEnviaResumo)
		Me.tabEnvio.Controls.Add(Me.btnProcAnali)
		Me.tabEnvio.Controls.Add(Me.btnImpRet)
		Me.tabEnvio.Controls.Add(Me.btnEnvAnali)
		Me.tabEnvio.Controls.Add(Me.lvEnvioEmail)
		Me.tabEnvio.Location = New System.Drawing.Point(4, 22)
		Me.tabEnvio.Name = "tabEnvio"
		Me.tabEnvio.Size = New System.Drawing.Size(1313, 530)
		Me.tabEnvio.TabIndex = 7
		Me.tabEnvio.Text = "Envio de Imagens"
		Me.tabEnvio.UseVisualStyleBackColor = True
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(1181, 479)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(116, 14)
		Me.Label24.TabIndex = 1042
		Me.Label24.Text = "Enviado Imagens"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label25.Location = New System.Drawing.Point(1162, 477)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(13, 16)
		Me.Label25.TabIndex = 1041
		Me.Label25.Text = " "
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(1023, 504)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(133, 14)
		Me.Label28.TabIndex = 1040
		Me.Label28.Text = "Enviado Pendências"
		'
		'Label31
		'
		Me.Label31.AutoSize = True
		Me.Label31.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label31.Location = New System.Drawing.Point(1004, 502)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(13, 16)
		Me.Label31.TabIndex = 1039
		Me.Label31.Text = " "
		'
		'Label36
		'
		Me.Label36.AutoSize = True
		Me.Label36.Location = New System.Drawing.Point(1181, 504)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(130, 14)
		Me.Label36.TabIndex = 1038
		Me.Label36.Text = "Cancelado no SGSS"
		'
		'Label37
		'
		Me.Label37.AutoSize = True
		Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label37.Location = New System.Drawing.Point(1162, 502)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(13, 16)
		Me.Label37.TabIndex = 1037
		Me.Label37.Text = " "
		'
		'Label38
		'
		Me.Label38.AutoSize = True
		Me.Label38.Location = New System.Drawing.Point(1023, 479)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(81, 14)
		Me.Label38.TabIndex = 1036
		Me.Label38.Text = "Respondido"
		'
		'Label40
		'
		Me.Label40.AutoSize = True
		Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label40.Location = New System.Drawing.Point(1004, 477)
		Me.Label40.Name = "Label40"
		Me.Label40.Size = New System.Drawing.Size(13, 16)
		Me.Label40.TabIndex = 1035
		Me.Label40.Text = " "
		'
		'Label42
		'
		Me.Label42.AutoSize = True
		Me.Label42.Location = New System.Drawing.Point(917, 504)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(85, 14)
		Me.Label42.TabIndex = 1034
		Me.Label42.Text = "Processo Ok"
		'
		'Label43
		'
		Me.Label43.AutoSize = True
		Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label43.Location = New System.Drawing.Point(898, 502)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(13, 16)
		Me.Label43.TabIndex = 1033
		Me.Label43.Text = " "
		'
		'Label45
		'
		Me.Label45.AutoSize = True
		Me.Label45.Location = New System.Drawing.Point(917, 479)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(81, 14)
		Me.Label45.TabIndex = 1032
		Me.Label45.Text = "A Processar"
		'
		'Label46
		'
		Me.Label46.AutoSize = True
		Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label46.Location = New System.Drawing.Point(898, 477)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(13, 16)
		Me.Label46.TabIndex = 1031
		Me.Label46.Text = " "
		'
		'btnCobranca
		'
		Me.btnCobranca.BackColor = System.Drawing.Color.Transparent
		Me.btnCobranca.BackgroundImage = CType(resources.GetObject("btnCobranca.BackgroundImage"), System.Drawing.Image)
		Me.btnCobranca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnCobranca.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnCobranca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnCobranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnCobranca.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnCobranca.ForeColor = System.Drawing.Color.Black
		Me.btnCobranca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnCobranca.Location = New System.Drawing.Point(787, 477)
		Me.btnCobranca.Name = "btnCobranca"
		Me.btnCobranca.Size = New System.Drawing.Size(103, 41)
		Me.btnCobranca.TabIndex = 1030
		Me.btnCobranca.Text = "&Cobrança"
		Me.btnCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnCobranca.UseVisualStyleBackColor = False
		'
		'btnEnviaResumo
		'
		Me.btnEnviaResumo.BackColor = System.Drawing.Color.Transparent
		Me.btnEnviaResumo.BackgroundImage = CType(resources.GetObject("btnEnviaResumo.BackgroundImage"), System.Drawing.Image)
		Me.btnEnviaResumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnEnviaResumo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnEnviaResumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnEnviaResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEnviaResumo.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnEnviaResumo.ForeColor = System.Drawing.Color.Black
		Me.btnEnviaResumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEnviaResumo.Location = New System.Drawing.Point(132, 477)
		Me.btnEnviaResumo.Name = "btnEnviaResumo"
		Me.btnEnviaResumo.Size = New System.Drawing.Size(121, 41)
		Me.btnEnviaResumo.TabIndex = 1027
		Me.btnEnviaResumo.Text = "Envia &Lista" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resumo"
		Me.btnEnviaResumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnEnviaResumo.UseVisualStyleBackColor = False
		Me.btnEnviaResumo.Visible = False
		'
		'btnProcAnali
		'
		Me.btnProcAnali.BackColor = System.Drawing.Color.Transparent
		Me.btnProcAnali.BackgroundImage = CType(resources.GetObject("btnProcAnali.BackgroundImage"), System.Drawing.Image)
		Me.btnProcAnali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnProcAnali.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnProcAnali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnProcAnali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProcAnali.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnProcAnali.ForeColor = System.Drawing.Color.Black
		Me.btnProcAnali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProcAnali.Location = New System.Drawing.Point(620, 477)
		Me.btnProcAnali.Name = "btnProcAnali"
		Me.btnProcAnali.Size = New System.Drawing.Size(111, 41)
		Me.btnProcAnali.TabIndex = 1029
		Me.btnProcAnali.Text = "P&rocessar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retorno"
		Me.btnProcAnali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnProcAnali.UseVisualStyleBackColor = False
		'
		'btnImpRet
		'
		Me.btnImpRet.BackColor = System.Drawing.Color.Transparent
		Me.btnImpRet.BackgroundImage = CType(resources.GetObject("btnImpRet.BackgroundImage"), System.Drawing.Image)
		Me.btnImpRet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnImpRet.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnImpRet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnImpRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnImpRet.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnImpRet.ForeColor = System.Drawing.Color.Black
		Me.btnImpRet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnImpRet.Location = New System.Drawing.Point(452, 477)
		Me.btnImpRet.Name = "btnImpRet"
		Me.btnImpRet.Size = New System.Drawing.Size(107, 41)
		Me.btnImpRet.TabIndex = 1028
		Me.btnImpRet.Text = "&Importar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retorno"
		Me.btnImpRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnImpRet.UseVisualStyleBackColor = False
		'
		'btnEnvAnali
		'
		Me.btnEnvAnali.BackColor = System.Drawing.Color.Transparent
		Me.btnEnvAnali.BackgroundImage = CType(resources.GetObject("btnEnvAnali.BackgroundImage"), System.Drawing.Image)
		Me.btnEnvAnali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnEnvAnali.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnEnvAnali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.btnEnvAnali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEnvAnali.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.btnEnvAnali.ForeColor = System.Drawing.Color.Black
		Me.btnEnvAnali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEnvAnali.Location = New System.Drawing.Point(13, 477)
		Me.btnEnvAnali.Name = "btnEnvAnali"
		Me.btnEnvAnali.Size = New System.Drawing.Size(113, 41)
		Me.btnEnvAnali.TabIndex = 1026
		Me.btnEnvAnali.Text = "Enviar P/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Análise"
		Me.btnEnvAnali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnEnvAnali.UseVisualStyleBackColor = False
		Me.btnEnvAnali.Visible = False
		'
		'lvEnvioEmail
		'
		Me.lvEnvioEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lvEnvioEmail.HabilitaOrdem = True
		Me.lvEnvioEmail.HideSelection = False
		Me.lvEnvioEmail.Location = New System.Drawing.Point(3, 3)
		Me.lvEnvioEmail.Name = "lvEnvioEmail"
		Me.lvEnvioEmail.SelecionaVarios = True
		Me.lvEnvioEmail.Size = New System.Drawing.Size(1307, 468)
		Me.lvEnvioEmail.TabIndex = 1025
		Me.lvEnvioEmail.UseCompatibleStateImageBehavior = False
		'
		'frmProc
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1346, 655)
		Me.ControlBox = False
		Me.Controls.Add(Me.tabContrEnvio)
		Me.Controls.Add(Me.grp_Botoes)
		Me.DoubleBuffered = True
		Me.Font = New System.Drawing.Font("Verdana", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmProc"
		Me.ShowIcon = False
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "frmControEnvio"
		Me.grp_Botoes.ResumeLayout(False)
		Me.tabContrEnvio.ResumeLayout(False)
		Me.tabFiltro.ResumeLayout(False)
		Me.tabFiltro.PerformLayout()
		Me.grpFiltro.ResumeLayout(False)
		Me.grpFiltro.PerformLayout()
		Me.tabDetalhe.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.Posicionamento.ResumeLayout(False)
		Me.Posicionamento.PerformLayout()
		Me.grpBoxContrato.ResumeLayout(False)
		Me.grpBoxContrato.PerformLayout()
		Me.tabSGSS.ResumeLayout(False)
		Me.tabSGSS.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.tabMainFr.ResumeLayout(False)
		Me.tabMainFr.PerformLayout()
		Me.tabEnvio.ResumeLayout(False)
		Me.tabEnvio.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents grp_Botoes As GroupBox
    Friend WithEvents cmdExcluir As GFT.Util.SuperButton
    Friend WithEvents cmdSalvar As GFT.Util.SuperButton
    Friend WithEvents cmdNovo As GFT.Util.SuperButton
    Friend WithEvents tabContrEnvio As GFT.Util.SuperTabControl
    Friend WithEvents tabFiltro As TabPage
    Friend WithEvents tabDetalhe As TabPage
    Friend WithEvents lvDetalheFiltro As GFT.Util.SuperLV
    Friend WithEvents grpFiltro As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DtInicial As GFT.Util.SuperDatePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents DtFinal As GFT.Util.SuperDatePicker
    Friend WithEvents Label32 As Label
    Friend WithEvents grpBoxContrato As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtcConta As GFT.Util.SuperTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtcAg As GFT.Util.SuperTextBox
    Friend WithEvents txtrCPFCliente As GFT.Util.SuperTextBox
    Friend WithEvents Posicionamento As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdNovoManual As GFT.Util.SuperButton
    Friend WithEvents CbocStatus As GFT.Util.SuperComboBox
    Friend WithEvents CbocEtapaProc As GFT.Util.SuperComboBox
    Friend WithEvents txtrStatus As GFT.Util.SuperTextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtInfo As GFT.Util.SuperLetreiro
    Friend WithEvents cmbFiltroStatus As GFT.Util.SuperComboBox
    Friend WithEvents cmbFiltroEtapa As GFT.Util.SuperComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents cmdSGSS As GFT.Util.SuperButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tabMainFr As TabPage
    Friend WithEvents txtProcessamento As GFT.Util.SuperTextBox
    Friend WithEvents lbProcesso As Label
    Friend WithEvents txtTerminal As TextBox
    Friend WithEvents tabSGSS As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtListaSE As GFT.Util.SuperTextBox
    Friend WithEvents cmdObterSGSS As GFT.Util.SuperButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantidade As GFT.Util.SuperTextBox
    Friend WithEvents cmdPesquisar As GFT.Util.SuperButton
    Friend WithEvents sDTP_DTInclusao As GFT.Util.SuperDatePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sTxtSolicitacao As GFT.Util.SuperTextBox
    Friend WithEvents sCmdAnexo As GFT.Util.SuperButton
    Friend WithEvents cmdDetalhes As GFT.Util.SuperButton
    Friend WithEvents sCmdVisualizar As GFT.Util.SuperButton
    Friend WithEvents sTxtCliente As GFT.Util.SuperTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents sTxtEmailCliente As GFT.Util.SuperTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbltVal As Label
    Friend WithEvents lbltInv As Label
    Friend WithEvents lbltIg As Label
    Friend WithEvents lbltLido As Label
    Friend WithEvents cmdVoltar As GFT.Util.SuperButton
    Friend WithEvents cmdProcessar As GFT.Util.SuperButton
    Friend WithEvents Label35 As Label
    Friend WithEvents lblCaceladoSGSS As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblReprocessado As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents lblProcessoOK As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblProcessar As Label
    Friend WithEvents sTxtGrupo As GFT.Util.SuperTextBox
    Friend WithEvents sTXTContrato As GFT.Util.SuperTextBox
    Friend WithEvents lblTipoObtencao As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lblVerificar As Label
    Friend WithEvents cmdImprimir As GFT.Util.SuperButton
    Friend WithEvents sTxtCota As GFT.Util.SuperTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents sLetreiro_Processo As GFT.Util.SuperLetreiro
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblFunCaf As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txbnSoltc As GFT.Util.SuperTextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txbConta As GFT.Util.SuperTextBox
    Friend WithEvents txbContrato As GFT.Util.SuperTextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txbAg As GFT.Util.SuperTextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txbSE As GFT.Util.SuperTextBox
    Friend WithEvents btnCancelaSGSS As GFT.Util.SuperButton
    Friend WithEvents btnConcluirSE As GFT.Util.SuperButton
    Friend WithEvents btnEnvio As GFT.Util.SuperButton
    Friend WithEvents tabEnvio As System.Windows.Forms.TabPage
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnCobranca As GFT.Util.SuperButton
    Friend WithEvents btnEnviaResumo As GFT.Util.SuperButton
    Friend WithEvents btnProcAnali As GFT.Util.SuperButton
    Friend WithEvents btnImpRet As GFT.Util.SuperButton
    Friend WithEvents btnEnvAnali As GFT.Util.SuperButton
    Friend WithEvents lvEnvioEmail As GFT.Util.SuperLV
    Friend WithEvents txtsTpBem As GFT.Util.SuperTextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsSolicitante As GFT.Util.SuperTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtsTelAg As GFT.Util.SuperTextBox
    Friend WithEvents btnVerificarImagens As GFT.Util.SuperButton
    Friend WithEvents btnIncImg As GFT.Util.SuperButton
	Friend WithEvents Label7 As Label
	Friend WithEvents SuperComboBox1 As GFT.Util.SuperComboBox
End Class
