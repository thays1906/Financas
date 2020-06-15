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
        Me.btnAddDespesa = New GFT.Util.SuperButton()
        Me.btnExportar = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.txtTotalDespesa = New GFT.Util.SuperTextBox()
        Me.tabDetalhe = New System.Windows.Forms.TabPage()
        Me.SuperGroupBox1 = New GFT.Util.SuperGroupBox()
        Me.tabDespesaFixa = New System.Windows.Forms.TabPage()
        Me.gbBotoes.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.tabDetalhe.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.LightSeaGreen
        Me.gbBotoes.Controls.Add(Me.btnStatusPago)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnAddDespesa)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBotoes.Location = New System.Drawing.Point(0, 722)
        Me.gbBotoes.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBotoes.Size = New System.Drawing.Size(1450, 70)
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
        Me.btnStatusPago.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStatusPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatusPago.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnStatusPago.ForeColor = System.Drawing.Color.Black
        Me.btnStatusPago.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconOk
        Me.btnStatusPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStatusPago.Location = New System.Drawing.Point(866, 10)
        Me.btnStatusPago.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStatusPago.Name = "btnStatusPago"
        Me.btnStatusPago.Size = New System.Drawing.Size(208, 55)
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
        Me.btnFechar.Location = New System.Drawing.Point(1298, 10)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(208, 55)
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
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(650, 10)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(208, 55)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "  &Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
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
        Me.btnAddDespesa.Location = New System.Drawing.Point(218, 10)
        Me.btnAddDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(208, 55)
        Me.btnAddDespesa.TabIndex = 10
        Me.btnAddDespesa.Text = "  &Despesa"
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = False
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
        Me.btnExportar.Location = New System.Drawing.Point(1082, 10)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(208, 55)
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
        Me.btnPesquisar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.Icon_search
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.Location = New System.Drawing.Point(2, 10)
        Me.btnPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(208, 55)
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
        Me.btnEditar.Location = New System.Drawing.Point(434, 10)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(208, 55)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "  &Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconMoneyRed.fw.png")
        Me.ImageList1.Images.SetKeyName(1, "Files_26987.png")
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Controls.Add(Me.tabDespesaFixa)
        Me.tbConsulta.Controls.Add(Me.tabDetalhe)
        Me.tbConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbConsulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConsulta.ImageList = Me.ImageList1
        Me.tbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.tbConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 6)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(1450, 722)
        Me.tbConsulta.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label4)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Controls.Add(Me.txtTotalDespesa)
        Me.tpPesquisa.ImageIndex = 0
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 61)
        Me.tpPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tpPesquisa.Size = New System.Drawing.Size(1442, 657)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Despesas"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
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
        Me.gbFiltro.Location = New System.Drawing.Point(11, 10)
        Me.gbFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Padding = New System.Windows.Forms.Padding(4)
        Me.gbFiltro.Size = New System.Drawing.Size(1418, 102)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(349, 32)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(51, 22)
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
        Me.cbMes.Location = New System.Drawing.Point(353, 57)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(333, 30)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
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
        Me.cbStatusFiltro.Location = New System.Drawing.Point(23, 57)
        Me.cbStatusFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(231, 30)
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
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(11, 158)
        Me.lvConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = True
        Me.lvConsulta.Size = New System.Drawing.Size(1416, 489)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesa.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDespesa.ForeColor = System.Drawing.Color.Red
        Me.txtTotalDespesa.Location = New System.Drawing.Point(184, 123)
        Me.txtTotalDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalDespesa.Name = "txtTotalDespesa"
        Me.txtTotalDespesa.ReadOnly = True
        Me.txtTotalDespesa.Size = New System.Drawing.Size(221, 32)
        Me.txtTotalDespesa.SuperMascara = ""
        Me.txtTotalDespesa.SuperObrigatorio = False
        Me.txtTotalDespesa.SuperTravaErrors = False
        Me.txtTotalDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesa.SuperTxtObrigatorio = ""
        Me.txtTotalDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesa.TabIndex = 8
        '
        'tabDetalhe
        '
        Me.tabDetalhe.Controls.Add(Me.SuperGroupBox1)
        Me.tabDetalhe.ImageIndex = 1
        Me.tabDetalhe.Location = New System.Drawing.Point(4, 61)
        Me.tabDetalhe.Name = "tabDetalhe"
        Me.tabDetalhe.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalhe.Size = New System.Drawing.Size(1442, 657)
        Me.tabDetalhe.TabIndex = 1
        Me.tabDetalhe.Text = "Detalhamento da Dívida"
        Me.tabDetalhe.UseVisualStyleBackColor = True
        '
        'SuperGroupBox1
        '
        Me.SuperGroupBox1.BorderCollor = System.Drawing.Color.Empty
        Me.SuperGroupBox1.Location = New System.Drawing.Point(39, 26)
        Me.SuperGroupBox1.Name = "SuperGroupBox1"
        Me.SuperGroupBox1.Size = New System.Drawing.Size(1375, 217)
        Me.SuperGroupBox1.TabIndex = 0
        Me.SuperGroupBox1.TabStop = False
        Me.SuperGroupBox1.Text = "SuperGroupBox1"
        '
        'tabDespesaFixa
        '
        Me.tabDespesaFixa.Location = New System.Drawing.Point(4, 61)
        Me.tabDespesaFixa.Name = "tabDespesaFixa"
        Me.tabDespesaFixa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDespesaFixa.Size = New System.Drawing.Size(1442, 657)
        Me.tabDespesaFixa.TabIndex = 2
        Me.tabDespesaFixa.Text = "Despesas Fixas"
        Me.tabDespesaFixa.UseVisualStyleBackColor = True
        '
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1450, 792)
        Me.Controls.Add(Me.tbConsulta)
        Me.Controls.Add(Me.gbBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDespesa"
        Me.Text = "frmDespesa"
        Me.gbBotoes.ResumeLayout(False)
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.tabDetalhe.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbConsulta As GFT.Util.SuperTabControl
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
End Class
