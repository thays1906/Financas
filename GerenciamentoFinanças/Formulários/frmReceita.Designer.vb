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
        Me.tbConsulta = New GFT.Util.SuperTabControl()
        Me.tpPesquisa = New System.Windows.Forms.TabPage()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.SuperButton2 = New GFT.Util.SuperButton()
        Me.btnAddReceita = New GFT.Util.SuperButton()
        Me.btnExportar = New GFT.Util.SuperButton()
        Me.btnPesquisar = New GFT.Util.SuperButton()
        Me.btnFechar = New GFT.Util.SuperButton()
        Me.btnEditar = New GFT.Util.SuperButton()
        Me.gbFiltro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatusFiltro = New GFT.Util.SuperComboBox()
        Me.dtFinalFiltro = New GFT.Util.SuperDatePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtInicialFiltro = New GFT.Util.SuperDatePicker()
        Me.lvConsulta = New GFT.Util.SuperLV()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbConsulta.SuspendLayout()
        Me.tpPesquisa.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.gbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbConsulta
        '
        Me.tbConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbConsulta.Controls.Add(Me.tpPesquisa)
        Me.tbConsulta.Controls.Add(Me.TabPage1)
        Me.tbConsulta.Location = New System.Drawing.Point(12, 12)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Drawing.Point(50, 5)
        Me.tbConsulta.SelectedIndex = 0
        Me.tbConsulta.Size = New System.Drawing.Size(923, 650)
        Me.tbConsulta.TabIndex = 4
        '
        'tpPesquisa
        '
        Me.tpPesquisa.Controls.Add(Me.gbBotoes)
        Me.tpPesquisa.Controls.Add(Me.gbFiltro)
        Me.tpPesquisa.Controls.Add(Me.lvConsulta)
        Me.tpPesquisa.Location = New System.Drawing.Point(4, 26)
        Me.tpPesquisa.Name = "tpPesquisa"
        Me.tpPesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.tpPesquisa.Size = New System.Drawing.Size(915, 620)
        Me.tpPesquisa.TabIndex = 0
        Me.tpPesquisa.Text = "Pesquisa"
        Me.tpPesquisa.UseVisualStyleBackColor = True
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.SuperButton2)
        Me.gbBotoes.Controls.Add(Me.btnAddReceita)
        Me.gbBotoes.Controls.Add(Me.btnExportar)
        Me.gbBotoes.Controls.Add(Me.btnPesquisar)
        Me.gbBotoes.Controls.Add(Me.btnFechar)
        Me.gbBotoes.Controls.Add(Me.btnEditar)
        Me.gbBotoes.Location = New System.Drawing.Point(39, 504)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(858, 54)
        Me.gbBotoes.TabIndex = 8
        Me.gbBotoes.TabStop = False
        '
        'SuperButton2
        '
        Me.SuperButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperButton2.BackColor = System.Drawing.Color.Transparent
        Me.SuperButton2.BackgroundImage = CType(resources.GetObject("SuperButton2.BackgroundImage"), System.Drawing.Image)
        Me.SuperButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SuperButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SuperButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.SuperButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SuperButton2.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.SuperButton2.ForeColor = System.Drawing.Color.Black
        Me.SuperButton2.Image = Global.GerenciamentoFinanças.My.Resources.Resources.iconClose
        Me.SuperButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SuperButton2.Location = New System.Drawing.Point(431, 10)
        Me.SuperButton2.Name = "SuperButton2"
        Me.SuperButton2.Size = New System.Drawing.Size(137, 40)
        Me.SuperButton2.TabIndex = 11
        Me.SuperButton2.Text = "  &Excluir"
        Me.SuperButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SuperButton2.UseVisualStyleBackColor = False
        '
        'btnAddReceita
        '
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
        Me.btnAddReceita.Location = New System.Drawing.Point(145, 10)
        Me.btnAddReceita.Name = "btnAddReceita"
        Me.btnAddReceita.Size = New System.Drawing.Size(137, 40)
        Me.btnAddReceita.TabIndex = 10
        Me.btnAddReceita.Text = "  &Receita"
        Me.btnAddReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddReceita.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
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
        Me.btnExportar.Location = New System.Drawing.Point(574, 10)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(137, 40)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "  &Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
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
        Me.btnFechar.Location = New System.Drawing.Point(715, 10)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 40)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "  &Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
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
        Me.btnEditar.Location = New System.Drawing.Point(288, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(137, 40)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "  &Editar"
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'gbFiltro
        '
        Me.gbFiltro.Controls.Add(Me.Label3)
        Me.gbFiltro.Controls.Add(Me.cbStatusFiltro)
        Me.gbFiltro.Controls.Add(Me.dtFinalFiltro)
        Me.gbFiltro.Controls.Add(Me.Label2)
        Me.gbFiltro.Controls.Add(Me.Label1)
        Me.gbFiltro.Controls.Add(Me.dtInicialFiltro)
        Me.gbFiltro.Location = New System.Drawing.Point(8, 29)
        Me.gbFiltro.Name = "gbFiltro"
        Me.gbFiltro.Size = New System.Drawing.Size(899, 83)
        Me.gbFiltro.TabIndex = 7
        Me.gbFiltro.TabStop = False
        Me.gbFiltro.Text = "Filtro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status:"
        '
        'cbStatusFiltro
        '
        Me.cbStatusFiltro.Alterado = False
        Me.cbStatusFiltro.FormattingEnabled = True
        Me.cbStatusFiltro.Location = New System.Drawing.Point(340, 35)
        Me.cbStatusFiltro.Name = "cbStatusFiltro"
        Me.cbStatusFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cbStatusFiltro.SuperObrigatorio = False
        Me.cbStatusFiltro.SuperTxtObrigatorio = ""
        Me.cbStatusFiltro.TabIndex = 7
        '
        'dtFinalFiltro
        '
        Me.dtFinalFiltro.Alterado = False
        Me.dtFinalFiltro.BackColor = System.Drawing.Color.White
        Me.dtFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinalFiltro.Location = New System.Drawing.Point(184, 36)
        Me.dtFinalFiltro.Name = "dtFinalFiltro"
        Me.dtFinalFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtFinalFiltro.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        '
        'dtInicialFiltro
        '
        Me.dtInicialFiltro.Alterado = False
        Me.dtInicialFiltro.BackColor = System.Drawing.Color.White
        Me.dtInicialFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicialFiltro.Location = New System.Drawing.Point(31, 36)
        Me.dtInicialFiltro.Name = "dtInicialFiltro"
        Me.dtInicialFiltro.Size = New System.Drawing.Size(108, 20)
        Me.dtInicialFiltro.TabIndex = 3
        '
        'lvConsulta
        '
        Me.lvConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvConsulta.HabilitaOrdem = True
        Me.lvConsulta.HideSelection = False
        Me.lvConsulta.HoverSelection = True
        Me.lvConsulta.Location = New System.Drawing.Point(8, 143)
        Me.lvConsulta.Name = "lvConsulta"
        Me.lvConsulta.SelecionaVarios = False
        Me.lvConsulta.Size = New System.Drawing.Size(899, 355)
        Me.lvConsulta.TabIndex = 0
        Me.lvConsulta.UseCompatibleStateImageBehavior = False
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(915, 620)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Cadastrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'frmReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 674)
        Me.Controls.Add(Me.tbConsulta)
        Me.Name = "frmReceita"
        Me.Text = "frmReceita"
        Me.tbConsulta.ResumeLayout(False)
        Me.tpPesquisa.ResumeLayout(False)
        Me.gbBotoes.ResumeLayout(False)
        Me.gbFiltro.ResumeLayout(False)
        Me.gbFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbConsulta As GFT.Util.SuperTabControl
    Friend WithEvents tpPesquisa As TabPage
    Friend WithEvents gbFiltro As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatusFiltro As GFT.Util.SuperComboBox
    Friend WithEvents dtFinalFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInicialFiltro As GFT.Util.SuperDatePicker
    Friend WithEvents lvConsulta As GFT.Util.SuperLV
    Friend WithEvents gbBotoes As GroupBox
    Friend WithEvents btnExportar As GFT.Util.SuperButton
    Friend WithEvents btnFechar As GFT.Util.SuperButton
    Friend WithEvents btnPesquisar As GFT.Util.SuperButton
    Friend WithEvents btnEditar As GFT.Util.SuperButton
    Friend WithEvents SuperButton2 As GFT.Util.SuperButton
    Friend WithEvents btnAddReceita As GFT.Util.SuperButton
    Friend WithEvents TabPage1 As TabPage
End Class
