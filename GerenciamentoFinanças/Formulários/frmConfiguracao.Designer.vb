﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracao
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracao))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tabCtrlConfig = New GFT.Util.SuperTabControl()
        Me.tabConta = New System.Windows.Forms.TabPage()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.lblContas = New System.Windows.Forms.Label()
        Me.gbDadosConta = New System.Windows.Forms.GroupBox()
        Me.txtBanco = New GFT.Util.SuperTextBox()
        Me.lblTipoConta = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtTipoConta = New GFT.Util.SuperTextBox()
        Me.lblAgencia = New System.Windows.Forms.Label()
        Me.txtSaldo = New GFT.Util.SuperTextBox()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.txtConta = New GFT.Util.SuperTextBox()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtAgencia = New GFT.Util.SuperTextBox()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New GFT.Util.SuperButton()
        Me.btnAddConta = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.tabCategoriaDespesa = New System.Windows.Forms.TabPage()
        Me.gbCadastroDespesa = New System.Windows.Forms.GroupBox()
        Me.lblCategoriaDespesa = New System.Windows.Forms.Label()
        Me.txtNovaCategoriaDespesa = New GFT.Util.SuperTextBox()
        Me.btnAdd = New GFT.Util.SuperButton()
        Me.gbTodasDespesa = New System.Windows.Forms.GroupBox()
        Me.gbBotoesCategoriaDespesa = New System.Windows.Forms.GroupBox()
        Me.btnEditarDespesa = New System.Windows.Forms.Button()
        Me.btnExcluirDespesa = New System.Windows.Forms.Button()
        Me.lvCategoriaDespesa = New GFT.Util.SuperLV()
        Me.tabFormaPagamento = New System.Windows.Forms.TabPage()
        Me.gbCadastroPagamento = New System.Windows.Forms.GroupBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.txtNovaFormaPag = New GFT.Util.SuperTextBox()
        Me.btnAddPag = New GFT.Util.SuperButton()
        Me.gbConsultaPagamento = New System.Windows.Forms.GroupBox()
        Me.gbBotoesPagamento = New System.Windows.Forms.GroupBox()
        Me.btnEditarPag = New System.Windows.Forms.Button()
        Me.btnExcluirPag = New System.Windows.Forms.Button()
        Me.lvFormaPagamento = New GFT.Util.SuperLV()
        Me.tabParcelamento = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExcluirParcela = New System.Windows.Forms.Button()
        Me.btnSalvarParcela = New System.Windows.Forms.Button()
        Me.lvParcela = New GFT.Util.SuperLV()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCadastrarParc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQtdeParcela = New GFT.Util.SuperTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbBotoesReceita = New System.Windows.Forms.GroupBox()
        Me.btnEditarReceita = New System.Windows.Forms.Button()
        Me.btnExcluirReceita = New System.Windows.Forms.Button()
        Me.lvReceita = New GFT.Util.SuperLV()
        Me.gbAddReceita = New System.Windows.Forms.GroupBox()
        Me.btnAdicionarReceita = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNovaReceita = New GFT.Util.SuperTextBox()
        Me.tabCtrlConfig.SuspendLayout()
        Me.tabConta.SuspendLayout()
        Me.gbDadosConta.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.tabCategoriaDespesa.SuspendLayout()
        Me.gbCadastroDespesa.SuspendLayout()
        Me.gbTodasDespesa.SuspendLayout()
        Me.gbBotoesCategoriaDespesa.SuspendLayout()
        Me.tabFormaPagamento.SuspendLayout()
        Me.gbCadastroPagamento.SuspendLayout()
        Me.gbConsultaPagamento.SuspendLayout()
        Me.gbBotoesPagamento.SuspendLayout()
        Me.tabParcelamento.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbBotoesReceita.SuspendLayout()
        Me.gbAddReceita.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Orange
        Me.ImageList1.Images.SetKeyName(0, "1486564399-close_81512.png")
        Me.ImageList1.Images.SetKeyName(1, "iconCartao1.png")
        Me.ImageList1.Images.SetKeyName(2, "iconEngrenagem.png")
        Me.ImageList1.Images.SetKeyName(3, "iconMoneyRed.fw.png")
        Me.ImageList1.Images.SetKeyName(4, "1495815224-jd15_84582.png")
        Me.ImageList1.Images.SetKeyName(5, "1495815224-jd15_84582 (1).png")
        Me.ImageList1.Images.SetKeyName(6, "Banco2.png")
        Me.ImageList1.Images.SetKeyName(7, "1495815224-jd15_84582 (2).png")
        Me.ImageList1.Images.SetKeyName(8, "iconMOneyGreen.png")
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1317, -1)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(58, 57)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'tabCtrlConfig
        '
        Me.tabCtrlConfig.Controls.Add(Me.tabConta)
        Me.tabCtrlConfig.Controls.Add(Me.tabCategoriaDespesa)
        Me.tabCtrlConfig.Controls.Add(Me.tabFormaPagamento)
        Me.tabCtrlConfig.Controls.Add(Me.tabParcelamento)
        Me.tabCtrlConfig.Controls.Add(Me.TabPage1)
        Me.tabCtrlConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConfig.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlConfig.ImageList = Me.ImageList1
        Me.tabCtrlConfig.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConfig.Multiline = True
        Me.tabCtrlConfig.Name = "tabCtrlConfig"
        Me.tabCtrlConfig.Padding = New System.Drawing.Point(30, 5)
        Me.tabCtrlConfig.SelectedIndex = 0
        Me.tabCtrlConfig.Size = New System.Drawing.Size(1371, 943)
        Me.tabCtrlConfig.TabIndex = 0
        '
        'tabConta
        '
        Me.tabConta.Controls.Add(Me.lvConsulta)
        Me.tabConta.Controls.Add(Me.lblContas)
        Me.tabConta.Controls.Add(Me.gbDadosConta)
        Me.tabConta.Controls.Add(Me.gbBotoes)
        Me.tabConta.ImageIndex = 6
        Me.tabConta.Location = New System.Drawing.Point(4, 118)
        Me.tabConta.Name = "tabConta"
        Me.tabConta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConta.Size = New System.Drawing.Size(1363, 821)
        Me.tabConta.TabIndex = 3
        Me.tabConta.Text = "Contas Bancárias"
        Me.tabConta.UseVisualStyleBackColor = True
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.Location = New System.Drawing.Point(29, 316)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(1315, 405)
        Me.lvConsulta.TabIndex = 24
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'lblContas
        '
        Me.lblContas.AutoSize = True
        Me.lblContas.Location = New System.Drawing.Point(25, 277)
        Me.lblContas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContas.Name = "lblContas"
        Me.lblContas.Size = New System.Drawing.Size(78, 24)
        Me.lblContas.TabIndex = 13
        Me.lblContas.Text = "Contas:"
        '
        'gbDadosConta
        '
        Me.gbDadosConta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDadosConta.Controls.Add(Me.txtBanco)
        Me.gbDadosConta.Controls.Add(Me.lblTipoConta)
        Me.gbDadosConta.Controls.Add(Me.lblBanco)
        Me.gbDadosConta.Controls.Add(Me.txtTipoConta)
        Me.gbDadosConta.Controls.Add(Me.lblAgencia)
        Me.gbDadosConta.Controls.Add(Me.txtSaldo)
        Me.gbDadosConta.Controls.Add(Me.lblConta)
        Me.gbDadosConta.Controls.Add(Me.txtConta)
        Me.gbDadosConta.Controls.Add(Me.lblSaldo)
        Me.gbDadosConta.Controls.Add(Me.txtAgencia)
        Me.gbDadosConta.Location = New System.Drawing.Point(29, 19)
        Me.gbDadosConta.Name = "gbDadosConta"
        Me.gbDadosConta.Size = New System.Drawing.Size(1315, 223)
        Me.gbDadosConta.TabIndex = 0
        Me.gbDadosConta.TabStop = False
        Me.gbDadosConta.Text = "Dados da Conta"
        '
        'txtBanco
        '
        Me.txtBanco.Alterado = False
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtBanco.Location = New System.Drawing.Point(31, 63)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(452, 32)
        Me.txtBanco.SuperMascara = ""
        Me.txtBanco.SuperObrigatorio = False
        Me.txtBanco.SuperTravaErrors = False
        Me.txtBanco.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtBanco.SuperTxtObrigatorio = ""
        Me.txtBanco.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtBanco.TabIndex = 15
        '
        'lblTipoConta
        '
        Me.lblTipoConta.AutoSize = True
        Me.lblTipoConta.Location = New System.Drawing.Point(537, 37)
        Me.lblTipoConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoConta.Name = "lblTipoConta"
        Me.lblTipoConta.Size = New System.Drawing.Size(56, 24)
        Me.lblTipoConta.TabIndex = 24
        Me.lblTipoConta.Text = "Tipo:"
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(27, 38)
        Me.lblBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(71, 24)
        Me.lblBanco.TabIndex = 14
        Me.lblBanco.Text = "Banco:"
        '
        'txtTipoConta
        '
        Me.txtTipoConta.Alterado = False
        Me.txtTipoConta.BackColor = System.Drawing.Color.White
        Me.txtTipoConta.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTipoConta.Location = New System.Drawing.Point(541, 63)
        Me.txtTipoConta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoConta.Name = "txtTipoConta"
        Me.txtTipoConta.Size = New System.Drawing.Size(201, 32)
        Me.txtTipoConta.SuperMascara = ""
        Me.txtTipoConta.SuperObrigatorio = False
        Me.txtTipoConta.SuperTravaErrors = False
        Me.txtTipoConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTipoConta.SuperTxtObrigatorio = ""
        Me.txtTipoConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTipoConta.TabIndex = 22
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Location = New System.Drawing.Point(27, 139)
        Me.lblAgencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(87, 24)
        Me.lblAgencia.TabIndex = 16
        Me.lblAgencia.Text = "Agência:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Alterado = False
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtSaldo.Location = New System.Drawing.Point(541, 164)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(201, 32)
        Me.txtSaldo.SuperMascara = "0,00"
        Me.txtSaldo.SuperObrigatorio = False
        Me.txtSaldo.SuperTravaErrors = False
        Me.txtSaldo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtSaldo.SuperTxtObrigatorio = ""
        Me.txtSaldo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtSaldo.TabIndex = 21
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(277, 136)
        Me.lblConta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(69, 24)
        Me.lblConta.TabIndex = 19
        Me.lblConta.Text = "Conta:"
        '
        'txtConta
        '
        Me.txtConta.Alterado = False
        Me.txtConta.BackColor = System.Drawing.Color.White
        Me.txtConta.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtConta.Location = New System.Drawing.Point(281, 164)
        Me.txtConta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(201, 32)
        Me.txtConta.SuperMascara = ""
        Me.txtConta.SuperObrigatorio = False
        Me.txtConta.SuperTravaErrors = False
        Me.txtConta.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtConta.SuperTxtObrigatorio = ""
        Me.txtConta.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtConta.TabIndex = 18
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(537, 136)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(66, 24)
        Me.lblSaldo.TabIndex = 20
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtAgencia
        '
        Me.txtAgencia.Alterado = False
        Me.txtAgencia.BackColor = System.Drawing.Color.White
        Me.txtAgencia.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtAgencia.Location = New System.Drawing.Point(31, 167)
        Me.txtAgencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(201, 32)
        Me.txtAgencia.SuperMascara = ""
        Me.txtAgencia.SuperObrigatorio = False
        Me.txtAgencia.SuperTravaErrors = False
        Me.txtAgencia.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtAgencia.SuperTxtObrigatorio = ""
        Me.txtAgencia.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtAgencia.TabIndex = 17
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnAddConta)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(3, 717)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1357, 101)
        Me.gbBotoes.TabIndex = 23
        Me.gbBotoes.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.BackgroundImage = CType(resources.GetObject("btnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(577, 12)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(183, 49)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "  &Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAddConta
        '
        Me.btnAddConta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddConta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddConta.BackgroundImage = CType(resources.GetObject("btnAddConta.BackgroundImage"), System.Drawing.Image)
        Me.btnAddConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddConta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddConta.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAddConta.ForeColor = System.Drawing.Color.Black
        Me.btnAddConta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAddConta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddConta.Location = New System.Drawing.Point(195, 12)
        Me.btnAddConta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddConta.Name = "btnAddConta"
        Me.btnAddConta.Size = New System.Drawing.Size(183, 49)
        Me.btnAddConta.TabIndex = 10
        Me.btnAddConta.Text = "  &Conta"
        Me.btnAddConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddConta.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.BackgroundImage = CType(resources.GetObject("btnPesquisar.BackgroundImage"), System.Drawing.Image)
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnPesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.Icon_search
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.Location = New System.Drawing.Point(5, 12)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(183, 49)
        Me.btnPesquisar.TabIndex = 1
        Me.btnPesquisar.Text = "  &Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.Location = New System.Drawing.Point(386, 12)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(183, 49)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "  &Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'tabCategoriaDespesa
        '
        Me.tabCategoriaDespesa.Controls.Add(Me.gbCadastroDespesa)
        Me.tabCategoriaDespesa.Controls.Add(Me.gbTodasDespesa)
        Me.tabCategoriaDespesa.ImageIndex = 3
        Me.tabCategoriaDespesa.Location = New System.Drawing.Point(4, 118)
        Me.tabCategoriaDespesa.Name = "tabCategoriaDespesa"
        Me.tabCategoriaDespesa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCategoriaDespesa.Size = New System.Drawing.Size(1363, 821)
        Me.tabCategoriaDespesa.TabIndex = 1
        Me.tabCategoriaDespesa.Text = "Categorias de Despesa"
        Me.tabCategoriaDespesa.UseVisualStyleBackColor = True
        '
        'gbCadastroDespesa
        '
        Me.gbCadastroDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCadastroDespesa.Controls.Add(Me.lblCategoriaDespesa)
        Me.gbCadastroDespesa.Controls.Add(Me.txtNovaCategoriaDespesa)
        Me.gbCadastroDespesa.Controls.Add(Me.btnAdd)
        Me.gbCadastroDespesa.Location = New System.Drawing.Point(46, 30)
        Me.gbCadastroDespesa.Name = "gbCadastroDespesa"
        Me.gbCadastroDespesa.Size = New System.Drawing.Size(1268, 110)
        Me.gbCadastroDespesa.TabIndex = 8
        Me.gbCadastroDespesa.TabStop = False
        Me.gbCadastroDespesa.Text = "Cadastrar"
        '
        'lblCategoriaDespesa
        '
        Me.lblCategoriaDespesa.AutoSize = True
        Me.lblCategoriaDespesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoriaDespesa.Location = New System.Drawing.Point(76, 27)
        Me.lblCategoriaDespesa.Name = "lblCategoriaDespesa"
        Me.lblCategoriaDespesa.Size = New System.Drawing.Size(121, 20)
        Me.lblCategoriaDespesa.TabIndex = 1
        Me.lblCategoriaDespesa.Text = "Nova categoria"
        '
        'txtNovaCategoriaDespesa
        '
        Me.txtNovaCategoriaDespesa.Alterado = False
        Me.txtNovaCategoriaDespesa.BackColor = System.Drawing.Color.White
        Me.txtNovaCategoriaDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaCategoriaDespesa.Location = New System.Drawing.Point(80, 50)
        Me.txtNovaCategoriaDespesa.Multiline = True
        Me.txtNovaCategoriaDespesa.Name = "txtNovaCategoriaDespesa"
        Me.txtNovaCategoriaDespesa.Size = New System.Drawing.Size(214, 38)
        Me.txtNovaCategoriaDespesa.SuperMascara = ""
        Me.txtNovaCategoriaDespesa.SuperObrigatorio = True
        Me.txtNovaCategoriaDespesa.SuperTravaErrors = False
        Me.txtNovaCategoriaDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaCategoriaDespesa.SuperTxtObrigatorio = "É necessário informar uma  categoria para cadastrar."
        Me.txtNovaCategoriaDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaCategoriaDespesa.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAdd.Location = New System.Drawing.Point(335, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(174, 48)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gbTodasDespesa
        '
        Me.gbTodasDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTodasDespesa.Controls.Add(Me.gbBotoesCategoriaDespesa)
        Me.gbTodasDespesa.Controls.Add(Me.lvCategoriaDespesa)
        Me.gbTodasDespesa.Location = New System.Drawing.Point(46, 159)
        Me.gbTodasDespesa.Name = "gbTodasDespesa"
        Me.gbTodasDespesa.Size = New System.Drawing.Size(1268, 434)
        Me.gbTodasDespesa.TabIndex = 7
        Me.gbTodasDespesa.TabStop = False
        Me.gbTodasDespesa.Text = "Todos"
        '
        'gbBotoesCategoriaDespesa
        '
        Me.gbBotoesCategoriaDespesa.Controls.Add(Me.btnEditarDespesa)
        Me.gbBotoesCategoriaDespesa.Controls.Add(Me.btnExcluirDespesa)
        Me.gbBotoesCategoriaDespesa.Location = New System.Drawing.Point(368, 30)
        Me.gbBotoesCategoriaDespesa.Name = "gbBotoesCategoriaDespesa"
        Me.gbBotoesCategoriaDespesa.Size = New System.Drawing.Size(87, 156)
        Me.gbBotoesCategoriaDespesa.TabIndex = 3
        Me.gbBotoesCategoriaDespesa.TabStop = False
        '
        'btnEditarDespesa
        '
        Me.btnEditarDespesa.FlatAppearance.BorderSize = 0
        Me.btnEditarDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditarDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarDespesa.Image = CType(resources.GetObject("btnEditarDespesa.Image"), System.Drawing.Image)
        Me.btnEditarDespesa.Location = New System.Drawing.Point(6, 13)
        Me.btnEditarDespesa.Name = "btnEditarDespesa"
        Me.btnEditarDespesa.Size = New System.Drawing.Size(75, 71)
        Me.btnEditarDespesa.TabIndex = 1
        Me.btnEditarDespesa.UseVisualStyleBackColor = True
        '
        'btnExcluirDespesa
        '
        Me.btnExcluirDespesa.FlatAppearance.BorderSize = 0
        Me.btnExcluirDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnExcluirDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExcluirDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirDespesa.Image = CType(resources.GetObject("btnExcluirDespesa.Image"), System.Drawing.Image)
        Me.btnExcluirDespesa.Location = New System.Drawing.Point(6, 90)
        Me.btnExcluirDespesa.Name = "btnExcluirDespesa"
        Me.btnExcluirDespesa.Size = New System.Drawing.Size(67, 60)
        Me.btnExcluirDespesa.TabIndex = 2
        Me.btnExcluirDespesa.UseVisualStyleBackColor = True
        '
        'lvCategoriaDespesa
        '
        Me.lvCategoriaDespesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCategoriaDespesa.HabilitaOrdem = True
        Me.lvCategoriaDespesa.HideSelection = False
        Me.lvCategoriaDespesa.Location = New System.Drawing.Point(20, 40)
        Me.lvCategoriaDespesa.Name = "lvCategoriaDespesa"
        Me.lvCategoriaDespesa.SelecionaVarios = False
        Me.lvCategoriaDespesa.Size = New System.Drawing.Size(342, 371)
        Me.lvCategoriaDespesa.TabIndex = 0
        Me.lvCategoriaDespesa.UseCompatibleStateImageBehavior = False
        '
        'tabFormaPagamento
        '
        Me.tabFormaPagamento.Controls.Add(Me.gbCadastroPagamento)
        Me.tabFormaPagamento.Controls.Add(Me.gbConsultaPagamento)
        Me.tabFormaPagamento.ImageIndex = 7
        Me.tabFormaPagamento.Location = New System.Drawing.Point(4, 118)
        Me.tabFormaPagamento.Name = "tabFormaPagamento"
        Me.tabFormaPagamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFormaPagamento.Size = New System.Drawing.Size(1363, 821)
        Me.tabFormaPagamento.TabIndex = 2
        Me.tabFormaPagamento.Text = "Formas de Pagamento"
        Me.tabFormaPagamento.UseVisualStyleBackColor = True
        '
        'gbCadastroPagamento
        '
        Me.gbCadastroPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCadastroPagamento.Controls.Add(Me.lblFormaPagamento)
        Me.gbCadastroPagamento.Controls.Add(Me.txtNovaFormaPag)
        Me.gbCadastroPagamento.Controls.Add(Me.btnAddPag)
        Me.gbCadastroPagamento.Location = New System.Drawing.Point(32, 22)
        Me.gbCadastroPagamento.Name = "gbCadastroPagamento"
        Me.gbCadastroPagamento.Size = New System.Drawing.Size(1268, 110)
        Me.gbCadastroPagamento.TabIndex = 10
        Me.gbCadastroPagamento.TabStop = False
        Me.gbCadastroPagamento.Text = "Cadastrar"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPagamento.Location = New System.Drawing.Point(76, 27)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(205, 20)
        Me.lblFormaPagamento.TabIndex = 1
        Me.lblFormaPagamento.Text = "Nova forma de pagamento"
        '
        'txtNovaFormaPag
        '
        Me.txtNovaFormaPag.Alterado = False
        Me.txtNovaFormaPag.BackColor = System.Drawing.Color.White
        Me.txtNovaFormaPag.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaFormaPag.Location = New System.Drawing.Point(80, 50)
        Me.txtNovaFormaPag.Multiline = True
        Me.txtNovaFormaPag.Name = "txtNovaFormaPag"
        Me.txtNovaFormaPag.Size = New System.Drawing.Size(214, 38)
        Me.txtNovaFormaPag.SuperMascara = ""
        Me.txtNovaFormaPag.SuperObrigatorio = True
        Me.txtNovaFormaPag.SuperTravaErrors = False
        Me.txtNovaFormaPag.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaFormaPag.SuperTxtObrigatorio = "Nova Forma de pagamento"
        Me.txtNovaFormaPag.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaFormaPag.TabIndex = 0
        '
        'btnAddPag
        '
        Me.btnAddPag.BackColor = System.Drawing.Color.Transparent
        Me.btnAddPag.BackgroundImage = CType(resources.GetObject("btnAddPag.BackgroundImage"), System.Drawing.Image)
        Me.btnAddPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddPag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPag.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAddPag.ForeColor = System.Drawing.Color.Black
        Me.btnAddPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAddPag.Location = New System.Drawing.Point(335, 41)
        Me.btnAddPag.Name = "btnAddPag"
        Me.btnAddPag.Size = New System.Drawing.Size(174, 48)
        Me.btnAddPag.TabIndex = 3
        Me.btnAddPag.Text = "Adicionar"
        Me.btnAddPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPag.UseVisualStyleBackColor = False
        '
        'gbConsultaPagamento
        '
        Me.gbConsultaPagamento.Controls.Add(Me.gbBotoesPagamento)
        Me.gbConsultaPagamento.Controls.Add(Me.lvFormaPagamento)
        Me.gbConsultaPagamento.Location = New System.Drawing.Point(32, 151)
        Me.gbConsultaPagamento.Name = "gbConsultaPagamento"
        Me.gbConsultaPagamento.Size = New System.Drawing.Size(1268, 447)
        Me.gbConsultaPagamento.TabIndex = 9
        Me.gbConsultaPagamento.TabStop = False
        Me.gbConsultaPagamento.Text = "Todos"
        '
        'gbBotoesPagamento
        '
        Me.gbBotoesPagamento.Controls.Add(Me.btnEditarPag)
        Me.gbBotoesPagamento.Controls.Add(Me.btnExcluirPag)
        Me.gbBotoesPagamento.Location = New System.Drawing.Point(387, 31)
        Me.gbBotoesPagamento.Name = "gbBotoesPagamento"
        Me.gbBotoesPagamento.Size = New System.Drawing.Size(89, 147)
        Me.gbBotoesPagamento.TabIndex = 9
        Me.gbBotoesPagamento.TabStop = False
        '
        'btnEditarPag
        '
        Me.btnEditarPag.FlatAppearance.BorderSize = 0
        Me.btnEditarPag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditarPag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEditarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditarPag.Location = New System.Drawing.Point(6, 16)
        Me.btnEditarPag.Name = "btnEditarPag"
        Me.btnEditarPag.Size = New System.Drawing.Size(72, 59)
        Me.btnEditarPag.TabIndex = 6
        Me.btnEditarPag.UseVisualStyleBackColor = True
        '
        'btnExcluirPag
        '
        Me.btnExcluirPag.FlatAppearance.BorderSize = 0
        Me.btnExcluirPag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnExcluirPag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExcluirPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnExcluirPag.Location = New System.Drawing.Point(6, 81)
        Me.btnExcluirPag.Name = "btnExcluirPag"
        Me.btnExcluirPag.Size = New System.Drawing.Size(72, 61)
        Me.btnExcluirPag.TabIndex = 8
        Me.btnExcluirPag.UseVisualStyleBackColor = True
        '
        'lvFormaPagamento
        '
        Me.lvFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFormaPagamento.HabilitaOrdem = True
        Me.lvFormaPagamento.HideSelection = False
        Me.lvFormaPagamento.Location = New System.Drawing.Point(28, 42)
        Me.lvFormaPagamento.Name = "lvFormaPagamento"
        Me.lvFormaPagamento.SelecionaVarios = False
        Me.lvFormaPagamento.Size = New System.Drawing.Size(342, 377)
        Me.lvFormaPagamento.TabIndex = 0
        Me.lvFormaPagamento.UseCompatibleStateImageBehavior = False
        Me.lvFormaPagamento.View = System.Windows.Forms.View.List
        '
        'tabParcelamento
        '
        Me.tabParcelamento.Controls.Add(Me.GroupBox2)
        Me.tabParcelamento.Controls.Add(Me.GroupBox1)
        Me.tabParcelamento.ImageIndex = 1
        Me.tabParcelamento.Location = New System.Drawing.Point(4, 118)
        Me.tabParcelamento.Name = "tabParcelamento"
        Me.tabParcelamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParcelamento.Size = New System.Drawing.Size(1363, 821)
        Me.tabParcelamento.TabIndex = 4
        Me.tabParcelamento.Text = "Parcelamento"
        Me.tabParcelamento.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnExcluirParcela)
        Me.GroupBox2.Controls.Add(Me.btnSalvarParcela)
        Me.GroupBox2.Controls.Add(Me.lvParcela)
        Me.GroupBox2.Location = New System.Drawing.Point(41, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 341)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Todos"
        '
        'btnExcluirParcela
        '
        Me.btnExcluirParcela.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnExcluirParcela.FlatAppearance.BorderSize = 0
        Me.btnExcluirParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnExcluirParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnExcluirParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirParcela.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExcluirParcela.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnExcluirParcela.Location = New System.Drawing.Point(276, 257)
        Me.btnExcluirParcela.Name = "btnExcluirParcela"
        Me.btnExcluirParcela.Size = New System.Drawing.Size(199, 54)
        Me.btnExcluirParcela.TabIndex = 3
        Me.btnExcluirParcela.Text = " &Excluir"
        Me.btnExcluirParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluirParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluirParcela.UseVisualStyleBackColor = False
        '
        'btnSalvarParcela
        '
        Me.btnSalvarParcela.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSalvarParcela.FlatAppearance.BorderSize = 0
        Me.btnSalvarParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvarParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnSalvarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarParcela.ForeColor = System.Drawing.Color.Black
        Me.btnSalvarParcela.Image = Global.GerenciamentoFinanças.My.Resources.Resources.icon_Salvar_png
        Me.btnSalvarParcela.Location = New System.Drawing.Point(32, 257)
        Me.btnSalvarParcela.Name = "btnSalvarParcela"
        Me.btnSalvarParcela.Size = New System.Drawing.Size(199, 54)
        Me.btnSalvarParcela.TabIndex = 3
        Me.btnSalvarParcela.Text = " &Salvar"
        Me.btnSalvarParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvarParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarParcela.UseVisualStyleBackColor = False
        '
        'lvParcela
        '
        Me.lvParcela.HabilitaOrdem = True
        Me.lvParcela.HideSelection = False
        Me.lvParcela.Location = New System.Drawing.Point(32, 40)
        Me.lvParcela.Name = "lvParcela"
        Me.lvParcela.SelecionaVarios = False
        Me.lvParcela.Size = New System.Drawing.Size(342, 211)
        Me.lvParcela.TabIndex = 0
        Me.lvParcela.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCadastrarParc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQtdeParcela)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 138)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametrização"
        '
        'btnCadastrarParc
        '
        Me.btnCadastrarParc.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCadastrarParc.FlatAppearance.BorderSize = 0
        Me.btnCadastrarParc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCadastrarParc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnCadastrarParc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarParc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarParc.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarParc.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnCadastrarParc.Location = New System.Drawing.Point(403, 59)
        Me.btnCadastrarParc.Name = "btnCadastrarParc"
        Me.btnCadastrarParc.Size = New System.Drawing.Size(199, 54)
        Me.btnCadastrarParc.TabIndex = 2
        Me.btnCadastrarParc.Text = " &Cadastrar"
        Me.btnCadastrarParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrarParc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrarParc.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade de Parcelas:"
        '
        'txtQtdeParcela
        '
        Me.txtQtdeParcela.Alterado = False
        Me.txtQtdeParcela.BackColor = System.Drawing.Color.White
        Me.txtQtdeParcela.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtQtdeParcela.Location = New System.Drawing.Point(274, 68)
        Me.txtQtdeParcela.Name = "txtQtdeParcela"
        Me.txtQtdeParcela.Size = New System.Drawing.Size(100, 32)
        Me.txtQtdeParcela.SuperMascara = ""
        Me.txtQtdeParcela.SuperObrigatorio = False
        Me.txtQtdeParcela.SuperTravaErrors = False
        Me.txtQtdeParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtQtdeParcela.SuperTxtObrigatorio = ""
        Me.txtQtdeParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtQtdeParcela.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.gbAddReceita)
        Me.TabPage1.ImageIndex = 8
        Me.TabPage1.Location = New System.Drawing.Point(4, 118)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1363, 821)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Categorias de Receita"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gbBotoesReceita)
        Me.GroupBox4.Controls.Add(Me.lvReceita)
        Me.GroupBox4.Location = New System.Drawing.Point(45, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1068, 385)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Todos"
        '
        'gbBotoesReceita
        '
        Me.gbBotoesReceita.Controls.Add(Me.btnEditarReceita)
        Me.gbBotoesReceita.Controls.Add(Me.btnExcluirReceita)
        Me.gbBotoesReceita.Location = New System.Drawing.Point(378, 41)
        Me.gbBotoesReceita.Name = "gbBotoesReceita"
        Me.gbBotoesReceita.Size = New System.Drawing.Size(87, 156)
        Me.gbBotoesReceita.TabIndex = 4
        Me.gbBotoesReceita.TabStop = False
        '
        'btnEditarReceita
        '
        Me.btnEditarReceita.FlatAppearance.BorderSize = 0
        Me.btnEditarReceita.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditarReceita.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarReceita.Image = CType(resources.GetObject("btnEditarReceita.Image"), System.Drawing.Image)
        Me.btnEditarReceita.Location = New System.Drawing.Point(6, 13)
        Me.btnEditarReceita.Name = "btnEditarReceita"
        Me.btnEditarReceita.Size = New System.Drawing.Size(75, 71)
        Me.btnEditarReceita.TabIndex = 1
        Me.btnEditarReceita.UseVisualStyleBackColor = True
        '
        'btnExcluirReceita
        '
        Me.btnExcluirReceita.FlatAppearance.BorderSize = 0
        Me.btnExcluirReceita.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnExcluirReceita.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExcluirReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirReceita.Image = CType(resources.GetObject("btnExcluirReceita.Image"), System.Drawing.Image)
        Me.btnExcluirReceita.Location = New System.Drawing.Point(6, 90)
        Me.btnExcluirReceita.Name = "btnExcluirReceita"
        Me.btnExcluirReceita.Size = New System.Drawing.Size(67, 60)
        Me.btnExcluirReceita.TabIndex = 2
        Me.btnExcluirReceita.UseVisualStyleBackColor = True
        '
        'lvReceita
        '
        Me.lvReceita.HabilitaOrdem = True
        Me.lvReceita.HideSelection = False
        Me.lvReceita.Location = New System.Drawing.Point(32, 51)
        Me.lvReceita.Name = "lvReceita"
        Me.lvReceita.SelecionaVarios = False
        Me.lvReceita.Size = New System.Drawing.Size(342, 300)
        Me.lvReceita.TabIndex = 0
        Me.lvReceita.UseCompatibleStateImageBehavior = False
        '
        'gbAddReceita
        '
        Me.gbAddReceita.Controls.Add(Me.btnAdicionarReceita)
        Me.gbAddReceita.Controls.Add(Me.Label2)
        Me.gbAddReceita.Controls.Add(Me.txtNovaReceita)
        Me.gbAddReceita.Location = New System.Drawing.Point(45, 24)
        Me.gbAddReceita.Name = "gbAddReceita"
        Me.gbAddReceita.Size = New System.Drawing.Size(1068, 143)
        Me.gbAddReceita.TabIndex = 0
        Me.gbAddReceita.TabStop = False
        Me.gbAddReceita.Text = "Cadastro"
        '
        'btnAdicionarReceita
        '
        Me.btnAdicionarReceita.Location = New System.Drawing.Point(458, 82)
        Me.btnAdicionarReceita.Name = "btnAdicionarReceita"
        Me.btnAdicionarReceita.Size = New System.Drawing.Size(173, 32)
        Me.btnAdicionarReceita.TabIndex = 2
        Me.btnAdicionarReceita.Text = "Adicionar"
        Me.btnAdicionarReceita.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nova categoria"
        '
        'txtNovaReceita
        '
        Me.txtNovaReceita.Alterado = False
        Me.txtNovaReceita.BackColor = System.Drawing.Color.White
        Me.txtNovaReceita.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaReceita.Location = New System.Drawing.Point(51, 82)
        Me.txtNovaReceita.Name = "txtNovaReceita"
        Me.txtNovaReceita.Size = New System.Drawing.Size(401, 32)
        Me.txtNovaReceita.SuperMascara = ""
        Me.txtNovaReceita.SuperObrigatorio = True
        Me.txtNovaReceita.SuperTravaErrors = False
        Me.txtNovaReceita.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaReceita.SuperTxtObrigatorio = "Nova Categoria"
        Me.txtNovaReceita.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaReceita.TabIndex = 0
        '
        'frmConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 943)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabCtrlConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConfiguracao"
        Me.Text = "frmConfiguracao"
        Me.tabCtrlConfig.ResumeLayout(False)
        Me.tabConta.ResumeLayout(False)
        Me.tabConta.PerformLayout()
        Me.gbDadosConta.ResumeLayout(False)
        Me.gbDadosConta.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCategoriaDespesa.ResumeLayout(False)
        Me.gbCadastroDespesa.ResumeLayout(False)
        Me.gbCadastroDespesa.PerformLayout()
        Me.gbTodasDespesa.ResumeLayout(False)
        Me.gbBotoesCategoriaDespesa.ResumeLayout(False)
        Me.tabFormaPagamento.ResumeLayout(False)
        Me.gbCadastroPagamento.ResumeLayout(False)
        Me.gbCadastroPagamento.PerformLayout()
        Me.gbConsultaPagamento.ResumeLayout(False)
        Me.gbBotoesPagamento.ResumeLayout(False)
        Me.tabParcelamento.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gbBotoesReceita.ResumeLayout(False)
        Me.gbAddReceita.ResumeLayout(False)
        Me.gbAddReceita.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCtrlConfig As GFT.Util.SuperTabControl
    Friend WithEvents tabCategoriaDespesa As TabPage
    Friend WithEvents gbCadastroDespesa As GroupBox
    Friend WithEvents lblCategoriaDespesa As Label
    Friend WithEvents txtNovaCategoriaDespesa As GFT.Util.SuperTextBox
    Friend WithEvents btnAdd As GFT.Util.SuperButton
    Friend WithEvents gbTodasDespesa As GroupBox
    Friend WithEvents lvCategoriaDespesa As GFT.Util.SuperLV
    Friend WithEvents tabFormaPagamento As TabPage
    Friend WithEvents gbCadastroPagamento As GroupBox
    Friend WithEvents lblFormaPagamento As Label
    Friend WithEvents txtNovaFormaPag As GFT.Util.SuperTextBox
    Friend WithEvents btnAddPag As GFT.Util.SuperButton
    Friend WithEvents gbConsultaPagamento As GroupBox
    Friend WithEvents lvFormaPagamento As GFT.Util.SuperLV
    Friend WithEvents btnEditarPag As Button
    Friend WithEvents btnExcluirPag As Button
    Friend WithEvents btnExcluirDespesa As Button
    Friend WithEvents btnEditarDespesa As Button
    Friend WithEvents gbBotoesCategoriaDespesa As GroupBox
    Friend WithEvents gbBotoesPagamento As GroupBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnFechar As Button
    Friend WithEvents tabConta As TabPage
    Friend WithEvents gbDadosConta As GroupBox
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnExcluir As GFT.Util.SuperButton
    Friend WithEvents btnAddConta As GFT.Util.SuperButton
    Friend WithEvents btnPesquisar As GFT.Util.SuperButton
    Friend WithEvents btnEditar As GFT.Util.SuperButton
    Friend WithEvents lblContas As Label
    Friend WithEvents txtBanco As GFT.Util.SuperTextBox
    Friend WithEvents lblTipoConta As Label
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtTipoConta As GFT.Util.SuperTextBox
    Friend WithEvents lblAgencia As Label
    Friend WithEvents txtSaldo As GFT.Util.SuperTextBox
    Friend WithEvents lblConta As Label
    Friend WithEvents txtConta As GFT.Util.SuperTextBox
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtAgencia As GFT.Util.SuperTextBox
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents tabParcelamento As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalvarParcela As Button
    Friend WithEvents lvParcela As GFT.Util.SuperLV
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCadastrarParc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQtdeParcela As GFT.Util.SuperTextBox
    Friend WithEvents btnExcluirParcela As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbBotoesReceita As GroupBox
    Friend WithEvents btnEditarReceita As Button
    Friend WithEvents btnExcluirReceita As Button
    Friend WithEvents lvReceita As GFT.Util.SuperLV
    Friend WithEvents gbAddReceita As GroupBox
    Friend WithEvents btnAdicionarReceita As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNovaReceita As GFT.Util.SuperTextBox
End Class
