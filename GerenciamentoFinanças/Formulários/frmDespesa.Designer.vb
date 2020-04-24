<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespesa
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDespesa))
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
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New GFT.Util.SuperButton()
        Me.btnAddDespesa = New GFT.Util.SuperButton()
        Me.btnExportar = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbConsulta
        '
        Me.tbConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConsulta.Location = New System.Drawing.Point(12, 2)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 5)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(870, 540)
        Me.tbConsulta.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.Label4)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Controls.Add(Me.txtTotalDespesa)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 30)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(862, 506)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Pesquisa"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(548, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
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
        Me.gbFiltro.Size = New System.Drawing.Size(846, 83)
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
        Me.lvConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(8, 125)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(846, 373)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'txtTotalDespesa
        '
        Me.txtTotalDespesa.Alterado = False
        Me.txtTotalDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDespesa.BackColor = System.Drawing.Color.White
        Me.txtTotalDespesa.CorFundoSelecionado = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.txtTotalDespesa.Location = New System.Drawing.Point(687, 94)
        Me.txtTotalDespesa.Name = "txtTotalDespesa"
        Me.txtTotalDespesa.Size = New System.Drawing.Size(167, 25)
        Me.txtTotalDespesa.SuperMascara = ""
        Me.txtTotalDespesa.SuperObrigatorio = False
        Me.txtTotalDespesa.SuperTravaErrors = False
        Me.txtTotalDespesa.SuperTxtCorDesabilitado = System.Drawing.Color.Empty
        Me.txtTotalDespesa.SuperTxtObrigatorio = ""
        Me.txtTotalDespesa.SuperUsaMascara = GFT.Util.SuperTextBox.TipoMascara_.NENHUMA
        Me.txtTotalDespesa.TabIndex = 8
        '
        'gbBotoes
        '
        Me.gbBotoes.BackColor = System.Drawing.Color.Transparent
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnAddDespesa)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbBotoes.Location = New System.Drawing.Point(12, 544)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(848, 50)
        Me.gbBotoes.TabIndex = 9
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
        'btnAddDespesa
        '
        Me.btnAddDespesa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnAddDespesa.Location = New System.Drawing.Point(144, 8)
        Me.btnAddDespesa.Name = "btnAddDespesa"
        Me.btnAddDespesa.Size = New System.Drawing.Size(137, 40)
        Me.btnAddDespesa.TabIndex = 10
        Me.btnAddDespesa.Text = "  &Despesa"
        Me.btnAddDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddDespesa.UseVisualStyleBackColor = False
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
        'frmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 660)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.tbConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDespesa"
        Me.Text = "frmDespesa"
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.tpPesquisa.PerformLayout()
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
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
End Class
