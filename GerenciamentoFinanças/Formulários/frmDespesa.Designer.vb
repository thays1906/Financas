<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespesa))
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnStatusPago = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnExcluir = New GFT.Util.SuperButton()
        Me.btnExportar = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.btnAddDespesa = New GFT.Util.SuperButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCtrlDespesa = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.txtTotalDespesa = New GFT.Util.SuperTextBox()
        Me.tabDespesaFixa = New System.Windows.Forms.TabPage()
        Me.tabDetalhe = New System.Windows.Forms.TabPage()
        Me.SuperGroupBox1 = New GFT.Util.SuperGroupBox()
        Me.dtDespesaDetalhe = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtTitulo = New GFT.Util.SuperTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtValor3 = New GFT.Util.SuperTextBox()
        Me.txtValor4 = New GFT.Util.SuperTextBox()
        Me.txtValor1 = New GFT.Util.SuperTextBox()
        Me.txtValor2 = New GFT.Util.SuperTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.gbBotoes.SuspendLayout()
        Me.tabCtrlDespesa.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.tabDetalhe.SuspendLayout()
        Me.SuperGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnStatusPago)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnAddDespesa)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 549)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1088, 73)
        Me.gbBotoes.TabIndex = 9
        Me.gbBotoes.TabStop = False
        '
        'btnStatusPago
        '
        Me.btnStatusPago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStatusPago.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStatusPago.BackgroundImage = CType(resources.GetObject("btnStatusPago.BackgroundImage"), System.Drawing.Image)
        Me.btnStatusPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStatusPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStatusPago.Enabled = False
        Me.btnStatusPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStatusPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusPago.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnStatusPago.ForeColor = System.Drawing.Color.Black
        Me.btnStatusPago.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.btnStatusPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStatusPago.Location = New System.Drawing.Point(648, 19)
        Me.btnStatusPago.Name = "btnStatusPago"
        Me.btnStatusPago.Size = New System.Drawing.Size(156, 45)
        Me.btnStatusPago.TabIndex = 13
        Me.btnStatusPago.Text = "  &Pagar"
        Me.btnStatusPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusPago.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.BackColor = System.Drawing.Color.Transparent
        Me.btnFechar.BackgroundImage = CType(resources.GetObject("btnFechar.BackgroundImage"), System.Drawing.Image)
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.Location = New System.Drawing.Point(972, 19)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(156, 45)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.BackgroundImage = CType(resources.GetObject("btnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(486, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(156, 45)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "  &Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.BackColor = System.Drawing.Color.Transparent
        Me.btnExportar.BackgroundImage = CType(resources.GetObject("btnExportar.BackgroundImage"), System.Drawing.Image)
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnExportar.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnExportar.Location = New System.Drawing.Point(810, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(156, 45)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "  &Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
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
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.Location = New System.Drawing.Point(0, 19)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(156, 44)
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
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.Location = New System.Drawing.Point(324, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(156, 45)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "  &Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAddDespesa
        '
        Me.btnAddDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddDespesa.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddDespesa.BackgroundImage = CType(resources.GetObject("btnAddDespesa.BackgroundImage"), System.Drawing.Image)
        Me.btnAddDespesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddDespesa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDespesa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDespesa.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAddDespesa.ForeColor = System.Drawing.Color.Black
        Me.btnAddDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAddDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDespesa.Location = New System.Drawing.Point(162, 19)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(156, 45)
        Me.btnAddDespesa.TabIndex = 10
        Me.btnAddDespesa.Text = "  &Despesa"
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconMoneyRed.fw.png")
        Me.ImageList1.Images.SetKeyName(1, "Files_26987.png")
        Me.ImageList1.Images.SetKeyName(2, "iconRotacao.png")
        Me.ImageList1.Images.SetKeyName(3, "iconCalandar.png")
        Me.ImageList1.Images.SetKeyName(4, "Files_26987 (1).png")
        '
        'tabCtrlDespesa
        '
        Me.tabCtrlDespesa.Controls.Add(Me.tpPesquisa)
        Me.tabCtrlDespesa.Controls.Add(Me.tabDespesaFixa)
        Me.tabCtrlDespesa.Controls.Add(Me.tabDetalhe)
        Me.tabCtrlDespesa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlDespesa.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlDespesa.ImageList = Me.ImageList1
        Me.tabCtrlDespesa.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlDespesa.Name = "tabCtrlDespesa"
        Me.tabCtrlDespesa.Padding = New System.Drawing.Point(50, 6)
        Me.tabCtrlDespesa.SelectedIndex = 0
        Me.tabCtrlDespesa.Size = New System.Drawing.Size(1088, 549)
        Me.tabCtrlDespesa.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Button4)
        Me.tpPesquisa.Controls.Add(Me.Label4)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Controls.Add(Me.txtTotalDespesa)
        Me.tpPesquisa.ImageIndex = 0
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1080, 484)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Despesas"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(765, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total de Despesas:"
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.Controls.Add(Me.lblMes)
        Me.gbFiltro.Controls.Add(Me.cbMes)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.cbStatusFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(8, 8)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(1064, 83)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(262, 26)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(39, 17)
        Me.lblMes.TabIndex = 10
        Me.lblMes.Text = "Mês:"
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.CorFundo = System.Drawing.Color.White
        Me.cbMes.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbMes.CorTexto = System.Drawing.Color.Black
        Me.cbMes.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(265, 46)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(251, 25)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'cbStatusFiltro
        '
        Me.cbStatusFiltro.Alterado = False
        Me.cbStatusFiltro.CorFundo = System.Drawing.Color.White
        Me.cbStatusFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatusFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbStatusFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatusFiltro.FormattingEnabled = True
        Me.cbStatusFiltro.Location = New System.Drawing.Point(17, 46)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(174, 25)
        Me.cbStatusFiltro.SuperObrigatorio = False
        Me.cbStatusFiltro.SuperTxtObrigatorio = ""
        Me.cbStatusFiltro.TabIndex = 7
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.Location = New System.Drawing.Point(8, 128)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = True
        Me.lvConsulta.Size = New System.Drawing.Size(1063, 361)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtTotalDespesa.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesa.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDespesa.Location = New System.Drawing.Point(905, 97)
        Me.txtTotalDespesa.Name = "txtTotalDespesa"
        Me.txtTotalDespesa.ReadOnly = True
        Me.txtTotalDespesa.Size = New System.Drawing.Size(167, 25)
        Me.txtTotalDespesa.SuperMascara = ""
        Me.txtTotalDespesa.SuperObrigatorio = False
        Me.txtTotalDespesa.SuperTravaErrors = False
        Me.txtTotalDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesa.SuperTxtObrigatorio = ""
        Me.txtTotalDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesa.TabIndex = 8
        Me.txtTotalDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tabDespesaFixa
        '
        Me.tabDespesaFixa.ImageIndex = 3
        Me.tabDespesaFixa.Location = New System.Drawing.Point(4, 61)
        Me.tabDespesaFixa.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDespesaFixa.Name = "tabDespesaFixa"
        Me.tabDespesaFixa.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDespesaFixa.Size = New System.Drawing.Size(1080, 484)
        Me.tabDespesaFixa.TabIndex = 2
        Me.tabDespesaFixa.Text = "Despesas Fixas"
        Me.tabDespesaFixa.UseVisualStyleBackColor = True
        '
        'tabDetalhe
        '
        Me.tabDetalhe.Controls.Add(Me.SuperGroupBox1)
        Me.tabDetalhe.ImageIndex = 4
        Me.tabDetalhe.Location = New System.Drawing.Point(4, 61)
        Me.tabDetalhe.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDetalhe.Name = "tabDetalhe"
        Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDetalhe.Size = New System.Drawing.Size(1080, 484)
        Me.tabDetalhe.TabIndex = 1
        Me.tabDetalhe.Text = "Detalhamento da Dívida"
        Me.tabDetalhe.UseVisualStyleBackColor = True
        '
        'SuperGroupBox1
        '
        Me.SuperGroupBox1.BorderCollor = System.Drawing.Color.Empty
        Me.SuperGroupBox1.Controls.Add(Me.dtDespesaDetalhe)
        Me.SuperGroupBox1.Controls.Add(Me.CheckBox1)
        Me.SuperGroupBox1.Controls.Add(Me.chk)
        Me.SuperGroupBox1.Controls.Add(Me.Button3)
        Me.SuperGroupBox1.Controls.Add(Me.txtTitulo)
        Me.SuperGroupBox1.Controls.Add(Me.Button2)
        Me.SuperGroupBox1.Controls.Add(Me.Button1)
        Me.SuperGroupBox1.Controls.Add(Me.txtValor3)
        Me.SuperGroupBox1.Controls.Add(Me.txtValor4)
        Me.SuperGroupBox1.Controls.Add(Me.txtValor1)
        Me.SuperGroupBox1.Controls.Add(Me.txtValor2)
        Me.SuperGroupBox1.Location = New System.Drawing.Point(29, 21)
        Me.SuperGroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperGroupBox1.Name = "SuperGroupBox1"
        Me.SuperGroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.SuperGroupBox1.Size = New System.Drawing.Size(1031, 354)
        Me.SuperGroupBox1.TabIndex = 0
        Me.SuperGroupBox1.TabStop = False
        Me.SuperGroupBox1.Text = "Dados da Despesa"
        '
        'dtDespesaDetalhe
        '
        Me.dtDespesaDetalhe.CalendarFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDespesaDetalhe.Enabled = False
        Me.dtDespesaDetalhe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDespesaDetalhe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDespesaDetalhe.Location = New System.Drawing.Point(30, 78)
        Me.dtDespesaDetalhe.Name = "dtDespesaDetalhe"
        Me.dtDespesaDetalhe.Size = New System.Drawing.Size(143, 26)
        Me.dtDespesaDetalhe.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.CheckBox1.FlatAppearance.BorderSize = 10
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(51, 185)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chk
        '
        Me.chk.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.chk.FlatAppearance.BorderSize = 10
        Me.chk.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk.Location = New System.Drawing.Point(51, 141)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(16, 16)
        Me.chk.TabIndex = 8
        Me.chk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chk.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.Button3.Location = New System.Drawing.Point(391, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 42)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = " &Pagar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Alterado = False
        Me.txtTitulo.BackColor = System.Drawing.Color.White
        Me.txtTitulo.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtTitulo.Location = New System.Drawing.Point(179, 78)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(523, 25)
        Me.txtTitulo.SuperMascara = ""
        Me.txtTitulo.SuperObrigatorio = False
        Me.txtTitulo.SuperTravaErrors = False
        Me.txtTitulo.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTitulo.SuperTxtObrigatorio = ""
        Me.txtTitulo.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTitulo.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.Button2.Location = New System.Drawing.Point(179, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 33)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.Button1.Location = New System.Drawing.Point(179, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtValor3
        '
        Me.txtValor3.Alterado = False
        Me.txtValor3.BackColor = System.Drawing.Color.White
        Me.txtValor3.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor3.Location = New System.Drawing.Point(531, 132)
        Me.txtValor3.Name = "txtValor3"
        Me.txtValor3.ReadOnly = True
        Me.txtValor3.Size = New System.Drawing.Size(100, 25)
        Me.txtValor3.SuperMascara = ""
        Me.txtValor3.SuperObrigatorio = False
        Me.txtValor3.SuperTravaErrors = False
        Me.txtValor3.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor3.SuperTxtObrigatorio = ""
        Me.txtValor3.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor3.TabIndex = 3
        '
        'txtValor4
        '
        Me.txtValor4.Alterado = False
        Me.txtValor4.BackColor = System.Drawing.Color.White
        Me.txtValor4.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor4.Location = New System.Drawing.Point(531, 176)
        Me.txtValor4.Name = "txtValor4"
        Me.txtValor4.ReadOnly = True
        Me.txtValor4.Size = New System.Drawing.Size(100, 25)
        Me.txtValor4.SuperMascara = ""
        Me.txtValor4.SuperObrigatorio = False
        Me.txtValor4.SuperTravaErrors = False
        Me.txtValor4.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor4.SuperTxtObrigatorio = ""
        Me.txtValor4.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor4.TabIndex = 2
        '
        'txtValor1
        '
        Me.txtValor1.Alterado = False
        Me.txtValor1.BackColor = System.Drawing.Color.White
        Me.txtValor1.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor1.Location = New System.Drawing.Point(73, 138)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.ReadOnly = True
        Me.txtValor1.Size = New System.Drawing.Size(100, 25)
        Me.txtValor1.SuperMascara = ""
        Me.txtValor1.SuperObrigatorio = False
        Me.txtValor1.SuperTravaErrors = False
        Me.txtValor1.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor1.SuperTxtObrigatorio = ""
        Me.txtValor1.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor1.TabIndex = 1
        '
        'txtValor2
        '
        Me.txtValor2.Alterado = False
        Me.txtValor2.BackColor = System.Drawing.Color.White
        Me.txtValor2.CorFundoSelecionado = System.Drawing.SystemColors.Control
        Me.txtValor2.Location = New System.Drawing.Point(531, 207)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.ReadOnly = True
        Me.txtValor2.Size = New System.Drawing.Size(100, 25)
        Me.txtValor2.SuperMascara = ""
        Me.txtValor2.SuperObrigatorio = False
        Me.txtValor2.SuperTravaErrors = False
        Me.txtValor2.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtValor2.SuperTxtObrigatorio = ""
        Me.txtValor2.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosReais
        Me.txtValor2.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(730, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1088, 622)
        Me.Controls.Add(Me.tabCtrlDespesa)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDespesa"
        Me.Text = "frmDespesa"
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCtrlDespesa.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.tabDetalhe.ResumeLayout(False)
        Me.SuperGroupBox1.ResumeLayout(False)
        Me.SuperGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabCtrlDespesa As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatusFiltro As GFT.Util.SuperComboBox
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnExcluir As GFT.Util.SuperButton
    Friend WithEvents btnAddDespesa As GFT.Util.SuperButton
    Friend WithEvents btnExportar As GFT.Util.SuperButton
    Friend WithEvents btnPesquisar As GFT.Util.SuperButton
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents btnEditar As GFT.Util.SuperButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDespesa As GFT.Util.SuperTextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnStatusPago As GFT.Util.SuperButton
    Friend WithEvents tabDetalhe As TabPage
    Friend WithEvents SuperGroupBox1 As GFT.Util.SuperGroupBox
    Friend WithEvents tabDespesaFixa As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chk As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtTitulo As GFT.Util.SuperTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtValor3 As GFT.Util.SuperTextBox
    Friend WithEvents txtValor4 As GFT.Util.SuperTextBox
    Friend WithEvents txtValor1 As GFT.Util.SuperTextBox
    Friend WithEvents txtValor2 As GFT.Util.SuperTextBox
    Friend WithEvents dtDespesaDetalhe As DateTimePicker
    Friend WithEvents Button4 As Button
End Class
