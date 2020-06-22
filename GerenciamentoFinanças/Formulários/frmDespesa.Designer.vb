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
        Me.gbDetalhe = New System.Windows.Forms.GroupBox()
        Me.gbDadosDetalhe = New System.Windows.Forms.GroupBox()
        Me.lblNaoPago = New System.Windows.Forms.Label()
        Me.txtPago = New GFT.Util.SuperTextBox()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.txtNaoPago = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalDespesaDetalhe = New GFT.Util.SuperTextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtDescriaoDetalhe = New GFT.Util.SuperTextBox()
        Me.pnlDetalhe = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuperLV1 = New GFT.Util.SuperLV()
        Me.gbBotoes.SuspendLayout()
        Me.tabCtrlDespesa.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.tabDespesaFixa.SuspendLayout()
        Me.tabDetalhe.SuspendLayout()
        Me.gbDetalhe.SuspendLayout()
        Me.gbDadosDetalhe.SuspendLayout()
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
        Me.gbBotoes.Location = New System.Drawing.Point(0, 504)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(1116, 100)
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
        Me.btnStatusPago.Location = New System.Drawing.Point(662, 19)
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
        Me.btnFechar.Location = New System.Drawing.Point(986, 19)
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
        Me.btnExcluir.Location = New System.Drawing.Point(500, 19)
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
        Me.btnExportar.Location = New System.Drawing.Point(824, 19)
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
        Me.btnPesquisar.Location = New System.Drawing.Point(14, 19)
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
        Me.btnEditar.Location = New System.Drawing.Point(338, 19)
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
        Me.btnAddDespesa.Location = New System.Drawing.Point(176, 19)
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
        Me.ImageList1.Images.SetKeyName(0, "Files_26987.png")
        Me.ImageList1.Images.SetKeyName(1, "iconCalandar.png")
        Me.ImageList1.Images.SetKeyName(2, "iconDespesaMensal.png")
        Me.ImageList1.Images.SetKeyName(3, "icon_Despesa.png")
        Me.ImageList1.Images.SetKeyName(4, "iconSearchFile.png")
        Me.ImageList1.Images.SetKeyName(5, "icon_DespesaMensal.png")
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
        Me.tabCtrlDespesa.Size = New System.Drawing.Size(1116, 504)
        Me.tabCtrlDespesa.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label4)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Controls.Add(Me.txtTotalDespesa)
        Me.tpPesquisa.ImageIndex = 3
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.tpPesquisa.Size = New System.Drawing.Size(1108, 439)
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
        Me.Label4.Location = New System.Drawing.Point(793, 104)
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
        Me.gbFiltro.Size = New System.Drawing.Size(1092, 83)
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
        Me.lvConsulta.Size = New System.Drawing.Size(1091, 326)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesa.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesa.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDespesa.Location = New System.Drawing.Point(933, 97)
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
        Me.tabDespesaFixa.Controls.Add(Me.SuperLV1)
        Me.tabDespesaFixa.Controls.Add(Me.GroupBox1)
        Me.tabDespesaFixa.ImageIndex = 5
        Me.tabDespesaFixa.Location = New System.Drawing.Point(4, 61)
        Me.tabDespesaFixa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDespesaFixa.Name = "tabDespesaFixa"
        Me.tabDespesaFixa.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDespesaFixa.Size = New System.Drawing.Size(1108, 439)
        Me.tabDespesaFixa.TabIndex = 2
        Me.tabDespesaFixa.Text = "Despesas Fixas"
        Me.tabDespesaFixa.UseVisualStyleBackColor = True
        '
        'tabDetalhe
        '
        Me.tabDetalhe.Controls.Add(Me.gbDetalhe)
        Me.tabDetalhe.ImageIndex = 4
        Me.tabDetalhe.Location = New System.Drawing.Point(4, 61)
        Me.tabDetalhe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDetalhe.Name = "tabDetalhe"
        Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabDetalhe.Size = New System.Drawing.Size(1108, 439)
        Me.tabDetalhe.TabIndex = 1
        Me.tabDetalhe.Text = "Detalhamento da Dívida"
        Me.tabDetalhe.UseVisualStyleBackColor = True
        '
        'gbDetalhe
        '
        Me.gbDetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetalhe.Controls.Add(Me.gbDadosDetalhe)
        Me.gbDetalhe.Controls.Add(Me.pnlDetalhe)
        Me.gbDetalhe.Location = New System.Drawing.Point(28, 28)
        Me.gbDetalhe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbDetalhe.Name = "gbDetalhe"
        Me.gbDetalhe.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbDetalhe.Size = New System.Drawing.Size(1041, 407)
        Me.gbDetalhe.TabIndex = 9
        Me.gbDetalhe.TabStop = False
        Me.gbDetalhe.Text = "Dados da Despesa"
        '
        'gbDadosDetalhe
        '
        Me.gbDadosDetalhe.Controls.Add(Me.lblNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtPago)
        Me.gbDadosDetalhe.Controls.Add(Me.lblPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.Label1)
        Me.gbDadosDetalhe.Controls.Add(Me.txtTotalDespesaDetalhe)
        Me.gbDadosDetalhe.Controls.Add(Me.lblTitulo)
        Me.gbDadosDetalhe.Controls.Add(Me.txtDescriaoDetalhe)
        Me.gbDadosDetalhe.Location = New System.Drawing.Point(38, 9)
        Me.gbDadosDetalhe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbDadosDetalhe.Name = "gbDadosDetalhe"
        Me.gbDadosDetalhe.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbDadosDetalhe.Size = New System.Drawing.Size(1148, 133)
        Me.gbDadosDetalhe.TabIndex = 9
        Me.gbDadosDetalhe.TabStop = False
        '
        'lblNaoPago
        '
        Me.lblNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNaoPago.AutoSize = True
        Me.lblNaoPago.Location = New System.Drawing.Point(818, 47)
        Me.lblNaoPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNaoPago.Name = "lblNaoPago"
        Me.lblNaoPago.Size = New System.Drawing.Size(72, 17)
        Me.lblNaoPago.TabIndex = 15
        Me.lblNaoPago.Text = "Não Pago"
        '
        'txtPago
        '
        Me.txtPago.Alterado = False
        Me.txtPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtPago.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPago.Location = New System.Drawing.Point(656, 68)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.ReadOnly = True
        Me.txtPago.Size = New System.Drawing.Size(158, 24)
        Me.txtPago.SuperMascara = ""
        Me.txtPago.SuperObrigatorio = False
        Me.txtPago.SuperTravaErrors = False
        Me.txtPago.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtPago.SuperTxtObrigatorio = ""
        Me.txtPago.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtPago.TabIndex = 14
        '
        'lblPago
        '
        Me.lblPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(653, 47)
        Me.lblPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(46, 17)
        Me.lblPago.TabIndex = 13
        Me.lblPago.Text = "Pago:"
        '
        'txtNaoPago
        '
        Me.txtNaoPago.Alterado = False
        Me.txtNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNaoPago.BackColor = System.Drawing.Color.White
        Me.txtNaoPago.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNaoPago.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaoPago.ForeColor = System.Drawing.Color.Red
        Me.txtNaoPago.Location = New System.Drawing.Point(820, 68)
        Me.txtNaoPago.Name = "txtNaoPago"
        Me.txtNaoPago.ReadOnly = True
        Me.txtNaoPago.Size = New System.Drawing.Size(158, 24)
        Me.txtNaoPago.SuperMascara = ""
        Me.txtNaoPago.SuperObrigatorio = False
        Me.txtNaoPago.SuperTravaErrors = False
        Me.txtNaoPago.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNaoPago.SuperTxtObrigatorio = ""
        Me.txtNaoPago.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNaoPago.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(490, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total da Despesa:"
        '
        'txtTotalDespesaDetalhe
        '
        Me.txtTotalDespesaDetalhe.Alterado = False
        Me.txtTotalDespesaDetalhe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotalDespesaDetalhe.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesaDetalhe.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesaDetalhe.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesaDetalhe.Location = New System.Drawing.Point(493, 68)
        Me.txtTotalDespesaDetalhe.Name = "txtTotalDespesaDetalhe"
        Me.txtTotalDespesaDetalhe.ReadOnly = True
        Me.txtTotalDespesaDetalhe.Size = New System.Drawing.Size(158, 24)
        Me.txtTotalDespesaDetalhe.SuperMascara = ""
        Me.txtTotalDespesaDetalhe.SuperObrigatorio = False
        Me.txtTotalDespesaDetalhe.SuperTravaErrors = False
        Me.txtTotalDespesaDetalhe.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesaDetalhe.SuperTxtObrigatorio = ""
        Me.txtTotalDespesaDetalhe.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesaDetalhe.TabIndex = 10
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(10, 47)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(158, 17)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Descrição da Despesa"
        '
        'txtDescriaoDetalhe
        '
        Me.txtDescriaoDetalhe.Alterado = False
        Me.txtDescriaoDetalhe.BackColor = System.Drawing.Color.White
        Me.txtDescriaoDetalhe.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDescriaoDetalhe.Location = New System.Drawing.Point(13, 68)
        Me.txtDescriaoDetalhe.Name = "txtDescriaoDetalhe"
        Me.txtDescriaoDetalhe.ReadOnly = True
        Me.txtDescriaoDetalhe.Size = New System.Drawing.Size(475, 25)
        Me.txtDescriaoDetalhe.SuperMascara = ""
        Me.txtDescriaoDetalhe.SuperObrigatorio = False
        Me.txtDescriaoDetalhe.SuperTravaErrors = False
        Me.txtDescriaoDetalhe.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtDescriaoDetalhe.SuperTxtObrigatorio = ""
        Me.txtDescriaoDetalhe.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtDescriaoDetalhe.TabIndex = 6
        '
        'pnlDetalhe
        '
        Me.pnlDetalhe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDetalhe.AutoScroll = True
        Me.pnlDetalhe.Location = New System.Drawing.Point(4, 128)
        Me.pnlDetalhe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlDetalhe.Name = "pnlDetalhe"
        Me.pnlDetalhe.Size = New System.Drawing.Size(1036, 275)
        Me.pnlDetalhe.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(39, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(997, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'SuperLV1
        '
        Me.SuperLV1.HabilitaOrdem = True
        Me.SuperLV1.HideSelection = False
        Me.SuperLV1.Location = New System.Drawing.Point(39, 141)
        Me.SuperLV1.Name = "SuperLV1"
        Me.SuperLV1.SelecionaVarios = False
        Me.SuperLV1.Size = New System.Drawing.Size(997, 177)
        Me.SuperLV1.TabIndex = 1
        Me.SuperLV1.UseCompatibleStateImageBehavior = False
        '
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1116, 604)
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
        Me.tabDespesaFixa.ResumeLayout(False)
        Me.tabDetalhe.ResumeLayout(False)
        Me.gbDetalhe.ResumeLayout(False)
        Me.gbDadosDetalhe.ResumeLayout(False)
        Me.gbDadosDetalhe.PerformLayout()
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
    Friend WithEvents tabDespesaFixa As TabPage
    Friend WithEvents txtDescriaoDetalhe As GFT.Util.SuperTextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbDetalhe As GroupBox
    Friend WithEvents gbDadosDetalhe As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalDespesaDetalhe As GFT.Util.SuperTextBox
    Friend WithEvents lblNaoPago As Label
    Friend WithEvents txtPago As GFT.Util.SuperTextBox
    Friend WithEvents lblPago As Label
    Friend WithEvents txtNaoPago As GFT.Util.SuperTextBox
    Friend WithEvents pnlDetalhe As Panel
    Friend WithEvents SuperLV1 As GFT.Util.SuperLV
    Friend WithEvents GroupBox1 As GroupBox
End Class
