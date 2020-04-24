<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceita))
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New GFT.Util.SuperButton()
        Me.btnAddReceita = New GFT.Util.SuperButton()
        Me.btnExportar = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.tbConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTipoFiltro = New GFT.Util.SuperComboBox()
        Me.lblContaFiltro = New System.Windows.Forms.Label()
        Me.cbContaFiltro = New GFT.Util.SuperComboBox()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cbMes = New GFT.Util.SuperComboBox()
        Me.txtTotalReceita = New GFT.Util.SuperTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBotoes.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnAddReceita)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbBotoes.Location = New System.Drawing.Point(80, 546)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(848, 50)
        Me.gbBotoes.TabIndex = 8
        Me.gbBotoes.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnExcluir.Location = New System.Drawing.Point(428, 8)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(137, 40)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "  &Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAddReceita
        '
        Me.btnAddReceita.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddReceita.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddReceita.BackgroundImage = CType(resources.GetObject("btnAddReceita.BackgroundImage"), System.Drawing.Image)
        Me.btnAddReceita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddReceita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddReceita.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddReceita.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAddReceita.ForeColor = System.Drawing.Color.Black
        Me.btnAddReceita.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconAddReceita
        Me.btnAddReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddReceita.Location = New System.Drawing.Point(144, 8)
        Me.btnAddReceita.Name = "btnAddReceita"
        Me.btnAddReceita.Size = New System.Drawing.Size(137, 40)
        Me.btnAddReceita.TabIndex = 10
        Me.btnAddReceita.Text = "  &Receita"
        Me.btnAddReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddReceita.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnExportar.Location = New System.Drawing.Point(570, 8)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(137, 40)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "  &Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnPesquisar.Location = New System.Drawing.Point(2, 8)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(137, 40)
        Me.btnPesquisar.TabIndex = 1
        Me.btnPesquisar.Text = "  &Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnFechar.Location = New System.Drawing.Point(711, 8)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 40)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnEditar.Location = New System.Drawing.Point(286, 8)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(137, 40)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "  &Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'tbConsulta
        '
        Me.tbConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConsulta.Location = New System.Drawing.Point(37, 1)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 5)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(923, 543)
        Me.tbConsulta.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label1)
        Me.tpPesquisa.Controls.Add(Me.txtTotalReceita)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 30)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(915, 509)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Pesquisa"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'gbFiltro
        '
        Me.gbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltro.Controls.Add(Me.lblMes)
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.cbTipoFiltro)
        Me.gbFiltro.Controls.Add(Me.cbMes)
        Me.gbFiltro.Controls.Add(Me.lblContaFiltro)
        Me.gbFiltro.Controls.Add(Me.cbContaFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(8, 19)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(899, 83)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tipo de Conta:"
        '
        'cbTipoFiltro
        '
        Me.cbTipoFiltro.Alterado = False
        Me.cbTipoFiltro.FormattingEnabled = True
        Me.cbTipoFiltro.Location = New System.Drawing.Point(548, 40)
        Me.cbTipoFiltro.Name = "cbTipoFiltro"
        Me.cbTipoFiltro.Size = New System.Drawing.Size(144, 25)
        Me.cbTipoFiltro.SuperObrigatorio = False
        Me.cbTipoFiltro.SuperTxtObrigatorio = ""
        Me.cbTipoFiltro.TabIndex = 9
        '
        'lblContaFiltro
        '
        Me.lblContaFiltro.AutoSize = True
        Me.lblContaFiltro.Location = New System.Drawing.Point(363, 20)
        Me.lblContaFiltro.Name = "lblContaFiltro"
        Me.lblContaFiltro.Size = New System.Drawing.Size(51, 17)
        Me.lblContaFiltro.TabIndex = 8
        Me.lblContaFiltro.Text = "Conta:"
        '
        'cbContaFiltro
        '
        Me.cbContaFiltro.Alterado = False
        Me.cbContaFiltro.FormattingEnabled = True
        Me.cbContaFiltro.Location = New System.Drawing.Point(366, 40)
        Me.cbContaFiltro.Name = "cbContaFiltro"
        Me.cbContaFiltro.Size = New System.Drawing.Size(164, 25)
        Me.cbContaFiltro.SuperObrigatorio = False
        Me.cbContaFiltro.SuperTxtObrigatorio = ""
        Me.cbContaFiltro.TabIndex = 7
        '
        'lvConsulta
        '
        Me.lvConsulta.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lvConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.BackColor = System.Drawing.SystemColors.Window
        Me.lvConsulta.FullRowSelect = True
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(8, 133)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(899, 365)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.TileSize = New System.Drawing.Size(400, 38)
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        Me.lvConsulta.View = System.Windows.Forms.View.Tile
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(56, 20)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(39, 17)
        Me.lblMes.TabIndex = 12
        Me.lblMes.Text = "Mês:"
        '
        'cbMes
        '
        Me.cbMes.Alterado = False
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Location = New System.Drawing.Point(59, 40)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(244, 25)
        Me.cbMes.SuperObrigatorio = False
        Me.cbMes.SuperTxtObrigatorio = ""
        Me.cbMes.TabIndex = 11
        '
        'txtTotalReceita
        '
        Me.txtTotalReceita.Alterado = False
        Me.txtTotalReceita.BackColor = System.Drawing.Color.White
        Me.txtTotalReceita.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalReceita.Location = New System.Drawing.Point(762, 108)
        Me.txtTotalReceita.Name = "txtTotalReceita"
        Me.txtTotalReceita.Size = New System.Drawing.Size(145, 25)
        Me.txtTotalReceita.SuperMascara = ""
        Me.txtTotalReceita.SuperObrigatorio = False
        Me.txtTotalReceita.SuperTravaErrors = False
        Me.txtTotalReceita.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalReceita.SuperTxtObrigatorio = ""
        Me.txtTotalReceita.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalReceita.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total das Receitas:"
        '
        'frmReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(986, 627)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.tbConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceita"
        Me.Text = "frmReceita"
        Me.gbBotoes.ResumeLayout(False)
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbConsulta As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents lblContaFiltro As Label
    Friend WithEvents cbContaFiltro As GFT.Util.SuperComboBox
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnExportar As GFT.Util.SuperButton
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents btnPesquisar As GFT.Util.SuperButton
    Friend WithEvents btnEditar As GFT.Util.SuperButton
    Friend WithEvents btnExcluir As GFT.Util.SuperButton
    Friend WithEvents btnAddReceita As GFT.Util.SuperButton
    Friend WithEvents cbTipoFiltro As GFT.Util.SuperComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalReceita As GFT.Util.SuperTextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents cbMes As GFT.Util.SuperComboBox
End Class
