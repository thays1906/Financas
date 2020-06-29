<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tabCtrlConfig = New GFT.Util.SuperTabControl()
        Me.tabReceita = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gbBotoesReceita = New System.Windows.Forms.GroupBox()
        Me.lvReceita = New GFT.Util.SuperLV()
        Me.gbAddReceita = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNovaReceita = New GFT.Util.SuperTextBox()
        Me.tabCategoriaDespesa = New System.Windows.Forms.TabPage()
        Me.gbCadastroDespesa = New System.Windows.Forms.GroupBox()
        Me.lblCategoriaDespesa = New System.Windows.Forms.Label()
        Me.txtNovaCategoriaDespesa = New GFT.Util.SuperTextBox()
        Me.gbTodasDespesa = New System.Windows.Forms.GroupBox()
        Me.gbBotoesCategoriaDespesa = New System.Windows.Forms.GroupBox()
        Me.lvCategoriaDespesa = New GFT.Util.SuperLV()
        Me.tabFormaPagamento = New System.Windows.Forms.TabPage()
        Me.gbCadastroPagamento = New System.Windows.Forms.GroupBox()
        Me.lblFormaPagamento = New System.Windows.Forms.Label()
        Me.txtNovaFormaPag = New GFT.Util.SuperTextBox()
        Me.gbConsultaPagamento = New System.Windows.Forms.GroupBox()
        Me.gbBotoesPagamento = New System.Windows.Forms.GroupBox()
        Me.lvFormaPagamento = New GFT.Util.SuperLV()
        Me.tabParcelamento = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvParcela = New GFT.Util.SuperLV()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQtdeParcela = New GFT.Util.SuperTextBox()
        Me.btnFecharConfig = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEditarReceita = New System.Windows.Forms.Button()
        Me.btnExcluirReceita = New System.Windows.Forms.Button()
        Me.btnAdicionarReceita = New System.Windows.Forms.Button()
        Me.btnAddCatDespesa = New System.Windows.Forms.Button()
        Me.btnEditarDespesa = New System.Windows.Forms.Button()
        Me.btnExcluirDespesa = New System.Windows.Forms.Button()
        Me.btnAddPag = New System.Windows.Forms.Button()
        Me.btnEditarPag = New System.Windows.Forms.Button()
        Me.btnExcluirPag = New System.Windows.Forms.Button()
        Me.btnExcluirParcela = New System.Windows.Forms.Button()
        Me.btnSalvarParcela = New System.Windows.Forms.Button()
        Me.btnCadastrarParc = New System.Windows.Forms.Button()
        Me.tabCtrlConfig.SuspendLayout()
        Me.tabReceita.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbBotoesReceita.SuspendLayout()
        Me.gbAddReceita.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Orange
        Me.ImageList1.Images.SetKeyName(0, "iconMoneyRed.fw.png")
        Me.ImageList1.Images.SetKeyName(1, "Banco2.png")
        Me.ImageList1.Images.SetKeyName(2, "icon_Receita.png")
        Me.ImageList1.Images.SetKeyName(3, "iconePArcela.png")
        Me.ImageList1.Images.SetKeyName(4, "icon_Despesa.png")
        Me.ImageList1.Images.SetKeyName(5, "icon_Parcela.png")
        Me.ImageList1.Images.SetKeyName(6, "iconCartaoCredito.png")
        '
        'tabCtrlConfig
        '
        Me.tabCtrlConfig.Controls.Add(Me.tabReceita)
        Me.tabCtrlConfig.Controls.Add(Me.tabCategoriaDespesa)
        Me.tabCtrlConfig.Controls.Add(Me.tabFormaPagamento)
        Me.tabCtrlConfig.Controls.Add(Me.tabParcelamento)
        Me.tabCtrlConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlConfig.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlConfig.ImageList = Me.ImageList1
        Me.tabCtrlConfig.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlConfig.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabCtrlConfig.Multiline = True
        Me.tabCtrlConfig.Name = "tabCtrlConfig"
        Me.tabCtrlConfig.Padding = New System.Drawing.Point(30, 5)
        Me.tabCtrlConfig.SelectedIndex = 0
        Me.tabCtrlConfig.Size = New System.Drawing.Size(1028, 640)
        Me.tabCtrlConfig.TabIndex = 0
        '
        'tabReceita
        '
        Me.tabReceita.Controls.Add(Me.GroupBox4)
        Me.tabReceita.Controls.Add(Me.gbAddReceita)
        Me.tabReceita.ImageIndex = 2
        Me.tabReceita.Location = New System.Drawing.Point(4, 118)
        Me.tabReceita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabReceita.Name = "tabReceita"
        Me.tabReceita.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabReceita.Size = New System.Drawing.Size(1020, 518)
        Me.tabReceita.TabIndex = 5
        Me.tabReceita.Text = "Categorias de Receita"
        Me.tabReceita.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.gbBotoesReceita)
        Me.GroupBox4.Controls.Add(Me.lvReceita)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 164)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(801, 313)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Todos"
        '
        'gbBotoesReceita
        '
        Me.gbBotoesReceita.Controls.Add(Me.btnEditarReceita)
        Me.gbBotoesReceita.Controls.Add(Me.btnExcluirReceita)
        Me.gbBotoesReceita.Location = New System.Drawing.Point(427, 39)
        Me.gbBotoesReceita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesReceita.Name = "gbBotoesReceita"
        Me.gbBotoesReceita.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesReceita.Size = New System.Drawing.Size(65, 127)
        Me.gbBotoesReceita.TabIndex = 4
        Me.gbBotoesReceita.TabStop = False
        '
        'lvReceita
        '
        Me.lvReceita.HabilitaOrdem = True
        Me.lvReceita.HideSelection = False
        Me.lvReceita.Location = New System.Drawing.Point(73, 39)
        Me.lvReceita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvReceita.Name = "lvReceita"
        Me.lvReceita.SelecionaVarios = False
        Me.lvReceita.Size = New System.Drawing.Size(350, 272)
        Me.lvReceita.TabIndex = 0
        Me.lvReceita.UseCompatibleStateImageBehavior = False
        '
        'gbAddReceita
        '
        Me.gbAddReceita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAddReceita.Controls.Add(Me.btnAdicionarReceita)
        Me.gbAddReceita.Controls.Add(Me.Label2)
        Me.gbAddReceita.Controls.Add(Me.txtNovaReceita)
        Me.gbAddReceita.Location = New System.Drawing.Point(34, 20)
        Me.gbAddReceita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAddReceita.Name = "gbAddReceita"
        Me.gbAddReceita.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbAddReceita.Size = New System.Drawing.Size(801, 116)
        Me.gbAddReceita.TabIndex = 0
        Me.gbAddReceita.TabStop = False
        Me.gbAddReceita.Text = "Cadastro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Novo categoria de Receita:"
        '
        'txtNovaReceita
        '
        Me.txtNovaReceita.Alterado = False
        Me.txtNovaReceita.BackColor = System.Drawing.Color.White
        Me.txtNovaReceita.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaReceita.Location = New System.Drawing.Point(73, 65)
        Me.txtNovaReceita.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNovaReceita.Multiline = True
        Me.txtNovaReceita.Name = "txtNovaReceita"
        Me.txtNovaReceita.Size = New System.Drawing.Size(350, 32)
        Me.txtNovaReceita.SuperMascara = ""
        Me.txtNovaReceita.SuperObrigatorio = True
        Me.txtNovaReceita.SuperTravaErrors = False
        Me.txtNovaReceita.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaReceita.SuperTxtObrigatorio = "Nova Categoria"
        Me.txtNovaReceita.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaReceita.TabIndex = 0
        '
        'tabCategoriaDespesa
        '
        Me.tabCategoriaDespesa.Controls.Add(Me.gbCadastroDespesa)
        Me.tabCategoriaDespesa.Controls.Add(Me.gbTodasDespesa)
        Me.tabCategoriaDespesa.ImageIndex = 4
        Me.tabCategoriaDespesa.Location = New System.Drawing.Point(4, 118)
        Me.tabCategoriaDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabCategoriaDespesa.Name = "tabCategoriaDespesa"
        Me.tabCategoriaDespesa.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabCategoriaDespesa.Size = New System.Drawing.Size(1020, 518)
        Me.tabCategoriaDespesa.TabIndex = 1
        Me.tabCategoriaDespesa.Text = "Categorias de Despesa"
        Me.tabCategoriaDespesa.UseVisualStyleBackColor = True
        '
        'gbCadastroDespesa
        '
        Me.gbCadastroDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCadastroDespesa.Controls.Add(Me.btnAddCatDespesa)
        Me.gbCadastroDespesa.Controls.Add(Me.lblCategoriaDespesa)
        Me.gbCadastroDespesa.Controls.Add(Me.txtNovaCategoriaDespesa)
        Me.gbCadastroDespesa.Location = New System.Drawing.Point(34, 20)
        Me.gbCadastroDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbCadastroDespesa.Name = "gbCadastroDespesa"
        Me.gbCadastroDespesa.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbCadastroDespesa.Size = New System.Drawing.Size(951, 116)
        Me.gbCadastroDespesa.TabIndex = 8
        Me.gbCadastroDespesa.TabStop = False
        Me.gbCadastroDespesa.Text = "Cadastrar"
        '
        'lblCategoriaDespesa
        '
        Me.lblCategoriaDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCategoriaDespesa.AutoSize = True
        Me.lblCategoriaDespesa.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblCategoriaDespesa.Location = New System.Drawing.Point(98, 32)
        Me.lblCategoriaDespesa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoriaDespesa.Name = "lblCategoriaDespesa"
        Me.lblCategoriaDespesa.Size = New System.Drawing.Size(240, 18)
        Me.lblCategoriaDespesa.TabIndex = 1
        Me.lblCategoriaDespesa.Text = "Nova categoria de Despesa:"
        '
        'txtNovaCategoriaDespesa
        '
        Me.txtNovaCategoriaDespesa.Alterado = False
        Me.txtNovaCategoriaDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNovaCategoriaDespesa.BackColor = System.Drawing.Color.White
        Me.txtNovaCategoriaDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaCategoriaDespesa.Location = New System.Drawing.Point(102, 63)
        Me.txtNovaCategoriaDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNovaCategoriaDespesa.Multiline = True
        Me.txtNovaCategoriaDespesa.Name = "txtNovaCategoriaDespesa"
        Me.txtNovaCategoriaDespesa.Size = New System.Drawing.Size(350, 32)
        Me.txtNovaCategoriaDespesa.SuperMascara = ""
        Me.txtNovaCategoriaDespesa.SuperObrigatorio = True
        Me.txtNovaCategoriaDespesa.SuperTravaErrors = False
        Me.txtNovaCategoriaDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaCategoriaDespesa.SuperTxtObrigatorio = "É necessário informar uma  categoria para cadastrar."
        Me.txtNovaCategoriaDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaCategoriaDespesa.TabIndex = 0
        '
        'gbTodasDespesa
        '
        Me.gbTodasDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTodasDespesa.Controls.Add(Me.gbBotoesCategoriaDespesa)
        Me.gbTodasDespesa.Controls.Add(Me.lvCategoriaDespesa)
        Me.gbTodasDespesa.Location = New System.Drawing.Point(34, 164)
        Me.gbTodasDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTodasDespesa.Name = "gbTodasDespesa"
        Me.gbTodasDespesa.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbTodasDespesa.Size = New System.Drawing.Size(951, 326)
        Me.gbTodasDespesa.TabIndex = 7
        Me.gbTodasDespesa.TabStop = False
        Me.gbTodasDespesa.Text = "Todos"
        '
        'gbBotoesCategoriaDespesa
        '
        Me.gbBotoesCategoriaDespesa.Controls.Add(Me.btnEditarDespesa)
        Me.gbBotoesCategoriaDespesa.Controls.Add(Me.btnExcluirDespesa)
        Me.gbBotoesCategoriaDespesa.Location = New System.Drawing.Point(457, 36)
        Me.gbBotoesCategoriaDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesCategoriaDespesa.Name = "gbBotoesCategoriaDespesa"
        Me.gbBotoesCategoriaDespesa.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesCategoriaDespesa.Size = New System.Drawing.Size(65, 127)
        Me.gbBotoesCategoriaDespesa.TabIndex = 3
        Me.gbBotoesCategoriaDespesa.TabStop = False
        '
        'lvCategoriaDespesa
        '
        Me.lvCategoriaDespesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvCategoriaDespesa.HabilitaOrdem = True
        Me.lvCategoriaDespesa.HideSelection = False
        Me.lvCategoriaDespesa.Location = New System.Drawing.Point(102, 36)
        Me.lvCategoriaDespesa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvCategoriaDespesa.Name = "lvCategoriaDespesa"
        Me.lvCategoriaDespesa.SelecionaVarios = False
        Me.lvCategoriaDespesa.Size = New System.Drawing.Size(350, 272)
        Me.lvCategoriaDespesa.TabIndex = 0
        Me.lvCategoriaDespesa.UseCompatibleStateImageBehavior = False
        '
        'tabFormaPagamento
        '
        Me.tabFormaPagamento.Controls.Add(Me.gbCadastroPagamento)
        Me.tabFormaPagamento.Controls.Add(Me.gbConsultaPagamento)
        Me.tabFormaPagamento.ImageIndex = 6
        Me.tabFormaPagamento.Location = New System.Drawing.Point(4, 118)
        Me.tabFormaPagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabFormaPagamento.Name = "tabFormaPagamento"
        Me.tabFormaPagamento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabFormaPagamento.Size = New System.Drawing.Size(1020, 518)
        Me.tabFormaPagamento.TabIndex = 2
        Me.tabFormaPagamento.Text = "Formas de Pagamento"
        Me.tabFormaPagamento.UseVisualStyleBackColor = True
        '
        'gbCadastroPagamento
        '
        Me.gbCadastroPagamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCadastroPagamento.Controls.Add(Me.btnAddPag)
        Me.gbCadastroPagamento.Controls.Add(Me.lblFormaPagamento)
        Me.gbCadastroPagamento.Controls.Add(Me.txtNovaFormaPag)
        Me.gbCadastroPagamento.Location = New System.Drawing.Point(34, 20)
        Me.gbCadastroPagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbCadastroPagamento.Name = "gbCadastroPagamento"
        Me.gbCadastroPagamento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbCadastroPagamento.Size = New System.Drawing.Size(951, 116)
        Me.gbCadastroPagamento.TabIndex = 10
        Me.gbCadastroPagamento.TabStop = False
        Me.gbCadastroPagamento.Text = "Cadastrar"
        '
        'lblFormaPagamento
        '
        Me.lblFormaPagamento.AutoSize = True
        Me.lblFormaPagamento.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.lblFormaPagamento.Location = New System.Drawing.Point(82, 36)
        Me.lblFormaPagamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFormaPagamento.Name = "lblFormaPagamento"
        Me.lblFormaPagamento.Size = New System.Drawing.Size(233, 18)
        Me.lblFormaPagamento.TabIndex = 1
        Me.lblFormaPagamento.Text = "Nova forma de pagamento:"
        '
        'txtNovaFormaPag
        '
        Me.txtNovaFormaPag.Alterado = False
        Me.txtNovaFormaPag.BackColor = System.Drawing.Color.White
        Me.txtNovaFormaPag.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtNovaFormaPag.Location = New System.Drawing.Point(85, 65)
        Me.txtNovaFormaPag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNovaFormaPag.Multiline = True
        Me.txtNovaFormaPag.Name = "txtNovaFormaPag"
        Me.txtNovaFormaPag.Size = New System.Drawing.Size(350, 32)
        Me.txtNovaFormaPag.SuperMascara = ""
        Me.txtNovaFormaPag.SuperObrigatorio = True
        Me.txtNovaFormaPag.SuperTravaErrors = False
        Me.txtNovaFormaPag.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtNovaFormaPag.SuperTxtObrigatorio = "Nova Forma de pagamento"
        Me.txtNovaFormaPag.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtNovaFormaPag.TabIndex = 0
        '
        'gbConsultaPagamento
        '
        Me.gbConsultaPagamento.Controls.Add(Me.gbBotoesPagamento)
        Me.gbConsultaPagamento.Controls.Add(Me.lvFormaPagamento)
        Me.gbConsultaPagamento.Location = New System.Drawing.Point(34, 152)
        Me.gbConsultaPagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbConsultaPagamento.Name = "gbConsultaPagamento"
        Me.gbConsultaPagamento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbConsultaPagamento.Size = New System.Drawing.Size(961, 308)
        Me.gbConsultaPagamento.TabIndex = 9
        Me.gbConsultaPagamento.TabStop = False
        Me.gbConsultaPagamento.Text = "Todos"
        '
        'gbBotoesPagamento
        '
        Me.gbBotoesPagamento.Controls.Add(Me.btnEditarPag)
        Me.gbBotoesPagamento.Controls.Add(Me.btnExcluirPag)
        Me.gbBotoesPagamento.Location = New System.Drawing.Point(440, 24)
        Me.gbBotoesPagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesPagamento.Name = "gbBotoesPagamento"
        Me.gbBotoesPagamento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbBotoesPagamento.Size = New System.Drawing.Size(67, 119)
        Me.gbBotoesPagamento.TabIndex = 9
        Me.gbBotoesPagamento.TabStop = False
        '
        'lvFormaPagamento
        '
        Me.lvFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvFormaPagamento.HabilitaOrdem = True
        Me.lvFormaPagamento.HideSelection = False
        Me.lvFormaPagamento.Location = New System.Drawing.Point(85, 24)
        Me.lvFormaPagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvFormaPagamento.Name = "lvFormaPagamento"
        Me.lvFormaPagamento.SelecionaVarios = False
        Me.lvFormaPagamento.Size = New System.Drawing.Size(350, 275)
        Me.lvFormaPagamento.TabIndex = 0
        Me.lvFormaPagamento.UseCompatibleStateImageBehavior = False
        Me.lvFormaPagamento.View = System.Windows.Forms.View.List
        '
        'tabParcelamento
        '
        Me.tabParcelamento.Controls.Add(Me.GroupBox2)
        Me.tabParcelamento.Controls.Add(Me.GroupBox1)
        Me.tabParcelamento.ImageIndex = 5
        Me.tabParcelamento.Location = New System.Drawing.Point(4, 118)
        Me.tabParcelamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabParcelamento.Name = "tabParcelamento"
        Me.tabParcelamento.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabParcelamento.Size = New System.Drawing.Size(1020, 518)
        Me.tabParcelamento.TabIndex = 4
        Me.tabParcelamento.Text = "Parcelamento"
        Me.tabParcelamento.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.btnExcluirParcela)
        Me.GroupBox2.Controls.Add(Me.btnSalvarParcela)
        Me.GroupBox2.Controls.Add(Me.lvParcela)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 164)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(801, 297)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Todos"
        '
        'lvParcela
        '
        Me.lvParcela.HabilitaOrdem = True
        Me.lvParcela.HideSelection = False
        Me.lvParcela.Location = New System.Drawing.Point(75, 24)
        Me.lvParcela.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lvParcela.Name = "lvParcela"
        Me.lvParcela.SelecionaVarios = False
        Me.lvParcela.Size = New System.Drawing.Size(299, 172)
        Me.lvParcela.TabIndex = 0
        Me.lvParcela.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.btnCadastrarParc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQtdeParcela)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(801, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de parcelas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantidade de Parcelas:"
        '
        'txtQtdeParcela
        '
        Me.txtQtdeParcela.Alterado = False
        Me.txtQtdeParcela.BackColor = System.Drawing.Color.White
        Me.txtQtdeParcela.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtQtdeParcela.Location = New System.Drawing.Point(75, 65)
        Me.txtQtdeParcela.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtQtdeParcela.Multiline = True
        Me.txtQtdeParcela.Name = "txtQtdeParcela"
        Me.txtQtdeParcela.Size = New System.Drawing.Size(92, 32)
        Me.txtQtdeParcela.SuperMascara = ""
        Me.txtQtdeParcela.SuperObrigatorio = False
        Me.txtQtdeParcela.SuperTravaErrors = False
        Me.txtQtdeParcela.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtQtdeParcela.SuperTxtObrigatorio = ""
        Me.txtQtdeParcela.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NumerosInteiros
        Me.txtQtdeParcela.TabIndex = 0
        '
        'btnFecharConfig
        '
        Me.btnFecharConfig.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFecharConfig.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFecharConfig.FlatAppearance.BorderSize = 0
        Me.btnFecharConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.btnFecharConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnFecharConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharConfig.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharConfig.ForeColor = System.Drawing.Color.White
        Me.btnFecharConfig.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFecharConfig.Location = New System.Drawing.Point(0, 594)
        Me.btnFecharConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFecharConfig.Name = "btnFecharConfig"
        Me.btnFecharConfig.Size = New System.Drawing.Size(1028, 46)
        Me.btnFecharConfig.TabIndex = 12
        Me.btnFecharConfig.Text = " &Fechar "
        Me.btnFecharConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFecharConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFecharConfig.UseVisualStyleBackColor = False
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
        Me.btnFechar.Location = New System.Drawing.Point(958, -1)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(73, 50)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnEditarReceita
        '
        Me.btnEditarReceita.FlatAppearance.BorderSize = 0
        Me.btnEditarReceita.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditarReceita.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarReceita.Image = CType(resources.GetObject("btnEditarReceita.Image"), System.Drawing.Image)
        Me.btnEditarReceita.Location = New System.Drawing.Point(4, 11)
        Me.btnEditarReceita.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarReceita.Name = "btnEditarReceita"
        Me.btnEditarReceita.Size = New System.Drawing.Size(56, 58)
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
        Me.btnExcluirReceita.Location = New System.Drawing.Point(4, 73)
        Me.btnExcluirReceita.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluirReceita.Name = "btnExcluirReceita"
        Me.btnExcluirReceita.Size = New System.Drawing.Size(50, 49)
        Me.btnExcluirReceita.TabIndex = 2
        Me.btnExcluirReceita.UseVisualStyleBackColor = True
        '
        'btnAdicionarReceita
        '
        Me.btnAdicionarReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAdicionarReceita.Location = New System.Drawing.Point(427, 55)
        Me.btnAdicionarReceita.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdicionarReceita.Name = "btnAdicionarReceita"
        Me.btnAdicionarReceita.Size = New System.Drawing.Size(203, 42)
        Me.btnAdicionarReceita.TabIndex = 2
        Me.btnAdicionarReceita.Text = "Adicionar"
        Me.btnAdicionarReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionarReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdicionarReceita.UseVisualStyleBackColor = True
        '
        'btnAddCatDespesa
        '
        Me.btnAddCatDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAddCatDespesa.Location = New System.Drawing.Point(457, 54)
        Me.btnAddCatDespesa.Name = "btnAddCatDespesa"
        Me.btnAddCatDespesa.Size = New System.Drawing.Size(203, 42)
        Me.btnAddCatDespesa.TabIndex = 4
        Me.btnAddCatDespesa.Text = " &Adicionar"
        Me.btnAddCatDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddCatDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddCatDespesa.UseVisualStyleBackColor = True
        '
        'btnEditarDespesa
        '
        Me.btnEditarDespesa.FlatAppearance.BorderSize = 0
        Me.btnEditarDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditarDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarDespesa.Image = CType(resources.GetObject("btnEditarDespesa.Image"), System.Drawing.Image)
        Me.btnEditarDespesa.Location = New System.Drawing.Point(4, 11)
        Me.btnEditarDespesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarDespesa.Name = "btnEditarDespesa"
        Me.btnEditarDespesa.Size = New System.Drawing.Size(56, 58)
        Me.btnEditarDespesa.TabIndex = 1
        Me.btnEditarDespesa.UseVisualStyleBackColor = True
        '
        'btnExcluirDespesa
        '
        Me.btnExcluirDespesa.FlatAppearance.BorderSize = 0
        Me.btnExcluirDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnExcluirDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExcluirDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconFechar48
        Me.btnExcluirDespesa.Location = New System.Drawing.Point(4, 74)
        Me.btnExcluirDespesa.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluirDespesa.Name = "btnExcluirDespesa"
        Me.btnExcluirDespesa.Size = New System.Drawing.Size(50, 49)
        Me.btnExcluirDespesa.TabIndex = 2
        Me.btnExcluirDespesa.UseVisualStyleBackColor = True
        '
        'btnAddPag
        '
        Me.btnAddPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAddPag.Location = New System.Drawing.Point(440, 56)
        Me.btnAddPag.Name = "btnAddPag"
        Me.btnAddPag.Size = New System.Drawing.Size(203, 42)
        Me.btnAddPag.TabIndex = 4
        Me.btnAddPag.Text = " &Adicionar"
        Me.btnAddPag.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPag.UseVisualStyleBackColor = True
        '
        'btnEditarPag
        '
        Me.btnEditarPag.FlatAppearance.BorderSize = 0
        Me.btnEditarPag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEditarPag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEditarPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEditarFile
        Me.btnEditarPag.Location = New System.Drawing.Point(4, 13)
        Me.btnEditarPag.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarPag.Name = "btnEditarPag"
        Me.btnEditarPag.Size = New System.Drawing.Size(54, 48)
        Me.btnEditarPag.TabIndex = 6
        Me.btnEditarPag.UseVisualStyleBackColor = True
        '
        'btnExcluirPag
        '
        Me.btnExcluirPag.FlatAppearance.BorderSize = 0
        Me.btnExcluirPag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight
        Me.btnExcluirPag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExcluirPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirPag.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconFechar48
        Me.btnExcluirPag.Location = New System.Drawing.Point(4, 66)
        Me.btnExcluirPag.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluirPag.Name = "btnExcluirPag"
        Me.btnExcluirPag.Size = New System.Drawing.Size(54, 50)
        Me.btnExcluirPag.TabIndex = 8
        Me.btnExcluirPag.UseVisualStyleBackColor = True
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
        Me.btnExcluirParcela.Location = New System.Drawing.Point(238, 222)
        Me.btnExcluirParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcluirParcela.Name = "btnExcluirParcela"
        Me.btnExcluirParcela.Size = New System.Drawing.Size(149, 44)
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
        Me.btnSalvarParcela.Location = New System.Drawing.Point(63, 222)
        Me.btnSalvarParcela.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalvarParcela.Name = "btnSalvarParcela"
        Me.btnSalvarParcela.Size = New System.Drawing.Size(149, 44)
        Me.btnSalvarParcela.TabIndex = 3
        Me.btnSalvarParcela.Text = " &Usar este"
        Me.btnSalvarParcela.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvarParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarParcela.UseVisualStyleBackColor = False
        '
        'btnCadastrarParc
        '
        Me.btnCadastrarParc.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCadastrarParc.FlatAppearance.BorderSize = 0
        Me.btnCadastrarParc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCadastrarParc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.btnCadastrarParc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarParc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarParc.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarParc.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnCadastrarParc.Location = New System.Drawing.Point(171, 56)
        Me.btnCadastrarParc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCadastrarParc.Name = "btnCadastrarParc"
        Me.btnCadastrarParc.Size = New System.Drawing.Size(203, 42)
        Me.btnCadastrarParc.TabIndex = 2
        Me.btnCadastrarParc.Text = " &Adicionar"
        Me.btnCadastrarParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastrarParc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrarParc.UseVisualStyleBackColor = False
        '
        'frmConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 640)
        Me.Controls.Add(Me.btnFecharConfig)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.tabCtrlConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmConfiguracao"
        Me.Text = "frmConfiguracao"
        Me.tabCtrlConfig.ResumeLayout(False)
        Me.tabReceita.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gbBotoesReceita.ResumeLayout(False)
        Me.gbAddReceita.ResumeLayout(False)
        Me.gbAddReceita.PerformLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFecharConfig As Button
    Friend WithEvents tabCategoriaDespesa As TabPage
    Friend WithEvents gbCadastroDespesa As GroupBox
    Friend WithEvents lblCategoriaDespesa As Label
    Friend WithEvents txtNovaCategoriaDespesa As GFT.Util.SuperTextBox
    Friend WithEvents gbTodasDespesa As GroupBox
    Friend WithEvents gbBotoesCategoriaDespesa As GroupBox
    Friend WithEvents btnEditarDespesa As Button
    Friend WithEvents btnExcluirDespesa As Button
    Friend WithEvents lvCategoriaDespesa As GFT.Util.SuperLV
    Friend WithEvents tabReceita As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gbBotoesReceita As GroupBox
    Friend WithEvents btnEditarReceita As Button
    Friend WithEvents btnExcluirReceita As Button
    Friend WithEvents lvReceita As GFT.Util.SuperLV
    Friend WithEvents gbAddReceita As GroupBox
    Friend WithEvents btnAdicionarReceita As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNovaReceita As GFT.Util.SuperTextBox
    Friend WithEvents tabCtrlConfig As GFT.Util.SuperTabControl
    Friend WithEvents tabFormaPagamento As TabPage
    Friend WithEvents gbCadastroPagamento As GroupBox
    Friend WithEvents lblFormaPagamento As Label
    Friend WithEvents txtNovaFormaPag As GFT.Util.SuperTextBox
    Friend WithEvents gbConsultaPagamento As GroupBox
    Friend WithEvents gbBotoesPagamento As GroupBox
    Friend WithEvents btnEditarPag As Button
    Friend WithEvents btnExcluirPag As Button
    Friend WithEvents lvFormaPagamento As GFT.Util.SuperLV
    Friend WithEvents tabParcelamento As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExcluirParcela As Button
    Friend WithEvents btnSalvarParcela As Button
    Friend WithEvents lvParcela As GFT.Util.SuperLV
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCadastrarParc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQtdeParcela As GFT.Util.SuperTextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnAddCatDespesa As Button
    Friend WithEvents btnAddPag As Button
End Class
