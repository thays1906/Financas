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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnStatusPago = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAddDespesa = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabCtrlDespesa = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalDespesa = New GFT.Util.SuperTextBox()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.tabDespesaFixa = New System.Windows.Forms.TabPage()
        Me.lvlConsultaFixa = New GFT.Util.SuperLV()
        Me.gbDespesaFixa = New System.Windows.Forms.GroupBox()
        Me.cbCategoriaFixa = New GFT.Util.SuperComboBox()
        Me.cbMesFixa = New GFT.Util.SuperComboBox()
        Me.cbPeriodo = New GFT.Util.SuperComboBox()
        Me.lblMesFixa = New System.Windows.Forms.Label()
        Me.lblCategoriaFixa = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
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
        Me.gbBotoes.SuspendLayout()
        Me.tabCtrlDespesa.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.tabDespesaFixa.SuspendLayout()
        Me.gbDespesaFixa.SuspendLayout()
        Me.tabDetalhe.SuspendLayout()
        Me.gbDetalhe.SuspendLayout()
        Me.gbDadosDetalhe.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnStatusPago)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Controls.Add(Me.btnAddDespesa)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.Location = New System.Drawing.Point(0, 659)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(0)
        Me.gbBotoes.Size = New System.Drawing.Size(1959, 84)
        Me.gbBotoes.TabIndex = 9
        Me.gbBotoes.TabStop = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFechar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1677, 20)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(271, 52)
        Me.btnFechar.TabIndex = 19
        Me.btnFechar.Text = " &Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPesquisar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconePesquisar
        Me.btnPesquisar.Location = New System.Drawing.Point(5, 20)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(271, 52)
        Me.btnPesquisar.TabIndex = 8
        Me.btnPesquisar.Text = " &Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnStatusPago
        '
        Me.btnStatusPago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnStatusPago.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnStatusPago.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.btnStatusPago.Location = New System.Drawing.Point(1120, 20)
        Me.btnStatusPago.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStatusPago.Name = "btnStatusPago"
        Me.btnStatusPago.Size = New System.Drawing.Size(271, 52)
        Me.btnStatusPago.TabIndex = 17
        Me.btnStatusPago.Text = " &Pagar"
        Me.btnStatusPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStatusPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatusPago.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExportar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcel
        Me.btnExportar.Location = New System.Drawing.Point(1399, 20)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(271, 52)
        Me.btnExportar.TabIndex = 18
        Me.btnExportar.Text = " &Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditar.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnEditar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditar
        Me.btnEditar.Location = New System.Drawing.Point(563, 20)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(271, 52)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = " &Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAddDespesa
        '
        Me.btnAddDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnAddDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddDespesa
        Me.btnAddDespesa.Location = New System.Drawing.Point(284, 20)
        Me.btnAddDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(271, 52)
        Me.btnAddDespesa.TabIndex = 14
        Me.btnAddDespesa.Text = " &Despesa"
        Me.btnAddDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExcluir
        Me.btnExcluir.Location = New System.Drawing.Point(841, 20)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(271, 52)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.Text = " &Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
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
        Me.tabCtrlDespesa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlDespesa.ImageList = Me.ImageList1
        Me.tabCtrlDespesa.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlDespesa.Name = "tabCtrlDespesa"
        Me.tabCtrlDespesa.Padding = New System.Drawing.Point(50, 6)
        Me.tabCtrlDespesa.SelectedIndex = 0
        Me.tabCtrlDespesa.Size = New System.Drawing.Size(1959, 659)
        Me.tabCtrlDespesa.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.ImageIndex = 3
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpPesquisa.Size = New System.Drawing.Size(1951, 594)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Despesas"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.Location = New System.Drawing.Point(44, 132)
        Me.lvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = True
        Me.lvConsulta.Size = New System.Drawing.Size(1848, 436)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.Controls.Add(Me.lblMes)
        Me.gbFiltro.Controls.Add(Me.Label4)
        Me.gbFiltro.Controls.Add(Me.cbMes)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.txtTotalDespesa)
        Me.gbFiltro.Controls.Add(Me.cbStatusFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(44, 22)
        Me.gbFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Size = New System.Drawing.Size(1849, 102)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(364, 30)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(60, 25)
        Me.lblMes.TabIndex = 10
        Me.lblMes.Text = "Mês:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1429, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total de Despesas:"
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.CorFundo = System.Drawing.Color.White
        Me.cbMes.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbMes.CorTexto = System.Drawing.Color.Black
        Me.cbMes.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(369, 58)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(333, 33)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesa.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesa.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDespesa.Location = New System.Drawing.Point(1435, 62)
        Me.txtTotalDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDespesa.Name = "txtTotalDespesa"
        Me.txtTotalDespesa.ReadOnly = True
        Me.txtTotalDespesa.Size = New System.Drawing.Size(221, 29)
        Me.txtTotalDespesa.SuperMascara = ""
        Me.txtTotalDespesa.SuperObrigatorio = False
        Me.txtTotalDespesa.SuperTravaErrors = False
        Me.txtTotalDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesa.SuperTxtObrigatorio = ""
        Me.txtTotalDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesa.TabIndex = 8
        Me.txtTotalDespesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbStatusFiltro
        '
        Me.cbStatusFiltro.Alterado = False
        Me.cbStatusFiltro.CorFundo = System.Drawing.Color.White
        Me.cbStatusFiltro.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbStatusFiltro.CorTexto = System.Drawing.Color.Black
        Me.cbStatusFiltro.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbStatusFiltro.FormattingEnabled = True
        Me.cbStatusFiltro.Location = New System.Drawing.Point(119, 58)
        Me.cbStatusFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(231, 33)
        Me.cbStatusFiltro.SuperObrigatorio = False
        Me.cbStatusFiltro.SuperTxtObrigatorio = ""
        Me.cbStatusFiltro.TabIndex = 7
        '
        'tabDespesaFixa
        '
        Me.tabDespesaFixa.Controls.Add(Me.lvlConsultaFixa)
        Me.tabDespesaFixa.Controls.Add(Me.gbDespesaFixa)
        Me.tabDespesaFixa.ImageIndex = 5
        Me.tabDespesaFixa.Location = New System.Drawing.Point(4, 61)
        Me.tabDespesaFixa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDespesaFixa.Name = "tabDespesaFixa"
        Me.tabDespesaFixa.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDespesaFixa.Size = New System.Drawing.Size(1951, 594)
        Me.tabDespesaFixa.TabIndex = 2
        Me.tabDespesaFixa.Text = "Despesas Fixas"
        Me.tabDespesaFixa.UseVisualStyleBackColor = True
        '
        'lvlConsultaFixa
        '
        Me.lvlConsultaFixa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvlConsultaFixa.HabilitaOrdem = True
        Me.lvlConsultaFixa.HideSelection = False
        Me.lvlConsultaFixa.Location = New System.Drawing.Point(52, 162)
        Me.lvlConsultaFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.lvlConsultaFixa.Name = "lvlConsultaFixa"
        Me.lvlConsultaFixa.SelecionaVarios = False
        Me.lvlConsultaFixa.Size = New System.Drawing.Size(1440, 410)
        Me.lvlConsultaFixa.TabIndex = 1
        Me.lvlConsultaFixa.UseCompatibleStateImageBehavior = False
        '
        'gbDespesaFixa
        '
        Me.gbDespesaFixa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDespesaFixa.Controls.Add(Me.cbCategoriaFixa)
        Me.gbDespesaFixa.Controls.Add(Me.cbMesFixa)
        Me.gbDespesaFixa.Controls.Add(Me.cbPeriodo)
        Me.gbDespesaFixa.Controls.Add(Me.lblMesFixa)
        Me.gbDespesaFixa.Controls.Add(Me.lblCategoriaFixa)
        Me.gbDespesaFixa.Controls.Add(Me.lblPeriodo)
        Me.gbDespesaFixa.Location = New System.Drawing.Point(52, 38)
        Me.gbDespesaFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDespesaFixa.Name = "gbDespesaFixa"
        Me.gbDespesaFixa.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDespesaFixa.Size = New System.Drawing.Size(1441, 117)
        Me.gbDespesaFixa.TabIndex = 0
        Me.gbDespesaFixa.TabStop = False
        Me.gbDespesaFixa.Text = "Filtro"
        '
        'cbCategoriaFixa
        '
        Me.cbCategoriaFixa.Alterado = False
        Me.cbCategoriaFixa.CorFundo = System.Drawing.Color.White
        Me.cbCategoriaFixa.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbCategoriaFixa.CorTexto = System.Drawing.Color.Black
        Me.cbCategoriaFixa.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbCategoriaFixa.FormattingEnabled = True
        Me.cbCategoriaFixa.Location = New System.Drawing.Point(361, 63)
        Me.cbCategoriaFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCategoriaFixa.Name = "cbCategoriaFixa"
        Me.cbCategoriaFixa.Size = New System.Drawing.Size(308, 33)
        Me.cbCategoriaFixa.SuperObrigatorio = False
        Me.cbCategoriaFixa.SuperTxtObrigatorio = ""
        Me.cbCategoriaFixa.TabIndex = 8
        '
        'cbMesFixa
        '
        Me.cbMesFixa.Alterado = False
        Me.cbMesFixa.CorFundo = System.Drawing.Color.White
        Me.cbMesFixa.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbMesFixa.CorTexto = System.Drawing.Color.Black
        Me.cbMesFixa.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbMesFixa.FormattingEnabled = True
        Me.cbMesFixa.Location = New System.Drawing.Point(719, 63)
        Me.cbMesFixa.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMesFixa.Name = "cbMesFixa"
        Me.cbMesFixa.Size = New System.Drawing.Size(269, 33)
        Me.cbMesFixa.SuperObrigatorio = False
        Me.cbMesFixa.SuperTxtObrigatorio = ""
        Me.cbMesFixa.TabIndex = 7
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Alterado = False
        Me.cbPeriodo.CorFundo = System.Drawing.Color.White
        Me.cbPeriodo.CorFundoSelecionado = System.Drawing.Color.White
        Me.cbPeriodo.CorTexto = System.Drawing.Color.Black
        Me.cbPeriodo.CorTextoSelecionado = System.Drawing.Color.Black
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Location = New System.Drawing.Point(88, 63)
        Me.cbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(229, 33)
        Me.cbPeriodo.SuperObrigatorio = False
        Me.cbPeriodo.SuperTxtObrigatorio = ""
        Me.cbPeriodo.TabIndex = 6
        '
        'lblMesFixa
        '
        Me.lblMesFixa.AutoSize = True
        Me.lblMesFixa.Location = New System.Drawing.Point(715, 37)
        Me.lblMesFixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMesFixa.Name = "lblMesFixa"
        Me.lblMesFixa.Size = New System.Drawing.Size(51, 25)
        Me.lblMesFixa.TabIndex = 5
        Me.lblMesFixa.Text = "Mês"
        '
        'lblCategoriaFixa
        '
        Me.lblCategoriaFixa.AutoSize = True
        Me.lblCategoriaFixa.Location = New System.Drawing.Point(357, 37)
        Me.lblCategoriaFixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoriaFixa.Name = "lblCategoriaFixa"
        Me.lblCategoriaFixa.Size = New System.Drawing.Size(109, 25)
        Me.lblCategoriaFixa.TabIndex = 3
        Me.lblCategoriaFixa.Text = "Categoria"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(84, 37)
        Me.lblPeriodo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(79, 25)
        Me.lblPeriodo.TabIndex = 1
        Me.lblPeriodo.Text = "A cada"
        '
        'tabDetalhe
        '
        Me.tabDetalhe.Controls.Add(Me.gbDetalhe)
        Me.tabDetalhe.ImageIndex = 4
        Me.tabDetalhe.Location = New System.Drawing.Point(4, 61)
        Me.tabDetalhe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDetalhe.Name = "tabDetalhe"
        Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabDetalhe.Size = New System.Drawing.Size(1951, 594)
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
        Me.gbDetalhe.Location = New System.Drawing.Point(37, 5)
        Me.gbDetalhe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalhe.Name = "gbDetalhe"
        Me.gbDetalhe.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDetalhe.Size = New System.Drawing.Size(1388, 570)
        Me.gbDetalhe.TabIndex = 9
        Me.gbDetalhe.TabStop = False
        Me.gbDetalhe.Text = "Despesa Parcelada"
        '
        'gbDadosDetalhe
        '
        Me.gbDadosDetalhe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbDadosDetalhe.Controls.Add(Me.lblNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtPago)
        Me.gbDadosDetalhe.Controls.Add(Me.lblPago)
        Me.gbDadosDetalhe.Controls.Add(Me.txtNaoPago)
        Me.gbDadosDetalhe.Controls.Add(Me.Label1)
        Me.gbDadosDetalhe.Controls.Add(Me.txtTotalDespesaDetalhe)
        Me.gbDadosDetalhe.Controls.Add(Me.lblTitulo)
        Me.gbDadosDetalhe.Controls.Add(Me.txtDescriaoDetalhe)
        Me.gbDadosDetalhe.Location = New System.Drawing.Point(51, 30)
        Me.gbDadosDetalhe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosDetalhe.Name = "gbDadosDetalhe"
        Me.gbDadosDetalhe.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDadosDetalhe.Size = New System.Drawing.Size(1531, 145)
        Me.gbDadosDetalhe.TabIndex = 9
        Me.gbDadosDetalhe.TabStop = False
        '
        'lblNaoPago
        '
        Me.lblNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNaoPago.AutoSize = True
        Me.lblNaoPago.Location = New System.Drawing.Point(1116, 42)
        Me.lblNaoPago.Name = "lblNaoPago"
        Me.lblNaoPago.Size = New System.Drawing.Size(106, 25)
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
        Me.txtPago.Location = New System.Drawing.Point(901, 75)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.ReadOnly = True
        Me.txtPago.Size = New System.Drawing.Size(209, 28)
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
        Me.lblPago.Location = New System.Drawing.Point(897, 42)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(60, 25)
        Me.lblPago.TabIndex = 13
        Me.lblPago.Text = "Pago"
        '
        'txtNaoPago
        '
        Me.txtNaoPago.Alterado = False
        Me.txtNaoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNaoPago.BackColor = System.Drawing.Color.White
        Me.txtNaoPago.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNaoPago.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaoPago.ForeColor = System.Drawing.Color.Red
        Me.txtNaoPago.Location = New System.Drawing.Point(1120, 75)
        Me.txtNaoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNaoPago.Name = "txtNaoPago"
        Me.txtNaoPago.ReadOnly = True
        Me.txtNaoPago.Size = New System.Drawing.Size(209, 28)
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
        Me.Label1.Location = New System.Drawing.Point(679, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total da Despesa"
        '
        'txtTotalDespesaDetalhe
        '
        Me.txtTotalDespesaDetalhe.Alterado = False
        Me.txtTotalDespesaDetalhe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotalDespesaDetalhe.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesaDetalhe.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesaDetalhe.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesaDetalhe.Location = New System.Drawing.Point(683, 75)
        Me.txtTotalDespesaDetalhe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDespesaDetalhe.Name = "txtTotalDespesaDetalhe"
        Me.txtTotalDespesaDetalhe.ReadOnly = True
        Me.txtTotalDespesaDetalhe.Size = New System.Drawing.Size(209, 28)
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
        Me.lblTitulo.Location = New System.Drawing.Point(3, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(229, 25)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Descrição da Despesa"
        '
        'txtDescriaoDetalhe
        '
        Me.txtDescriaoDetalhe.Alterado = False
        Me.txtDescriaoDetalhe.BackColor = System.Drawing.Color.White
        Me.txtDescriaoDetalhe.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtDescriaoDetalhe.Location = New System.Drawing.Point(7, 71)
        Me.txtDescriaoDetalhe.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescriaoDetalhe.Name = "txtDescriaoDetalhe"
        Me.txtDescriaoDetalhe.ReadOnly = True
        Me.txtDescriaoDetalhe.Size = New System.Drawing.Size(632, 32)
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
        Me.pnlDetalhe.Location = New System.Drawing.Point(5, 160)
        Me.pnlDetalhe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDetalhe.Name = "pnlDetalhe"
        Me.pnlDetalhe.Size = New System.Drawing.Size(1381, 404)
        Me.pnlDetalhe.TabIndex = 10
        '
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1959, 743)
        Me.Controls.Add(Me.tabCtrlDespesa)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDespesa"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDespesa"
        Me.gbBotoes.ResumeLayout(False)
        Me.tabCtrlDespesa.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.tabDespesaFixa.ResumeLayout(False)
        Me.gbDespesaFixa.ResumeLayout(False)
        Me.gbDespesaFixa.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalDespesa As GFT.Util.SuperTextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
    Friend WithEvents ImageList1 As ImageList
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
    Friend WithEvents lvlConsultaFixa As GFT.Util.SuperLV
    Friend WithEvents gbDespesaFixa As GroupBox
    Friend WithEvents lblMesFixa As Label
    Friend WithEvents lblCategoriaFixa As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents cbCategoriaFixa As GFT.Util.SuperComboBox
    Friend WithEvents cbMesFixa As GFT.Util.SuperComboBox
    Friend WithEvents cbPeriodo As GFT.Util.SuperComboBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnStatusPago As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAddDespesa As Button
    Friend WithEvents btnExcluir As Button
End Class
