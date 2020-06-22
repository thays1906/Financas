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
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServiçoDeEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuárioSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SScima = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SsBaixo = New System.Windows.Forms.StatusStrip()
        Me.txtCaptionHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.txtCaption = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SScima.SuspendLayout()
        Me.SsBaixo.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ReceitasToolStripMenuItem, Me.DespesasToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.JanelasToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LoginToolStripMenuItem1, Me.TesteToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 53)
        Me.MenuStrip1.MdiWindowListItem = Me.JanelasToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1431, 62)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.AutoSize = False
        Me.CadastroToolStripMenuItem.AutoToolTip = True
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasToolStripMenuItem, Me.ToolStripSeparator3, Me.ServiçoDeEmailToolStripMenuItem, Me.ToolStripSeparator2, Me.CategoriasToolStripMenuItem, Me.ToolStripSeparator4, Me.UsuárioSenhaToolStripMenuItem, Me.ToolStripSeparator1})
        Me.CadastroToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CadastroToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconEngrenagem
        Me.CadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(200, 58)
        Me.CadastroToolStripMenuItem.Text = "Configurações"
        '
        'ContasToolStripMenuItem
        '
        Me.ContasToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ContasToolStripMenuItem.AutoToolTip = True
        Me.ContasToolStripMenuItem.Image = CType(resources.GetObject("ContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ContasToolStripMenuItem.Name = "ContasToolStripMenuItem"
        Me.ContasToolStripMenuItem.Size = New System.Drawing.Size(299, 56)
        Me.ContasToolStripMenuItem.Text = " &Contas"
        Me.ContasToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(296, 6)
        '
        'ServiçoDeEmailToolStripMenuItem
        '
        Me.ServiçoDeEmailToolStripMenuItem.Image = CType(resources.GetObject("ServiçoDeEmailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçoDeEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ServiçoDeEmailToolStripMenuItem.Name = "ServiçoDeEmailToolStripMenuItem"
        Me.ServiçoDeEmailToolStripMenuItem.Size = New System.Drawing.Size(299, 56)
        Me.ServiçoDeEmailToolStripMenuItem.Text = " &Envio de E-mail"
        Me.ServiçoDeEmailToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(296, 6)
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.AutoSize = False
        Me.CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoriasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(235, 54)
        Me.CategoriasToolStripMenuItem.Text = " &Parâmetros"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(296, 6)
        '
        'UsuárioSenhaToolStripMenuItem
        '
        Me.UsuárioSenhaToolStripMenuItem.Image = CType(resources.GetObject("UsuárioSenhaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuárioSenhaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuárioSenhaToolStripMenuItem.Name = "UsuárioSenhaToolStripMenuItem"
        Me.UsuárioSenhaToolStripMenuItem.Size = New System.Drawing.Size(299, 56)
        Me.UsuárioSenhaToolStripMenuItem.Text = " &Usuário/Senha"
        Me.UsuárioSenhaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(296, 6)
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ConsultaToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconExtract
        Me.ConsultaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(151, 58)
        Me.ConsultaToolStripMenuItem.Text = "Extrato"
        '
        'ReceitasToolStripMenuItem
        '
        Me.ReceitasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceitasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ReceitasToolStripMenuItem.Image = CType(resources.GetObject("ReceitasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReceitasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReceitasToolStripMenuItem.Name = "ReceitasToolStripMenuItem"
        Me.ReceitasToolStripMenuItem.Size = New System.Drawing.Size(164, 58)
        Me.ReceitasToolStripMenuItem.Text = "Receitas"
        '
        'DespesasToolStripMenuItem
        '
        Me.DespesasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DespesasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DespesasToolStripMenuItem.Image = CType(resources.GetObject("DespesasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DespesasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DespesasToolStripMenuItem.Name = "DespesasToolStripMenuItem"
        Me.DespesasToolStripMenuItem.Size = New System.Drawing.Size(173, 58)
        Me.DespesasToolStripMenuItem.Text = "Despesas"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Image = CType(resources.GetObject("RelatórioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(169, 58)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'JanelasToolStripMenuItem
        '
        Me.JanelasToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JanelasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.JanelasToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconJanelas
        Me.JanelasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        Me.JanelasToolStripMenuItem.Size = New System.Drawing.Size(154, 58)
        Me.JanelasToolStripMenuItem.Text = "Janelas"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LoginToolStripMenuItem.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconLogout
        Me.LoginToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(130, 58)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(75, 58)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(69, 58)
        Me.TesteToolStripMenuItem.Text = "Teste"
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
        Me.SScima.Size = New System.Drawing.Size(1431, 53)
        Me.SScima.SizingGrip = False
        Me.SScima.TabIndex = 2
        Me.SScima.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.GerenciamentoFinanças.My.Resources.Resources.LOGO1_2_fw
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(0, 3, 20, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(424, 48)
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SsBaixo
        '
        Me.SsBaixo.AutoSize = False
        Me.SsBaixo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SsBaixo.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SsBaixo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SsBaixo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaptionHora})
        Me.SsBaixo.Location = New System.Drawing.Point(0, 544)
        Me.SsBaixo.Name = "SsBaixo"
        Me.SsBaixo.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.SsBaixo.Size = New System.Drawing.Size(1431, 37)
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
        Me.txtCaptionHora.Size = New System.Drawing.Size(1411, 31)
        Me.txtCaptionHora.Spring = True
        Me.txtCaptionHora.Text = "ToolStripStatusLabel1"
        Me.txtCaptionHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCaptionHora.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtCaption})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 115)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1431, 34)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.txtCaption.Size = New System.Drawing.Size(1401, 29)
        Me.txtCaption.Spring = True
        Me.txtCaption.Text = "HOME"
        Me.txtCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.txtCaption.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.txtCaption.ToolTipText = "Você está aqui"
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1319, 5)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(52, 48)
        Me.btnMaximizar.TabIndex = 9
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1259, 5)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(52, 48)
        Me.btnMinimizar.TabIndex = 8
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.ForeColor = System.Drawing.Color.Transparent
        Me.btnFechar.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.btnFechar.Location = New System.Drawing.Point(1379, 5)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(52, 48)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 581)
        Me.Controls.Add(Me.btnMaximizar)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SsBaixo)
        Me.Controls.Add(Me.SScima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrincipal"
        Me.Text = " Finance Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SScima.ResumeLayout(False)
        Me.SScima.PerformLayout()
        Me.SsBaixo.ResumeLayout(False)
        Me.SsBaixo.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuárioSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçoDeEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JanelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtCaption As ToolStripStatusLabel
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
