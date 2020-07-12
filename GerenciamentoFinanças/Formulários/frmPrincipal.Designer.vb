<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServiçoDeEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PersonalizacaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvestimentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SScima = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SsBaixo = New System.Windows.Forms.StatusStrip()
        Me.txtCaptionHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ssTituloTela = New System.Windows.Forms.StatusStrip()
        Me.txtCaption = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbPricnipal = New System.Windows.Forms.GroupBox()
        Me.tabCtrlAvisos = New System.Windows.Forms.TabControl()
        Me.tabCtrlPrincAvisos = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbAcessoRapido = New System.Windows.Forms.GroupBox()
        Me.btnAddConta = New System.Windows.Forms.Button()
        Me.btnAddDespesa = New System.Windows.Forms.Button()
        Me.btnAddReceita = New System.Windows.Forms.Button()
        Me.tabCtrlSaldo = New System.Windows.Forms.TabControl()
        Me.tabSaldo = New System.Windows.Forms.TabPage()
        Me.btnRefreshSaldo = New System.Windows.Forms.Button()
        Me.tabCtrlInvest = New System.Windows.Forms.TabControl()
        Me.tabInvest = New System.Windows.Forms.TabPage()
        Me.btnRefreshInvest = New System.Windows.Forms.Button()
        Me.btnInvest = New System.Windows.Forms.Button()
        Me.tabCtrlDespesa = New System.Windows.Forms.TabControl()
        Me.tabTotDesp = New System.Windows.Forms.TabPage()
        Me.btnRefreshDespesa = New System.Windows.Forms.Button()
        Me.btnDespesa = New System.Windows.Forms.Button()
        Me.tabCtrlPrincReceita = New System.Windows.Forms.TabControl()
        Me.TabPrinc = New System.Windows.Forms.TabPage()
        Me.btnRefreshReceita = New System.Windows.Forms.Button()
        Me.btnReceita = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SScima.SuspendLayout()
        Me.SsBaixo.SuspendLayout()
        Me.ssTituloTela.SuspendLayout()
        Me.gbPricnipal.SuspendLayout()
        Me.tabCtrlAvisos.SuspendLayout()
        Me.tabCtrlPrincAvisos.SuspendLayout()
        Me.gbAcessoRapido.SuspendLayout()
        Me.tabCtrlSaldo.SuspendLayout()
        Me.tabSaldo.SuspendLayout()
        Me.tabCtrlInvest.SuspendLayout()
        Me.tabInvest.SuspendLayout()
        Me.tabCtrlDespesa.SuspendLayout()
        Me.tabTotDesp.SuspendLayout()
        Me.tabCtrlPrincReceita.SuspendLayout()
        Me.TabPrinc.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustesToolStripMenuItem, Me.ContaToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ReceitasToolStripMenuItem, Me.DespesasToolStripMenuItem, Me.InvestimentosToolStripMenuItem, Me.CobrançaToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.JanelasToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LoginToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 53)
        Me.MenuStrip1.MdiWindowListItem = Me.JanelasToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(2229, 88)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.AutoSize = False
        Me.AjustesToolStripMenuItem.AutoToolTip = True
        Me.AjustesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ServiçoDeEmailToolStripMenuItem, Me.ToolStripSeparator2, Me.PersonalizacaoToolStripMenuItem, Me.ToolStripSeparator4, Me.ConfigLoginToolStripMenuItem, Me.ToolStripSeparator1})
        Me.AjustesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjustesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AjustesToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEngrenagem
        Me.AjustesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(152, 58)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(365, 6)
        '
        'ServiçoDeEmailToolStripMenuItem
        '
        Me.ServiçoDeEmailToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ServiçoDeEmailToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEnvioEmail
        Me.ServiçoDeEmailToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ServiçoDeEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ServiçoDeEmailToolStripMenuItem.Name = "ServiçoDeEmailToolStripMenuItem"
        Me.ServiçoDeEmailToolStripMenuItem.Size = New System.Drawing.Size(368, 54)
        Me.ServiçoDeEmailToolStripMenuItem.Text = " &Envio de E-mail"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(365, 6)
        '
        'PersonalizacaoToolStripMenuItem
        '
        Me.PersonalizacaoToolStripMenuItem.Image = CType(resources.GetObject("PersonalizacaoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PersonalizacaoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PersonalizacaoToolStripMenuItem.Name = "PersonalizacaoToolStripMenuItem"
        Me.PersonalizacaoToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PersonalizacaoToolStripMenuItem.Size = New System.Drawing.Size(368, 54)
        Me.PersonalizacaoToolStripMenuItem.Text = " &Personalização"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(365, 6)
        '
        'ConfigLoginToolStripMenuItem
        '
        Me.ConfigLoginToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconUsuar
        Me.ConfigLoginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfigLoginToolStripMenuItem.Name = "ConfigLoginToolStripMenuItem"
        Me.ConfigLoginToolStripMenuItem.Size = New System.Drawing.Size(368, 54)
        Me.ConfigLoginToolStripMenuItem.Text = " &Configurção de Login"
        Me.ConfigLoginToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(365, 6)
        '
        'ContaToolStripMenuItem
        '
        Me.ContaToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold)
        Me.ContaToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconBank
        Me.ContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContaToolStripMenuItem.Name = "ContaToolStripMenuItem"
        Me.ContaToolStripMenuItem.Size = New System.Drawing.Size(259, 84)
        Me.ContaToolStripMenuItem.Text = "Conta Báncaria"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ConsultaToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExtract
        Me.ConsultaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(151, 84)
        Me.ConsultaToolStripMenuItem.Text = "Extrato"
        '
        'ReceitasToolStripMenuItem
        '
        Me.ReceitasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ReceitasToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconReceita
        Me.ReceitasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReceitasToolStripMenuItem.Name = "ReceitasToolStripMenuItem"
        Me.ReceitasToolStripMenuItem.Size = New System.Drawing.Size(152, 84)
        Me.ReceitasToolStripMenuItem.Text = "Receitas"
        '
        'DespesasToolStripMenuItem
        '
        Me.DespesasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DespesasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DespesasToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconDespesa
        Me.DespesasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DespesasToolStripMenuItem.Name = "DespesasToolStripMenuItem"
        Me.DespesasToolStripMenuItem.Size = New System.Drawing.Size(161, 84)
        Me.DespesasToolStripMenuItem.Text = "Despesas"
        '
        'InvestimentosToolStripMenuItem
        '
        Me.InvestimentosToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InvestimentosToolStripMenuItem.Image = CType(resources.GetObject("InvestimentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InvestimentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InvestimentosToolStripMenuItem.Name = "InvestimentosToolStripMenuItem"
        Me.InvestimentosToolStripMenuItem.Size = New System.Drawing.Size(228, 84)
        Me.InvestimentosToolStripMenuItem.Text = "Investimentos"
        '
        'CobrançaToolStripMenuItem
        '
        Me.CobrançaToolStripMenuItem.Image = CType(resources.GetObject("CobrançaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CobrançaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CobrançaToolStripMenuItem.Name = "CobrançaToolStripMenuItem"
        Me.CobrançaToolStripMenuItem.Size = New System.Drawing.Size(169, 84)
        Me.CobrançaToolStripMenuItem.Text = "Cobrança"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Image = CType(resources.GetObject("RelatórioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(169, 84)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'JanelasToolStripMenuItem
        '
        Me.JanelasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JanelasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.JanelasToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconJanelas
        Me.JanelasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        Me.JanelasToolStripMenuItem.Size = New System.Drawing.Size(154, 84)
        Me.JanelasToolStripMenuItem.Text = "Janelas"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAbout
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(129, 84)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LoginToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconLogout
        Me.LoginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(130, 84)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(75, 84)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'SScima
        '
        Me.SScima.AutoSize = False
        Me.SScima.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SScima.Dock = System.Windows.Forms.DockStyle.Top
        Me.SScima.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SScima.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SScima.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.SScima.Location = New System.Drawing.Point(0, 0)
        Me.SScima.Name = "SScima"
        Me.SScima.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SScima.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.SScima.Size = New System.Drawing.Size(2229, 53)
        Me.SScima.SizingGrip = False
        Me.SScima.TabIndex = 2
        Me.SScima.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(164, 48)
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SsBaixo
        '
        Me.SsBaixo.AutoSize = False
        Me.SsBaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SsBaixo.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SsBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SsBaixo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaptionHora})
        Me.SsBaixo.Location = New System.Drawing.Point(0, 930)
        Me.SsBaixo.Name = "SsBaixo"
        Me.SsBaixo.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SsBaixo.Size = New System.Drawing.Size(2229, 37)
        Me.SsBaixo.SizingGrip = False
        Me.SsBaixo.TabIndex = 3
        Me.SsBaixo.Text = "StatusStrip2"
        '
        'txtCaptionHora
        '
        Me.txtCaptionHora.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.txtCaptionHora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaptionHora.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaptionHora.ForeColor = System.Drawing.Color.White
        Me.txtCaptionHora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaptionHora.Name = "txtCaptionHora"
        Me.txtCaptionHora.Size = New System.Drawing.Size(2209, 31)
        Me.txtCaptionHora.Spring = True
        Me.txtCaptionHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaptionHora.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ssTituloTela
        '
        Me.ssTituloTela.AutoSize = False
        Me.ssTituloTela.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ssTituloTela.Dock = System.Windows.Forms.DockStyle.Top
        Me.ssTituloTela.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssTituloTela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ssTituloTela.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaption})
        Me.ssTituloTela.Location = New System.Drawing.Point(0, 141)
        Me.ssTituloTela.Name = "ssTituloTela"
        Me.ssTituloTela.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssTituloTela.Size = New System.Drawing.Size(2229, 34)
        Me.ssTituloTela.SizingGrip = False
        Me.ssTituloTela.TabIndex = 6
        Me.ssTituloTela.Text = "StatusStrip1"
        '
        'txtCaption
        '
        Me.txtCaption.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.txtCaption.AutoSize = False
        Me.txtCaption.BackColor = System.Drawing.Color.Transparent
        Me.txtCaption.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.txtCaption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.txtCaption.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaption.ForeColor = System.Drawing.Color.White
        Me.txtCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtCaption.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(2160, 29)
        Me.txtCaption.Spring = True
        Me.txtCaption.Text = "HOME"
        Me.txtCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtCaption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.txtCaption.ToolTipText = "Você está aqui"
        '
        'gbPricnipal
        '
        Me.gbPricnipal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbPricnipal.Controls.Add(Me.tabCtrlAvisos)
        Me.gbPricnipal.Controls.Add(Me.gbAcessoRapido)
        Me.gbPricnipal.Controls.Add(Me.tabCtrlSaldo)
        Me.gbPricnipal.Controls.Add(Me.tabCtrlInvest)
        Me.gbPricnipal.Controls.Add(Me.tabCtrlDespesa)
        Me.gbPricnipal.Controls.Add(Me.tabCtrlPrincReceita)
        Me.gbPricnipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbPricnipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbPricnipal.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.gbPricnipal.Location = New System.Drawing.Point(0, 175)
        Me.gbPricnipal.Margin = New System.Windows.Forms.Padding(4)
        Me.gbPricnipal.Name = "gbPricnipal"
        Me.gbPricnipal.Padding = New System.Windows.Forms.Padding(4)
        Me.gbPricnipal.Size = New System.Drawing.Size(2229, 755)
        Me.gbPricnipal.TabIndex = 11
        Me.gbPricnipal.TabStop = False
        '
        'tabCtrlAvisos
        '
        Me.tabCtrlAvisos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlAvisos.Controls.Add(Me.tabCtrlPrincAvisos)
        Me.tabCtrlAvisos.Location = New System.Drawing.Point(143, 463)
        Me.tabCtrlAvisos.Name = "tabCtrlAvisos"
        Me.tabCtrlAvisos.Padding = New System.Drawing.Point(100, 10)
        Me.tabCtrlAvisos.SelectedIndex = 0
        Me.tabCtrlAvisos.Size = New System.Drawing.Size(974, 260)
        Me.tabCtrlAvisos.TabIndex = 6
        '
        'tabCtrlPrincAvisos
        '
        Me.tabCtrlPrincAvisos.AutoScroll = True
        Me.tabCtrlPrincAvisos.Controls.Add(Me.GroupBox1)
        Me.tabCtrlPrincAvisos.Location = New System.Drawing.Point(4, 48)
        Me.tabCtrlPrincAvisos.Name = "tabCtrlPrincAvisos"
        Me.tabCtrlPrincAvisos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCtrlPrincAvisos.Size = New System.Drawing.Size(966, 208)
        Me.tabCtrlPrincAvisos.TabIndex = 0
        Me.tabCtrlPrincAvisos.Text = "Lembretes"
        Me.tabCtrlPrincAvisos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(39, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gbAcessoRapido
        '
        Me.gbAcessoRapido.BackColor = System.Drawing.Color.SteelBlue
        Me.gbAcessoRapido.Controls.Add(Me.btnAddConta)
        Me.gbAcessoRapido.Controls.Add(Me.btnAddDespesa)
        Me.gbAcessoRapido.Controls.Add(Me.btnAddReceita)
        Me.gbAcessoRapido.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbAcessoRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbAcessoRapido.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbAcessoRapido.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbAcessoRapido.Location = New System.Drawing.Point(4, 29)
        Me.gbAcessoRapido.Margin = New System.Windows.Forms.Padding(4)
        Me.gbAcessoRapido.Name = "gbAcessoRapido"
        Me.gbAcessoRapido.Padding = New System.Windows.Forms.Padding(133, 4, 4, 4)
        Me.gbAcessoRapido.Size = New System.Drawing.Size(2221, 98)
        Me.gbAcessoRapido.TabIndex = 5
        Me.gbAcessoRapido.TabStop = False
        Me.gbAcessoRapido.Text = "Acesso Rápido"
        '
        'btnAddConta
        '
        Me.btnAddConta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddConta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddConta.FlatAppearance.BorderSize = 0
        Me.btnAddConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAddConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAddConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddConta.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnAddConta.ForeColor = System.Drawing.Color.Black
        Me.btnAddConta.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddBlue
        Me.btnAddConta.Location = New System.Drawing.Point(795, 32)
        Me.btnAddConta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddConta.Name = "btnAddConta"
        Me.btnAddConta.Size = New System.Drawing.Size(271, 52)
        Me.btnAddConta.TabIndex = 6
        Me.btnAddConta.Text = " &Conta"
        Me.btnAddConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddConta.UseVisualStyleBackColor = False
        '
        'btnAddDespesa
        '
        Me.btnAddDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddDespesa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddDespesa.FlatAppearance.BorderSize = 0
        Me.btnAddDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAddDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAddDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDespesa.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnAddDespesa.ForeColor = System.Drawing.Color.Black
        Me.btnAddDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddDespesa
        Me.btnAddDespesa.Location = New System.Drawing.Point(497, 32)
        Me.btnAddDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(271, 52)
        Me.btnAddDespesa.TabIndex = 5
        Me.btnAddDespesa.Text = " &Despesa"
        Me.btnAddDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = False
        '
        'btnAddReceita
        '
        Me.btnAddReceita.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddReceita.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddReceita.FlatAppearance.BorderSize = 0
        Me.btnAddReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.btnAddReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAddReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReceita.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.btnAddReceita.ForeColor = System.Drawing.Color.Black
        Me.btnAddReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita1
        Me.btnAddReceita.Location = New System.Drawing.Point(200, 32)
        Me.btnAddReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddReceita.Name = "btnAddReceita"
        Me.btnAddReceita.Size = New System.Drawing.Size(271, 52)
        Me.btnAddReceita.TabIndex = 4
        Me.btnAddReceita.Text = " &Receita"
        Me.btnAddReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddReceita.UseVisualStyleBackColor = False
        '
        'tabCtrlSaldo
        '
        Me.tabCtrlSaldo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlSaldo.Controls.Add(Me.tabSaldo)
        Me.tabCtrlSaldo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlSaldo.Location = New System.Drawing.Point(143, 204)
        Me.tabCtrlSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlSaldo.Name = "tabCtrlSaldo"
        Me.tabCtrlSaldo.Padding = New System.Drawing.Point(107, 10)
        Me.tabCtrlSaldo.SelectedIndex = 0
        Me.tabCtrlSaldo.Size = New System.Drawing.Size(467, 220)
        Me.tabCtrlSaldo.TabIndex = 3
        '
        'tabSaldo
        '
        Me.tabSaldo.AutoScroll = True
        Me.tabSaldo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabSaldo.Controls.Add(Me.btnRefreshSaldo)
        Me.tabSaldo.Location = New System.Drawing.Point(4, 48)
        Me.tabSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSaldo.Name = "tabSaldo"
        Me.tabSaldo.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSaldo.Size = New System.Drawing.Size(459, 168)
        Me.tabSaldo.TabIndex = 0
        Me.tabSaldo.Text = "Saldo na Conta"
        '
        'btnRefreshSaldo
        '
        Me.btnRefreshSaldo.FlatAppearance.BorderSize = 0
        Me.btnRefreshSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshSaldo.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconRefresh
        Me.btnRefreshSaldo.Location = New System.Drawing.Point(3, 4)
        Me.btnRefreshSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshSaldo.Name = "btnRefreshSaldo"
        Me.btnRefreshSaldo.Size = New System.Drawing.Size(57, 42)
        Me.btnRefreshSaldo.TabIndex = 4
        Me.btnRefreshSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefreshSaldo.UseVisualStyleBackColor = True
        '
        'tabCtrlInvest
        '
        Me.tabCtrlInvest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlInvest.Controls.Add(Me.tabInvest)
        Me.tabCtrlInvest.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlInvest.Location = New System.Drawing.Point(1648, 204)
        Me.tabCtrlInvest.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlInvest.Name = "tabCtrlInvest"
        Me.tabCtrlInvest.Padding = New System.Drawing.Point(110, 10)
        Me.tabCtrlInvest.SelectedIndex = 0
        Me.tabCtrlInvest.Size = New System.Drawing.Size(459, 220)
        Me.tabCtrlInvest.TabIndex = 2
        '
        'tabInvest
        '
        Me.tabInvest.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabInvest.Controls.Add(Me.btnRefreshInvest)
        Me.tabInvest.Controls.Add(Me.btnInvest)
        Me.tabInvest.Location = New System.Drawing.Point(4, 48)
        Me.tabInvest.Margin = New System.Windows.Forms.Padding(4)
        Me.tabInvest.Name = "tabInvest"
        Me.tabInvest.Padding = New System.Windows.Forms.Padding(4)
        Me.tabInvest.Size = New System.Drawing.Size(451, 168)
        Me.tabInvest.TabIndex = 0
        Me.tabInvest.Text = "Investimentos"
        '
        'btnRefreshInvest
        '
        Me.btnRefreshInvest.FlatAppearance.BorderSize = 0
        Me.btnRefreshInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshInvest.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconRefresh
        Me.btnRefreshInvest.Location = New System.Drawing.Point(4, 4)
        Me.btnRefreshInvest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshInvest.Name = "btnRefreshInvest"
        Me.btnRefreshInvest.Size = New System.Drawing.Size(57, 42)
        Me.btnRefreshInvest.TabIndex = 7
        Me.btnRefreshInvest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefreshInvest.UseVisualStyleBackColor = True
        '
        'btnInvest
        '
        Me.btnInvest.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnInvest.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnInvest.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnInvest.FlatAppearance.BorderSize = 2
        Me.btnInvest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvest.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInvest.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnInvest.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconeInvest
        Me.btnInvest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInvest.Location = New System.Drawing.Point(109, 14)
        Me.btnInvest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInvest.Name = "btnInvest"
        Me.btnInvest.Size = New System.Drawing.Size(255, 127)
        Me.btnInvest.TabIndex = 2
        Me.btnInvest.UseVisualStyleBackColor = False
        '
        'tabCtrlDespesa
        '
        Me.tabCtrlDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlDespesa.Controls.Add(Me.tabTotDesp)
        Me.tabCtrlDespesa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlDespesa.Location = New System.Drawing.Point(1131, 204)
        Me.tabCtrlDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlDespesa.Name = "tabCtrlDespesa"
        Me.tabCtrlDespesa.Padding = New System.Drawing.Point(107, 10)
        Me.tabCtrlDespesa.SelectedIndex = 0
        Me.tabCtrlDespesa.Size = New System.Drawing.Size(505, 220)
        Me.tabCtrlDespesa.TabIndex = 1
        '
        'tabTotDesp
        '
        Me.tabTotDesp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tabTotDesp.Controls.Add(Me.btnRefreshDespesa)
        Me.tabTotDesp.Controls.Add(Me.btnDespesa)
        Me.tabTotDesp.Location = New System.Drawing.Point(4, 48)
        Me.tabTotDesp.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTotDesp.Name = "tabTotDesp"
        Me.tabTotDesp.Padding = New System.Windows.Forms.Padding(4)
        Me.tabTotDesp.Size = New System.Drawing.Size(497, 168)
        Me.tabTotDesp.TabIndex = 0
        Me.tabTotDesp.Text = "Total de Despesas"
        '
        'btnRefreshDespesa
        '
        Me.btnRefreshDespesa.FlatAppearance.BorderSize = 0
        Me.btnRefreshDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconRefresh
        Me.btnRefreshDespesa.Location = New System.Drawing.Point(4, 4)
        Me.btnRefreshDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshDespesa.Name = "btnRefreshDespesa"
        Me.btnRefreshDespesa.Size = New System.Drawing.Size(57, 42)
        Me.btnRefreshDespesa.TabIndex = 6
        Me.btnRefreshDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefreshDespesa.UseVisualStyleBackColor = True
        '
        'btnDespesa
        '
        Me.btnDespesa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDespesa.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnDespesa.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDespesa.FlatAppearance.BorderSize = 2
        Me.btnDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDespesa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDespesa.ForeColor = System.Drawing.Color.Red
        Me.btnDespesa.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconDespesa
        Me.btnDespesa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDespesa.Location = New System.Drawing.Point(125, 14)
        Me.btnDespesa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDespesa.Name = "btnDespesa"
        Me.btnDespesa.Size = New System.Drawing.Size(241, 127)
        Me.btnDespesa.TabIndex = 1
        Me.btnDespesa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDespesa.UseVisualStyleBackColor = False
        '
        'tabCtrlPrincReceita
        '
        Me.tabCtrlPrincReceita.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabCtrlPrincReceita.Controls.Add(Me.TabPrinc)
        Me.tabCtrlPrincReceita.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCtrlPrincReceita.HotTrack = True
        Me.tabCtrlPrincReceita.Location = New System.Drawing.Point(624, 204)
        Me.tabCtrlPrincReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.tabCtrlPrincReceita.Name = "tabCtrlPrincReceita"
        Me.tabCtrlPrincReceita.Padding = New System.Drawing.Point(107, 10)
        Me.tabCtrlPrincReceita.SelectedIndex = 0
        Me.tabCtrlPrincReceita.Size = New System.Drawing.Size(493, 220)
        Me.tabCtrlPrincReceita.TabIndex = 0
        '
        'TabPrinc
        '
        Me.TabPrinc.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPrinc.Controls.Add(Me.btnRefreshReceita)
        Me.TabPrinc.Controls.Add(Me.btnReceita)
        Me.TabPrinc.Location = New System.Drawing.Point(4, 48)
        Me.TabPrinc.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPrinc.Name = "TabPrinc"
        Me.TabPrinc.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPrinc.Size = New System.Drawing.Size(485, 168)
        Me.TabPrinc.TabIndex = 0
        Me.TabPrinc.Text = "Total de Receitas"
        '
        'btnRefreshReceita
        '
        Me.btnRefreshReceita.FlatAppearance.BorderSize = 0
        Me.btnRefreshReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconRefresh
        Me.btnRefreshReceita.Location = New System.Drawing.Point(1, 1)
        Me.btnRefreshReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefreshReceita.Name = "btnRefreshReceita"
        Me.btnRefreshReceita.Size = New System.Drawing.Size(57, 42)
        Me.btnRefreshReceita.TabIndex = 5
        Me.btnRefreshReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefreshReceita.UseVisualStyleBackColor = True
        '
        'btnReceita
        '
        Me.btnReceita.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReceita.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnReceita.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnReceita.FlatAppearance.BorderSize = 2
        Me.btnReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceita.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceita.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconReceita
        Me.btnReceita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReceita.Location = New System.Drawing.Point(107, 14)
        Me.btnReceita.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReceita.Name = "btnReceita"
        Me.btnReceita.Size = New System.Drawing.Size(241, 127)
        Me.btnReceita.TabIndex = 0
        Me.btnReceita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReceita.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2229, 967)
        Me.Controls.Add(Me.gbPricnipal)
        Me.Controls.Add(Me.ssTituloTela)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SsBaixo)
        Me.Controls.Add(Me.SScima)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.Text = " Finance $ Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SScima.ResumeLayout(False)
        Me.SScima.PerformLayout()
        Me.SsBaixo.ResumeLayout(False)
        Me.SsBaixo.PerformLayout()
        Me.ssTituloTela.ResumeLayout(False)
        Me.ssTituloTela.PerformLayout()
        Me.gbPricnipal.ResumeLayout(False)
        Me.tabCtrlAvisos.ResumeLayout(False)
        Me.tabCtrlPrincAvisos.ResumeLayout(False)
        Me.gbAcessoRapido.ResumeLayout(False)
        Me.tabCtrlSaldo.ResumeLayout(False)
        Me.tabSaldo.ResumeLayout(False)
        Me.tabCtrlInvest.ResumeLayout(False)
        Me.tabInvest.ResumeLayout(False)
        Me.tabCtrlDespesa.ResumeLayout(False)
        Me.tabTotDesp.ResumeLayout(False)
        Me.tabCtrlPrincReceita.ResumeLayout(False)
        Me.TabPrinc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceitasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DespesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SScima As StatusStrip
    Friend WithEvents SsBaixo As StatusStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtCaptionHora As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçoDeEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ssTituloTela As StatusStrip
    Friend WithEvents txtCaption As ToolStripStatusLabel
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PersonalizacaoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents InvestimentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbPricnipal As GroupBox
    Friend WithEvents tabCtrlSaldo As TabControl
    Friend WithEvents tabSaldo As TabPage
    Friend WithEvents tabCtrlInvest As TabControl
    Friend WithEvents tabInvest As TabPage
    Friend WithEvents tabCtrlDespesa As TabControl
    Friend WithEvents tabTotDesp As TabPage
    Friend WithEvents tabCtrlPrincReceita As TabControl
    Friend WithEvents TabPrinc As TabPage
    Friend WithEvents gbAcessoRapido As GroupBox
    Friend WithEvents btnAddDespesa As Button
    Friend WithEvents btnAddReceita As Button
    Friend WithEvents btnAddConta As Button
    Friend WithEvents btnReceita As Button
    Friend WithEvents btnInvest As Button
    Friend WithEvents btnDespesa As Button
    Friend WithEvents btnRefreshSaldo As Button
    Friend WithEvents btnRefreshInvest As Button
    Friend WithEvents btnRefreshDespesa As Button
    Friend WithEvents btnRefreshReceita As Button
    Friend WithEvents ContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabCtrlAvisos As TabControl
    Friend WithEvents tabCtrlPrincAvisos As TabPage
    Friend WithEvents GroupBox1 As GroupBox
End Class
